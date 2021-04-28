namespace CourseProject
{
    partial class TrianglePerimeters
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
            this.TriLeftSide = new System.Windows.Forms.TextBox();
            this.TriRightSide = new System.Windows.Forms.TextBox();
            this.TriBaseSide = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.labelAlert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TriLeftSide
            // 
            this.TriLeftSide.Location = new System.Drawing.Point(123, 25);
            this.TriLeftSide.Name = "TriLeftSide";
            this.TriLeftSide.Size = new System.Drawing.Size(100, 20);
            this.TriLeftSide.TabIndex = 0;
            // 
            // TriRightSide
            // 
            this.TriRightSide.Location = new System.Drawing.Point(123, 51);
            this.TriRightSide.Name = "TriRightSide";
            this.TriRightSide.Size = new System.Drawing.Size(100, 20);
            this.TriRightSide.TabIndex = 1;
            // 
            // TriBaseSide
            // 
            this.TriBaseSide.Location = new System.Drawing.Point(123, 77);
            this.TriBaseSide.Name = "TriBaseSide";
            this.TriBaseSide.Size = new System.Drawing.Size(100, 20);
            this.TriBaseSide.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Left Side";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Right Side";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Base Side";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(91, 103);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(172, 103);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // labelAlert
            // 
            this.labelAlert.AutoSize = true;
            this.labelAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlert.ForeColor = System.Drawing.Color.Red;
            this.labelAlert.Location = new System.Drawing.Point(106, 128);
            this.labelAlert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlert.Name = "labelAlert";
            this.labelAlert.Size = new System.Drawing.Size(129, 17);
            this.labelAlert.TabIndex = 12;
            this.labelAlert.Text = "INVALID FIGURE";
            this.labelAlert.Visible = false;
            // 
            // TrianglePerimeters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(318, 154);
            this.Controls.Add(this.labelAlert);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TriBaseSide);
            this.Controls.Add(this.TriRightSide);
            this.Controls.Add(this.TriLeftSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TrianglePerimeters";
            this.Text = "Triangle Perimeters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TriLeftSide;
        private System.Windows.Forms.TextBox TriRightSide;
        private System.Windows.Forms.TextBox TriBaseSide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label labelAlert;
    }
}