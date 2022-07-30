using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;

namespace WIRWeatherApp
{
    public abstract class WeatherDict
    {
        public static string GetWindDirectionName(string directionSign)
        {
            switch (directionSign)
            {
                case "N":
                    return "North";
                case "S":
                    return "South";
                case "W":
                    return "West";
                case "E":
                    return "East";
                case "NW":
                    return "Northwest";
                case "NE":
                    return "Northeast";
                case "SW":
                    return "Southwest";
                case "SE":
                    return "Southeast";
                default:
                    return null;
            }
        }

        public static string GetPrecipitationAmountName(int pAmount)
        {
            if (pAmount >= 8) return "Very Heavy";
            if (pAmount == 7) return "Heavy";
            if (pAmount >= 5) return "Regular";
            if (pAmount >= 3) return "Light";
            if (pAmount >= 1) return "Trace";
            if (pAmount == 0) return "None";
            return null;
        }

        public static string GetPrecipitationTypeName(string pType)
        {
            switch (pType)
            {
                case "snow":
                    return "Snow";
                case "rain":
                    return "Rain";
                case "frzr":
                    return "Freezing Rain";
                case "icep":
                    return "Ice Pellets";
                case "none":
                    return "None";
                default:
                    return null;
            }
        }
        public static string GetWindSpeedName(int wSpeed)
        {
            switch (wSpeed)
            {
                case 1:
                    return "Calm";
                case 2:
                    return "Light";
                case 3:
                    return "Moderate";
                case 4:
                    return "Refreshing";
                case 5:
                    return "Strong";
                case 6:
                    return "Gale";
                case 7:
                    return "Storm";
                case 8:
                    return "Hurricane";
                default:
                    return null;
            }
        }
        public static LI GetLI(int _li)
        {
            if (_li <= -10) return LI.Certain;
            if (_li <= -6) return LI.Likely;
            if (_li <= -4) return LI.Possible;
            if (_li <= 2) return LI.Unlikely;
            if (_li >= 3) return LI.Improbable;
            return LI.ERROR;
        }
        public static Bitmap GetWeatherIcon(string wName)
        {
            return (Bitmap)Resource1.ResourceManager.GetObject(wName);
        }
        public enum CloudCover {
            None = 1,
            Scarce,
            Few,
            Some,
            Regular,
            Hazy,
            Overcasting,
            Dense,
            Enshrouding
        };
        public enum LI {
            ERROR = -1,
            Improbable = 0,
            Unlikely,
            Possible,
            Likely,
            Certain
        };
    }
}
