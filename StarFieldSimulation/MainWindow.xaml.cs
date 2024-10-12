using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Timers;
using System.Windows.Threading;

namespace StarFieldSimulation
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += MainWindow_KeyDown;
            timer.Tick += new EventHandler(TimerTick);
            timer.Interval = new TimeSpan(0, 0, 0,0,10);
            DrawStars();
            //mediaPlayer.Open(new Uri("C:\\Users\\user\\source\\repos\\StarFieldSimulation\\StarFieldSimulation\\assets\\8d82b5_Star_Wars_Main_Theme_Song.mp3"));
            //mediaPlayer.Play();
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Escape)
            {
                this.Close();
            }
        }
    }
}
