using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Weather
{
    public partial class Form1 : Form
    {

        private string URL = String.Format("https://api.openweathermap.org/data/2.5/weather?lat=50.37&lon=18.93&appid=071fe0aeaf4e3d44d3dd5ffa317db9bc&units=metric&mode=xml");
        public DateTime dtDateTime;
        public Form1()
        {
            InitializeComponent();
            SetUpDefault();
            backgroundWorker1.RunWorkerAsync();
        }
        string GetDataFromAPI()
        {
            var request = WebRequest.Create(URL);
            var response = request.GetResponse();
            var stream = response.GetResponseStream();
            var streamReader = new StreamReader(stream);
     
            string line = streamReader.ReadToEnd();
            streamReader.Close();
            return line;
        }

        void SetUpDefault()
        {
            string response = GetDataFromAPI();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(response);

            dtDateTime = DateTime.UtcNow;
            dtDateTime = dtDateTime.AddSeconds(Int16.Parse(doc.SelectSingleNode("//timezone").InnerText));

            labelMain.Text = doc.SelectSingleNode("//clouds").Attributes["name"].Value;
            labelDescription.Text = doc.SelectSingleNode("//weather").Attributes["value"].Value;
            labelDegree.Text = doc.SelectSingleNode("//temperature").Attributes["value"].Value + "°C";
            labelFeelLikeValue.Text = doc.SelectSingleNode("//feels_like").Attributes["value"].Value + "°C";
            labelPressureValue.Text = doc.SelectSingleNode("//pressure").Attributes["value"].Value + doc.SelectSingleNode("//pressure").Attributes["unit"].Value;
            labelHumidityValue.Text = doc.SelectSingleNode("//humidity").Attributes["value"].Value + doc.SelectSingleNode("//humidity").Attributes["unit"].Value;
            labelVisibilityValue.Text = doc.SelectSingleNode("//visibility").Attributes["value"].Value + "m";
            labelWindSpeedValue.Text = doc.SelectSingleNode("//speed").Attributes["value"].Value + doc.SelectSingleNode("//speed").Attributes["unit"].Value;
            labelWindDegreeValue.Text = doc.SelectSingleNode("//direction").Attributes["code"].Value;
            labelWeek.Text = dtDateTime.DayOfWeek.ToString();
            labelTime.Text = dtDateTime.ToString("HH:mm:ss");
            labelLoc.Text = doc.SelectSingleNode("//city").Attributes["name"].Value + ", " + doc.SelectSingleNode("//country").InnerText;
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(true)
            {
                Thread.Sleep(1000);
                backgroundWorker1.ReportProgress(0);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            dtDateTime = dtDateTime.AddSeconds(1);
            labelTime.Text = dtDateTime.ToString("HH:mm:ss");
        }
    }
}
