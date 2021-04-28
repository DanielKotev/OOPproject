namespace CourseProject
{
    partial class StartWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWindow));
            this.OpenNewProject = new System.Windows.Forms.Button();
            this.ImportProject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAlert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenNewProject
            // 
            this.OpenNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenNewProject.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenNewProject.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenNewProject.Image = ((System.Drawing.Image)(resources.GetObject("OpenNewProject.Image")));
            this.OpenNewProject.Location = new System.Drawing.Point(114, 36);
            this.OpenNewProject.Name = "OpenNewProject";
            this.OpenNewProject.Size = new System.Drawing.Size(64, 79);
            this.OpenNewProject.TabIndex = 0;
            this.OpenNewProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpenNewProject.UseVisualStyleBackColor = true;
            this.OpenNewProject.Click += new System.EventHandler(this.OpenNewProject_Click);
            // 
            // ImportProject
            // 
            this.ImportProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ImportProject.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ImportProject.Image = ((System.Drawing.Image)(resources.GetObject("ImportProject.Image")));
            this.ImportProject.Location = new System.Drawing.Point(45, 35);
            this.ImportProject.Name = "ImportProject";
            this.ImportProject.Size = new System.Drawing.Size(63, 80);
            this.ImportProject.TabIndex = 1;
            this.ImportProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImportProject.UseVisualStyleBackColor = true;
            this.ImportProject.Click += new System.EventHandler(this.ImportProject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Import File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Project";
            // 
            // labelAlert
            // 
            this.labelAlert.AutoSize = true;
            this.labelAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlert.ForeColor = System.Drawing.Color.Red;
            this.labelAlert.Location = new System.Drawing.Point(64, 118);
            this.labelAlert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlert.Name = "labelAlert";
            this.labelAlert.Size = new System.Drawing.Size(104, 17);
            this.labelAlert.TabIndex = 15;
            this.labelAlert.Text = "INVALID FILE";
            this.labelAlert.Visible = false;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(221, 153);
            this.Controls.Add(this.labelAlert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImportProject);
            this.Controls.Add(this.OpenNewProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Draw Figures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenNewProject;
        private System.Windows.Forms.Button ImportProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAlert;
    }
}

