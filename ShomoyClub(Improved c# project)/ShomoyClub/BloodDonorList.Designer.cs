namespace ShomoyClub
{
    partial class BloodDonorList
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
            this.Blood_List = new System.Windows.Forms.Button();
            this.blood_grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blood_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Blood_List);
            this.panel1.Controls.Add(this.blood_grid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 559);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Blood_List
            // 
            this.Blood_List.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Blood_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blood_List.Location = new System.Drawing.Point(0, 0);
            this.Blood_List.Name = "Blood_List";
            this.Blood_List.Size = new System.Drawing.Size(158, 54);
            this.Blood_List.TabIndex = 2;
            this.Blood_List.Text = "Show Blood Donor List";
            this.Blood_List.UseVisualStyleBackColor = false;
            this.Blood_List.Click += new System.EventHandler(this.Blood_List_Click);
            // 
            // blood_grid
            // 
            this.blood_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blood_grid.Location = new System.Drawing.Point(0, 58);
            this.blood_grid.Name = "blood_grid";
            this.blood_grid.RowTemplate.Height = 24;
            this.blood_grid.Size = new System.Drawing.Size(1031, 484);
            this.blood_grid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1031, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Blood Donor List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BloodDonorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 608);
            this.Controls.Add(this.panel1);
            this.Name = "BloodDonorList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloodDonorList";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.blood_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView blood_grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Blood_List;
    }
}