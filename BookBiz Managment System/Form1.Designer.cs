namespace BookBiz_Managment_System
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
            this.UserName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.LogBut = new System.Windows.Forms.Button();
            this.comboBoxname = new System.Windows.Forms.ComboBox();
            this.comboBoxCarrier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(19, 96);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(85, 20);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "Full Name";
            this.UserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(19, 219);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(92, 213);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(237, 22);
            this.textBoxPass.TabIndex = 4;
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            // 
            // LogBut
            // 
            this.LogBut.BackColor = System.Drawing.Color.Gold;
            this.LogBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogBut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogBut.Location = new System.Drawing.Point(153, 252);
            this.LogBut.Name = "LogBut";
            this.LogBut.Size = new System.Drawing.Size(105, 33);
            this.LogBut.TabIndex = 5;
            this.LogBut.Text = "Login";
            this.LogBut.UseVisualStyleBackColor = false;
            this.LogBut.Click += new System.EventHandler(this.LogBut_Click);
            // 
            // comboBoxname
            // 
            this.comboBoxname.FormattingEnabled = true;
            this.comboBoxname.Items.AddRange(new object[] {
            "Henry Brown",
            "Thomas Moore",
            "Peter Wang",
            "Mary Brown",
            "Jennifer Bouchard"});
            this.comboBoxname.Location = new System.Drawing.Point(92, 88);
            this.comboBoxname.Name = "comboBoxname";
            this.comboBoxname.Size = new System.Drawing.Size(241, 24);
            this.comboBoxname.TabIndex = 7;
            this.comboBoxname.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxCarrier
            // 
            this.comboBoxCarrier.FormattingEnabled = true;
            this.comboBoxCarrier.Items.AddRange(new object[] {
            "MIS Manager",
            "Sales Manager",
            "Inventory Controller",
            "Order Clerks"});
            this.comboBoxCarrier.Location = new System.Drawing.Point(92, 138);
            this.comboBoxCarrier.Name = "comboBoxCarrier";
            this.comboBoxCarrier.Size = new System.Drawing.Size(241, 24);
            this.comboBoxCarrier.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Career";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblmsg
            // 
            this.lblmsg.Location = new System.Drawing.Point(88, 291);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(241, 22);
            this.lblmsg.TabIndex = 10;
            this.lblmsg.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(416, 30);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblmsg);
            this.groupBox1.Controls.Add(this.comboBoxname);
            this.groupBox1.Controls.Add(this.LogBut);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPass);
            this.groupBox1.Controls.Add(this.comboBoxCarrier);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.UserName);
            this.groupBox1.Location = new System.Drawing.Point(0, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 351);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Welcome To Book Biz";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select your fullname and your career";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 391);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button LogBut;
        private System.Windows.Forms.ComboBox comboBoxname;
        private System.Windows.Forms.ComboBox comboBoxCarrier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblmsg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}

