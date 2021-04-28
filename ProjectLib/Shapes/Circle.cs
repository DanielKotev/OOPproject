using System;
using System.Drawing;

namespace LibraryProject
{
   
    public class Circle : BaseShape
    {
        private double Radius { get; set; }
        public Circle(double redius):base()
        {
            Radius =redius;
        }
        public Circle(double redius,float x,float y,int color,int index) : base()
        {
            Radius = redius;
            Location = new Point((int)x, (int)y);
            Color = Color.FromArgb(color);
            Index = index;
        }
        public override void FillSelectedFigure(Graphics graphics)
        {
            using (var brush = new SolidBrush(
               Color.FromArgb(
                  Math.Min(byte.MaxValue, Color.R + 50),
                   Math.Min(byte.MaxValue, Color.G + 50),
                    Math.Min(byte.MaxValue, Color.B + 50))))
                graphics.FillEllipse(brush, Location.X, Location.Y, (float)Radius * 2, (float)Radius * 2);

            using (var pen = new Pen(Color, 2))
                graphics.DrawEllipse(pen, Location.X, Location.Y, (float)Radius * 2, (float)Radius * 2);
        }
        public override void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(Color, 2))
            {
                graphics.DrawEllipse(pen, Location.X, Location.Y,(float)Radius*2, (float)Radius*2);
            }
        }
        public override double CalculateSurface()=> Math.PI * Math.Pow(Radius, 2);
        public override double CalculateParameter()=>2 * Math.PI * Radius;
        public override bool Contains(Point point)
        {
            return (point.X - (Location.X + Radius)) * (point.X - (Location.X + Radius))
                  + (point.Y - (Location.Y + Radius)) * (point.Y - (Location.Y + Radius)) <= Radius * Radius;
        }
        public override string ToString()=> "Circle With Parimeter Radius: " + Radius;

        public override void Rotate90() { }

        public override double[] GetValues()
        {
            double[] Value= { this.Radius};
            return Value;

        }

        public override SerializeableShape SerializeObj()
        {
            return new SerializeableShape
            {
                FigureType = (int)FigureTypes.Circle,
                Perimeters = new double[] { Radius },
                Points = new float[] { Location.X, Location.Y },
                Color = this.Color.ToArgb() 
            };
        }

       
    }
}
