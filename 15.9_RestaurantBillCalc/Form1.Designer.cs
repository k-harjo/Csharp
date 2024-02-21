namespace _15._9_RestaurantBillCalc
{
    partial class Form1
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
            this.bevs = new System.Windows.Forms.ComboBox();
            this.mains = new System.Windows.Forms.ComboBox();
            this.dess = new System.Windows.Forms.ComboBox();
            this.apps = new System.Windows.Forms.ComboBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bevs
            // 
            this.bevs.FormattingEnabled = true;
            this.bevs.Items.AddRange(new object[] {
            "Soda, $1.95",
            "Tea, $1.50",
            "Coffee, $1.25",
            "Mineral Water, $2.95",
            "Juice, $2.50",
            "Milk, $1.50"});
            this.bevs.Location = new System.Drawing.Point(12, 21);
            this.bevs.Name = "bevs";
            this.bevs.Size = new System.Drawing.Size(121, 21);
            this.bevs.TabIndex = 0;
            this.bevs.Text = "Beverages";
            this.bevs.SelectedIndexChanged += new System.EventHandler(this.dropdownSelection);
            // 
            // mains
            // 
            this.mains.FormattingEnabled = true;
            this.mains.Items.AddRange(new object[] {
            "Chicken Alfredo, $13.95",
            "Chicken Picatta, $13.95",
            "Turkey Club, $11.95",
            "Lobster Pie, $19.95",
            "Prime Rib, $20.95",
            "Shrimp Scampi, $18.95",
            "Turkey Dinner, $13.95",
            "Stuffed Chicken, $14.95"});
            this.mains.Location = new System.Drawing.Point(159, 21);
            this.mains.Name = "mains";
            this.mains.Size = new System.Drawing.Size(121, 21);
            this.mains.TabIndex = 1;
            this.mains.Text = "Main Courses";
            this.mains.SelectedIndexChanged += new System.EventHandler(this.dropdownSelection);
            // 
            // dess
            // 
            this.dess.FormattingEnabled = true;
            this.dess.Items.AddRange(new object[] {
            "Apple Pie, $5.95",
            "Sundae, $3.95",
            "Carrot Cake, $5.95",
            "Mud Pie, $4.95",
            "Apple Crisp, $5.95"});
            this.dess.Location = new System.Drawing.Point(159, 73);
            this.dess.Name = "dess";
            this.dess.Size = new System.Drawing.Size(121, 21);
            this.dess.TabIndex = 3;
            this.dess.Text = "Desserts";
            this.dess.SelectedIndexChanged += new System.EventHandler(this.dropdownSelection);
            // 
            // apps
            // 
            this.apps.FormattingEnabled = true;
            this.apps.Items.AddRange(new object[] {
            "Buffalo Wings, $5.95",
            "Buffalo Fingers, $6.95",
            "Potato Skins, $8.95",
            "Nachos, $8.95",
            "Mushroom Caps, $10.95",
            "Chips and Salsa, $6.95"});
            this.apps.Location = new System.Drawing.Point(12, 73);
            this.apps.Name = "apps";
            this.apps.Size = new System.Drawing.Size(121, 21);
            this.apps.TabIndex = 2;
            this.apps.Text = "Appetizers";
            this.apps.SelectedIndexChanged += new System.EventHandler(this.dropdownSelection);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(12, 126);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(268, 121);
            this.lstOutput.TabIndex = 4;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(85, 270);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(112, 23);
            this.clear.TabIndex = 5;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 316);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.dess);
            this.Controls.Add(this.apps);
            this.Controls.Add(this.mains);
            this.Controls.Add(this.bevs);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox bevs;
        private System.Windows.Forms.ComboBox mains;
        private System.Windows.Forms.ComboBox dess;
        private System.Windows.Forms.ComboBox apps;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button clear;
    }
}

