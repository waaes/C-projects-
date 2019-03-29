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
    public partial class MemberDetails : Form
    {
        public MemberDetails()
        {
            InitializeComponent();
        }

        private void member_details_Click(object sender, EventArgs e)
        {
          
                dbDataContext db = new dbDataContext();
                var data = (from x in db.registrations where x.status == "pending" select new { x.name, x.student_id, x.department, x.age, x.mail_address, x.blood_group, x.phone_number, x.status });

                pending_grid.DataSource = data;
            
        }

        private void invalid_member_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            var data = (from x in db.registrations where x.status == "invalid" select new { x.name, x.student_id, x.department, x.age, x.mail_address, x.blood_group, x.phone_number, x.status });

            invalid_grid.DataSource = data;
        }
    }
}
