using System;
using System.Reflection.Emit;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace TMS.Views
{
    public partial class WelcomeScreen : Window
    {
        private DispatcherTimer Timer;
        private double _value;
        
        public WelcomeScreen()
        {
            Timer = new DispatcherTimer();
            InitializeComponent();

            StartProgressBar();
        }
        
        private void StartProgressBar()
        {
            Timer.Tick += SetValue;
        }

        private void SetValue(object sender, EventArgs e)
        {
            ProgressBar.Value++;
            _value = ProgressBar.Value;

            while (ProgressBar.Value <= 100)
            {
                if (ProgressBar.Value == 1)
                { 
                    DownloadLabel.Content = "Fayllar Yüklənir";
                }
                else if (ProgressBar.Value == 20)
                {
                    DownloadLabel.Content = "Faylların Doğruluğu Yoxlanılır";
                }
                else if (ProgressBar.Value == 50)
                {
                    DownloadLabel.Content = "Salam qaqaş necəsən";
                }
                else if (ProgressBar.Value == 100)
                {
                    DownloadLabel.Content = "Xoş Gəldiniz";
                    Thread.Sleep(2000);
                    Timer.Stop();
                }

                Thread.Sleep(250);
            }
        }

        private void StartAndStopTimer(object sender, RoutedEventArgs e)
        {
            Timer.Start();

            if (_value == 100)
            {
                // button Color change et
                // button content change Continue.
                // and LoginScreen show.
            }
        }
    }
}