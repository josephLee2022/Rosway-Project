using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project.FORMS
{
    public partial class Auto_acci_claim1 : Form
    {
        public Auto_acci_claim1()
        {
            InitializeComponent();
        }

        private void Auto_acci_claim1_Load(object sender, EventArgs e)
        {
            lblstatus.Text = "Form Loaded....";
            label2.Text = "you are logged in as : " + ((Form)this.MdiParent).Controls["label1"].Text;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            lblstatus.Text = "Button Clicked.......";
            if (txtBox1.Text == "" || maskedTextBox2.Text == "")
             MessageBox.Show("please complete the form in order to submit your information");
            if (txtBox3.Text == "" || maskedTextBox1.Text == "")
             MessageBox.Show("please complete the form in order to submit your information");
            if (txtBox5.Text == "" || txtBox6.Text == "")
             MessageBox.Show("please complete the form in order to submit your information");
            if (txtBox7.Text == "" || maskedTextBox3.Text == "")
             MessageBox.Show("please complete the form in order to submit your information");
                      
             else
            {
                final_project.CLASSES.Auto_acci_form.FullName = txtBox1.Text;
               final_project.CLASSES .Auto_acci_form.policy_number = maskedTextBox2.Text;
               final_project.CLASSES .Auto_acci_form.street_Address = txtBox3.Text;
               final_project.CLASSES .Auto_acci_form.phone_number = maskedTextBox1.Text;
               final_project.CLASSES .Auto_acci_form.city = txtBox5.Text;
              final_project.CLASSES .Auto_acci_form.drivers_license = txtBox6.Text;
              final_project.CLASSES  .Auto_acci_form.email = txtBox7.Text;
              final_project.CLASSES  .Auto_acci_form.time_of_accident = maskedTextBox3.Text;
                MessageBox.Show("information submitted successfully");
                this.Hide();
                Auto_acci_claim2 ob = new Auto_acci_claim2();
                ob.Show();
            }
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }

