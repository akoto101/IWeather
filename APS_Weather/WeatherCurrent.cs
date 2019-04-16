using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Drawing;
using System.Net;
using System.Globalization;

   public class WeatherCurrent
    {
        private  String city;
        private  String country;
        
        private  int temperature_Min;
        private int temperature_Max;
        private int temperature_Value;
        private  double wind_Value;
        private  String wind_Name;
        private  String wind_Direction_Code;
        private  String wind_Direction_Name;
        private  int wind_Direction_Value;
        private  int humidity;
        private  String weather;
        private  String weather_Icon;
        private  int visibility;
        private  int cloud_Value;
        private  String cloud_Name;
        private  int pressure_Value;
        private  String pressure_Unit;
        private  String last_Update;


        private String current_Country;
        private String current_City;
        private String current_CountryCode;
        private float current_CountryLat;
        private float current_CountryLong;
        private String current_Region;
        private String current_TimeZone;



        public WeatherCurrent()
        {

        }

        public WeatherCurrent(String API_KEY, String City_Name)
        {
            Min("http://api.openweathermap.org/data/2.5/weather?q=" + City_Name + "&mode=xml&units=metric&APPID=" + API_KEY + "");
        }
        public WeatherCurrent(String API_KEY, int City_Zip)
        {
            Min("http://api.openweathermap.org/data/2.5/weather?zip=" + City_Zip + "&mode=xml&units=metric&APPID=" + API_KEY + "");
        }
        public WeatherCurrent(String API_KEY, double Latitude, double Longhitude)
        {
            Min("http://api.openweathermap.org/data/2.5/find?lat=" + Latitude + "&lon=" + Longhitude + "&mode=xml&units=metric&APPID=" + API_KEY + "");
        }
        void Min(String SITE)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                var xDoc = XDocument.Load(SITE);
                Load(xDoc);
                // LoadCountry();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        void Load(XDocument xDoc)
        {
            try
            {

                City = (string)xDoc.Root.Element("city").Attribute("name");
                Country = (string)xDoc.Root.Element("city").Element("country");

                Temperature_Min = (int)xDoc.Root.Element("temperature").Attribute("min");
                Temperature_Max = (int)xDoc.Root.Element("temperature").Attribute("max");
                Temperature_Value = (int)xDoc.Root.Element("temperature").Attribute("value");

                Wind_Value = (double)xDoc.Root.Element("wind").Element("speed").Attribute("value");
                Wind_Name = (string)xDoc.Root.Element("wind").Element("speed").Attribute("name");
                Wind_Direction_Code = (string)xDoc.Root.Element("wind").Element("direction").Attribute("code");
                Wind_Direction_Name = (string)xDoc.Root.Element("wind").Element("direction").Attribute("name");
                Wind_Direction_Value = (int)xDoc.Root.Element("wind").Element("direction").Attribute("value");

                Humidity = (int)xDoc.Root.Element("humidity").Attribute("value");

                Cloud_Value = (int)xDoc.Root.Element("clouds").Attribute("value");
                Cloud_Name = (string)xDoc.Root.Element("clouds").Attribute("name");

                Weather = (string)xDoc.Root.Element("weather").Attribute("value");
                Weather_Icon = (string)xDoc.Root.Element("weather").Attribute("icon");

                Visibility = (int)xDoc.Root.Element("visibility").Attribute("value");

                Last_Update = (string)xDoc.Root.Element("lastupdate").Attribute("value");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        void LoadCountry()
        {
            try {
                string externalip = new WebClient().DownloadString("http://icanhazip.com");
                XmlDocument doc = new XmlDocument();
                var xDoc = XDocument.Load("http://ip-api.com/xml/" + externalip);
                Current_Country = (string)xDoc.Root.Element("country");
                Current_City = (string)xDoc.Root.Element("city"); ;
                Current_CountryCode = (string)xDoc.Root.Element("countryCode");
                Current_CountryLat = (float)xDoc.Root.Element("lat");
                Current_CountryLong = (float)xDoc.Root.Element("lon");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static String ToUp(String Text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Text);
        }


        public string City
        {
            get
            {
                return city;
            }

            private set
            {
                city = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            private set
            {
                country = value;
            }
        }

        public int Temperature_Min
        {
            get
            {
                return temperature_Min;
            }

            private set
            {
                temperature_Min = value;
            }
        }

        public int Temperature_Max
        {
            get
            {
                return temperature_Max;
            }

            private set
            {
                temperature_Max = value;
            }
        }

        public int Temperature_Value
        {
            get
            {
                return temperature_Value;
            }

            private set
            {
                temperature_Value = value;
            }
        }

        public double Wind_Value
        {
            get
            {
                return wind_Value;
            }

            private set
            {
                wind_Value = value;
            }
        }

        public string Wind_Name
        {
            get
            {
                return wind_Name;
            }

            private set
            {
                wind_Name = value;
            }
        }

        public string Wind_Direction_Code
        {
            get
            {
                return wind_Direction_Code;
            }

            private set
            {
                wind_Direction_Code = value;
            }
        }

        public string Wind_Direction_Name
        {
            get
            {
                return wind_Direction_Name;
            }

            private set
            {
                wind_Direction_Name = value;
            }
        }

        public int Wind_Direction_Value
        {
            get
            {
                return wind_Direction_Value;
            }

            private set
            {
                wind_Direction_Value = value;
            }
        }

        public int Humidity
        {
            get
            {
                return humidity;
            }

            private set
            {
                humidity = value;
            }
        }

        public string Weather
        {
            get
            {
                return weather;
            }

            private set
            {
                weather = value;
            }
        }

        public string Weather_Icon
        {
            get
            {
                return weather_Icon;
            }

            private set
            {
                weather_Icon = value;
            }
        }

        public int Visibility
        {
            get
            {
                return visibility;
            }

            private set
            {
                visibility = value;
            }
        }

        public int Cloud_Value
        {
            get
            {
                return cloud_Value;
            }

            private set
            {
                cloud_Value = value;
            }
        }

        public string Cloud_Name
        {
            get
            {
                return cloud_Name;
            }

            private set
            {
                cloud_Name = value;
            }
        }

        public int Pressure_Value
        {
            get
            {
                return pressure_Value;
            }

            private set
            {
                pressure_Value = value;
            }
        }

        public string Pressure_Unit
        {
            get
            {
                return pressure_Unit;
            }

            private set
            {
                pressure_Unit = value;
            }
        }

        public string Last_Update
        {
            get
            {
                return last_Update;
            }

            private set
            {
                last_Update = value;
            }
        }

        public string Current_Country
        {
            get
            {
                return current_Country;
            }

            private set
            {
                current_Country = value;
            }
        }

        public string Current_City
        {
            get
            {
                return current_City;
            }

            private set
            {
                current_City = value;
            }
        }

        public string Current_CountryCode
        {
            get
            {
                return current_CountryCode;
            }

            private set
            {
                current_CountryCode = value;
            }
        }

        public float Current_CountryLat
        {
            get
            {
                return current_CountryLat;
            }

            private set
            {
                current_CountryLat = value;
            }
        }

        public float Current_CountryLong
        {
            get
            {
                return current_CountryLong;
            }

            private set
            {
                current_CountryLong = value;
            }
        }

        public string Current_Region
        {
            get
            {
                return current_Region;
            }

            private set
            {
                current_Region = value;
            }
        }

        public string Current_TimeZone
        {
            get
            {
                return current_TimeZone;
            }

            private set
            {
                current_TimeZone = value;
            }
        }


        
    }

