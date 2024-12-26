using WpfApp6._1;

namespace WpfApp6._1
{
    public abstract class AbstractMeasuringDevice : IMeasuringDevice
    {
        protected string DeviceName;
        protected string UnitOfMeasurement;

        protected AbstractMeasuringDevice(string name, string unit)
        {
            DeviceName = name;
            UnitOfMeasurement = unit;
        }

        public abstract double Measure();

        public string GetDeviceInfo()
        {
            return $"Device: {DeviceName}, Unit: {UnitOfMeasurement}";
        }
    }
}
