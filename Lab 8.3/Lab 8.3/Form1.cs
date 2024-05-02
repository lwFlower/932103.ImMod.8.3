using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] prob = new double[6];
        int[] stat = new int[6];
        double[] freq = new double[6];
        Random x = new Random();
        double p;
        private void StartBt_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            int count = 0;
            int k = -1;
            prob[0] = (double)prob1.Value;
            prob[1] = (double)prob2.Value;
            prob[2] = (double)prob3.Value;
            prob[3] = (double)prob4.Value;
            prob[4] = 1 - prob[3] - prob[2] - prob[1] - prob[0];
            double N = (double)countN.Value;

            for (int i = 0; i < stat.Length; i++)
            {
                stat[i] = 0;
            }

            while (count < N)
            {
                p = x.NextDouble();
                k = -1;
                while (!(p <= 0))
                {
                    k++;
                    p -= prob[k];
                }
                stat[k]++;
                count++;
            }
            
            for (int jj = 0; jj < freq.Length-1; jj++)
            {
                freq[jj] = (stat[jj] / N);
                chart1.Series[0].Points.AddXY(jj+1, freq[jj]);
            }

        }
    }
}
