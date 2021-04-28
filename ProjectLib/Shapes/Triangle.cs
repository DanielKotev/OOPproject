using System;
using System.Drawing;


namespace LibraryProject
{

    public class Triangle : BaseShape
    {
        private double LeftSide { get; set; }
        private double RightSide { get; set; }
        private double BaseSide { get; set; }
        private PointF Top { get; set; }
        private PointF Left { get; set; }
        private PointF Right { get; set; }

        public PointF[] GetPoints()
        {
            this.Left = new PointF(this.Location.X, Location.Y);
            this.Right = new PointF(Left.X + (float)BaseSide, Left.Y);
            this.Top = new PointF(Left.X + PythagHieghtLeft(), Right.Y - CalcHeight());
            return new PointF[] { Top, Left, Right };
        }

        public Triangle(double leftSide, double rightside, double baseSide) : base()
        {
            LeftSide = leftSide;
            RightSide = rightside;
            BaseSide = baseSide;
        }
        public Triangle(double leftSide, double rightside, double baseSide, float x1, float y1, int color,int index)
        {
            LeftSide = leftSide;
            RightSide = rightside;
            BaseSide = baseSide;
            Location = new Point((int)x1, (int)y1);
            Index = index;
             GetPoints();
            this.Color = Color.FromArgb(color);
        }

        private float CalcHeight()
        {
            var height = (CalculateSurface() * 2) / BaseSide;
            return
               (float)height;
        }

        private float PythagHieghtLeft()
        {
            var HLeft = Math.Pow(LeftSide, 2) - Math.Pow(CalcHeight(), 2);
            return
                (float)Math.Sqrt(HLeft);
        }

        public override void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(Color, 2))
            {
                graphics.DrawPolygon(pen, GetPoints());
            }
        }
        public override void FillSelectedFigure(Graphics graphics)
        {
            using (var brush = new SolidBrush(
             Color.FromArgb(
                Math.Min(byte.MaxValue, Color.R + 50),
                 Math.Min(byte.MaxValue, Color.G + 50),
                  Math.Min(byte.MaxValue, Color.B + 50))))
                graphics.FillPolygon(brush, GetPoints());

            using (var pen = new Pen(Color, 2))
                graphics.DrawPolygon(pen, GetPoints());
        }

        public override bool Contains(Point point)
        {

            return
                (((point.X - Left.X) * (Top.Y - Left.Y) - (point.Y - Left.Y) * (Top.X - Left.X)) * ((Right.X - Left.X) * (Top.Y - Left.Y) - (Right.Y - Left.Y) * (Top.X - Left.X)) >= 0) &&
                (((point.X - Top.X) * (Right.Y - Top.Y) - (point.Y - Top.Y) * (Right.X - Top.X)) * ((Left.X - Top.X) * (Right.Y - Top.Y) - (Left.Y - Top.Y) * (Right.X - Top.X)) >= 0) &&
                (((point.X - Right.X) * (Left.Y - Right.Y) - (point.Y - Right.Y) * (Left.X - Right.X)) * ((Top.X - Right.X) * (Left.Y - Right.Y) - (Top.Y - Right.Y) * (Left.X - Right.X)) >= 0);
        }

        public override double CalculateParameter() => LeftSide + RightSide + BaseSide;

        public override string ToString() => "Triangle With Parimeters " + LeftSide + " " + RightSide + " " + BaseSide + " ";

        public override double CalculateSurface()
        {
            double s = CalculateParameter() / 2;

            if (LeftSide + RightSide >= BaseSide &&
                RightSide + BaseSide >= LeftSide &&
                BaseSide + LeftSide >= RightSide)
                return
                    Math.Sqrt(s * (s - LeftSide) * (s - RightSide) * (s - BaseSide));
            return -1;
        }

        public override double[] GetValues()
        {
            double[] Value = { this.LeftSide, this.RightSide, this.BaseSide };
            return Value;

        }
        public override void Rotate90()
        {
            var temp = RightSide;
            RightSide = BaseSide;
            BaseSide = LeftSide;
            LeftSide = temp;
        }

        public override SerializeableShape SerializeObj()
        {
            return new SerializeableShape
            {
                FigureType = (int)FigureTypes.Triangle,
                Perimeters = new double[] { LeftSide, RightSide, BaseSide },
                Points = new float[] { Left.X, Left.Y, Top.X, Top.Y, Right.X, Right.Y },
                Color = this.Color.ToArgb()
            };
        }

    
    }
}
