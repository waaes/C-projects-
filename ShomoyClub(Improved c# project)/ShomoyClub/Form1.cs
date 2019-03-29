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
    public partial class Form1 : Form
    {
        private string masterUser = "Admin";
        private string masterPassword = "Admin";

        public Form1()
        {
            InitializeComponent();
            dbDataContext db = new dbDataContext();
            
        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            var admin = db.admins.SingleOrDefault(x => x.t_id == username.Text && x.password == pass.Text);
            var member = db.registrations.SingleOrDefault(x => x.student_id == username.Text && x.password == pass.Text && x.status == "valid");
            if (username.Text == "")
            {
                MessageBox.Show("User Id is Empty","Warning message");
            }
            else if (pass.Text == "")
            {
                MessageBox.Show("Password is Empty", "Warning message");
            }
            else if (username.Text == masterUser && pass.Text == masterPassword)
            {
                SuperAdmin sup = new SuperAdmin();
                this.Hide();
                sup.Show();

                username.Text = "";
                pass.Text = "";
            }
            else if(admin != null)
            {
                Admin ad = new Admin(this);
                this.Hide();
                ad.Show();

                //username.Text = "";
                pass.Text = "";
            }
            else if (member != null)
            {
                Member mem = new Member(this);
                this.Hide();
                mem.ShowDialog();

                //username.Text = "";
                pass.Text = "";
            }
           
            else
            {
                MessageBox.Show("User Id or Password is Wrong or your credential is not valid", "Warning Message");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            this.Hide();
            reg.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Logo log = new Logo();
            this.Close();
            log.Show();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
