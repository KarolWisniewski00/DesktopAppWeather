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
        public static Form1 instance;
        public string keyAPI = "&appid=071fe0aeaf4e3d44d3dd5ffa317db9bc";
        public string lat = "50.37";
        public string lon = "18.93";
        public string location = "Piekary Śląskie";
        public string language = "English";
        public string languageValue = "";
        public string Units = "Metric";
        public string UnitsValue = "&units=metric";
        public string UnitsTempValue = "°C";
        public DateTime dtDateTime;
        public Form1()
        {
            InitializeComponent();
            SetUpDefault();
            backgroundWorker1.RunWorkerAsync();
            instance = this;
        }
        public string GetDataFromAPI(string URL)
        {
            var request = WebRequest.Create(URL);
            var response = request.GetResponse();
            var stream = response.GetResponseStream();
            var streamReader = new StreamReader(stream);
     
            string line = streamReader.ReadToEnd();
            streamReader.Close();
            return line;
        }
        private void SetUpLanguage()
        {
            if (language == "English")
            {
                labelFeelLike.Text = "Feel like";
                labelPressure.Text = "Pressure";
                labelHumidity.Text = "Humidity";
                labelVisibility.Text = "Visibility";
                labelWindSpeed.Text = "Wind speed";
                labelWindDegree.Text = "Wind degree";
                labelWeek.Text = dtDateTime.DayOfWeek.ToString();
            }
            else if (language == "Polish")
            {
                labelFeelLike.Text = "Odczuwalna";
                labelPressure.Text = "Ciśnienie";
                labelHumidity.Text = "Wilgotność";
                labelVisibility.Text = "Widoczność";
                labelWindSpeed.Text = "Prędkość wiatru";
                labelWindDegree.Text = "Kierunek wiatru";
                if (dtDateTime.DayOfWeek.ToString() == "Monday")
                {
                    labelWeek.Text = "Poniedziałek";
                }
                else if (dtDateTime.DayOfWeek.ToString() == "Tuesday")
                {
                    labelWeek.Text = "Wtorek";
                }
                else if (dtDateTime.DayOfWeek.ToString() == "Wednesday")
                {
                    labelWeek.Text = "Środa";
                }
                else if (dtDateTime.DayOfWeek.ToString() == "Thursday")
                {
                    labelWeek.Text = "Czwartek";
                }
                else if (dtDateTime.DayOfWeek.ToString() == "Friday")
                {
                    labelWeek.Text = "Piątek";
                }
                else if (dtDateTime.DayOfWeek.ToString() == "Saturday")
                {
                    labelWeek.Text = "Sobota";
                }
                else if (dtDateTime.DayOfWeek.ToString() == "Sunday")
                {
                    labelWeek.Text = "Niedziela";
                }
            }
        }
        public void SetUpDefault()
        {
            //Get data
            string response = GetDataFromAPI("https://api.openweathermap.org/data/2.5/weather?lat=" + lat + "&lon=" + lon + keyAPI + "&mode=xml" + languageValue + UnitsValue);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(response);

            //Set up time
            dtDateTime = DateTime.UtcNow;
            dtDateTime = dtDateTime.AddSeconds(Int16.Parse(doc.SelectSingleNode("//timezone").InnerText));

            //Set up details
            labelMain.Text = doc.SelectSingleNode("//clouds").Attributes["name"].Value;
            labelDescription.Text = doc.SelectSingleNode("//weather").Attributes["value"].Value;
            labelDegree.Text = doc.SelectSingleNode("//temperature").Attributes["value"].Value + UnitsTempValue;
            labelFeelLikeValue.Text = doc.SelectSingleNode("//feels_like").Attributes["value"].Value + UnitsTempValue;
            labelPressureValue.Text = doc.SelectSingleNode("//pressure").Attributes["value"].Value + doc.SelectSingleNode("//pressure").Attributes["unit"].Value;
            labelHumidityValue.Text = doc.SelectSingleNode("//humidity").Attributes["value"].Value + doc.SelectSingleNode("//humidity").Attributes["unit"].Value;
            labelVisibilityValue.Text = doc.SelectSingleNode("//visibility").Attributes["value"].Value + "m";
            labelWindSpeedValue.Text = doc.SelectSingleNode("//speed").Attributes["value"].Value + doc.SelectSingleNode("//speed").Attributes["unit"].Value;
            labelWindDegreeValue.Text = doc.SelectSingleNode("//direction").Attributes["code"].Value;
            labelTime.Text = dtDateTime.ToString("HH:mm:ss");
            labelLoc.Text = doc.SelectSingleNode("//city").Attributes["name"].Value + ", " + doc.SelectSingleNode("//country").InnerText;

            SetUpLanguage();
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

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Form2 settings = new Form2();
            settings.Show();
        }
    }
}
