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
    
    public partial class Deposit : Form
    {
       
        
        public Deposit()
        {
            InitializeComponent();
            dbDataContext db = new dbDataContext();
        }

        private void deposit_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            
            
        }

        private void get_info_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            var data = (from x in db.donwithtables where x.status == "deposit" select new { x.donor_id, x.donation_amount, x.donation_date, x.donation_details });

            deposit_grid.DataSource = data;

            int sum = 0;
            for (int i = 0; i < deposit_grid.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(deposit_grid.Rows[i].Cells[1].Value);

            }
            label2.Text = Convert.ToString(sum) + " " + "taka";
        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void search_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            string searchx = search_box.Text;

            var data = from x in db.donwithtables where x.donor_id.Contains(search_box.Text) select new { x.donor_id, x.donation_amount, x.donation_date, x.donation_details }; 

            if(data.Any())
            {
                deposit_grid.DataSource = data.ToList();
                deposit_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                MessageBox.Show("No such result available!! :/","Warning Message");
                search_box.Text = "";
            }
           
            int sum = 0;
            for (int i = 0; i < deposit_grid.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(deposit_grid.Rows[i].Cells[1].Value);

            }
            label2.Text = Convert.ToString(sum) + " " + "taka";
            
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
