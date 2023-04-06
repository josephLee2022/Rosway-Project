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
    public partial class CarEditResult : Form
    {
        public CarEditResult()
        {
            InitializeComponent();
        }
        public CarEditResult(Image img)
       {
       InitializeComponent();
       this.Picb1.Image = img;
     }


     
        private void CarEditResult_Load(object sender, EventArgs e)
        {
           
            textBox1.Text = final_project.CLASSES.Car2.TagNumber;
            textBox2.Text = final_project.CLASSES.Car2.Make;
            textBox4.Text = final_project.CLASSES.Car2.Model;
            textBox3.Text = final_project.CLASSES.Car2.Year;
            textBox5.Text = final_project.CLASSES.Car2.Category;
            textBox6.Text = final_project.CLASSES.Car2.Vehicle_Price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
        

           