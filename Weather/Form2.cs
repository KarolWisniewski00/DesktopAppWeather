using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            comboBoxLanguage.Text = Form1.instance.language;
            comboBoxUnits.Text = Form1.instance.Units;
            textBoxLocation.Text = Form1.instance.location;

            if (Form1.instance.language == "Polish")
            {
                labelSettings.Text = "Ustawienia";
                labelLocation.Text = "Lokalizacja";
                labelUnits.Text = "Jednostki";
                labelLanguage.Text = "Język";
                button1.Text = "Zapisz";
            }
        }
        public class jsonData
        {
            public string name;
            public string lat;
            public string lon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Location
            string response = Form1.instance.GetDataFromAPI("http://api.openweathermap.org/geo/1.0/direct?q=" + textBoxLocation.Text + "&limit=1"+ Form1.instance.keyAPI);
            response = response.Substring(1, response.Length - 2);
            jsonData json = JsonConvert.DeserializeObject<jsonData>(response);
            Form1.instance.location = json.name;
            Form1.instance.lat = json.lat;
            Form1.instance.lon = json.lon;

            //Language
            Form1.instance.language = comboBoxLanguage.Text;
            if (comboBoxLanguage.Text == "English")
            {
                Form1.instance.languageValue = "";
            }
            else if (comboBoxLanguage.Text == "Polish")
            {
                Form1.instance.languageValue = "&lang=pl";
            }

            //Units
            Form1.instance.Units = comboBoxUnits.Text;
            if (comboBoxUnits.Text == "Standard")
            {
                Form1.instance.UnitsValue = "";
                Form1.instance.UnitsTempValue = "K";
            }
            else if (comboBoxUnits.Text == "Metric")
            {
                Form1.instance.UnitsValue = "&units=metric";
                Form1.instance.UnitsTempValue = "°C";
            }
            else if (comboBoxUnits.Text == "Imperial")
            {
                Form1.instance.UnitsValue = "&units=imperial";
                Form1.instance.UnitsTempValue = "°F";
            }

            Form1.instance.SetUpDefault();
            this.Close();
        }
    }
}
