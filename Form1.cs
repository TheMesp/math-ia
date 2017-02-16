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
        //Applying a transformation of 40 to the graph - this graph will seperate the distance from 0 and 1 into 40 equal parts.
        int attempts = 0;

        //The function we are analyzing. It will output a number from 0 to 4.
        float generate(float[] r)
        {
            //This isn't exactly good style, but I'll only be putting in arrays with 4 indexes (0-3) so it's fine
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
            lblOutput.ResetText();
            lblOutput.Text += "Attempts: " + attempts;
            chrData.Series[0].Points.Clear();
            chrData.Series[0].Points.AddXY(0, 0);
            chrData.Series[1].Points.Clear();
            chrData.Series[1].Points.AddXY(0, 0);
            total = 0;
            for (int i = 0; i < dataCollection.Length; i++)
            {
                total += (double)dataCollection[i] / attempts;
                if (!chkCu.Checked)
                    chrData.Series[0].Points.AddXY((i / 10f + .1f), (double)dataCollection[i] / attempts);
                else
                    chrData.Series[1].Points.AddXY((i / 10f + .1f), total);
                lblOutput.Text += "\r\n" + (i / 10f) + " - " + (i / 10f + .1f) + ": " + dataCollection[i];
            }
            lblOutput.Text += "\r\n Sum: " + total;
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
    }
}
