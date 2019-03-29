namespace ShomoyClub
{
    partial class MemberDetails
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
            this.pen_inv = new System.Windows.Forms.ComboBox();
            this.invalid_member = new System.Windows.Forms.Button();
            this.invalid_grid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.member_details = new System.Windows.Forms.Button();
            this.pending_grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invalid_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pending_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pen_inv);
            this.panel1.Controls.Add(this.invalid_member);
            this.panel1.Controls.Add(this.invalid_grid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.member_details);
            this.panel1.Controls.Add(this.pending_grid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 775);
            this.panel1.TabIndex = 1;
            // 
            // pen_inv
            // 
            this.pen_inv.FormattingEnabled = true;
            this.pen_inv.Items.AddRange(new object[] {
            "Pending",
            "Invalid"});
            this.pen_inv.Location = new System.Drawing.Point(1090, 11);
            this.pen_inv.Name = "pen_inv";
            this.pen_inv.Size = new System.Drawing.Size(164, 24);
            this.pen_inv.TabIndex = 8;
            // 
            // invalid_member
            // 
            this.invalid_member.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.invalid_member.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalid_member.Location = new System.Drawing.Point(4, 381);
            this.invalid_member.Name = "invalid_member";
            this.invalid_member.Size = new System.Drawing.Size(228, 58);
            this.invalid_member.TabIndex = 7;
            this.invalid_member.Text = "Show Invalid Members";
            this.invalid_member.UseVisualStyleBackColor = false;
            this.invalid_member.Click += new System.EventHandler(this.invalid_member_Click);
            // 
            // invalid_grid
            // 
            this.invalid_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invalid_grid.Location = new System.Drawing.Point(4, 445);
            this.invalid_grid.Name = "invalid_grid";
            this.invalid_grid.RowTemplate.Height = 24;
            this.invalid_grid.Size = new System.Drawing.Size(1321, 309);
            this.invalid_grid.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1325, 60);
            this.label2.TabIndex = 5;
            this.label2.Text = "Invalid Member Information Details Table";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // member_details
            // 
            this.member_details.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.member_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_details.Location = new System.Drawing.Point(4, 4);
            this.member_details.Name = "member_details";
            this.member_details.Size = new System.Drawing.Size(228, 62);
            this.member_details.TabIndex = 4;
            this.member_details.Text = "Show Pending Member Requests";
            this.member_details.UseVisualStyleBackColor = false;
            this.member_details.Click += new System.EventHandler(this.member_details_Click);
            // 
            // pending_grid
            // 
            this.pending_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pending_grid.Location = new System.Drawing.Point(4, 70);
            this.pending_grid.Name = "pending_grid";
            this.pending_grid.RowTemplate.Height = 24;
            this.pending_grid.Size = new System.Drawing.Size(1327, 300);
            this.pending_grid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1325, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pending Member Information Details Table";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemberDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 806);
            this.Controls.Add(this.panel1);
            this.Name = "MemberDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberDetails";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invalid_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pending_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView pending_grid;
        private System.Windows.Forms.Button member_details;
        private System.Windows.Forms.DataGridView invalid_grid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button invalid_member;
        private System.Windows.Forms.ComboBox pen_inv;
    }
}