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
    public partial class Logo : Form
    {
        public Logo()
        {
            InitializeComponent();
        }

        private void Blood_List_Click(object sender, EventArgs e)
        {
            BloodDonorList bd = new BloodDonorList();
            bd.ShowDialog();
            
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            this.Hide();
            log.Show();
        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            this.Hide();
            reg.Show();
        }
    }
}
