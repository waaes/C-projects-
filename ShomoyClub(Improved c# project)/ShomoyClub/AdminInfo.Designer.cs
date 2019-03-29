namespace ShomoyClub
{
    partial class AdminInfo
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
            this.admin_grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_info = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.admin_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_grid
            // 
            this.admin_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admin_grid.Location = new System.Drawing.Point(3, 59);
            this.admin_grid.Name = "admin_grid";
            this.admin_grid.RowTemplate.Height = 24;
            this.admin_grid.Size = new System.Drawing.Size(921, 427);
            this.admin_grid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(921, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Information Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // admin_info
            // 
            this.admin_info.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.admin_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_info.Location = new System.Drawing.Point(3, 2);
            this.admin_info.Name = "admin_info";
            this.admin_info.Size = new System.Drawing.Size(163, 54);
            this.admin_info.TabIndex = 2;
            this.admin_info.Text = "Show Admin Infos";
            this.admin_info.UseVisualStyleBackColor = false;
            this.admin_info.Click += new System.EventHandler(this.admin_info_Click);
            // 
            // AdminInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 559);
            this.Controls.Add(this.admin_info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.admin_grid);
            this.Name = "AdminInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminInfo";
            ((System.ComponentModel.ISupportInitialize)(this.admin_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView admin_grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button admin_info;
    }
}