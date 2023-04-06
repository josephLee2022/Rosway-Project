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
    public partial class Auto_acci_claim2 : Form
    {
        public Auto_acci_claim2()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            lblstatus.Text = "Button Clicked....";
            this.Close();
        }

        private void Auto_acci_claim2_Load(object sender, EventArgs e)
        {
            lblstatus.Text = "Form Loaded.....";
            txtBox1.Text = final_project.CLASSES.Auto_acci_form.FullName;
            txtBox2.Text = final_project.CLASSES.Auto_acci_form.policy_number;
            txtBox4.Text = final_project.CLASSES.Auto_acci_form.street_Address;
            txtBox3.Text = final_project.CLASSES.Auto_acci_form.phone_number;
            txtBox5.Text = final_project.CLASSES.Auto_acci_form.city;
            txtBox6.Text = final_project.CLASSES.Auto_acci_form.time_of_accident;
        }
    }
}
