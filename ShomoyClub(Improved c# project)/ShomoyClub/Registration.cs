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
    public partial class Registration : Form
    {
  


        public Registration()
        {
            InitializeComponent();
            dbDataContext db = new dbDataContext();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            int warning = 0;
            
            
            if (s_name.Text == "" || s_id.Text == "" || s_dept.Text == "" || s_age.Text == "" || mail.Text == ""|| b_gr.Text == ""|| p_numb.Text == "" || pass.Text == "" || repass.Text == "")
            {
                MessageBox.Show("Fill UP all The Fields!!", "Warning Message");
                

            }
            
            else if(pass.Text == repass.Text)
                {

                    if (s_id.Text != "")
                    {
                        string id_pattern = @"^[1]{1}[0-9]{1}-[1-3]{1}\d{3}[1-3]{1}-[1-3]{1}$";
                        string input = s_id.Text;
                        Match match = Regex.Match(input, id_pattern);
                        if (match.Success)
                        {

                        }
                        else
                        {
                            MessageBox.Show("Enter Correct Id!!", "Warning Message");
                            warning = 2;
                            s_id.Text = "";
                        }
                    }

                    if (s_age.Text != "")
                    {
                        string age_pattern = @"^[1-9]{2}$";
                        string input_age = s_age.Text;
                        Match match_age = Regex.Match(input_age, age_pattern);

                        if(match_age.Success)
                        { }
                        else
                        {
                            MessageBox.Show("Enter Your Original Age!!", "Warning Message");
                            warning = 1;
                            s_age.Text = "";
                        }

                    }
                    if (mail.Text != "")
                    {
                        string mail_pattern = @"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$";
                        string input_mail = mail.Text;
                        Match match_mail = Regex.Match(input_mail, mail_pattern);

                        if (match_mail.Success)
                        { }
                        else
                        {
                            MessageBox.Show("Enter Your Valid Mail Address!!", "Warning Message");
                            warning = 1;
                            mail.Text = "";
                        }

                    }
                    if (p_numb.Text != "")
                    {
                        string numb_pattern = @"^[0]{1}[1]{1}[5-9]{1}\d{8}$";
                        string input_numb = p_numb.Text;
                        Match match_numb = Regex.Match(input_numb, numb_pattern);

                        if (match_numb.Success)
                        { }
                        else
                        {
                            MessageBox.Show("Enter Your Valid Phone Number!!", "Warning Message");
                            warning = 1;
                            p_numb.Text = "";
                        }

                    }
                
                    

                    if (warning == 0)
                    {
                        dbDataContext db = new dbDataContext();
                        registration reg = new registration();

                        reg.name = s_name.Text;
                        reg.student_id = s_id.Text;
                        reg.department = s_dept.Text;
                        reg.age = int.Parse(s_age.Text);
                        reg.mail_address = mail.Text;
                        reg.blood_group = b_gr.Text;
                        reg.phone_number = p_numb.Text;
                        reg.password = pass.Text;
                        reg.status = "pending";

                        db.registrations.InsertOnSubmit(reg);
                        db.SubmitChanges();
                        MessageBox.Show("Registration Request has been sent successfully");

                        s_name.Text = "";
                        s_id.Text = "";
                        s_dept.Text = "";
                        s_age.Text = "";
                        mail.Text = "";
                        b_gr.Text = "";
                        p_numb.Text = "";
                        pass.Text = "";
                        repass.Text = "";
                    }                
                }
                else
                {
                    MessageBox.Show("Password and Re-Type Password Didn't match");
                    pass.Text = "";
                    repass.Text = "";

                }
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        }
    }

