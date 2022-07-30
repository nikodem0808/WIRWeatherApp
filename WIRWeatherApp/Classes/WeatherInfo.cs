using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WIRWeatherApp
{
    [Serializable]
    public class WeatherInfo
    {
        public WeatherInfo() { }
        public WeatherInfo(DateTime _h, int _cc, int _li, string _pt, int _pa, int _tc, string _rh, string _wd, int _ws, string _wtn)
        {
            date = _h;
            cloudCover = (WeatherDict.CloudCover)_cc;
            li = WeatherDict.GetLI(_li);
            precipitationType = WeatherDict.GetPrecipitationTypeName(_pt);
            precipitationAmount = WeatherDict.GetPrecipitationAmountName(_pa);
            temperature = _tc;
            relativeHumidity = _rh;
            windDirection = WeatherDict.GetWindDirectionName(_wd);
            windSpeed = WeatherDict.GetWindSpeedName(_ws);
            weatherIcon = WeatherDict.GetWeatherIcon(_wtn);
            weatherIcon.Tag = _wtn;
        }
        public WeatherInfo(string _stringObject)
        {
            string[] props = _stringObject.Split('$');
            date = DateTime.Parse(props[0]).ToLocalTime();
            cloudCover = (WeatherDict.CloudCover)Int32.Parse(props[1]);
            li = WeatherDict.GetLI(Int32.Parse(props[2]));
            precipitationType = props[3];
            precipitationAmount = props[4];
            temperature = Int32.Parse(props[5]);
            relativeHumidity = props[6];
            windDirection = props[7];
            windSpeed = props[8];
            weatherIcon = WeatherDict.GetWeatherIcon(props[9]);
            weatherIcon.Tag = props[9];
        }
        public override string ToString()
        {
            return String.Join("$", date.ToUniversalTime().ToString(), $"{(int)cloudCover}", $"{(int)li}", precipitationType.ToString(), precipitationAmount.ToString(), temperature.ToString(), relativeHumidity.ToString(), windDirection.ToString(), windSpeed.ToString(), (string)weatherIcon.Tag);
        }
        public DateTime date { get; }
        public WeatherDict.CloudCover cloudCover { get; }
        public WeatherDict.LI li { get; } // Lifted Index
        public string precipitationType { get; }
        public string precipitationAmount { get; }
        public int temperature { get; }
        public string relativeHumidity { get; }
        public string windDirection { get; }
        public string windSpeed { get; }
        public Bitmap weatherIcon { get; }
    }
}
