using LibraryProject;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class StartWindow : Form
    {

        public StartWindow()
        {
            InitializeComponent();
            this.CenterToScreen();
            labelAlert.Hide();

        }

        private void OpenNewProject_Click(object sender, EventArgs e)
        {
            Form Form = new DrawScene();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }

        private void ImportProject_Click(object sender, EventArgs e)
        {
            DrawScene Form = new DrawScene();
           
            using (var openFileDialog = new OpenFileDialog())
            {
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
                                    Form.FigureList.Add(new Circle(f.Perimeters[0], f.Points[0], f.Points[1], f.Color, ++index));
                                    break;
                                case (int)FigureTypes.Rectangle:
                                    Form.FigureList.Add(new LibraryProject.Rectangle(f.Perimeters[0], f.Perimeters[1], f.Points[0], f.Points[1], f.Color, ++index));
                                    break;
                                case (int)FigureTypes.Triangle:
                                    Form.FigureList.Add(new Triangle(f.Perimeters[0], f.Perimeters[1], f.Perimeters[2], f.Points[0], f.Points[1], f.Color, ++index));
                                    break;
                             
                            }
                        }
                    }
                    Form.ShowDialog();
                    this.Close();
                }
               
                catch (Exception ex) when (ex is Newtonsoft.Json.JsonReaderException)
                {
                    labelAlert.Text = "INVALID FILE!";
                    labelAlert.Show();
                }
                catch (Exception ex) when (ex is NotImplementedException || ex is System.IndexOutOfRangeException)
                {
                    labelAlert.Text = "INVALID FIGURES!";
                    labelAlert.Show();
                }

            }
        }
    }
}
