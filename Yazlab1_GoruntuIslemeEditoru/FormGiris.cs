using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazlab1_GoruntuIslemeEditoru
{
    public partial class FormGiris : MetroFramework.Forms.MetroForm
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        int operation = 0;
        private void FormGiris_Load(object sender, EventArgs e)
        {
            TimerDelay.Enabled = true;
            TimerDelay.Interval = 500;
        }
        private void Delay(int second)
        {
            second = (second + Convert.ToInt32(DateTime.Now.Second)) % 60;
            for( ; ; )
            {
                if (second == DateTime.Now.Second)
                    break;
            }
        }

        private void TimerDelay_Tick(object sender, EventArgs e)
        {
            if (operation == 1)
                metroLabel1.Text = "Yükleniyor.";
            if (operation == 2)
                metroLabel1.Text = "Yükleniyor..";
            if (operation == 3)
                metroLabel1.Text = "Yükleniyor...";
            if (operation == 4)
                metroLabel1.Text = "Yükleniyor....";
            if (operation == 5)
            {
                TimerDelay.Enabled = false;
                MainForm frm = new MainForm();
                frm.Show();
                this.Hide();
            }
            operation++;
        }
    }
}
