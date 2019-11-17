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
using System.Windows.Media;
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
        public DateTime lastPacketTimestamp;
        public DateTime thisPacketTimestamp;
        public int numPacketsReceived = 0;
        public double packetSuccessRate;
        public TimeSpan elapsedTimeBetweenPackets;
        public int lastAltitudeReading;

        public SeriesCollection PressureGraphSeries { get; set; }
        public SeriesCollection HumidityGraphSeries { get; set; }
        public SeriesCollection IntTempGraphSeries { get; set; }
        public SeriesCollection ExtTempGraphSeries { get; set; }
        public SeriesCollection SpeedGraphSeries { get; set; }
        public SeriesCollection AltitudeGraphSeries { get; set; }
        public SeriesCollection AscentRateGraphSeries { get; set; }
        public SeriesCollection BatteryVoltageGraphSeries { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // Set up the UI elements and gauges

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
            batteryGauge.FromColor = System.Windows.Media.Color.FromArgb(0xFF, 0xFF, 0x00, 0x00);
            batteryGauge.To = 3;
            batteryGauge.ToColor = System.Windows.Media.Color.FromArgb(0xFF, 0x00, 0xFF, 0x00);

            speedGauge.FromValue = 0;
            speedGauge.ToValue = 100;
            speedGauge.Wedge = 270;
            speedGauge.Sections.Add(
                new AngularSection
                {
                    FromValue = 0,
                    ToValue = 60,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 255, 0))
                }
            );
            speedGauge.Sections.Add(
                new AngularSection
                {
                    FromValue = 60,
                    ToValue = 75,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 0))
                }
            );
            speedGauge.Sections.Add(
                new AngularSection
                {
                    FromValue = 75,
                    ToValue = 100,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 0, 0))
                }
            );

            // Set up the graphs

            // Pressure Graph
            PressureGraphSeries = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Pressure",
                    Values = new ChartValues<double> { },
                    PointGeometry = DefaultGeometries.None,
                    //PointGeometry = DefaultGeometries.Circle,
                    //PointGeometrySize = 5,
                    //PointForeground = System.Windows.Media.Brushes.Blue,
                    StrokeThickness = 2,
                    Visibility = System.Windows.Visibility.Visible
                }
            };
            pressureChart.Series.Add(PressureGraphSeries[0]);
            pressureChart.AxisY.Add(new Axis { });
            pressureChart.AxisX.Add(new Axis { });
            pressureChart.AxisY[0].MinValue = 0;
            pressureChart.AxisY[0].MaxValue = 1;
            pressureChart.AxisY[0].Separator.Step = 0.2;

            // Humidity Graph
            HumidityGraphSeries = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Humidity",
                    Values = new ChartValues<double> { },
                    PointGeometry = DefaultGeometries.None,
                    //PointGeometry = DefaultGeometries.Circle,
                    //PointGeometrySize = 5,
                    //PointForeground = System.Windows.Media.Brushes.Blue,
                    StrokeThickness = 2,
                    Visibility = System.Windows.Visibility.Visible
                }
            };
            humidityChart.Series.Add(HumidityGraphSeries[0]);
            humidityChart.AxisY.Add(new Axis { });
            humidityChart.AxisX.Add(new Axis { });
            humidityChart.AxisY[0].MinValue = 0;
            humidityChart.AxisY[0].MaxValue = 100;
            humidityChart.AxisY[0].Separator.Step = 20;

            // External Temperature Graph
            ExtTempGraphSeries = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "External Temperature",
                    Values = new ChartValues<double> { },
                    PointGeometry = DefaultGeometries.None,
                    //PointGeometry = DefaultGeometries.Circle,
                    //PointGeometrySize = 5,
                    //PointForeground = System.Windows.Media.Brushes.Blue,
                    StrokeThickness = 2,
                    Visibility = System.Windows.Visibility.Visible
                }
            };
            extTempChart.Series.Add(ExtTempGraphSeries[0]);
            extTempChart.AxisY.Add(new Axis { });
            extTempChart.AxisX.Add(new Axis { });
            extTempChart.AxisY[0].MinValue = -60;
            extTempChart.AxisY[0].MaxValue = 60;
            extTempChart.AxisY[0].Separator.Step = 20;

            // Internal Temperature Graph
            IntTempGraphSeries = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Internal Temperature",
                    Values = new ChartValues<double> { },
                    PointGeometry = DefaultGeometries.None,
                    //PointGeometry = DefaultGeometries.Circle,
                    //PointGeometrySize = 5,
                    //PointForeground = System.Windows.Media.Brushes.Blue,
                    StrokeThickness = 2,
                    Visibility = System.Windows.Visibility.Visible
                }
            };
            intTempChart.Series.Add(IntTempGraphSeries[0]);
            intTempChart.AxisY.Add(new Axis { });
            intTempChart.AxisX.Add(new Axis { });
            intTempChart.AxisY[0].MinValue = -60;
            intTempChart.AxisY[0].MaxValue = 60;
            intTempChart.AxisY[0].Separator.Step = 20;

            // Speed Graph
            SpeedGraphSeries = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Speed",
                    Values = new ChartValues<int> { },
                    PointGeometry = DefaultGeometries.None,
                    //PointGeometry = DefaultGeometries.Circle,
                    //PointGeometrySize = 5,
                    //PointForeground = System.Windows.Media.Brushes.Blue,
                    StrokeThickness = 2,
                    Visibility = System.Windows.Visibility.Visible
                }
            };
            speedChart.Series.Add(SpeedGraphSeries[0]);
            speedChart.AxisY.Add(new Axis { });
            speedChart.AxisX.Add(new Axis { });
            speedChart.AxisY[0].MinValue = 0;
            speedChart.AxisY[0].MaxValue = 100;
            speedChart.AxisY[0].Separator.Step = 20;

            // Battery Graph
            BatteryVoltageGraphSeries = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Battery Voltage",
                    Values = new ChartValues<double> { },
                    PointGeometry = DefaultGeometries.None,
                    //PointGeometry = DefaultGeometries.Circle,
                    //PointGeometrySize = 5,
                    //PointForeground = System.Windows.Media.Brushes.Blue,
                    StrokeThickness = 2,
                    Visibility = System.Windows.Visibility.Visible
                }
            };
            batteryVoltageChart.Series.Add(BatteryVoltageGraphSeries[0]);
            batteryVoltageChart.AxisY.Add(new Axis { });
            batteryVoltageChart.AxisX.Add(new Axis { });
            batteryVoltageChart.AxisY[0].MinValue = 0;
            batteryVoltageChart.AxisY[0].MaxValue = 3;
            batteryVoltageChart.AxisY[0].Separator.Step = 0.5;

            // Altitude Graph
            AltitudeGraphSeries = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Altitude",
                    Values = new ChartValues<int> { },
                    PointGeometry = DefaultGeometries.None,
                    //PointGeometry = DefaultGeometries.Circle,
                    //PointGeometrySize = 5,
                    //PointForeground = System.Windows.Media.Brushes.Blue,
                    StrokeThickness = 2,
                    Visibility = System.Windows.Visibility.Visible
                }
            };
            altitudeChart.Series.Add(AltitudeGraphSeries[0]);
            altitudeChart.AxisY.Add(new Axis { });
            altitudeChart.AxisX.Add(new Axis { });
            altitudeChart.AxisY[0].MinValue = 0;
            altitudeChart.AxisY[0].MaxValue = 100000;
            altitudeChart.AxisY[0].Separator.Step = 20000;

            // Ascent Rate Graph
            AscentRateGraphSeries = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Ascent Rate",
                    Values = new ChartValues<double> { },
                    PointGeometry = DefaultGeometries.None,
                    //PointGeometry = DefaultGeometries.Circle,
                    //PointGeometrySize = 5,
                    //PointForeground = System.Windows.Media.Brushes.Blue,
                    StrokeThickness = 2,
                    Visibility = System.Windows.Visibility.Visible
                }
            };
            ascentRateChart.Series.Add(AscentRateGraphSeries[0]);
            ascentRateChart.AxisY.Add(new Axis { });
            ascentRateChart.AxisX.Add(new Axis { });
            ascentRateChart.AxisY[0].MinValue = -100;
            ascentRateChart.AxisY[0].MaxValue = 100;
            ascentRateChart.AxisY[0].Separator.Step = 40;

            TNCListener.RunWorkerAsync();
        }

        private void TNCListener_DoWork(object sender, DoWorkEventArgs e)
        {            
            // Set up the TCP connection to the TNC
            string server = "127.0.0.1";
            Int32 port = 8001;
            try
            {
                using (TcpClient client = new TcpClient(server, port))
                {
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
                        String srcSSID = SSID.ToString();
                        String srcAddrWSSID = srcAddress + "-" + srcSSID;
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
            }
            catch (SocketException)
            {
                // Could not connect to modem
                DialogResult exceptionDialogResult = MessageBox.Show("Could not connect to modem.", "Modem Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (exceptionDialogResult == DialogResult.Cancel)
                {
                    e.Result = "CANCEL";
                }
                else if (exceptionDialogResult == DialogResult.Retry)
                {
                    e.Result = "RETRY";
                }
            }
            catch (SystemException)
            {
                // Lost existing connection to modem
                DialogResult exceptionDialogResult = MessageBox.Show("Lost connection to modem.", "Modem Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (exceptionDialogResult == DialogResult.Cancel)
                {
                    e.Result = "CANCEL";
                }
                else if (exceptionDialogResult == DialogResult.Retry)
                {
                    e.Result = "RETRY";
                }
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
            if ((e.Result.ToString() != "CANCEL") && (e.Result.ToString() != "RETRY"))
            {
                // We got a packet, let's parse it.
                packetParser.RunWorkerAsync(e.Result);
            }
            if (e.Result.ToString() == "CANCEL")
            {
                this.Close();
            }

            // Start listening again.
            TNCListener.RunWorkerAsync();
            
        }

        private void PacketParser_DoWork(object sender, DoWorkEventArgs e)
        {
            var dataPoint = new DataPoint();
            numPacketsReceived++;
            dataPoint.PacketsReceived = numPacketsReceived;

            String aprsPacket = e.Argument.ToString();
            
            // Parse Timestamp
            string timestampStr = aprsPacket.Substring(0, 6);
            timestampStr = timestampStr.Insert(4, ":");
            timestampStr = timestampStr.Insert(2, ":");
            dataPoint.Timestamp = timestampStr;
            // How long has it been since the last packet? Use the computer's clock for more precision.
            thisPacketTimestamp = DateTime.Now;
            if (numPacketsReceived > 1)
            {
                elapsedTimeBetweenPackets = thisPacketTimestamp - lastPacketTimestamp;
            }
            lastPacketTimestamp = thisPacketTimestamp;

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
                        if (numPacketsReceived > 1)
                        {
                            int altitudeGain = dataPoint.Altitude - lastAltitudeReading;
                            double ascentRate = altitudeGain / elapsedTimeBetweenPackets.TotalSeconds;
                            dataPoint.AscentRate = ascentRate;
                        }
                        else
                        {
                            dataPoint.AscentRate = 0;
                        }                            
                        lastAltitudeReading = dataPoint.Altitude;
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

        private void PacketParser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Update the UI with the telemetry data.
            var dataPoint = e.Result as DataPoint;

            lastPacketTimestampLbl.Text = dataPoint.Timestamp;

            latitudeBox.Text = dataPoint.Latitude;
            longitudeBox.Text = dataPoint.Longitude;

            courseBox.Text = dataPoint.Course.ToString();

            speedBox.Text = dataPoint.Speed.ToString();
            speedGauge.Value = dataPoint.Speed;
            SpeedGraphSeries[0].Values.Add(dataPoint.Speed);

            altitudeBox.Text = dataPoint.Altitude.ToString();
            AltitudeGraphSeries[0].Values.Add(dataPoint.Altitude);
            maxAltBox.Text = dataPoint.MaxAltitude.ToString();

            ascentRateBox.Text = dataPoint.AscentRate.ToString();
            AscentRateGraphSeries[0].Values.Add(dataPoint.AscentRate);

            // Convert the pressure units in Pa to atm and round to 2 decimal places.
            double pressureATM = Math.Round((dataPoint.Pressure / 101325.0), 2);
            pressureGauge.Value = pressureATM;
            PressureGraphSeries[0].Values.Add(pressureATM);

            humidityGauge.Value = (Double)dataPoint.RelativeHumidity;
            HumidityGraphSeries[0].Values.Add((Double)dataPoint.RelativeHumidity);

            intTempGauge.Value = dataPoint.TemperatureIn;
            IntTempGraphSeries[0].Values.Add(dataPoint.TemperatureIn);

            extTempGauge.Value = dataPoint.TemperatureOut;
            ExtTempGraphSeries[0].Values.Add(dataPoint.TemperatureOut);

            batteryGauge.Value = dataPoint.BatteryVoltage;
            BatteryVoltageGraphSeries[0].Values.Add(dataPoint.BatteryVoltage);

            // Update the compass pointer
            using (Bitmap b = new Bitmap(Properties.Resources.pointer_arrow))
            {
                Bitmap newBmp = RotateImage(b, (dataPoint.Course));
                compass.BackgroundImage = newBmp;
            }

            packetsRxLbl.Text = dataPoint.PacketsReceived.ToString();
            packetsExpectedLbl.Text = dataPoint.PacketIndex.ToString();
            packetSuccessLbl.Text = (((double)dataPoint.PacketsReceived / (double)dataPoint.PacketIndex) * 100.0).ToString("F1");
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

        private void ToolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            PreferencesForm prefsForm = new PreferencesForm();
            prefsForm.ShowDialog();
        }
    }
}
