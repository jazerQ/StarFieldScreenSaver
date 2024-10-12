using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace StarFieldSimulation
{
    interface IShape
    {
        void Move();
        void Draw(ref Canvas canvas);
    }
    abstract class Point
    {
        public abstract float X { get; set; }
        public abstract float Y { get; set; }
        public abstract float Z { get; set; }
        public abstract void RandParams();
        protected abstract (double size, float x, float y) MapParams();
    }
    class Star : Point, IShape
    {
        public Star(double WidthWindow, double HeightWindow) {
            _width = WidthWindow;
            _height = HeightWindow;
        }
        public override float X { get; set; }
        public override float Y { get; set; }
        public override float Z { get; set; }

        private double _width;
        private double _height;

        //METHODS
        public  override void RandParams()
        {
            X = (float)GeneratorRandomValuesForPoints.rand.Next(-(int)_width, (int)_width);
            Y = (float)GeneratorRandomValuesForPoints.rand.Next(-(int)_height, (int)_height);
            Z = (float)GeneratorRandomValuesForPoints.rand.Next(1, (int)_width);
        }
        protected override (double size, float x, float y) MapParams()
        {
            double size = ClassMap.Map(Z, 0, (float)_width, 7, 0);
            float x = ClassMap.Map(X / Z, 0, 1, 0, (float)_width) + ((float)_width / 2);
            float y = ClassMap.Map(Y / Z, 0, 1, 0, (float)_height) + ((float)_height / 2);
            return (size: size, x: x, y: y);
        }
        public void Move()
        {
            Z -= 30;
            if (Z < 1)
            {
                RandParams();
            }
        }
        public void Draw(ref Canvas canvas)
        {
            (double size, float x, float y) tupleParams = MapParams();
            Ellipse ellipse = new Ellipse()
            {
                Fill = Brushes.GreenYellow,
                Width = tupleParams.size,
                Height = tupleParams.size
            };
            Canvas.SetLeft(ellipse, tupleParams.x);
            Canvas.SetTop(ellipse, tupleParams.y);
            canvas.Children.Add(ellipse);
        }
    }
}
