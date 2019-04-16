using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Drawing;
using System.Globalization;
using System.IO;

  public class Utils
    {

        private static String ToUp(String Text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Text);
        }

        public static System.Drawing.Image Image_Returner(int code)
        {
            System.Drawing.Image img = null;
            if (code <= 232 && code >= 200)
            {
                //Thunderstorm
                img = global::APS_Weather.Resource1.thunderStorm;
            }
            if (code <= 321 && code >= 300)
            {
                //drizzle
                //  System.Drawing.Image.FromFile("WeatherIcon\");
                img = global::APS_Weather.Resource1.drizzle;
            }
            if (code <= 504 && code >= 500)
            {
                //Rain
                img =global::APS_Weather.Resource1.lightrain;
            }
            if (code <= 511 && code >= 531)
            {
                //Rain
                img = global::APS_Weather.Resource1.heavyRain;
            }

            if (code <= 622 && code >= 600)
            {
                //Snow
                img = global::APS_Weather.Resource1.snow;
            }
            if (code == 800)
            {
                DateTime timenow = DateTime.Now;

                if (timenow.Hour >= 5 && timenow.Hour < 12)
                { img = global::APS_Weather.Resource1.Day; }
                if (timenow.Hour >= 12 && timenow.Hour < 18)
                { img = global::APS_Weather.Resource1.Sunset; }
                if (timenow.Hour >= 18 && timenow.Hour < 24)
                {
                    img = global::APS_Weather.Resource1.Night;
                    //System.Drawing.Image.FromFile(@"WeatherIcon\Night.png");
                }
                if (timenow.Hour < 5)
                { img = global::APS_Weather.Resource1.Night; }

            }
            //if (code <= 781 && code >= 701) {
            //    //Atmosphere
            //}
            return img;
        }

        public static Bitmap Weather_ToIcon(string icon)
        {
            string url = "http://openweathermap.org/img/w/" + icon + ".png";
            HttpWebRequest wreq;
            HttpWebResponse wresp;
            Stream mystream;
            Bitmap bmp;

            bmp = null;
            mystream = null;
            wresp = null;
            try
            {
                wreq = (HttpWebRequest)WebRequest.Create(url);
                wreq.AllowWriteStreamBuffering = true;

                wresp = (HttpWebResponse)wreq.GetResponse();

                if ((mystream = wresp.GetResponseStream()) != null)
                    bmp = new Bitmap(mystream);
            }
            finally
            {
                if (mystream != null)
                    mystream.Close();

                if (wresp != null)
                    wresp.Close();
            }

            return (bmp);
        }


    }

