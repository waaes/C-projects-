namespace ShomoyClub
{
    partial class SuperAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.t_dept = new System.Windows.Forms.ComboBox();
            this.admin_info = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.repass = new System.Windows.Forms.TextBox();
            this.logout = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ad_remove = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.r_tid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ad_register = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.tid = new System.Windows.Forms.TextBox();
            this.ad_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.t_dept);
            this.panel1.Controls.Add(this.admin_info);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.repass);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.ad_remove);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.r_tid);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ad_register);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.tid);
            this.panel1.Controls.Add(this.ad_name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 653);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.linkLabel1.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(486, 494);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(420, 23);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mail To Admin : https://mail.google.com/mail/";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_dept
            // 
            this.t_dept.FormattingEnabled = true;
            this.t_dept.Items.AddRange(new object[] {
            "CSE",
            "EEE",
            "BBA",
            "Archi",
            "Social Science",
            "Law"});
            this.t_dept.Location = new System.Drawing.Point(214, 194);
            this.t_dept.Name = "t_dept";
            this.t_dept.Size = new System.Drawing.Size(201, 24);
            this.t_dept.TabIndex = 27;
            // 
            // admin_info
            // 
            this.admin_info.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.admin_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_info.Location = new System.Drawing.Point(519, 427);
            this.admin_info.Name = "admin_info";
            this.admin_info.Size = new System.Drawing.Size(292, 34);
            this.admin_info.TabIndex = 22;
            this.admin_info.Text = "Admin Details";
            this.admin_info.UseVisualStyleBackColor = false;
            this.admin_info.Click += new System.EventHandler(this.admin_info_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Retype Password";
            // 
            // repass
            // 
            this.repass.Location = new System.Drawing.Point(214, 310);
            this.repass.Multiline = true;
            this.repass.Name = "repass";
            this.repass.PasswordChar = '*';
            this.repass.Size = new System.Drawing.Size(202, 34);
            this.repass.TabIndex = 20;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(803, 16);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(106, 50);
            this.logout.TabIndex = 19;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(519, 273);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(292, 34);
            this.button6.TabIndex = 18;
            this.button6.Text = "Blood Availability List";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(519, 188);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(292, 34);
            this.button5.TabIndex = 17;
            this.button5.Text = "Expenditure Details";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(519, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(292, 34);
            this.button4.TabIndex = 16;
            this.button4.Text = "Member Details";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(519, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(292, 34);
            this.button3.TabIndex = 15;
            this.button3.Text = "Deposit Details";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ad_remove
            // 
            this.ad_remove.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ad_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad_remove.Location = new System.Drawing.Point(214, 554);
            this.ad_remove.Name = "ad_remove";
            this.ad_remove.Size = new System.Drawing.Size(106, 34);
            this.ad_remove.TabIndex = 14;
            this.ad_remove.Text = "Remove";
            this.ad_remove.UseVisualStyleBackColor = false;
            this.ad_remove.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Teacher ID";
            // 
            // r_tid
            // 
            this.r_tid.Location = new System.Drawing.Point(214, 483);
            this.r_tid.Multiline = true;
            this.r_tid.Name = "r_tid";
            this.r_tid.Size = new System.Drawing.Size(202, 34);
            this.r_tid.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(405, 34);
            this.label7.TabIndex = 11;
            this.label7.Text = "Admin Removal Panel";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ad_register
            // 
            this.ad_register.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ad_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad_register.Location = new System.Drawing.Point(214, 375);
            this.ad_register.Name = "ad_register";
            this.ad_register.Size = new System.Drawing.Size(106, 34);
            this.ad_register.TabIndex = 10;
            this.ad_register.Text = "Register";
            this.ad_register.UseVisualStyleBackColor = false;
            this.ad_register.Click += new System.EventHandler(this.ad_register_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(405, 46);
            this.label6.TabIndex = 9;
            this.label6.Text = "Admin Register Panel";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(214, 270);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(202, 34);
            this.pass.TabIndex = 7;
            // 
            // tid
            // 
            this.tid.Location = new System.Drawing.Point(214, 230);
            this.tid.Multiline = true;
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(202, 34);
            this.tid.TabIndex = 6;
            // 
            // ad_name
            // 
            this.ad_name.Location = new System.Drawing.Point(214, 148);
            this.ad_name.Multiline = true;
            this.ad_name.Name = "ad_name";
            this.ad_name.Size = new System.Drawing.Size(202, 34);
            this.ad_name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teacher ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teacher Department";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(903, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Super Admin Control panel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SuperAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 666);
            this.Controls.Add(this.panel1);
            this.Name = "SuperAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperAdmin";
            this.Load += new System.EventHandler(this.SuperAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tid;
        private System.Windows.Forms.TextBox ad_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ad_remove;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox r_tid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ad_register;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox repass;
        private System.Windows.Forms.Button admin_info;
        private System.Windows.Forms.ComboBox t_dept;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}