using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WeatherMapApp
{
    public partial class Form1 : Form
    {
        private string key = "e4b7070abab1899610fd58316c8d4c53";
        private string url = "https://api.openweathermap.org/data/2.5/weather?q=eskisehir&mode=xml&units=metric&lang=tr&appid=";
        private string url5dayto3hour = "http://api.openweathermap.org/data/2.5/forecast?q=eskisehir&mode=xml&units=metric&lang=tr&appid=";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            besgundoldur();
        }

        private void doldur()
        {
            XDocument dokuman = XDocument.Load(url + key);
            XElement rootelement = dokuman.Root;
            string sehir = dokuman.Descendants("city").ElementAt(0).Attribute("name").Value;
            lbl_sehir.Text = sehir;
            lbl_tarih.Text = DateTime.Now.ToLongDateString();
            string sicaklik = dokuman.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            lbl_sicaklik.Text = String.Format($"{sicaklik} °C");

            string nem = dokuman.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            lbl_nem.Text = String.Format($"%{nem}");

            string hissedilen = dokuman.Descendants("feels_like").ElementAt(0).Attribute("value").Value;
            lbl_hissedilen.Text = String.Format($"{hissedilen} °C");

            string basinc = dokuman.Descendants("pressure").ElementAt(0).Attribute("value").Value;
            string basincdeger = dokuman.Descendants("pressure").ElementAt(0).Attribute("unit").Value;
            lbl_basinc.Text = String.Format($"{basinc} {basincdeger}");

            string ruzgar = dokuman.Descendants("speed").ElementAt(0).Attribute("value").Value;
            string ruzgardeger = dokuman.Descendants("speed").ElementAt(0).Attribute("unit").Value;
            lbl_ruzgar.Text = String.Format($"{ruzgar} {ruzgardeger}");

            string icon = dokuman.Descendants("weather").ElementAt(0).Attribute("icon").Value;
            string iconlink = "http://openweathermap.org/img/wn/" + icon + "@2x.png";
            pictureBox1.Load(iconlink);

            string durum = dokuman.Descendants("weather").ElementAt(0).Attribute("value").Value;
            lbl_durum.Text = String.Format($"hava durumu = {durum}");


            string yagis = dokuman.Descendants("precipitation").ElementAt(0).Attribute("mode").Value;
            lbl_yagis.Text = yagis == "no"? "Yok":"Var";

            string songuncelleme = Convert.ToDateTime(dokuman.Descendants("lastupdate").ElementAt(0).Attribute("value").Value).ToString();
            lbl_guncelleme.Text = "Son Güncelleme = " + songuncelleme.ToString();
        }

        private void besgundoldur()
        {
            XDocument doc = XDocument.Load(url5dayto3hour + key);
            XElement rootelement = doc.Root;
           
            List<XElement> GunSaatler = doc.Descendants("forecast").Elements().ToList();
            lbl_g1.Text = XmlToStringBugun(GunSaatler[0]);
            lbl_g2.Text = XmlToStringBugun(GunSaatler[1]);
            lbl_g3.Text = XmlToStringBugun(GunSaatler[2]);
            lbl_g4.Text = XmlToStringBugun(GunSaatler[3]);
            lbl_g5.Text = XmlToStringBugun(GunSaatler[4]);


            foreach (XElement item in GunSaatler)
            {
                DateTime tarihfrom = Convert.ToDateTime(item.Attribute("from").Value);
                if (tarihfrom.Hour == 9)
                {
                    string sicaklik = item.Element("temperature").Attribute("value").Value + " °C";
                    string tarih = tarihfrom.ToLongDateString();
                    string durum = item.Element("clouds").Attribute("value").Value;
                    string icon = item.Element("symbol").Attribute("var").Value;
                    string iconlink = "http://openweathermap.org/img/wn/" + icon + "@2x.png";
                    HourlyControl hc = new HourlyControl(tarih, sicaklik, durum, iconlink);
                    flowLayoutPanel1.Controls.Add(hc);
                }

            }
           
        }
        private string XmlToStringBugun(XElement item)
        {
            double sicaklikdbl = Convert.ToDouble(item.Element("temperature").Attribute("value").Value.Replace('.',','));
            string sicaklik = Convert.ToInt32(sicaklikdbl).ToString();
            string durum = item.Element("clouds").Attribute("value").Value;
            return sicaklik + "°C      " + durum;
        }
        private string XmlToString(XElement item)
        {
            string sicaklik = item.Element("temperature").Attribute("value").Value;
            DateTime tarihfrom = Convert.ToDateTime(item.Attribute("from").Value);
            string tarihFromstr = tarihfrom.Hour.ToString();
            DateTime tarihto = Convert.ToDateTime(item.Attribute("to").Value);
            string tarihtostr = tarihto.Hour.ToString();
            string durum = item.Element("clouds").Attribute("value").Value;
            string icon = item.Element("symbol").Attribute("var").Value;
            string iconlink = "http://openweathermap.org/img/wn/" + icon + "@2x.png";
            return tarihFromstr + " - " + tarihtostr + "     " + sicaklik + " °C - " + durum;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            doldur();
        }
    }
}
