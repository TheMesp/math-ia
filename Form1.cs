using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
//David Loewen
//Random Graphing Application
//November 10th, 2016

namespace Math_Random_IA
{
    public partial class frmMain : Form
    {
        int newCount = 100;
        double total = 0;
        Random random = new Random();
        float[] rands = new float[4];
        float output;
        int[] dataCollection = new int[40];
        int attempts = 0;

        //The function we are analyzing. It will output a number from 0 to 4.
        float generate(float[] r)
        {
            //This isn't exactly good style, but I'll only be putting in arrays with 4 indexes (0-3) so it's fine
            //Also important to note: The array has an index of 40, but this number only generates between 0 and 4.
            //As a result, the final product will be horizontally compressed by a factor of 10
            return ((r[0] + r[1]) * (r[2] + r[3]));
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            newCount = Convert.ToInt32(txtInput.Text);
            for (int count = 0; count < newCount; count++)
            {
                for (int i = 0; i < rands.Length; i++)
                {
                    rands[i] = (float)random.NextDouble();
                }
                attempts++;
                output = generate(rands);
                dataCollection[(int)Math.Floor(output * 10)]++;
            }
            graphData();
            
        }
        public void graphData()
        {
            double xValue, yValue, mean, variance;
            mean = 0;
            variance = 0;
            lblOutput.ResetText();
            if(chkPdf.Checked)
                lblOutput.Text += "Coords";
            else
                lblOutput.Text += "Attempts: " + attempts;
            chrData.Series[0].Points.Clear();
            chrData.Series[1].Points.Clear();
            chrData.Series[0].Points.AddXY(0, 0);
            chrData.Series[1].Points.AddXY(0, 0);
            total = 0;
            for (int i = 0; i < dataCollection.Length; i++)
            {
                //The code below this point is used for the visual graph and is not related to the mean and variance calculations.
                total += (double)dataCollection[i] / attempts;
                if (!chkCu.Checked && !chkPdf.Checked)
                {
                    chrData.Series[0].Points.AddXY((i / 10f + .1f), (double)dataCollection[i] / attempts);
                    lblOutput.Text += "\r\n" + (i / 10f) + " - " + (i / 10f + .1f) + ": " + dataCollection[i];
                }
                else if (chkCu.Checked)
                {
                    chrData.Series[1].Points.AddXY((i / 10f + .1f), total);
                    lblOutput.Text += "\r\n" + (i / 10f) + " - " + (i / 10f + .1f) + ": " + dataCollection[i];
                }
                else
                {
                    chrData.Series[0].Points.AddXY((i / 10f + .1f) / 4f, (double)(dataCollection[i] * dataCollection.Length) / attempts);
                    lblOutput.Text += "\r\n(" + (i / 10f + .1f) / 4f + ", " + (double)(dataCollection[i] * dataCollection.Length) / attempts + ")";
                }
                //The code above this point is used for the visual graph and is not related to the mean and variance calculations.
                //This code is run 40 times, and the variable "i" is used to denote the current loop number (from 0 to 39 inclusive).
                xValue = (i / 10f + .1f) / 4f; //The loop number is converted to the x coordinate of the current data point being graphed.
                yValue = (double)(dataCollection[i] * dataCollection.Length) / attempts; /*dataCollection is the set which contains the raw data found in
                                                                                           figure 2a. It is multiplied by 40(the set length) and then divided
                                                                                           by the total amount of times the function ran. This returns the
                                                                                           Y value of the data point.*/
                mean += (xValue * yValue); //Each set of the product of the x and y values are added onto the mean - which starts at zero.
            }
            //This code only runs once: it does not loop 40 times. It runs AFTER all forty loops.
            mean /= dataCollection.Length; //Divides our current value for mean by 40 - the amount of x values we have.
            //"mean" now equals the mean of the Probability Density Function.

            for(int i = 0; i < dataCollection.Length; i++)
            {
                //We're in another "for" loop: this code will loop 40 times, and it doesn't start until AFTER all the code above it has ran.
                //We're redefining the xValue and yValue.
                xValue = (i / 10f + .1f) / 4f;
                yValue = (double)(dataCollection[i] * dataCollection.Length) / attempts;               
                //Adds (|mean - x|^2)y to the variance - which starts at zero.
                variance += Math.Pow(Math.Abs(mean - xValue), 2) * yValue;
            }
            //We're outside the for loop - the below code runs AFTER all the above code has finished (loops and all).
            variance /= dataCollection.Length;
            //"variance" now equals the variance of the Probability Density Function.
            lblOutput.Text += "\r\nMean: " + mean;
            lblOutput.Text += "\r\nVariance: " + variance;
            if (!chkCu.Checked && !chkPdf.Checked)
            {
                chrData.Series[0].Points.AddXY(4, 0);
                chrData.Titles["title"].Text = "Probability Distribution for f(x)";
                chrData.ChartAreas[0].AxisX.Interval = 1;
                chrData.ChartAreas[0].AxisX.Maximum = 4;
            }
            else if (chkCu.Checked)
            {
                chrData.Titles["title"].Text = "Cumulative Distribution Function for f(x)";
            }
            else
            {
                chrData.Series[0].Points.AddXY(1, 0);
                chrData.Titles["title"].Text = "Probability Density Function for f(x)";
                chrData.ChartAreas[0].AxisX.Interval = 0.25;
                chrData.ChartAreas[0].AxisX.Maximum = 1;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            total = 0;
            attempts = 0;
            lblOutput.ResetText();
            for (int i = 0; i < dataCollection.Length; i++)
            {
                dataCollection[i] = 0;
                lblOutput.Text += "\r\n" + (i / 10f + .1f) + ": " + dataCollection[i];
            }
        }

        private void chkCu_CheckedChanged(object sender, EventArgs e)
        {
            graphData();
        }

        private void chkPdf_CheckedChanged(object sender, EventArgs e)
        {
            graphData();
        }
    }
}
