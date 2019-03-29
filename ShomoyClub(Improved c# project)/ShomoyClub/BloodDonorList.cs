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
    public partial class BloodDonorList : Form
    {
        public BloodDonorList()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Blood_List_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            var data = (from x in db.registrations where x.status == "valid" select new { x.name, x.age, x.mail_address, x.blood_group, x.phone_number });

            blood_grid.DataSource = data;
        }
    }
}
