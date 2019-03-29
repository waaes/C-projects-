using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShomoyClub
{
    public partial class Withdrawal : Form
    {
        public Withdrawal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            var data = (from x in db.donwithtables where x.status == "withdraw" select new { x.withdrawer_id, x.withdrawal_amount, x.withdrawal_date, x.withdrawal_details });

            withdraw_grid.DataSource = data;

            int sum = 0;
            for (int i = 0; i < withdraw_grid.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(withdraw_grid.Rows[i].Cells[1].Value);

            }
            label3.Text = Convert.ToString(sum) + " " + "taka";
        }

        private void sum_balance_Click(object sender, EventArgs e)
        {
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();

            string searchx = search_box.Text;

            var data = from x in db.donwithtables where x.withdrawer_id.Contains(search_box.Text) select new { x.withdrawer_id, x.withdrawal_amount, x.withdrawal_date, x.withdrawal_details };

            if (data.Any())
            {
                withdraw_grid.DataSource = data.ToList();
                withdraw_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            else
            {
                MessageBox.Show("No such result available!! :/", "Warning Message");
                search_box.Text = "";
            }


            int sum = 0;
            for (int i = 0; i < withdraw_grid.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(withdraw_grid.Rows[i].Cells[1].Value);

            }
            label3.Text = Convert.ToString(sum) + " " + "taka";
        }
    }
}
