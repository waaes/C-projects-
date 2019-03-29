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
    public partial class Admin : Form
    {
        Form1 f2;
        public Admin(Form1 fr2)
        {
            InitializeComponent();
            this.f2 = fr2;
            dbDataContext db = new dbDataContext();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int warning = 0;

            if (d_id.Text == "" || d_am.Text == "" ||re_am.Text == ""|| d_date.Text == "" || d_det.Text == "")
            {
                MessageBox.Show("One of the field is empty", "Warning Message");

            }
            else if (d_am.Text == re_am.Text)
            {
                if (d_id.Text != "")
                {
                    string d_id_pattern = @"^[1]{1}[0-9]{3}-[1-9]{3}-[1-9]{4}$";
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
                if (d_am.Text != "")
                {
                    string d_am_pattern = @"^[1-9]{1,10}\d{0,8}$";
                    string dam_input = d_am.Text;
                    Match dam_match = Regex.Match(dam_input, d_am_pattern);
                    if (dam_match.Success)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Enter a Valid Deposit Amount!!", "Warning Message");
                        warning = 1;
                        d_am.Text = "";
                        re_am.Text = "";
                    }
                }



                if (warning == 0)
                {

                    dbDataContext db = new dbDataContext();
                    donwithtable dw = new donwithtable();
                    dw.donor_id = d_id.Text;
                    dw.donation_amount = d_am.Text;
                    dw.donation_date = d_date.Text;
                    dw.donation_details = d_det.Text;
                    dw.status = "deposit";

                    db.donwithtables.InsertOnSubmit(dw);
                    db.SubmitChanges();
                    MessageBox.Show("Deposit Sucessfull");

                    //d_id.Text = "";
                    d_am.Text = "";
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

        private void withdraw_Click(object sender, EventArgs e)
        {
            int warning_wd = 0;

            if (w_id.Text == "" || w_am.Text == "" ||re_wam.Text ==""|| w_date.Text == "" || w_det.Text == "")
            {
                MessageBox.Show("One of the field is empty", "Warning Message");

            }
            else if (w_am.Text == re_wam.Text)
                {
                    if (w_id.Text != "")
                    {
                        string w_id_pattern = @"^[1]{1}[0-9]{3}-[1-9]{3}-[1-9]{4}$";
                        string w_input = w_id.Text;
                        Match w_match = Regex.Match(w_input, w_id_pattern);
                        if (w_match.Success)
                        {

                        }
                        else
                        {
                            MessageBox.Show("Enter a Correct Withdrawal Id!!", "Warning Message");
                            warning_wd = 1;
                            w_id.Text = "";
                            
                        }
                    }
                    if (w_am.Text != "")
                    {
                        string w_am_pattern = @"^[1-9]{1,10}\d{0,8}$";
                        string w_am_input = w_am.Text;
                        Match wam_match = Regex.Match(w_am_input, w_am_pattern);
                        if (wam_match.Success)
                        {

                        }
                        else
                        {
                            MessageBox.Show("Enter a Valid Withdrawal Amount!!", "Warning Message");
                            warning_wd = 1;
                            w_am.Text = "";
                            re_wam.Text = "";
                        }
                    }
                    

                    if (warning_wd == 0)
                    {
                        dbDataContext db = new dbDataContext();
                        donwithtable dw1 = new donwithtable();
                        dw1.withdrawer_id = w_id.Text;
                        dw1.withdrawal_amount = w_am.Text;
                        dw1.withdrawal_date = w_date.Text;
                        dw1.withdrawal_details = w_det.Text;
                        dw1.status = "withdraw";

                        db.donwithtables.InsertOnSubmit(dw1);
                        db.SubmitChanges();
                        MessageBox.Show("Withdraw Sucessfull");

                        //w_id.Text = "";
                        w_am.Text = "";
                        re_wam.Text = "";
                        w_date.Text = "";
                        w_det.Text = "";
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

            if (sid.Text == "")
            {
                MessageBox.Show("Input an Id to update");
                sid.Text = "";
            }
            else
            {
                if (sid.Text != "")
                {
                    string id_pattern = @"^[1]{1}[0-9]{1}-[1-3]{1}\d{3}[1-3]{1}-[1-3]{1}$";
                    string sid_input = sid.Text;
                    Match sid_match = Regex.Match(sid_input, id_pattern);
                    if (sid_match.Success)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Enter a Valid Id!!", "Warning Message");
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
                    registration reg = db.registrations.SingleOrDefault(x => x.student_id == sid.Text && x.status == "valid");

                    reg.name = s_name.Text;
                    reg.student_id = sid.Text;
                    reg.department = dept.Text;
                    reg.age = int.Parse(s_age.Text);
                    reg.mail_address = mail.Text;
                    reg.blood_group = b_gr.Text;
                    reg.phone_number = p_numb.Text;


                    db.SubmitChanges();
                    MessageBox.Show("Member Profile updated Sucessfully", "Message");

                    s_name.Text = "";
                    sid.Text = "";
                    dept.Text = "";
                    s_age.Text = "";
                    mail.Text = "";
                    b_gr.Text = "";
                    p_numb.Text = "";
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MemberDetails mem = new MemberDetails();
            mem.ShowDialog();
        }

        private void deposit_details_Click(object sender, EventArgs e)
        {

            Deposit dep = new Deposit();
            dep.ShowDialog();
            
            
        }

        private void Add_member_Click(object sender, EventArgs e)
        {
            int warning_add = 0;

            if (member_add.Text == "")
            {
                MessageBox.Show("Input a Student Id to Add!!");
                member_add.Text = "";
            }
            else
            {
                if (member_add.Text != "")
                {
                    string id_pattern = @"^[1]{1}[0-9]{1}-[1-3]{1}\d{3}[1-3]{1}-[1-3]{1}$";
                    string mem_input = member_add.Text;
                    Match mem_match = Regex.Match(mem_input, id_pattern);
                    if (mem_match.Success)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Enter A Valid Id!!", "Warning Message");
                        warning_add = 1;
                        member_add.Text = "";
                    }
                }


                if (warning_add == 0)
                {

                    dbDataContext db = new dbDataContext();
                    registration reg = db.registrations.SingleOrDefault(x => x.student_id == member_add.Text);

                    reg.status = "valid";
                    db.SubmitChanges();
                    MessageBox.Show("Member Added Sucessfully", "Message");
                    member_add.Text = "";
                }
            
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            int warning_rem = 0;

            if (rmember_id.Text == "")
            {
                MessageBox.Show("Input a Member Id to Remove!!");
                rmember_id.Text = "";
            }
            else
            {
                if (rmember_id.Text != "")
                {
                    string rid_pattern = @"^[1]{1}[0-9]{1}-[1-3]{1}\d{3}[1-3]{1}-[1-3]{1}$";
                    string rmem_input = rmember_id.Text;
                    Match rmem_match = Regex.Match(rmem_input, rid_pattern);
                    if (rmem_match.Success)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Enter Correct Id!!", "Warning Message");
                        warning_rem = 1;
                        rmember_id.Text = "";
                    }
                }

                if (warning_rem == 0)
                {
                    dbDataContext db = new dbDataContext();
                    registration reg = db.registrations.SingleOrDefault(x => x.student_id == rmember_id.Text);

                    reg.status = "invalid";
                    db.SubmitChanges();
                    MessageBox.Show("Member Has Been Removed Sucessfully", "Message");
                    rmember_id.Text = "";
                }
            }
        }

        private void expense_details_Click(object sender, EventArgs e)
        {
            Withdrawal wit = new Withdrawal();
            wit.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Logo log = new Logo();
            this.Hide();
            log.Show();
        }

        private void member_details_Click(object sender, EventArgs e)
        {
            ValidMember memb = new ValidMember();
            memb.ShowDialog();
        }

        private void blood_donor_Click(object sender, EventArgs e)
        {
            BloodDonorList bd = new BloodDonorList();
            bd.ShowDialog();
        }

        private void invalid_members_Click(object sender, EventArgs e)
        {
            MemberDetails inv = new MemberDetails();
            inv.ShowDialog();
        }

        private void s_dept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            d_id.Text = f2.username.Text;
            w_id.Text = f2.username.Text;
        }

        private void d_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
