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
    public partial class AdminInfo : Form
    {
        public AdminInfo()
        {
            InitializeComponent();
        }

        private void admin_info_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            var data = (from x in db.admins select new { x.admin_name, x.t_department, x.t_id, x.password });

            admin_grid.DataSource = data;
        }
    }
}
