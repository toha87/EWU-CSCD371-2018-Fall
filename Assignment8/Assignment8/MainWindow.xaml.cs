using Assignment8UnitTest;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Assignment8
{

    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer _timer;
        private readonly DispatcherTimer _clock;
        private DateTime start;
        private string currentTimer;

        public MainWindow()
        {
            InitializeComponent();

            _clock = new DispatcherTimer
            {
                Interval = new TimeSpan(0, 0, 1)
            };

            _clock.Tick += ClockTime_Tick;
            _clock.Start();

            _timer = new DispatcherTimer
            {
                Interval = new TimeSpan(0, 0, 1)
            };

            labelTimer.Content = "00:00:00.0000000";
        }

        private void ClockTime_Tick(object sender, EventArgs e)
        {
            IDateTime dateTime = new TimeNow();
            labelClock.Content = dateTime.DateTime();  
        }

        private void Timer_Tick(object sender, EventArgs e)
        { 
            currentTimer = Convert.ToString(DateTime.Now - start);
            labelTimer.Content = currentTimer;
        }

        private void ClickMeButton_OnClickStartTimer(object sender, EventArgs e)
        {
            TimeManager time = new TimeManager();
            _timer.Start();
            start = time.LabelTimeCurrent();
            _timer.Tick += Timer_Tick;
        }

        private void ClickMeButton_OnClickStopTimer(object sender, RoutedEventArgs e)
        {
            _timer.Stop();

            ListBox.Items.Add(new TimeManager()
            {
                EventName = EventTextBox.Text.ToString(),
                StopTime = currentTimer
        });

            EventTextBox.Text = String.Empty;
            labelTimer.Content = "00:00:00.0000000";
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ListBox.SelectedIndex > -1)
            {
                ListBox.Items.RemoveAt
            (ListBox.Items.IndexOf(ListBox.SelectedItem));
            }
    
        }

    }
}
