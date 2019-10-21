using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalloonTracker
{
    public class DataPoint
    {
        public string Timestamp { get; set; }
        public int PacketsReceived { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int Course { get; set; }
        public int Speed { get; set; }
        public int Altitude { get; set; }
        public int MaxAltitude { get; set; }
        public double AscentRate { get; set; }
        public int Pressure { get; set; }
        public int RelativeHumidity { get; set; }
        public double TemperatureIn { get; set; }
        public double TemperatureOut { get; set; }
        public double BatteryVoltage { get; set; }
        public int PacketIndex { get; set; }
    }
}
