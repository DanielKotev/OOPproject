using System;
using System.Windows.Forms;
using LibraryProject;

namespace CourseProject
{

    public partial class RectPerimeters : Form 
    {
        private readonly DrawScene parent;
        
        public RectPerimeters(DrawScene scene)
        {
         
            InitializeComponent();
            this.CenterToScreen();
            parent = scene;
            
            if (parent.IsEditing&&parent.SelectedFigure!=null)
            {
                double[] Value = parent.SelectedFigure.GetValues();
                HeightRect.Text = Value[0].ToString();
                WidthRect.Text = Value[1].ToString();
            }

        }

        public double Width
        {
            get
            {
                try
                {
                    return double.Parse(WidthRect.Text);
                }
                catch (System.FormatException)
                {
                    return -1;
                }
            }
        }

        public double Height
        {
            get
            {
                try
                {
                    return double.Parse(HeightRect.Text);
                }
                catch (System.FormatException)
                {
                    return -1;
                }
            }
            
        }

        public Rectangle SetNewRectangle()=>  new Rectangle(Height,Width);

        private void OK_Click(object sender, EventArgs e)
        {

            if (Height > 1 && Width > 1)
            {
                this.DialogResult = DialogResult.OK;
                parent.CurrentFigure = SetNewRectangle();
                this.Close();
            }
            else
            {
                labelAlert.Show();
            }
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if(parent.IsEditing)
            {
                parent.SelectedFigure.Color = parent.OriginalColor;
                parent.SelectedFigure = null;
            }
             
            this.DialogResult = DialogResult.Cancel;
            
        }
    }
}
