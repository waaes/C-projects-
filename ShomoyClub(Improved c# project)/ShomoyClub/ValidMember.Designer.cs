namespace ShomoyClub
{
    partial class ValidMember
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
            this.valid_members = new System.Windows.Forms.Button();
            this.valid_grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valid_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.valid_members);
            this.panel1.Controls.Add(this.valid_grid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 580);
            this.panel1.TabIndex = 0;
            // 
            // valid_members
            // 
            this.valid_members.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.valid_members.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valid_members.Location = new System.Drawing.Point(0, 0);
            this.valid_members.Name = "valid_members";
            this.valid_members.Size = new System.Drawing.Size(151, 56);
            this.valid_members.TabIndex = 2;
            this.valid_members.Text = "Show Valid Members";
            this.valid_members.UseVisualStyleBackColor = false;
            this.valid_members.Click += new System.EventHandler(this.valid_members_Click);
            // 
            // valid_grid
            // 
            this.valid_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.valid_grid.Location = new System.Drawing.Point(-12, 59);
            this.valid_grid.Name = "valid_grid";
            this.valid_grid.RowTemplate.Height = 24;
            this.valid_grid.Size = new System.Drawing.Size(1020, 518);
            this.valid_grid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1011, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valid Shomoy Club Member Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValidMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 633);
            this.Controls.Add(this.panel1);
            this.Name = "ValidMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ValidMember";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.valid_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView valid_grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button valid_members;
    }
}