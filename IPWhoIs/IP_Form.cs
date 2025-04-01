using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPWhoIs
{
    public partial class WhoIS : Form
    {
        public WhoIS()
        {
            InitializeComponent();
        }

        private void get_btn_Click(object sender, EventArgs e)
        {
            string statusCheck;
            using (HttpClient httpClient = new HttpClient())
                statusCheck = httpClient.GetStringAsync($"https://ipwho.is/{ipInput_txt.Text}?output=xml&&fields=success").Result;
            Match check = Regex.Match(statusCheck, "<success>(.*?)</success>");

            if (check.Groups[1].Value == "1")
            {
                string whoIsLine;
                using (HttpClient httpClient = new HttpClient())
                    whoIsLine = httpClient.GetStringAsync($"https://ipwho.is/{ipInput_txt.Text}?output=xml").Result;

                Match matchMainInfo = Regex.Match(whoIsLine,
                "<ip>(.*?)</ip>(.*?)<continent>(.*?)</continent>(.*?)<continent_code>(.*?)</continent_code>(.*?)<country>(.*?)</country>(.*?)<country_code>(.*?)</country_code>(.*?)<region>(.*?)</region>(.*?)<city>(.*?)</city>(.*?)<calling_code>(.*?)</calling_code>(.*?)<capital>(.*?)</capital>(.*?)<utc>(.*?)</utc>");

                Match matchLatitudeLongitude = Regex.Match(whoIsLine, "<latitude>(?'latitude'.*?)</latitude>(.*?)<longitude>(?'longitude'.*?)</longitude>");

                ipResult_lbl.Text =
                    matchMainInfo.Groups[1].Value + Environment.NewLine +
                    matchMainInfo.Groups[3].Value + Environment.NewLine +
                    matchMainInfo.Groups[5].Value + Environment.NewLine +
                    matchMainInfo.Groups[7].Value + Environment.NewLine +
                    matchMainInfo.Groups[9].Value + Environment.NewLine +
                    matchMainInfo.Groups[11].Value + Environment.NewLine +
                    matchMainInfo.Groups[13].Value + Environment.NewLine +
                    matchMainInfo.Groups[15].Value + Environment.NewLine +
                    matchMainInfo.Groups[17].Value + Environment.NewLine +
                    matchMainInfo.Groups[19].Value + Environment.NewLine +
                    matchLatitudeLongitude.Groups["latitude"].Value + Environment.NewLine +
                    matchLatitudeLongitude.Groups["longitude"].Value;

                //Match matchFlag = Regex.Match(whoIsLine, "<img>(.*?)</img>");
                //label1.Text = matchFlag.Groups[1].Value;
                //flag_pb.ImageLocation = "https://cdn.ipwhois.io/flags/ua.svg";

                //GMap
                gMapControl.Zoom = 12;
                gMapControl.Position = new GMap.NET.PointLatLng
                    (Convert.ToDouble(matchLatitudeLongitude.Groups["latitude"].Value, CultureInfo.InvariantCulture),
                    Convert.ToDouble(matchLatitudeLongitude.Groups["longitude"].Value, CultureInfo.InvariantCulture));

                // маркер при открытии
                //var marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng
                //    (Convert.ToDouble(matchLatitudeLongitude.Groups["latitude"].Value, CultureInfo.InvariantCulture),
                //    Convert.ToDouble(matchLatitudeLongitude.Groups["longitude"].Value, CultureInfo.InvariantCulture)),
                //    GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_small);

                //пример под формат поля череж regex и рег. выражения
                //Regex regex = new Regex
                //    (@"(^(25[0-5]|2[0-4][0-9]|[0-1][0-9]{2}|[0-9]{2}|[0-9])((\.)(25[0-5]|2[0-4][0-9]|[0-1][0-9]{2}|[0-9]{2}|[0-9])){3}$)");

                //if (!regex.IsMatch(ipInput_txt.Text))
                //{
                //    MessageBox.Show("Введен некорректный формат IP адреса.");
                //    ipInput_txt.Focus();
                //    return;
                //}

                // old webBrowser
                //double latitude = Convert.ToDouble(matchLatitudeLongitude.Groups["latitude"].Value, CultureInfo.InvariantCulture);
                //double longitude = Convert.ToDouble(matchLatitudeLongitude.Groups["longitude"].Value, CultureInfo.InvariantCulture);
                //webBrowser1.Url = new Uri($"https://www.google.com/maps/search/?api=1&query={latitude},{longitude}");
            }
            else
            {
                MessageBox.Show("Incorrect IP");
                ipInput_txt.Focus();
            }
        }

        private void ipInput_txt_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(ipInput_txt.Text, "[^0-9,.]"))
            {
                ipInput_txt.Text = ipInput_txt.Text.Remove(ipInput_txt.Text.Length - 1);
                ipInput_txt.SelectionStart = ipInput_txt.Text.Length;
            }
        }

        private void gMapControl_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; //выбор подгрузки карты – онлайн или из ресурсов
            gMapControl.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance; //какой провайдер карт используется (в нашем случае гугл) 
            gMapControl.MinZoom = 2; //минимальный зум
            gMapControl.MaxZoom = 16; //максимальный зум
            gMapControl.Zoom = 1; // какой используется зум при открытии
            gMapControl.Position = new GMap.NET.PointLatLng(0,0); //начальные координаты для карты
            gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter; // как приближает (просто в центр карты или по положению мыши)
            gMapControl.CanDragMap = true; // перетаскивание карты мышью
            gMapControl.DragButton = MouseButtons.Left; // какой кнопкой осуществляется перетаскивание
            gMapControl.ShowCenter = false; //показывать или скрывать красный крестик в центре
            gMapControl.ShowTileGridLines = false; //показывать или скрывать тайлы
        }
    }
}
