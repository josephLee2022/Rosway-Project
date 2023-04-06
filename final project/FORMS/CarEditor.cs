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
    public partial class CarEditor : Form
    {
        public CarEditor()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                lblPictureName.Text = dlgOpen.FileName;
                pbxCar.Image = Image.FromFile(lblPictureName.Text);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtTagNumber.Text == "" || txtMake.Text == "")
             MessageBox.Show("please complete the required Fields in order to submit your information");
              if (txtYear.Text == "" || cboCategories.Text == "")
             MessageBox.Show("please complete the required Fields in order to submit your information");
                   
             else
            {
                final_project.CLASSES.Car2.TagNumber = txtTagNumber.Text;
               final_project.CLASSES .Car2.Make = txtMake.Text;
               final_project.CLASSES .Car2. Model = txtModel.Text;
               final_project.CLASSES .Car2.Year = txtYear.Text;
               final_project.CLASSES .Car2.Category = cboCategories.Text;
               final_project.CLASSES.Car2.Vehicle_Price = txtVehiclePrice.Text;
                MessageBox.Show("information submitted successfully");
                this.Hide();
               CarEditResult ob = new CarEditResult(this.pbxCar.Image);
                ob.Show();
            }
        }

        private void CarEditor_Load(object sender, EventArgs e)
        {
             label8.Text = "you are logged in as : " + ((Form)this.MdiParent).Controls["label1"].Text;
            if (((Form)this.MdiParent).Controls["label1"].Text != "Client")
            {
                btnSubmit.Enabled = false;
            }
        }
        }

        }
    

    

