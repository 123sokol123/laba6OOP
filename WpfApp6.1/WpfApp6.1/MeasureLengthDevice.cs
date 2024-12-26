using System;
using WpfApp6._1;

namespace WpfApp6._1
{
    public class MeasureLengthDevice : AbstractMeasuringDevice
    {
        public MeasureLengthDevice(string name, string unit) : base(name, unit) { }

        public override double Measure()
        {
            Random random = new Random();
            return Math.Round(random.NextDouble() * 100, 2); // Length in meters
        }
    }
}
