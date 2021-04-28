using System;
using System.Drawing;


namespace LibraryProject
{
    
    public class Rectangle : BaseShape
    {
        private double Height { get; set; }
        private double Width { get; set; }

        public Rectangle(double height, double width): base()
        {
            Height = height;
            Width = width;
        }
        public Rectangle(double height, double width,float x,float y,int color,int index) : base()
        {
            Height = Math.Abs(height);
            Width = Math.Abs(width);
            Location = new Point((int)x,(int) y);
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
                graphics.FillRectangle(brush, Location.X, Location.Y, (int)Height, (int)Width);

            using (var pen = new Pen(Color, 2))
                graphics.DrawRectangle(pen, this.Location.X, this.Location.Y, (int)Height, (int)Width);
        }
        public override void Draw(Graphics graphics)
        {
                using (Pen pen = new Pen(Color, 2))
                {
                    graphics.DrawRectangle(pen, this.Location.X, this.Location.Y, (int)Height, (int)Width);
                }
        }

        public override double CalculateSurface()=> Height * Width;

        public override string ToString()=> "Rectangle With Height: " + Height + " ,Width: " + Width ;

        public override bool Contains(Point point)
        {
            return Location.X < point.X && point.X < Location.X + Height &&
               Location.Y < point.Y && point.Y < Location.Y + Width;
        }

        public override double CalculateParameter()=> 2 * (Height + Width);

        public override void Rotate90()
        {
            var temp = this.Width;
            this.Width = this.Height;
            this.Height = temp;
        }
        public override double[] GetValues()
        {
            double[] Value = { this.Height,this.Width };
            return Value;

        }

        public override SerializeableShape SerializeObj()
        {
            return new SerializeableShape
            {
                FigureType = (int)FigureTypes.Rectangle,
                Perimeters = new double[] { Height, Width },
                Points = new float[] { Location.X, Location.Y },
                Color = this.Color.ToArgb() 


            };
        }

       
    }
}
