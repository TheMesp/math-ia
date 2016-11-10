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
        Random random = new Random();
        float[] rands = new float[4];
        float output;
        int[] dataCollection = new int[40];
        //The index divided by ten equals the result of the function - and we increase the int stored in that index slot by one when we get one there.
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
            for (int count = 0; count < 10000000; count++)
            {
                for (int i = 0; i < rands.Length; i++)
                {
                    rands[i] = (float)random.NextDouble();
                }
                output = generate(rands);
                dataCollection[(int)Math.Floor(output * 10)]++;
            }
            lblOutput.ResetText();
            for (int i = 0; i < dataCollection.Length; i++)
            {
                lblOutput.Text += "\r\n" + i / 10f + ": " + dataCollection[i];
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblOutput.ResetText();
            for (int i = 0; i < dataCollection.Length; i++)
            {
                dataCollection[i] = 0;
                lblOutput.Text += "\r\n" + i / 10f + ": " + dataCollection[i];
            }
        }
    }
}
