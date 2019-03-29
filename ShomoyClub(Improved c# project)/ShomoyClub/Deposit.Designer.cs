namespace ShomoyClub
{
    partial class Deposit
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
            this.deposit_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.get_info = new System.Windows.Forms.Button();
            this.deposit_grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.deposit_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deposit_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // deposit_panel
            // 
            this.deposit_panel.Controls.Add(this.label4);
            this.deposit_panel.Controls.Add(this.search);
            this.deposit_panel.Controls.Add(this.search_box);
            this.deposit_panel.Controls.Add(this.label3);
            this.deposit_panel.Controls.Add(this.label2);
            this.deposit_panel.Controls.Add(this.get_info);
            this.deposit_panel.Controls.Add(this.deposit_grid);
            this.deposit_panel.Controls.Add(this.label1);
            this.deposit_panel.Location = new System.Drawing.Point(1, 1);
            this.deposit_panel.Name = "deposit_panel";
            this.deposit_panel.Size = new System.Drawing.Size(1203, 666);
            this.deposit_panel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(788, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Donation Collection";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.search.Location = new System.Drawing.Point(1008, 40);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(88, 28);
            this.search.TabIndex = 7;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(940, 12);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(229, 22);
            this.search_box.TabIndex = 6;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 43);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Donation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(586, 593);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = " ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // get_info
            // 
            this.get_info.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.get_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_info.Location = new System.Drawing.Point(3, 0);
            this.get_info.Name = "get_info";
            this.get_info.Size = new System.Drawing.Size(151, 70);
            this.get_info.TabIndex = 3;
            this.get_info.Text = "Get The Infos";
            this.get_info.UseVisualStyleBackColor = false;
            this.get_info.Click += new System.EventHandler(this.get_info_Click);
            // 
            // deposit_grid
            // 
            this.deposit_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deposit_grid.Location = new System.Drawing.Point(7, 74);
            this.deposit_grid.Name = "deposit_grid";
            this.deposit_grid.RowTemplate.Height = 24;
            this.deposit_grid.Size = new System.Drawing.Size(1193, 516);
            this.deposit_grid.TabIndex = 1;
            this.deposit_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deposit_grid_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1189, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Donation Deposit Details Table";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 669);
            this.Controls.Add(this.deposit_panel);
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.deposit_panel.ResumeLayout(false);
            this.deposit_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deposit_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel deposit_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView deposit_grid;
        private System.Windows.Forms.Button get_info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox search_box;
    }
}