using System;
using WpfApp6._1;

namespace WpfApp6._1
{
    public class MeasureMassDevice : AbstractMeasuringDevice
    {
        public MeasureMassDevice(string name, string unit) : base(name, unit) { }

        public override double Measure()
        {
            Random random = new Random();
            return Math.Round(random.NextDouble() * 50, 2); // Mass in kilograms
        }
    }
}
