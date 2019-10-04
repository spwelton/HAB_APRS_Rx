using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts; //Core of the library
using LiveCharts.Wpf; //The WPF controls
using LiveCharts.WinForms; //the WinForm wrappers
using System.Drawing.Drawing2D;

namespace BalloonTracker
{

    public partial class MainWindow : Form
    {
        public String balloonAddress;
        public String balloonSSID;
        public String balloonAddrWSSID;

        public MainWindow()
        {
            InitializeComponent();

            balloonAddress = Properties.Settings.Default.balloonCallSign;
            balloonSSID = Properties.Settings.Default.balloonSSID;
            balloonAddrWSSID = balloonAddress + "-" + balloonSSID;

            pressureGauge.From = 0;
            pressureGauge.To = 1;

            humidityGauge.From = 0;
            humidityGauge.To = 100;

            intTempGauge.From = -60;
            intTempGauge.To = 60;

            extTempGauge.From = -60;
            extTempGauge.To = 60;

            batteryGauge.From = 2;
            batteryGauge.FromColor = System.Windows.Media.Color.FromArgb(0xFF,0xFF,0x00,0x00);
            batteryGauge.To = 3;
            batteryGauge.ToColor = System.Windows.Media.Color.FromArgb(0xFF, 0x00, 0xFF, 0x00);

            speedGauge.FromValue = 0;
            speedGauge.ToValue = 100;
            speedGauge.Wedge = 270;

            TNCListener.RunWorkerAsync();
        }

        private void TNCListener_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                // Set up the TCP connection to the TNC
                string server = "127.0.0.1";
                Int32 port = 8001;
                TcpClient client = new TcpClient(server, port);
                NetworkStream stream = client.GetStream();

                var loop = true;

                while (loop)
                {
                    // Buffer to store the incoming KISS frame.
                    Byte[] KISSFrame = new Byte[256];

                    // Read the input from TCP localhost and return byte count.
                    Int32 bytes = stream.Read(KISSFrame, 0, KISSFrame.Length);                    
                    
                    Byte[] srcAddressRaw = new Byte[7];  // APRS src addr raw from KISS
                    Byte[] srcAddressBytes = new Byte[6];     // APRS src addr w/o SSID
                    Byte SSID = new Byte();                 // APRS src addr SSID
                    Byte SSIDMask = 0x1E;                   // Bitmask for AX.25 SSID field
                    int srcAddressOffset = 9;                  // KISS byte number for src addr

                    // Collect the source address bytes and convert to ASCII
                    for (int pos = 0; pos < 7; pos++)
                    {
                        // Get the raw src addr bytes from the KISS frame
                        srcAddressRaw[pos] = KISSFrame[pos + srcAddressOffset];
                        if (pos < 6)
                        {
                            // Bit-shift the first 6 bytes right 1 position for address
                            srcAddressBytes[pos] = (Byte)(srcAddressRaw[pos] >> 1);
                        }
                        else if (pos == 6)
                        {
                            // Use the SSID mask to recover the SSID from the AX.25 frame
                            // The field has 3 bits reserved, then 4-bits for SSID, then 1 reserved
                            // xxxSSIDx
                            SSID = (byte)((srcAddressRaw[pos] & SSIDMask) >> 1);
                        }
                    }
                    // Convert to human-readable formats :)
                    String srcAddress = Encoding.ASCII.GetString(srcAddressBytes);
                    String srcSSID    = SSID.ToString();
                    String srcAddrWSSID  = srcAddress + "-" + srcSSID;
                    String wholeFrame = Encoding.UTF8.GetString(KISSFrame, 0, bytes - 1);
                    
                    int index = wholeFrame.IndexOf('/');
                    string aprsPayload = wholeFrame.Substring(index + 1);

                    if (srcAddrWSSID == balloonAddrWSSID)
                    {
                        // OK, we got a packet to display, stop looping.
                        loop = false;
                        // Set the results and let's exit.
                        e.Result = aprsPayload;
                    }
                }
            }
            catch (Exception ex)
            {
                // Something broke, show a message.
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void PreferencesBtn_Click(object sender, EventArgs e)
        {
            PreferencesForm prefsForm = new PreferencesForm();
            prefsForm.ShowDialog();
        }

        private void TNCListener_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Process the packet and update the UI.
            packetParser.RunWorkerAsync(e.Result);
            //this.latitudeBox.Text = e.Result.ToString();
            // Start listening again.
            TNCListener.RunWorkerAsync();
        }

        private void PacketParser_DoWork(object sender, DoWorkEventArgs e)
        {
            var dataPoint = new DataPoint();

            String aprsPacket = e.Argument.ToString();
            try
            {
                // Parse Timestamp
                string timestampStr = aprsPacket.Substring(0, 6);
                timestampStr = timestampStr.Insert(4, ":");
                timestampStr = timestampStr.Insert(2, ":");
                dataPoint.Timestamp = timestampStr;

                // Parse Lat/Lon
                var latDegrees = aprsPacket.Substring(7, 2);
                var latMinutes = aprsPacket.Substring(9, 5);
                var latDirection = aprsPacket.Substring(14, 1);
                dataPoint.Latitude = String.Concat(latDegrees, "° ", latMinutes, "' ", latDirection);

                var longDegrees = aprsPacket.Substring(16, 3);
                var longMinutes = aprsPacket.Substring(19, 5);
                var longDirection = aprsPacket.Substring(24, 1);
                dataPoint.Longitude = String.Concat(longDegrees, "° ", longMinutes, "' ", longDirection);

                // Parse course and speed
                string courseStr = aprsPacket.Substring(26, 3);
                dataPoint.Course = Convert.ToInt32(courseStr);

                string speedStr = aprsPacket.Substring(30, 3);
                dataPoint.Speed = Convert.ToInt32(speedStr);

                // Get remaining telemetry which is slash separated
                string[] telemetryPoints = aprsPacket.Substring(34).Split('/');

                foreach (string tPoint in telemetryPoints)
                {
                    var dataTuple = tPoint.Split('=');
                    switch (dataTuple[0])
                    {
                        case "A":
                            dataPoint.Altitude = Convert.ToInt32(dataTuple[1]);
                            break;

                        case "Amax":
                            dataPoint.MaxAltitude = Convert.ToInt32(dataTuple[1]);
                            break;

                        case "Pa":
                            dataPoint.Pressure = Convert.ToInt32(dataTuple[1]);
                            break;

                        case "Rh":
                            dataPoint.RelativeHumidity = Convert.ToInt32(dataTuple[1]);
                            break;

                        case "Ti":
                            dataPoint.TemperatureIn = Convert.ToDouble(dataTuple[1]);
                            break;

                        case "Te":
                            dataPoint.TemperatureOut = Convert.ToDouble(dataTuple[1]);
                            break;

                        case "Vb":
                            dataPoint.BatteryVoltage = Convert.ToDouble(dataTuple[1]);
                            break;

                        case "i":
                            dataPoint.PacketIndex = Convert.ToInt32(dataTuple[1]);
                            break;

                        default:
                            break;
                    }
                }


                e.Result = dataPoint;

            }
            catch (Exception ex)
            {
                string errorMsg = String.Format("Unable to parse packet '{0}'", ex.ToString());
                MessageBox.Show(errorMsg, "FAIL");
                
            }
        }

        private void PacketParser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Update the UI with the telemetry data.
            var dataPoint = e.Result as DataPoint;
            timestampBox.Text = dataPoint.Timestamp;
            latitudeBox.Text = dataPoint.Latitude;
            longitudeBox.Text = dataPoint.Longitude;
            courseBox.Text = dataPoint.Course.ToString();
            speedBox.Text = dataPoint.Speed.ToString();
            speedGauge.Value = dataPoint.Speed;
            altitudeBox.Text = dataPoint.Altitude.ToString();
            maxAltBox.Text = dataPoint.MaxAltitude.ToString();
            // Convert the pressure units in Pa to atm and round to 2 decimal places.
            pressureGauge.Value = Math.Round((dataPoint.Pressure / 101325.0),2);
            humidityGauge.Value = (Double)dataPoint.RelativeHumidity;
            intTempGauge.Value = dataPoint.TemperatureIn;
            extTempGauge.Value = dataPoint.TemperatureOut;
            batteryGauge.Value = dataPoint.BatteryVoltage;

            // Update the compass pointer
            using (Bitmap b = new Bitmap(Properties.Resources.pointer_arrow))
            {
                Bitmap newBmp = RotateImage(b, (dataPoint.Course));
                compass.BackgroundImage = newBmp;
            }
        }

        private Bitmap RotateImage(Bitmap b, float angle)
        {
            //Create a new empty bitmap to hold rotated image.
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
            //Make a graphics object from the empty bitmap.
            Graphics g = Graphics.FromImage(returnBitmap);
            //move rotation point to center of image.
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
            //Rotate.        
            g.RotateTransform(angle);
            //Move image back.
            g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
            //Draw passed in image onto graphics object.
            g.DrawImage(b, new Point(0, 0));
            return returnBitmap;
        }
    }
}
