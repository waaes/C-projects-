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
    public partial class Member : Form
    {
        Form1 f1;
        public Member(Form1 fr1)
        {
            InitializeComponent();
            this.f1 = fr1;
            //dbDataContext db = new dbDataContext();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void deposit_Click(object sender, EventArgs e)
        {
            int warning = 0;



            if (d_id.Text == "" || d_amount.Text == "" || re_am.Text == ""|| d_date.Text == "" || d_det.Text == "")
            {
                MessageBox.Show("One of the field is empty", "Warning Message");

            }
            else if (d_amount.Text == re_am.Text)
            {
                if (d_id.Text != "")
                {
                    string d_id_pattern = @"^[1]{1}[0-9]{1}-[1-3]{1}\d{3}[1-3]{1}-[1-3]{1}$";
                    string did_input = d_id.Text;
                    Match did_match = Regex.Match(did_input, d_id_pattern);
                    if (did_match.Success)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Enter a Correct Deposit Id!!", "Warning Message");
                        warning = 1;
                        d_id.Text = "";
                    }
                }
                if (d_amount.Text != "")
                {
                    string d_am_pattern = @"^[1-9]{1,10}\d{0,8}$";
                    string dam_input = d_amount.Text;
                    Match dam_match = Regex.Match(dam_input, d_am_pattern);
                    if (dam_match.Success)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Enter a Valid Deposit Amount!!", "Warning Message");
                        warning = 1;
                        d_amount.Text = "";
                        re_am.Text = "";
                    }
                }
                if (warning == 0)
                {
                    dbDataContext db = new dbDataContext();
                    donwithtable dw = new donwithtable();
                    
                    dw.donor_id = d_id.Text;
                    dw.donation_amount = d_amount.Text;
                    dw.donation_date = d_date.Text;
                    dw.donation_details = d_det.Text;
                    dw.status = "deposit";

                    db.donwithtables.InsertOnSubmit(dw);
                    db.SubmitChanges();
                    MessageBox.Show("Deposit Sucessfull");

                   // d_id.Text = "";
                    d_amount.Text = "";
                    re_am.Text = "";
                    d_date.Text = "";
                    d_det.Text = "";

                }
            }
            else
            {
                MessageBox.Show("Amount is not correct");

            }


            
        }

        private void update_Click(object sender, EventArgs e)
        {
            int warning_up = 0;
            if (s_name.Text == "" || sid.Text == "" || dept.Text == "" || s_age.Text == "" || mail.Text == "" || b_gr.Text == "" || p_numb.Text == "" || pass.Text == "" || repass.Text == "")
            {
                MessageBox.Show("Something is missinng");

                if (sid.Text == "")
                {
                    MessageBox.Show("Input an Id to update");
                }
                
            }
            else if (pass.Text == repass.Text)
            {
                if (sid.Text != "")
                {
                    string s_id_pattern = @"^[1]{1}[0-9]{1}-[1-3]{1}\d{3}[1-3]{1}-[1-3]{1}$";
                    string sid_input = sid.Text;
                    Match sid_match = Regex.Match(sid_input, s_id_pattern);
                    if (sid_match.Success)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Enter a Valid Student Id!!", "Warning Message");
                        warning_up = 1;
                        sid.Text = "";
                    }
                }
                if (s_age.Text != "")
                {
                    string age_pattern = @"^[1-9]{2}$";
                    string input_age = s_age.Text;
                    Match match_age = Regex.Match(input_age, age_pattern);

                    if (match_age.Success)
                    { }
                    else
                    {
                        MessageBox.Show("Enter A Valid Age!!", "Warning Message");
                        warning_up = 1;
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
                        MessageBox.Show("Enter A Valid Mail Address!!", "Warning Message");
                        warning_up = 1;
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
                        MessageBox.Show("Enter A Valid Phone Number!!", "Warning Message");
                        warning_up = 1;
                        p_numb.Text = "";
                    }

                }

                if (warning_up == 0)
                {

                    dbDataContext db = new dbDataContext();
                    registration reg = db.registrations.SingleOrDefault(x => x.student_id == sid.Text);

                    reg.name = s_name.Text;
                   // reg.student_id = sid.Text;
                    reg.department = dept.Text;
                    reg.age = int.Parse(s_age.Text);
                    reg.mail_address = mail.Text;
                    reg.blood_group = b_gr.Text;
                    reg.phone_number = p_numb.Text;
                    reg.password = pass.Text;


                    db.SubmitChanges();
                    MessageBox.Show("Profile updated Sucessfully", "Message");

                    s_name.Text = "";
                    sid.Text = "";
                    dept.Text = "";
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

                MessageBox.Show("ReEnter your password correctly", "Warning Message");

                pass.Text = "";
                repass.Text = "";

            }
        }

        private void expense_details_Click(object sender, EventArgs e)
        {
            Withdrawal wit = new Withdrawal();
            wit.ShowDialog();
        }

        private void deposit_details_Click(object sender, EventArgs e)
        {
            Deposit dep = new Deposit();
            dep.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Logo log = new Logo();
            this.Hide();
            log.Show();
        }

        private void blood_availability_Click(object sender, EventArgs e)
        {
            BloodDonorList bd = new BloodDonorList();
            bd.ShowDialog();
        }

        private void d_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void d_id_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Member_Load(object sender, EventArgs e)
        {
            d_id.Text = f1.username.Text;
            sid.Text = f1.username.Text;
        }
    }
}
