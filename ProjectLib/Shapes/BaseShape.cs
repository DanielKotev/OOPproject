using System;
using System.Drawing;

namespace LibraryProject
{
   
   
    public abstract class BaseShape
    {
        public Point Location { get; set; }
        public int Index { get; set; }
        public Color Color { get; set; }

        public BaseShape()
        {
            Color = Color.Blue;
        }
        public abstract double CalculateSurface();
        public abstract void Draw(Graphics graphics);
        public abstract void FillSelectedFigure(Graphics graphics);
        public abstract double CalculateParameter();
        public abstract bool Contains(Point point);
        public abstract double[] GetValues();
        public abstract void Rotate90();
        public abstract SerializeableShape SerializeObj();
        
       
        
        
    }
}


