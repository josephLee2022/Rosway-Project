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
    public partial class main : Form
    {

        public main(string Role)
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackgroundImage = this.BackgroundImage;
                    break;
                }
            }
            label1.Text = Role;
        }


        private void mainfrm_Load(object sender, EventArgs e)
        {
            lblstatus1.Text = "Form Loaded.....";
        }

        private void carStocklistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VechicleStocklist ss = new VechicleStocklist();
            ss.MdiParent = this;
            ss.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void main_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "Form has been minimized";
                notifyIcon1.ShowBalloonTip(1000);
            }

            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.BalloonTipText = "Form has come back to Normal";
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void autoAccidentClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auto_acci_claim1 ss = new Auto_acci_claim1();
            ss.MdiParent = this;
            ss.Show();
        }

        private void clientsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientsfrm ss = new Clientsfrm();
            ss.MdiParent = this;
            ss.Show();
        }

        private void journeyCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Journey_Caculator ss = new Journey_Caculator();
            ss.MdiParent = this;
            ss.Show();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contact_us ss = new contact_us();
            ss.MdiParent = this;
            ss.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Login frmReview = new Login();
            frmReview.Show();
            this.Hide();

        }

        private void takeTestDriveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void carStocklistImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarEditor ss = new CarEditor();
            ss.MdiParent = this;
            ss.Show();
        }
        }
    }

        
    



      