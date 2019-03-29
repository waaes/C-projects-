using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ShomoyClub
{
    public partial class SuperAdmin : Form
    {
        public SuperAdmin()
        {
            InitializeComponent();
            dbDataContext db = new dbDataContext();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ad_register_Click(object sender, EventArgs e)
        {
            int warning = 0;

            if (ad_name.Text == "" || t_dept.Text == "" || tid.Text == "" || pass.Text == "" || repass.Text == "")
            {
                MessageBox.Show("May be something is missing!!", "Warning Message");
            }
            else if(pass.Text == repass.Text)
                {
                    if (ad_name.Text != "")
                    {
                        string name_pattern = @"^[\p{L}'][ \p{L}'-]*[\p{L}]$";
                        string input_name = ad_name.Text;
                        Match match_name = Regex.Match(input_name, name_pattern);

                        if (match_name.Success)
                        { }
                        else
                        {
                            MessageBox.Show("Enter A Valid Name!!", "Warning Message");
                            warning = 1;
                            ad_name.Text = "";
                        }

                    }
                    if (tid.Text != "")
                    {
                        string id_pattern = @"^[1]{1}[0-9]{3}-[1-9]{3}-[1-9]{4}$";
                        string tid_input = tid.Text;
                        Match tid_match = Regex.Match(tid_input, id_pattern);
                        if (tid_match.Success)
                        {

                        }
                        else
                        {
                            MessageBox.Show("Enter a Valid Id!!", "Warning Message");
                            warning = 1;
                            tid.Text = "";
                        }
                    }

                    if (warning == 0)
                    {
                        dbDataContext db = new dbDataContext();
                        admin ad = new admin();
                        ad.admin_name = ad_name.Text;
                        ad.t_department = t_dept.Text;
                        ad.t_id = tid.Text;
                        ad.password = pass.Text;


                        db.admins.InsertOnSubmit(ad);
                        db.SubmitChanges();
                        MessageBox.Show("Sucessfully Registered");

                        ad_name.Text = "";
                        t_dept.Text = "";
                        tid.Text = "";
                        pass.Text = "";
                        repass.Text = "";
                    }


                }
                else
                {
                    MessageBox.Show("Password and Re-Type Password Didn't match");
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int warning_rem = 0;

            
            if (r_tid.Text == "")
            {
                MessageBox.Show("Enter a valid teacher Id", "Warning Message");
            }
            else if (r_tid.Text != null)
            {
                if (r_tid.Text != "")
                {
                    string id_pattern = @"^[1]{1}[0-9]{3}-[1-9]{3}-[1-9]{4}$";
                    string tid_input = r_tid.Text;
                    Match tid_match = Regex.Match(tid_input, id_pattern);
                    if (tid_match.Success)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Enter a Valid Id!!", "Warning Message");
                        warning_rem = 1;
                        r_tid.Text = "";
                    }
                }

                if (warning_rem == 0)
                {
                    dbDataContext db = new dbDataContext();
                    var adm = db.admins.SingleOrDefault(x => x.t_id == r_tid.Text);

                    db.admins.DeleteOnSubmit(adm);
                    db.SubmitChanges();
                    MessageBox.Show("Admin removed successfully!!");

                    r_tid.Text = "";
                }
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Logo log = new Logo();
            this.Hide();
            log.Show();       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Deposit dep = new Deposit();
            dep.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Withdrawal with = new Withdrawal();
            with.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ValidMember vm = new ValidMember();
            vm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BloodDonorList bd = new BloodDonorList();
            bd.ShowDialog();
        }

        private void SuperAdmin_Load(object sender, EventArgs e)
        {

        }

        private void admin_info_Click(object sender, EventArgs e)
        {
            AdminInfo ai = new AdminInfo();
            ai.ShowDialog();
        }
    }
}
