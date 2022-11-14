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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class Form1 : Form
    {
        private string URL = String.Format("https://api.openweathermap.org/data/2.5/weather?lat=50.25&lon=19.01&appid=071fe0aeaf4e3d44d3dd5ffa317db9bc");
        private string str = String.Empty;
        public Form1()
        {
            InitializeComponent();
            SetUpDefault();
        }
        Dictionary<string, string> GetDictionary(string str)
        {
            str = str.Substring(1, str.Length - 2);
            var dictionary = new Dictionary<string, string>();
            List<string> listKey = new List<string>();
            List<string> listValue = new List<string>();
            bool canAdd = false;
            bool isValue = false;
            bool wasClon = false;
            string key = "";
            string value = "";
            int counter = 0;

            foreach (char character in str)
            {
                //Check
                if (character == ':')
                {
                    wasClon = true;
                }
                if ((character == '{') & (wasClon == true))
                {
                    isValue = true;
                }
                else if ((character == '}') & (wasClon == true))
                {
                    isValue = false;
                    wasClon= false;
                }
                else if ((character == ',') & (wasClon == true))
                {
                    wasClon = false;
                }

                //Add
                if ((canAdd == true) & (isValue == false))
                {
                    key += character;
                }
                else
                {
                    value += character;
                }

                //Chceck
                if ((character == '"') & (canAdd == false) & (wasClon == false))
                {
                    canAdd = true;
                }
                else if ((character == '"') & (canAdd == true) & (wasClon == false))
                {
                    try
                    {
                        listKey.Add(key.Substring(0, key.Length - 1));
                        key = "";
                        if (value.Length > 1)
                        {
                            listValue.Add(value.Substring(1, value.Length - 3));
                        }
                        value = "";
                    }
                    catch {}
                    canAdd = false;
                }
                //Add last
                counter++;
                if(str.Length == counter)
                {
                    listValue.Add(value.Substring(1, value.Length - 1));
                }
            }
            //Create dict from lists
            for (int i = 0; i < listKey.Count; i++)
            {
                dictionary.Add(listKey[i], listValue[i]);
            }
            return dictionary;
        }
        string GetDataFromAPI()
        {

            var request = WebRequest.Create(URL);
            var response = request.GetResponse();
            var stream = response.GetResponseStream();
            var streamReader = new StreamReader(stream);
     

            string line = streamReader.ReadLine();
            streamReader.Close();
            return line;
        }

        void SetUpDefault()
        {
            string str = GetDataFromAPI();
            var dictionaryMain = GetDictionary(str);
            var weather = GetDictionary(dictionaryMain["weather"].Substring(1, dictionaryMain["weather"].Length - 2));
            var main = GetDictionary(dictionaryMain["main"]);
            var wind = GetDictionary(dictionaryMain["wind"]);

            //REMOVE APOSTROFS
            weather["main"] = weather["main"].Substring(1, weather["main"].Length - 2);
            weather["description"] = weather["description"].Substring(1, weather["description"].Length - 2);

            labelMain.Text = weather["main"];
            labelDescription.Text = weather["description"];
            labelDegree.Text = main["temp"];
            labelFeelLikeValue.Text = main["feels_like"];
            labelPressureValue.Text = main["pressure"];
            labelHumidityValue.Text = main["humidity"];
            labelVisibilityValue.Text = dictionaryMain["visibility"];
            labelWindSpeedValue.Text = wind["speed"];
            labelWindDegreeValue.Text = wind["deg"];
        }
    }
}
