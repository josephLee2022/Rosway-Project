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
    public partial class Clientsfrm : Form
    {
        public Clientsfrm()
        {
            InitializeComponent();
        }
         SqlConnection CON = new SqlConnection("Data Source=.;Initial Catalog=ClientDB;Integrated Security=True;Pooling=False");
        

        private void Clientsfrm_Load(object sender, EventArgs e)
        {
            label9.Text = "you are logged in as : " + ((Form)this.MdiParent).Controls["label1"].Text;
            if (((Form)this.MdiParent).Controls["label1"].Text != "Admin")
            {
                btndelete.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("INSERT INTO personal  (ClientID,FirstName,LastName,Address,PhoneNumber,Gender,Email) VALUES('" + textBox1.Text + "','" + txtfirstname.Text + "','" + txtlastname.Text + "','" + txtaddress.Text + "','" + txtphonenumber.Text + "','" + combogender.Text + "','" + txtemail.Text + "')", CON);
            SDA.SelectCommand.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("SAVED SUCCESSFULLY !!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM personal", CON);
           DataTable DATA = new DataTable();
           SDA.Fill(DATA);
           dataGridView1.DataSource = DATA;
           CON.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("UPDATE personal SET  FirstName = '" + txtfirstname.Text + "', LastName ='" + txtlastname.Text + "', Address = '" + txtaddress.Text + "', PhoneNumber = '" + txtphonenumber.Text + "', Gender = '" + combogender.Text + "', Email = '" + txtemail.Text + "' WHERE ClientID = '" + textBox1.Text + "'", CON);
            SDA.SelectCommand.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("UPDATED SUCCESSFULLY !!!!");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtfirstname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtlastname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtaddress.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtphonenumber.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            combogender.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtemail.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("DELETE FROM personal  WHERE ClientID = '" + textBox1.Text + "'", CON);
            SDA.SelectCommand.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("DELETED SUCCESSFULLY !!!!"); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
