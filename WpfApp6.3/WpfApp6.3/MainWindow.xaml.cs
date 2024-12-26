using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp6._3
{
    public partial class MainWindow : Window
    {
        private Thread highPriorityThread;
        private Thread lowPriorityThread;
        private bool isRunning = true;
        private object lockObject = new object();
        private static Mutex mutex = new Mutex();
        private static Semaphore semaphore = new Semaphore(2, 2);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartThreads()
        {
            isRunning = true;

            highPriorityThread = new Thread(() =>
            {
                while (isRunning)
                {
                    Dispatcher.Invoke(() => MoveObject(HighPriorityObject));
                    Thread.Sleep(50);
                }
            });
            highPriorityThread.Priority = ThreadPriority.Highest;

            lowPriorityThread = new Thread(() =>
            {
                while (isRunning)
                {
                    Dispatcher.Invoke(() => MoveObject(LowPriorityObject));
                    Thread.Sleep(100);
                }
            });
            lowPriorityThread.Priority = ThreadPriority.Lowest;

            highPriorityThread.Start();
            lowPriorityThread.Start();
        }

        private void MoveObject(UIElement element)
        {
            lock (lockObject)
            {
                var left = Canvas.GetLeft(element) + 5;
                if (left > MainCanvas.Width - 30) left = 0;
                Canvas.SetLeft(element, left);
            }
        }

        private void StopThreads()
        {
            isRunning = false;
            highPriorityThread.Join();
            lowPriorityThread.Join();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e) => StartThreads();

        private void StopButton_Click(object sender, RoutedEventArgs e) => StopThreads();

        private async Task PerformTask()
        {
            await Task.Run(() =>
            {
                semaphore.WaitOne();
                try
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Task iteration {i} in thread {Thread.CurrentThread.ManagedThreadId}");
                        Thread.Sleep(200);
                    }
                }
                finally
                {
                    semaphore.Release();
                }
            });
        }

        private async void TestAsync_Click(object sender, RoutedEventArgs e)
        {
            string result = await FetchDataAsync();
            MessageBox.Show(result);
        }

        private async Task<string> FetchDataAsync()
        {
            await Task.Delay(1000);
            return "Async data fetched";
        }

        private void ParallelForDemo()
        {
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine($"Parallel iteration {i} in thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(100);
            });
        }
    }
}
