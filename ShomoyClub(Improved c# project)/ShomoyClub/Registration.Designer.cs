namespace ShomoyClub
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.s_dept = new System.Windows.Forms.ComboBox();
            this.b_gr = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.repass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.p_numb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.sign_in = new System.Windows.Forms.Button();
            this.sign_up = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.s_age = new System.Windows.Forms.TextBox();
            this.s_id = new System.Windows.Forms.TextBox();
            this.s_name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.s_dept);
            this.panel1.Controls.Add(this.b_gr);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.repass);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.p_numb);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.sign_in);
            this.panel1.Controls.Add(this.sign_up);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mail);
            this.panel1.Controls.Add(this.s_age);
            this.panel1.Controls.Add(this.s_id);
            this.panel1.Controls.Add(this.s_name);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 670);
            this.panel1.TabIndex = 0;
            // 
            // s_dept
            // 
            this.s_dept.FormattingEnabled = true;
            this.s_dept.Items.AddRange(new object[] {
            "CSE",
            "EEE",
            "BBA",
            "Archi",
            "Social Science",
            "Law"});
            this.s_dept.Location = new System.Drawing.Point(655, 196);
            this.s_dept.Name = "s_dept";
            this.s_dept.Size = new System.Drawing.Size(201, 24);
            this.s_dept.TabIndex = 26;
            // 
            // b_gr
            // 
            this.b_gr.FormattingEnabled = true;
            this.b_gr.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.b_gr.Location = new System.Drawing.Point(655, 322);
            this.b_gr.Name = "b_gr";
            this.b_gr.Size = new System.Drawing.Size(201, 24);
            this.b_gr.TabIndex = 25;
            this.b_gr.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(474, 451);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Retype Password";
            // 
            // repass
            // 
            this.repass.Location = new System.Drawing.Point(655, 448);
            this.repass.Multiline = true;
            this.repass.Name = "repass";
            this.repass.PasswordChar = '*';
            this.repass.Size = new System.Drawing.Size(201, 42);
            this.repass.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(474, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Phone Number";
            // 
            // p_numb
            // 
            this.p_numb.Location = new System.Drawing.Point(655, 352);
            this.p_numb.Multiline = true;
            this.p_numb.Name = "p_numb";
            this.p_numb.Size = new System.Drawing.Size(201, 42);
            this.p_numb.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(448, 613);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(562, 35);
            this.label10.TabIndex = 20;
            this.label10.Text = "A Social Welfare Organisation TO Motivate The Youth ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(935, 535);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(81, 33);
            this.exit.TabIndex = 19;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // sign_in
            // 
            this.sign_in.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sign_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in.Location = new System.Drawing.Point(762, 535);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(94, 33);
            this.sign_in.TabIndex = 18;
            this.sign_in.Text = "Sign In";
            this.sign_in.UseVisualStyleBackColor = false;
            this.sign_in.Click += new System.EventHandler(this.sign_in_Click);
            // 
            // sign_up
            // 
            this.sign_up.BackColor = System.Drawing.SystemColors.Highlight;
            this.sign_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_up.Location = new System.Drawing.Point(655, 535);
            this.sign_up.Name = "sign_up";
            this.sign_up.Size = new System.Drawing.Size(90, 33);
            this.sign_up.TabIndex = 17;
            this.sign_up.Text = "Sign Up";
            this.sign_up.UseVisualStyleBackColor = false;
            this.sign_up.Click += new System.EventHandler(this.sign_up_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(448, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(562, 49);
            this.label9.TabIndex = 16;
            this.label9.Text = "Registration Panel";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(474, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Password";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(655, 400);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(201, 42);
            this.pass.TabIndex = 14;
            this.pass.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Department";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Blood Group";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mail Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(655, 274);
            this.mail.Multiline = true;
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(201, 42);
            this.mail.TabIndex = 5;
            // 
            // s_age
            // 
            this.s_age.Location = new System.Drawing.Point(655, 226);
            this.s_age.Multiline = true;
            this.s_age.Name = "s_age";
            this.s_age.Size = new System.Drawing.Size(201, 42);
            this.s_age.TabIndex = 4;
            // 
            // s_id
            // 
            this.s_id.Location = new System.Drawing.Point(655, 145);
            this.s_id.Multiline = true;
            this.s_id.Name = "s_id";
            this.s_id.Size = new System.Drawing.Size(201, 42);
            this.s_id.TabIndex = 2;
            // 
            // s_name
            // 
            this.s_name.Location = new System.Drawing.Point(655, 95);
            this.s_name.Multiline = true;
            this.s_name.Name = "s_name";
            this.s_name.Size = new System.Drawing.Size(201, 44);
            this.s_name.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 670);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 678);
            this.Controls.Add(this.panel1);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox s_age;
        private System.Windows.Forms.TextBox s_id;
        private System.Windows.Forms.TextBox s_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sign_in;
        private System.Windows.Forms.Button sign_up;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pass;
        
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox p_numb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox repass;
        private System.Windows.Forms.ComboBox b_gr;
        private System.Windows.Forms.ComboBox s_dept;
    }
}