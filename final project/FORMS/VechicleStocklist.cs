using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace final_project.FORMS
{
    public partial class VechicleStocklist : Form
    {
        public VechicleStocklist()
        {
            InitializeComponent();

        }
        SqlConnection CON = new SqlConnection("Data Source=.;Initial Catalog=carDB;Integrated Security=True;Pooling=False");

        private void btnsave_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("INSERT INTO vechicle (YEAR,MODEL,BODY,FUEL,COLOUR,ENGINE) VALUES('" + txtyear.Text + "','" + txtmodel.Text + "','" + txttype.Text + "','" + txtfuel.Text + "','" + txtcolour.Text + "','" + txtsize.Text + "')", CON);
            SDA.SelectCommand.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("SAVED SUCCESSFULLY !!!!");
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            lblstatus.Text = "Button Clicked.....";
            CON.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM vechicle", CON);
            DataTable DATA = new DataTable();
            SDA.Fill(DATA);
            dataGridView1.DataSource = DATA;
            CON.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("UPDATE vechicle SET  MODEL = '" + txtmodel.Text + "', BODY ='" + txttype.Text + "', FUEL = '" + txtfuel.Text + "', COLOUR = '" + txtcolour.Text + "', ENGINE = '" + txtsize.Text + "' WHERE YEAR = '" + txtyear.Text + "'", CON);
            SDA.SelectCommand.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("UPDATED SUCCESSFULLY !!!!");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtyear.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtmodel.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txttype.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtfuel.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtcolour.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtsize.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("DELETE FROM vechicle  WHERE YEAR = '" + txtyear.Text + "'", CON);
            SDA.SelectCommand.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("DELETED SUCCESSFULLY !!!!");
        }

        private void car_stocklist_Load(object sender, EventArgs e)
        {
            lblstatus.Text = "Form Loaded....";
            label3.Text = "you are logged in as : " + ((Form)this.MdiParent).Controls["label1"].Text;

            if (((Form)this.MdiParent).Controls["label1"].Text != "Admin")
            {
                btndelete.Enabled = false;
            }
        }

        private void VechicleStocklist_SizeChanged(object sender, EventArgs e)
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

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
        }
    }

    

    


       