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
    public partial class ValidMember : Form
    {
        public ValidMember()
        {
            InitializeComponent();
        }

        private void valid_members_Click(object sender, EventArgs e)
        {

            dbDataContext db = new dbDataContext();
            var data = (from x in db.registrations where x.status == "valid" select new { x.name, x.student_id, x.department, x.age, x.mail_address, x.blood_group,x.phone_number, x.status });

            valid_grid.DataSource = data;
        }
    }
}
