using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazlab1_GoruntuIslemeEditoru
{
    public partial class FormHistogram : MetroFramework.Forms.MetroForm
    {
        public FormHistogram()
        {
            InitializeComponent();
        }
        public int activeHistogram;
        public int[] histogramR = new int[256];
        public int[] histogramG = new int[256];
        public int[] histogramB = new int[256];
        public int[] histogramGray = new int[256];
        private void FormHistogram_Load(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            for (int i = 0; i < 256; i++)
            {
                if(activeHistogram == 0)
                    ChartHistogram.Series["SeriesRed"].Points.AddXY(i.ToString(), histogramR[i]);
                else if (activeHistogram == 1)
                    ChartHistogram.Series["SeriesGreen"].Points.AddXY(i.ToString(), histogramG[i]);
                else if (activeHistogram == 2)
                    ChartHistogram.Series["SeriesBlue"].Points.AddXY(i.ToString(), histogramB[i]);
                else if (activeHistogram == 3)
                    ChartHistogram.Series["SeriesGray"].Points.AddXY(i.ToString(), histogramGray[i]);
            }
        }

        private void ChartHistogram_Click(object sender, EventArgs e)
        {

        }
    }
}
