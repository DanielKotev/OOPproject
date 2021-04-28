using System;
using LibraryProject;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class CirclePerimeters : Form
    {
        private readonly DrawScene parent;

        public CirclePerimeters(DrawScene scene)
        {
            
            InitializeComponent();
            this.CenterToScreen();
            parent = scene;
          
            if (parent.IsEditing && parent.SelectedFigure != null)
            {
                double[] Value = parent.SelectedFigure.GetValues();
                RadiusPer.Text = Value[0].ToString();
              
            }
        }

        private double Radius
        {
            get
            {
                try
                {
                    return double.Parse(RadiusPer.Text);
                }
                catch (System.FormatException)
                {
                    return -1;
                }
            }
        }

        private Circle SetNewCircle() => new Circle(Radius);

        private void Save_Click(object sender, EventArgs e)
        {

            if (Radius > 1)
            {
              
                this.DialogResult = DialogResult.OK;
                parent.CurrentFigure = SetNewCircle();
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
