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
using final_project.FORMS;



namespace final_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=newDB;Integrated Security=True;Pooling=False");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            llblstatus.Text = "Button Clicked.......";
            SqlDataAdapter sdf = new SqlDataAdapter("select Role from Login where Username= '" + textBox1.Text + "' and Password= '" + textBox2.Text + "' ", con);
            DataTable dt = new DataTable();
            sdf.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                main ss = new main(dt.Rows[0][0].ToString());
                ss.Show();
                MessageBox.Show("you have logged in successfully");
                //((Form)ss).Controls["label1"].Text = dt.Rows[0][0].ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }

        private void Login_SizeChanged(object sender, EventArgs e)
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

        private void Login_Load(object sender, EventArgs e)
        {
            llblstatus.Text = "Form Loaded....";
        }
    }
}
        
    







       
               
              
                       
                 
                    
     
                
        
    
    


                
            
                
        
    
        
        
    


    


         
   


        
   
    

