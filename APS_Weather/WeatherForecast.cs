using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
  public class WeatherForecast
    {
        public enum WeatherUnits
        {
              Metric,Imperial,Default
        }
        /// <summary>
        /// DATA MODEL INITIALIZATION
        /// START
        /// </summary>
        private String xmlUnits;
        private String time_Current;
        private String[] time_Forecast_From;
        private String[] time_ForecastTo;

        private String[] weather_Id; // Weather Icon ID
        private String[] weather_Icon; // Weather Symbol <Must Load>
        private String[] weather_Name;

        private double[] wind_Speed;
        private String[] wind_Name;
        private String[] wind_Code;

        private double[] temperature_OnDay;
        private double[] temperature_OnNight;
        private double[] temperature_OnEve;
        private double[] temperature_OnMorning;
        private double[] temperature_Minimum;
        private double[] temperature_Maximum;

        private String[] pressure_Unit;
        private double[] pressure_Value;

        private int[] humidity_Value;
        private String[] humidity_Unit;

        private String[] cloud;
        private int[] rain_Chance;

        private String[] sun_Rise;
        private String[] sun_Set;

        private String city;

        /// <summary>
        /// DATA MODEL INITIALIZATION
        /// END
        /// </summary>
        public WeatherForecast()
        {

        }

        public WeatherForecast(String API_KEY, String City_Name, int Day_Return)
        {
            String API = "http://api.openweathermap.org/data/2.5/forecast/daily?q=" + City_Name + "&mode=xml&APPID=" + API_KEY + "&cnt=" + Day_Return + "";
            XmlDocument doc = new XmlDocument();
            var xDoc = XDocument.Load(API);
            XElement root = XElement.Load(API);
            Load(xDoc, root);

        }
        public WeatherForecast(String API_KEY, String City_Name,WeatherUnits units, int Day_Return)
        {
            String API = "http://api.openweathermap.org/data/2.5/forecast/daily?q=" + City_Name + "&mode=xml" + getUnits(units) + "&APPID=" + API_KEY + "&cnt=" + Day_Return + "";
            XmlDocument doc = new XmlDocument();
            var xDoc = XDocument.Load(API);
            XElement root = XElement.Load(API);
            Load(xDoc, root);

        }
        void Load(XDocument xDoc,XElement root)
        {

            City = (string)xDoc.Root.Element("location").Attribute("name");
        
            Time_Forecast_From = root.Element("forecast").Elements("time").Attributes("day").Select(e => e.Value).ToArray();

            //Symbol
            Weather_Name = root.Element("forecast").Elements("time").Elements("symbol").Attributes("name").Select(e => e.Value).ToArray();
            Weather_Icon = root.Element("forecast").Elements("time").Elements("symbol").Attributes("var").Select(e => e.Value).ToArray();
            Weather_Id = root.Element("forecast").Elements("time").Elements("symbol").Attributes("number").Select(e => e.Value).ToArray();
            //Symbol_End

            //windDirection
            Wind_Speed = Array.ConvertAll(root.Element("forecast").Elements("time").Elements("windSpeed").Attributes("mps").Select(e => e.Value).ToArray(), s => double.Parse(s));
            Wind_Name = root.Element("forecast").Elements("time").Elements("windSpeed").Attributes("name").Select(e => e.Value).ToArray();
            //Wind_direction_end

            //temperature
            Temperature_OnDay = root.Element("forecast").Elements("time").Elements("temperature").Attributes("day").Select(e => Double.Parse(e.Value)).ToArray();
            Temperature_Minimum = root.Element("forecast").Elements("time").Elements("temperature").Attributes("min").Select(e => Double.Parse(e.Value)).ToArray();
            Temperature_Maximum = root.Element("forecast").Elements("time").Elements("temperature").Attributes("max").Select(e => Double.Parse(e.Value)).ToArray();
            Temperature_OnNight = root.Element("forecast").Elements("time").Elements("temperature").Attributes("night").Select(e => Double.Parse(e.Value)).ToArray();
            Temperature_OnEve = root.Element("forecast").Elements("time").Elements("temperature").Attributes("eve").Select(e => Double.Parse(e.Value)).ToArray();
            Temperature_OnMorning = root.Element("forecast").Elements("time").Elements("temperature").Attributes("morn").Select(e => Double.Parse(e.Value)).ToArray();
            //temperature_end

            //Pressure
            Pressure_Unit = root.Element("forecast").Elements("time").Elements("pressure").Attributes("unit").Select(e => e.Value).ToArray();
            Pressure_Value = root.Element("forecast").Elements("time").Elements("pressure").Attributes("value").Select(e => Double.Parse(e.Value)).ToArray();
            //Pressure_End

            //humidity
            Humidity_Value = root.Element("forecast").Elements("time").Elements("humidity").Attributes("value").Select(e => Int32.Parse(e.Value)).ToArray();
            Humidity_Unit = root.Element("forecast").Elements("time").Elements("humidity").Attributes("unit").Select(e => e.Value).ToArray();
            //humidity_End

            //Cloud
            Cloud = root.Element("forecast").Elements("time").Elements("clouds").Attributes("value").Select(e => e.Value).ToArray();
            Rain_Chance = root.Element("forecast").Elements("time").Elements("clouds").Attributes("all").Select(e => Int32.Parse(e.Value)).ToArray();

            //Clouds_end

            Time_ForecastTo = root.Element("forecast").Elements("time").Attributes("to").Select(e => e.Value).ToArray();

            Sun_Rise = root.Element("sun").Attributes("rise").Select(e => e.Value).ToArray();
            Sun_set = root.Element("sun").Attributes("private set").Select(e => e.Value).ToArray();

        }
        /// <summary>
        /// DATA MODELS
        /// !DO NOT CHANGE
        /// START
        /// </summary>
        
        public string Time_Current
        {
            get
            {
                return time_Current;
            }

            private set
            {
                time_Current = value;
            }
        }

        public string[] Time_Forecast_From
        {
            get
            {
                return time_Forecast_From;
            }

            private set
            {
                time_Forecast_From = value;
            }
        }

        public string[] Time_ForecastTo
        {
            get
            {
                return time_ForecastTo;
            }

            private set
            {
                time_ForecastTo = value;
            }
        }

        public string[] Weather_Id
        {
            get
            {
                return weather_Id;
            }

            private set
            {
                weather_Id = value;
            }
        }

        public string[] Weather_Icon
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

        public double[] Wind_Speed
        {
            get
            {
                return wind_Speed;
            }

            private set
            {
                wind_Speed = value;
            }
        }

        public string[] Wind_Name
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

        public string[] Wind_Code
        {
            get
            {
                return wind_Code;
            }

            private set
            {
                wind_Code = value;
            }
        }

        public double[] Temperature_OnDay
        {
            get
            {
                return temperature_OnDay;
            }

            private set
            {
                temperature_OnDay = value;
            }
        }

        public double[] Temperature_OnNight
        {
            get
            {
                return temperature_OnNight;
            }

            private set
            {
                temperature_OnNight = value;
            }
        }

        public double[] Temperature_OnEve
        {
            get
            {
                return temperature_OnEve;
            }

            private set
            {
                temperature_OnEve = value;
            }
        }

        public double[] Temperature_OnMorning
        {
            get
            {
                return temperature_OnMorning;
            }

            private set
            {
                temperature_OnMorning = value;
            }
        }

        public double[] Temperature_Minimum
        {
            get
            {
                return temperature_Minimum;
            }

            private set
            {
                temperature_Minimum = value;
            }
        }

        public double[] Temperature_Maximum
        {
            get
            {
                return temperature_Maximum;
            }

            private set
            {
                temperature_Maximum = value;
            }
        }

        public string[] Pressure_Unit
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

        public double[] Pressure_Value
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

        public int[] Humidity_Value
        {
            get
            {
                return humidity_Value;
            }

            private set
            {
                humidity_Value = value;
            }
        }

        public string[] Humidity_Unit
        {
            get
            {
                return humidity_Unit;
            }

            private set
            {
                humidity_Unit = value;
            }
        }

        public string[] Cloud
        {
            get
            {
                return cloud;
            }

            private set
            {
                cloud = value;
            }
        }

        public int[] Rain_Chance
        {
            get
            {
                return rain_Chance;
            }

            private set
            {
                rain_Chance = value;
            }
        }

        public string[] Sun_Rise
        {
            get
            {
                return sun_Rise;
            }

            private set
            {
                sun_Rise = value;
            }
        }

        public string[] Sun_set
        {
            get
            {
                return sun_Set;
            }

            private set
            {
                sun_Set = value;
            }
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

        public string[] Weather_Name
        {
            get
            {
                return weather_Name;
            }

            private set
            {
                weather_Name = value;
            }
        }

        String getUnits(WeatherUnits units)
        {

            String unitsMustUse = "";
            switch (units)
            {
                case WeatherUnits.Imperial:

                    unitsMustUse = "&units=imperial";

                    break;
                case WeatherUnits.Metric:
                    unitsMustUse = "&units=metric";
                    break;
                default:
                    unitsMustUse = "";
                    break;


            }
            return unitsMustUse;
        }

        public string XmlUnits
        {
            get
            {
               
                return xmlUnits;
            }

            set
            {
                xmlUnits = value;
            }
        }

        /// <summary>
        /// DATA MODELS
        /// !DO NOT CHANGE
        /// START
        /// </summary>
    }

