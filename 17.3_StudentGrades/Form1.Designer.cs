namespace _17._3_StudentGrades
{
    partial class frmGrades
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.txtGrades = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(762, 9);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(29, 432);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // txtGrades
            // 
            this.txtGrades.Location = new System.Drawing.Point(12, 9);
            this.txtGrades.Name = "txtGrades";
            this.txtGrades.ReadOnly = true;
            this.txtGrades.Size = new System.Drawing.Size(747, 432);
            this.txtGrades.TabIndex = 1;
            this.txtGrades.Text = "";
            // 
            // frmGrades
            // 
            this.AccessibleDescription = "frmGrades";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGrades);
            this.Controls.Add(this.vScrollBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmGrades";
            this.Text = "Student Grades";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.RichTextBox txtGrades;
    }
}

