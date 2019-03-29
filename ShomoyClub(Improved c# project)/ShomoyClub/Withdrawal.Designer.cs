namespace ShomoyClub
{
    partial class Withdrawal
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.withdraw_details = new System.Windows.Forms.Button();
            this.withdraw_grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.search_box = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.withdraw_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.search_box);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.withdraw_details);
            this.panel1.Controls.Add(this.withdraw_grid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 698);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 631);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 50);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Withdrawal";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(634, 649);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(714, 649);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 5;
            // 
            // withdraw_details
            // 
            this.withdraw_details.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.withdraw_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw_details.Location = new System.Drawing.Point(0, 0);
            this.withdraw_details.Name = "withdraw_details";
            this.withdraw_details.Size = new System.Drawing.Size(159, 66);
            this.withdraw_details.TabIndex = 4;
            this.withdraw_details.Text = "Get Withdrawal Details";
            this.withdraw_details.UseVisualStyleBackColor = false;
            this.withdraw_details.Click += new System.EventHandler(this.button2_Click);
            // 
            // withdraw_grid
            // 
            this.withdraw_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.withdraw_grid.Location = new System.Drawing.Point(3, 72);
            this.withdraw_grid.Name = "withdraw_grid";
            this.withdraw_grid.RowTemplate.Height = 24;
            this.withdraw_grid.Size = new System.Drawing.Size(1183, 555);
            this.withdraw_grid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1189, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Donation Withdrawal Details Table";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(939, 12);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(229, 22);
            this.search_box.TabIndex = 8;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.search.Location = new System.Drawing.Point(999, 38);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(88, 28);
            this.search.TabIndex = 9;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(786, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Personal Withdrawal";
            // 
            // Withdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 710);
            this.Controls.Add(this.panel1);
            this.Name = "Withdrawal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdrawal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.withdraw_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView withdraw_grid;
        private System.Windows.Forms.Button withdraw_details;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label5;
    }
}