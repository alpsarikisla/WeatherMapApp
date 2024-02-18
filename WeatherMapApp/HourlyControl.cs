using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherMapApp
{
    public partial class HourlyControl : UserControl
    {
        public HourlyControl()
        {
            InitializeComponent();
        }
        public HourlyControl(string tarih, string sicaklik, string durum, string icon)
        {
            InitializeComponent();
            pictureBox1.Load(icon);
            lbl_Sicaklik.Text = sicaklik;
            lbl_Tarih.Text = tarih;
            lbl_Durum.Text = durum;
        }
    }
}
