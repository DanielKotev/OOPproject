using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibraryProject;
using System.Linq;
using System.Drawing;
using System.Reflection;
using Newtonsoft.Json;
using System.IO;
using Rectangle = LibraryProject.Rectangle;

namespace CourseProject
{

    public partial class DrawScene : Form
    {
      
        public BaseShape CurrentFigure = null;
        public List<BaseShape> FigureList = new List<BaseShape>();
        public BaseShape SelectedFigure = null;
        public Color OriginalColor;
        public bool IsMoving = false;
        public bool IsEditing = false;

        private int DeltaX = 0;
        private int DeltaY = 0;

        public DrawScene()
        {
            InitializeComponent();
            this.CenterToScreen();

            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty |
                BindingFlags.Instance |
                BindingFlags.NonPublic,
                null,
               PanelDraw,
                new object[] { true });
        }

        private void CalculateAreaPermiters()
        {
            if (SelectedFigure != null)
                toolStripStatusLabelArea.Text = "Area:" + (int)SelectedFigure.CalculateSurface() + " Pixels     " + " Perimeters: " + (int)SelectedFigure.CalculateParameter() + " Pixels";

            if (SelectedFigure == null && FigureList != null)
            {
                var area = FigureList
                     .Select(s => s.CalculateSurface())
                     .Sum();

                var Perimiters = FigureList
                   .Select(s => s.CalculateParameter())
                   .Sum();

                toolStripStatusLabelArea.Text = "Area:" + (int)area + " Pixels     " + " Perimeters: " + (int)Perimiters + " Pixels ";
            }
        }

        private void PanelDraw_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var f in FigureList)
            {
                f.Draw(e.Graphics);
                if (SelectedFigure != null)
                    SelectedFigure.FillSelectedFigure(e.Graphics);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            FigureList.Clear();
            CalculateAreaPermiters();
            PanelDraw.Invalidate();
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            using (RectPerimeters f = new RectPerimeters(this))
            {
                f.ShowDialog();
                this.Show();
            }
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            using (CirclePerimeters f = new CirclePerimeters(this))
            {
                f.ShowDialog();
                this.Show();
            }
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            using (TrianglePerimeters f = new TrianglePerimeters(this))
            {
                f.ShowDialog();
                this.Show();
            }
        }

        private void PanelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && CurrentFigure != null)
            {
                using (var graphics = PanelDraw.CreateGraphics())
                {
                    CurrentFigure.Color = colorDialog1.Color;
                    CurrentFigure.Location = e.Location;
                    CurrentFigure.Draw(graphics);
                    CurrentFigure.Index = FigureList
                                        .Select(f => f.Index)
                                        .OrderBy(i => i)
                                        .LastOrDefault() + 1;
                }

                FigureList.Add(CurrentFigure);
                Mode.Text = "Right Click On The Figure Will Select It";

                CurrentFigure = null;
                if (SelectedFigure != null)
                {
                    SelectedFigure.Color = OriginalColor;
                    SelectedFigure = null;
                }
            }

            else if (e.Button == MouseButtons.Right)
            {
                //If the figure is no longer selected, figure's color turnes back to original color
                if (SelectedFigure != null)
                {
                    SelectedFigure.Color = OriginalColor;
                    Mode.Text = "Figure:";
                }

                SelectedFigure = FigureList
                                .OrderByDescending(i => i.Index)
                                .Where(f => f.Contains(e.Location))
                                .FirstOrDefault();

                //Selected figure turns Red
                if (SelectedFigure != null)
                {
                    OriginalColor = SelectedFigure.Color;
                    SelectedFigure.Color = Color.Red;

                    if (SelectedFigure is Circle)
                    {
                        Mode.Text = "Figure: Circle is Selected";
                    }
                    if (SelectedFigure is Triangle)
                    {
                        Mode.Text = "Figure: Triangle is Selected";
                    }
                    if (SelectedFigure is Rectangle)
                    {
                        Mode.Text = "Figure: Rectangle is Selected";
                    }

                }

                //Checking if selected figure is clicked once again- figure is moving 
                if (SelectedFigure != null && e.Button == MouseButtons.Right)
                {
                    IsMoving = true;
                }

                if (SelectedFigure != null)
                {
                    DeltaX = e.Location.X - SelectedFigure.Location.X;
                    DeltaY = e.Location.Y - SelectedFigure.Location.Y;
                }

            }
            CalculateAreaPermiters();
            PanelDraw.Invalidate();
        }

        private void PanelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            //Adding (X,Y) to the moving figure to the old coordinates
            if (SelectedFigure != null && IsMoving)
                SelectedFigure.Location = new Point(e.X - DeltaX, e.Y - DeltaY);
            PanelDraw.Invalidate();
            Application.DoEvents();

        }

        private void ChangeColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (SelectedFigure != null)
                OriginalColor = colorDialog1.Color;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //Delete selected figure
            if (SelectedFigure != null)
                FigureList.Remove(SelectedFigure);
            SelectedFigure = null;

            CalculateAreaPermiters();
            PanelDraw.Invalidate();
        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            if (SelectedFigure != null)
                SelectedFigure.Rotate90();

            else
                Mode.Text = "You must Select Figure";

            PanelDraw.Invalidate();
        }

        private void PanelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                IsMoving = false;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            IsEditing = true;
            if (SelectedFigure != null)
            {
                if (SelectedFigure is Rectangle)
                {
                    var f = new RectPerimeters(this);
                    f.ShowDialog();
                    if (CurrentFigure != null)
                    {
                        using (var graphics = PanelDraw.CreateGraphics())
                        {
                            CurrentFigure.Color = OriginalColor;
                            CurrentFigure.Location = SelectedFigure.Location;
                            CurrentFigure.Index = SelectedFigure.Index;
                            FigureList.Remove(SelectedFigure);
                            CurrentFigure.Draw(graphics);
                            FigureList.Add(CurrentFigure);
                        }
                        Mode.Text = "Figure: Rectangle has been edited successfully";
                    }
                }
                if (SelectedFigure is Circle)
                {
                    var f = new CirclePerimeters(this);
                    f.ShowDialog();
                    if (CurrentFigure != null)
                    {
                        using (var graphics = PanelDraw.CreateGraphics())
                        {
                            CurrentFigure.Color = OriginalColor;
                            CurrentFigure.Location = SelectedFigure.Location;
                            CurrentFigure.Index = SelectedFigure.Index;
                            FigureList.Remove(SelectedFigure);
                            CurrentFigure.Draw(graphics);
                            FigureList.Add(CurrentFigure);
                        }
                        Mode.Text = "Figure: Circle has been edited successfully";
                    }
                }
                if (SelectedFigure is Triangle)
                {
                    var f = new TrianglePerimeters(this);
                    f.ShowDialog();
                    if (CurrentFigure != null)
                    {
                        using (var graphics = PanelDraw.CreateGraphics())
                        {
                            CurrentFigure.Color = OriginalColor;
                            CurrentFigure.Location = SelectedFigure.Location;
                            CurrentFigure.Index = SelectedFigure.Index;
                            FigureList.Remove(SelectedFigure);
                            CurrentFigure.Draw(graphics);
                            FigureList.Add(CurrentFigure);
                        }
                        Mode.Text = "Figure: Triangle has been edited successfully";
                    }
                }
                SelectedFigure = null;
                CurrentFigure = null;
                PanelDraw.Invalidate();
                IsEditing = false;
            }

            CalculateAreaPermiters();
            PanelDraw.Invalidate();
            if (SelectedFigure == null)
            {
                Mode.Text = "You must Select Figure";
            }
        }

        private void SaveProject_Click(object sender, EventArgs e)
        {
            if (SelectedFigure != null)
            {
               SelectedFigure.Color = OriginalColor;
                SelectedFigure = null;
            }

            using (SaveFileDialog SaveFileDialog = new SaveFileDialog())
            {
                SaveFileDialog.FileName = "Figures.Json";
                SaveFileDialog.Filter = "Binary files (*.Json)|*.Json|All files(*.*)|*.*";
                SaveFileDialog.DefaultExt = "Binary files (*.Json)|*.Json|All files(*.*)|*.*";
                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<SerializeableShape> serializeableShapes = FigureList
                        .Select(s => s.SerializeObj())
                        .ToList();

                    string StrResult = JsonConvert.SerializeObject(serializeableShapes, Formatting.Indented);
                    File.WriteAllText(SaveFileDialog.FileName, StrResult);
                }
            }
            if (FigureList.Any())
            {
                Mode.Text = "Figures Saved Successfully";
            }
        }

        private void ImportFile_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                FigureList.Clear();
                try
                {
                    openFileDialog.FileName = "";
                    openFileDialog.Filter = "Binary files (*.Json)|*.Json|All files(*.*)|*.*";
                    openFileDialog.DefaultExt = "Binary files (*.Json)|*.Json|All files(*.*)|*.*";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var strJsonResult = File.ReadAllText(openFileDialog.FileName);
                        var resultShapes = JsonConvert.DeserializeObject<List<SerializeableShape>>(strJsonResult);
                        var index = 0;
                        foreach (var f in resultShapes)
                        {
                            switch (f.FigureType)
                            {
                                case (int)FigureTypes.Circle:
                                    FigureList.Add(new Circle(f.Perimeters[0], f.Points[0], f.Points[1], f.Color, ++index));
                                    break;
                                case (int)FigureTypes.Rectangle:
                                    FigureList.Add(new Rectangle(f.Perimeters[0], f.Perimeters[1], f.Points[0], f.Points[1], f.Color, ++index));
                                    break;
                                case (int)FigureTypes.Triangle:
                                    FigureList.Add(new Triangle(f.Perimeters[0], f.Perimeters[1], f.Perimeters[2], f.Points[0], f.Points[1], f.Color, ++index));
                                    break;
                               
                            }
                        }
                      
                    }
                   
                }
                catch (Exception ex) when (ex is NotImplementedException || ex is System.IndexOutOfRangeException)
                {

                    Mode.Text = "The Figures Is not Supported!";
                    FigureList.Clear();
                }
                catch (Exception ex) when (ex is Newtonsoft.Json.JsonReaderException)
                {
                    Mode.Text = "Invalid File, Please Choose JSON FIle";
                }
            }

            if (FigureList.Any())
            {
                Mode.Text = "Figures have been Imported Successfully";
            }
           
        }
       
    }
}
