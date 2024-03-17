namespace libbuhha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonb1 = new library.custome.buttonb();
            this.rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.Exit = new System.Windows.Forms.Label();
            this.show1 = new System.Windows.Forms.PictureBox();
            this.hide1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::libbuhha.Properties.Resources.stack_of_books;
            this.pictureBox1.Location = new System.Drawing.Point(46, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 260);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.Image = global::libbuhha.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(436, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox3.Image = global::libbuhha.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(436, 263);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(85, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "GM Library ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(493, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Opps! wrong passwords or name";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(493, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Login Success";
            this.label4.Visible = false;
            // 
            // buttonb1
            // 
            this.buttonb1.BackColor = System.Drawing.Color.White;
            this.buttonb1.BackgroundColor = System.Drawing.Color.White;
            this.buttonb1.BorderColor = System.Drawing.Color.White;
            this.buttonb1.BorderRadius = 10;
            this.buttonb1.BorderSize = 0;
            this.buttonb1.FlatAppearance.BorderSize = 0;
            this.buttonb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonb1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonb1.ForeColor = System.Drawing.Color.Black;
            this.buttonb1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonb1.Location = new System.Drawing.Point(546, 367);
            this.buttonb1.Name = "buttonb1";
            this.buttonb1.Size = new System.Drawing.Size(138, 44);
            this.buttonb1.TabIndex = 4;
            this.buttonb1.Text = "Login";
            this.buttonb1.TextColor = System.Drawing.Color.Black;
            this.buttonb1.UseVisualStyleBackColor = false;
            this.buttonb1.Click += new System.EventHandler(this.buttonb1_Click);
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.AutoSize = true;
            this.rjTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox2.BorderColor = System.Drawing.Color.HotPink;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.Red;
            this.rjTextBox2.BorderSize = 4;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.rjTextBox2.ForeColor = System.Drawing.Color.White;
            this.rjTextBox2.Location = new System.Drawing.Point(497, 263);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.Size = new System.Drawing.Size(240, 46);
            this.rjTextBox2.TabIndex = 3;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = true;
            this.rjTextBox2._TextChanged += new System.EventHandler(this.rjTextBox2__TextChanged);
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.BorderColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.Red;
            this.rjTextBox1.BorderSize = 4;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.White;
            this.rjTextBox1.Location = new System.Drawing.Point(497, 139);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.Size = new System.Drawing.Size(240, 46);
            this.rjTextBox1.TabIndex = 0;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = true;
            this.rjTextBox1._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(767, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(21, 23);
            this.Exit.TabIndex = 16;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // show1
            // 
            this.show1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.show1.Image = global::libbuhha.Properties.Resources.icons8_show_25;
            this.show1.Location = new System.Drawing.Point(744, 269);
            this.show1.Name = "show1";
            this.show1.Size = new System.Drawing.Size(38, 40);
            this.show1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.show1.TabIndex = 17;
            this.show1.TabStop = false;
            this.show1.Click += new System.EventHandler(this.show1_Click);
            // 
            // hide1
            // 
            this.hide1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hide1.Image = global::libbuhha.Properties.Resources.icons8_hide_50;
            this.hide1.Location = new System.Drawing.Point(744, 263);
            this.hide1.Name = "hide1";
            this.hide1.Size = new System.Drawing.Size(38, 40);
            this.hide1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hide1.TabIndex = 18;
            this.hide1.TabStop = false;
            this.hide1.Click += new System.EventHandler(this.hide1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(444, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Don\'t have account? ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::libbuhha.Properties.Resources.darkbackground;
            this.ClientSize = new System.Drawing.Size(798, 510);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hide1);
            this.Controls.Add(this.show1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonb1);
            this.Controls.Add(this.rjTextBox2);
            this.Controls.Add(this.rjTextBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Library Managemt 1.0.0.0 (experimental)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private library.custome.buttonb buttonb1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public CustomControls.RJControls.RJTextBox rjTextBox1;
        public CustomControls.RJControls.RJTextBox rjTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.PictureBox show1;
        private System.Windows.Forms.PictureBox hide1;
        private System.Windows.Forms.Label label3;
    }
}

