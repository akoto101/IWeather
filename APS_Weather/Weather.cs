using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class APS_Weather 
    {  
                  
        public APS_Weather()
        {

        }
       
        public static void getWeatherByCity(String API_KEY,String CITY_NAME)
        {
            WeatherCurrent modelCurrent = new WeatherCurrent(API_KEY,CITY_NAME);
        }
        public static void getWeatherByZip(String API_KEY, int Zip)
        {
            WeatherCurrent modelCurrent = new WeatherCurrent(API_KEY, Zip);
        }
        public static void getWeatherByLatLong(String API_KEY, double Lat , double Long)
        {
            WeatherCurrent modelCurrent = new WeatherCurrent(API_KEY , Lat , Long);
        }
        public static void getWeatherForecast(String API_KEY, String CITY_NAME, int Day_Return)
        {
            WeatherForecast modelForeCast = new WeatherForecast(API_KEY,CITY_NAME,Day_Return);
        }

     

    }

