using System;
using System.Windows;

namespace WpfApp6._1
{
    public partial class MainWindow : Window
    {
        private AbstractMeasuringDevice device;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MeasureButton_Click(object sender, RoutedEventArgs e)
        {
            if (DeviceSelector.SelectedIndex == 0) // Length Device
                device = new MeasureLengthDevice("Length Device", "meters");
            else if (DeviceSelector.SelectedIndex == 1) // Mass Device
                device = new MeasureMassDevice("Mass Device", "kilograms");

            if (device != null)
            {
                double measurement = device.Measure();
                string info = device.GetDeviceInfo();
                ResultTextBlock.Text = $"{info}\nMeasurement: {measurement}";
            }
            else
            {
                ResultTextBlock.Text = "Please select a device.";
            }
        }
    }
}
