using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace StarFieldSimulation
{
    public partial class MainWindow
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private MediaPlayer mediaPlayer = new MediaPlayer();
        private Star[] stars = new Star[700];
        private DispatcherTimer inTimer = new DispatcherTimer();
        private Random rand = new Random();
        //METHODS
        
        
        public void TimerTick(object sender, EventArgs e)
        {

            MyCanvas.Children.Clear();

            foreach (Star elem in stars)
            {
                elem.Draw(ref MyCanvas);
                elem.Move();
            }

        }
        public void DrawStars()
        {
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new Star(Width,Height);
                stars[i].RandParams();
            }
            timer.Start();

        }
        
       
    }
}
