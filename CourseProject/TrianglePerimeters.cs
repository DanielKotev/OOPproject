using System;
using System.Windows.Forms;
using LibraryProject;

namespace CourseProject
{
    public partial class TrianglePerimeters : Form
    {
        private readonly DrawScene parent;
        public TrianglePerimeters(DrawScene scene)
        {
            InitializeComponent();
            this.CenterToScreen();
            parent = scene;
           
            if (parent.IsEditing && parent.SelectedFigure != null)
            {
                double[] Value = parent.SelectedFigure.GetValues();
                TriLeftSide.Text = Value[0].ToString();
                TriRightSide.Text = Value[1].ToString();
                TriBaseSide.Text = Value[2].ToString();
            }

        }
        private double LeftSide
        {
            get
            {
                try
                {
                    return double.Parse(TriLeftSide.Text);
                }
                catch (System.FormatException)
                {
                    return -1;
                }
            }
        }

        private double RightSide
        {
            get
            {
                try
                {
                    return double.Parse(TriRightSide.Text);
                }
                catch (System.FormatException)
                {
                    return -1;
                }
            }
        }

        private double BaseSide
        {
            get
            {
                try
                {
                    return double.Parse(TriBaseSide.Text);
                }
                catch (System.FormatException)
                {
                    return -1;
                }
            }

        }

        public Triangle SetNewTriangle()=> new Triangle(LeftSide, RightSide, BaseSide);

        private void Save_Click(object sender, EventArgs e)
        {
            if ((LeftSide + RightSide > BaseSide &&
             RightSide + BaseSide > LeftSide &&
             BaseSide + LeftSide > RightSide))
            {
                
                this.DialogResult = DialogResult.OK;
                parent.CurrentFigure = SetNewTriangle();
                this.Close();
            }

            else
            {
                labelAlert.Show();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (parent.IsEditing)
            {
                parent.SelectedFigure.Color = parent.OriginalColor;
                parent.SelectedFigure = null;
            }
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
