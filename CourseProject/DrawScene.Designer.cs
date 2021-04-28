namespace CourseProject
{
    partial class DrawScene
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelDraw = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Mode = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripScene = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelArea = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Edit = new System.Windows.Forms.Button();
            this.ChangeColor = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Rotate = new System.Windows.Forms.Button();
            this.ImportFile = new System.Windows.Forms.Button();
            this.SaveProject = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.PanelDraw.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStripScene.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDraw
            // 
            this.PanelDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDraw.AutoSize = true;
            this.PanelDraw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelDraw.Controls.Add(this.statusStrip1);
            this.PanelDraw.Controls.Add(this.statusStripScene);
            this.PanelDraw.Location = new System.Drawing.Point(-1, -2);
            this.PanelDraw.Name = "PanelDraw";
            this.PanelDraw.Size = new System.Drawing.Size(828, 498);
            this.PanelDraw.TabIndex = 0;
            this.PanelDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDraw_Paint);
            this.PanelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelDraw_MouseDown);
            this.PanelDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelDraw_MouseMove);
            this.PanelDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelDraw_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mode});
            this.statusStrip1.Location = new System.Drawing.Point(0, 454);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(828, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Mode
            // 
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(46, 17);
            this.Mode.Text = "Figure: ";
            // 
            // statusStripScene
            // 
            this.statusStripScene.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelArea});
            this.statusStripScene.Location = new System.Drawing.Point(0, 476);
            this.statusStripScene.Name = "statusStripScene";
            this.statusStripScene.Size = new System.Drawing.Size(828, 22);
            this.statusStripScene.TabIndex = 1;
            this.statusStripScene.Text = "statusStrip1";
            // 
            // toolStripStatusLabelArea
            // 
            this.toolStripStatusLabelArea.Name = "toolStripStatusLabelArea";
            this.toolStripStatusLabelArea.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabelArea.Text = "Area: ";
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Blue;
            // 
            // Edit
            // 
            this.Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit.Image = global::CourseProject.Properties.Resources.icons8_edit_16;
            this.Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit.Location = new System.Drawing.Point(833, 102);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(87, 24);
            this.Edit.TabIndex = 10;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // ChangeColor
            // 
            this.ChangeColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeColor.Image = global::CourseProject.Properties.Resources.icons8_color_dropper_16;
            this.ChangeColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeColor.Location = new System.Drawing.Point(833, 132);
            this.ChangeColor.Name = "ChangeColor";
            this.ChangeColor.Size = new System.Drawing.Size(87, 23);
            this.ChangeColor.TabIndex = 9;
            this.ChangeColor.Text = "Color";
            this.ChangeColor.UseVisualStyleBackColor = true;
            this.ChangeColor.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.Image = global::CourseProject.Properties.Resources.icons8_delete_16;
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.Location = new System.Drawing.Point(833, 41);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(87, 23);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Rotate
            // 
            this.Rotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rotate.Image = global::CourseProject.Properties.Resources.icons8_rotate_page_clockwise_24;
            this.Rotate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Rotate.Location = new System.Drawing.Point(833, 70);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(87, 26);
            this.Rotate.TabIndex = 7;
            this.Rotate.Text = "Rotate";
            this.Rotate.UseVisualStyleBackColor = true;
            this.Rotate.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // ImportFile
            // 
            this.ImportFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportFile.Image = global::CourseProject.Properties.Resources.icons8_download_16;
            this.ImportFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImportFile.Location = new System.Drawing.Point(833, 462);
            this.ImportFile.Name = "ImportFile";
            this.ImportFile.Size = new System.Drawing.Size(87, 23);
            this.ImportFile.TabIndex = 6;
            this.ImportFile.Text = "Import File";
            this.ImportFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImportFile.UseVisualStyleBackColor = true;
            this.ImportFile.Click += new System.EventHandler(this.ImportFile_Click);
            // 
            // SaveProject
            // 
            this.SaveProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveProject.Image = global::CourseProject.Properties.Resources.icons8_save_16;
            this.SaveProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveProject.Location = new System.Drawing.Point(833, 433);
            this.SaveProject.Name = "SaveProject";
            this.SaveProject.Size = new System.Drawing.Size(87, 23);
            this.SaveProject.TabIndex = 5;
            this.SaveProject.Text = "Save ";
            this.SaveProject.UseVisualStyleBackColor = true;
            this.SaveProject.Click += new System.EventHandler(this.SaveProject_Click);
            // 
            // Triangle
            // 
            this.Triangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Triangle.Image = global::CourseProject.Properties.Resources.icons8_triangle_24__2_;
            this.Triangle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Triangle.Location = new System.Drawing.Point(833, 302);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(87, 31);
            this.Triangle.TabIndex = 4;
            this.Triangle.Text = "Triangle";
            this.Triangle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Circle
            // 
            this.Circle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Circle.Image = global::CourseProject.Properties.Resources.icons8_circle_24__1_;
            this.Circle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Circle.Location = new System.Drawing.Point(833, 267);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(87, 29);
            this.Circle.TabIndex = 3;
            this.Circle.Text = "Circle";
            this.Circle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rectangle.Image = global::CourseProject.Properties.Resources.icons8_rectangular_24__2_;
            this.Rectangle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Rectangle.Location = new System.Drawing.Point(833, 228);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(87, 33);
            this.Rectangle.TabIndex = 2;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Clear.Cursor = System.Windows.Forms.Cursors.Default;
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Image = global::CourseProject.Properties.Resources.icons8_clear_symbol_16;
            this.Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clear.Location = new System.Drawing.Point(833, 12);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(87, 23);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // DrawScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(925, 495);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.ChangeColor);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Rotate);
            this.Controls.Add(this.ImportFile);
            this.Controls.Add(this.SaveProject);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.PanelDraw);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "DrawScene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "DrawScene";
            this.PanelDraw.ResumeLayout(false);
            this.PanelDraw.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStripScene.ResumeLayout(false);
            this.statusStripScene.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelDraw;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button SaveProject;
        private System.Windows.Forms.Button ImportFile;
        private System.Windows.Forms.Button Rotate;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button ChangeColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.StatusStrip statusStripScene;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelArea;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Mode;
    }
}