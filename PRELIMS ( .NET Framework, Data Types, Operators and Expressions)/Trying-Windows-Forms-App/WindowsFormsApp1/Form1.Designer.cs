namespace WindowsFormsApp1
{
    partial class WindowsFormTry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsFormTry));
            this.Greeting = new System.Windows.Forms.Label();
            this.helloInput = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.USERNAME = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Greeting
            // 
            this.Greeting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Greeting.AutoSize = true;
            this.Greeting.BackColor = System.Drawing.Color.Transparent;
            this.Greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greeting.ForeColor = System.Drawing.Color.FloralWhite;
            this.Greeting.Location = new System.Drawing.Point(544, 276);
            this.Greeting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Greeting.Name = "Greeting";
            this.Greeting.Size = new System.Drawing.Size(63, 25);
            this.Greeting.TabIndex = 0;
            this.Greeting.Text = "hello";
            this.Greeting.Click += new System.EventHandler(this.label1_Click);
            // 
            // helloInput
            // 
            this.helloInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helloInput.Location = new System.Drawing.Point(525, 304);
            this.helloInput.Name = "helloInput";
            this.helloInput.Size = new System.Drawing.Size(100, 20);
            this.helloInput.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GAY",
            "LESBIAN",
            "PANSEXUAL",
            "TRANSGENDER",
            "BOB",
            "ALL OF THE ABOVE"});
            this.comboBox1.Location = new System.Drawing.Point(514, 334);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.SubmitButton.Location = new System.Drawing.Point(539, 369);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // USERNAME
            // 
            this.USERNAME.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.USERNAME.AutoSize = true;
            this.USERNAME.BackColor = System.Drawing.Color.Transparent;
            this.USERNAME.ForeColor = System.Drawing.Color.Cyan;
            this.USERNAME.Location = new System.Drawing.Point(416, 306);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(108, 13);
            this.USERNAME.TabIndex = 5;
            this.USERNAME.Text = "WHAT YO NAME:";
            this.USERNAME.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(418, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SELECT BLUD:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // WindowsFormTry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._15533cefda44444cf7a90ceed6de8300;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 606);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.USERNAME);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.helloInput);
            this.Controls.Add(this.Greeting);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "WindowsFormTry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SURVEY";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Greeting;
        public System.Windows.Forms.TextBox helloInput;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label USERNAME;
        private System.Windows.Forms.Label label2;
    }
}

