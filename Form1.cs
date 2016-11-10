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
            for(int i = 0; i < rands.Length; i++)
            {
                rands[i] = (float)random.NextDouble();
            }
            lblOutput.Text =
                " r1 = " + rands[0] +
                "\r\n r2 = " + rands[1] +
                "\r\n r3 = " + rands[2] +
                "\r\n r4 = " + rands[3] +
                "\r\n rfinal = " + generate(rands);
            
        }

    }
}
