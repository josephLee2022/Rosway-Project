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
    public partial class Journey_Caculator : Form
    {
        public Journey_Caculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
             {
                lblstatus.Text = "Button clicked...";


                try
                {
                    //get journey distance in miles
                    Double distance = Convert.ToDouble(txtDistance.Text);
                }
                catch
                {
                    MessageBox.Show("Incorrect data entered");
                }

                try
                {
                    Double distance = Convert.ToDouble(txtDistance.Text);
                    if (rbtnKm.Checked == true)
                    {
                        distance = distance * 0.621;
                    }

                    {
                        Double mpg = Convert.ToDouble(txtMpg.Text);

                        Double fuelRequired = distance / mpg;
                        fuelRequired = fuelRequired * 4.546;
                        string output = fuelRequired.ToString("f1");
                        txtLitres.Text = output;
                        Double fuelPrice = Convert.ToDouble(txtFuelPrice.Text);
                        Double totalCost = fuelRequired * fuelPrice;
                        output = totalCost.ToString("f2");
                        txtJourneyCost.Text = Convert.ToString(output);

                        Double motorwayPercent = Convert.ToDouble(txtMotorways.Text);
                        int townCentres = Convert.ToInt16(txtTowns.Text);

                        Double motorwayMiles = distance * motorwayPercent / 100;
                        Double otherMiles = distance - motorwayMiles;
                        Double totalMinutes = (motorwayMiles / 60 + otherMiles / 35) * 60;

                        totalMinutes = totalMinutes + (townCentres * 20);

                        int hours = Convert.ToInt16(totalMinutes) / 60;

                        int minutes = Convert.ToInt16(totalMinutes) % 60;

                        txtHours.Text = Convert.ToString(hours);

                        txtMinutes.Text = Convert.ToString(minutes);

                    }
                }
                finally { }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }

