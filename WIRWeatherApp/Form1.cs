using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Xml;
using System.IO;
using System.Globalization;

namespace WIRWeatherApp
{
    public partial class Form1 : Form
    {
        WeatherInfo[] WeatherData = null;
        WeatherInfo current = null;
        FileStream f;
        DateTime dateTime;
        int displayedHour = 0;
        int focus = 0;
        string workingDirectory;
        Size _defsize;
        string place;
        // °C
        public Form1()
        {
            InitializeComponent();
            workingDirectory = Directory.GetCurrentDirectory();
            if(!Directory.Exists(workingDirectory + @"\Saved")) Directory.CreateDirectory(workingDirectory + @"\Saved");
            Resize += Form1_Resize;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            //
            panelWeather.Visible = false;
            panelWeather.Enabled = false;
            panelWeather.Location = new Point(2, 5);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Size = new Size(816, 489);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (panelWeather.Visible) return;
            string parseResult = await ParseCity();
            if (parseResult == "fail") return;
            if (parseResult.EndsWith("notSearchingCity"))
            {
                try
                {
                    parseResult = await ParseCoordinates();
                    place = parseResult.Substring(parseResult.IndexOf(';') + 1);
                    parseResult = parseResult.Substring(0, parseResult.IndexOf(';'));
                }
                catch (Exception _exc)
                {
                    if (_exc.Message != "Error: Unknown/Internet") MessageBox.Show("Something went wrong, assuming not searching for city, check angle input, must be decimal signed number or DD:MM:SS:R\nDD-degrees\nMM-minutes\nSS-seconds\nR-direction sign\nThis error can also occur if there is no internet connection.");
                    return;
                }
            }
            if (place.StartsWith(", ")) place = place.Substring(2) + " @ " + String.Join(", ", parseResult.Split(',').ToArray());
            else if (parseResult.StartsWith("Error: "))
            {
                MessageBox.Show(parseResult, "Error: Could Not Finish Location");
                return;
            }
            var splitResult = parseResult.Split(',');
            HttpClient api = new HttpClient();
            string result = await api.GetStringAsync($"https://www.7timer.info/bin/civil.php?lon={splitResult[1]}&lat={splitResult[0]}&ac=0&unit=metric&output=xml&tzshift=0");
            XmlDocument reader = new XmlDocument();
            reader.LoadXml(result);
            var dataList = reader.GetElementsByTagName("data");
            if (dataList?.Count == 0)
            {
                MessageBox.Show("No Results");
                return;
            }
            WeatherData = new WeatherInfo[] { };
            // get result UTC
            dateTime = DateTime.ParseExact(reader.GetElementsByTagName("init")[0].InnerXml,"yyyyMMddHH", CultureInfo.CurrentCulture.DateTimeFormat,System.Globalization.DateTimeStyles.AssumeUniversal);
            try
            {
                foreach (XmlNode i in dataList)
                {
                    WeatherData = WeatherData.Append(new WeatherInfo(
                        //Int32.Parse(i.Attributes["timepoint"].Value.Substring(0, i.Attributes["timepoint"].Value.Length - 1)),
                        dateTime.AddHours(Int32.Parse(i.Attributes["timepoint"].Value.Substring(0, i.Attributes["timepoint"].Value.Length - 1))),
                        Int32.Parse(i["cloudcover"].InnerXml),
                        Int32.Parse(i["lifted_index"].InnerXml),
                        i["prec_type"].InnerXml,
                        Int32.Parse(i["prec_amount"].InnerXml),
                        Int32.Parse(i["temp2m"].InnerXml),
                        i["rh2m"].InnerXml,
                        i["wind10m_direction"].InnerXml,
                        Int32.Parse(i["wind10m_speed"].InnerXml),
                        i["weather"].InnerXml
                    )).ToArray();
                    datetimeMenu.Items.Add(WeatherData.Last().date.ToString());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
            Save(WeatherData, place);
            //
            DisplayForecastName(place);
            datetimeMenu.SelectedItem = WeatherData.First();
            Display(WeatherData.First());
            //
            panelWeather.Visible = true;
            panelWeather.Enabled = true;
            panelMain.Visible = false;
            panelMain.Enabled = false;
        }

        private void datetimeMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _temp =
                from _s in WeatherData
                where _s.date.ToString() == (string)datetimeMenu.SelectedItem
                select _s
                ;
            Display(_temp.Single());
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            var _tempdatestring = current.date.AddHours(-3.0).ToString();
            var _temp =
                from _s in WeatherData
                where _s.date.ToString() == _tempdatestring
                select _s
                ;
            if (_temp.Count() == 0) return;
            Display(_temp.Single());
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var _tempdatestring = current.date.AddHours(3.0).ToString();
            var _temp =
                from _s in WeatherData
                where _s.date.ToString() == _tempdatestring
                select _s
                ;
            if (_temp.Count() == 0) return;
            Display(_temp.Single());
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            WeatherData = null;
            current = null;
            panelWeather.Visible = false;
            panelWeather.Enabled = false;
            panelMain.Visible = true;
            panelMain.Enabled = true;
            place = "";
            datetimeMenu.Items.Clear();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = workingDirectory + @"\Saved";
                DialogResult _dres = fileDialog.ShowDialog();
                if (DialogResult.Cancel == _dres || DialogResult.Abort == _dres)
                {
                    return;
                }
                if (fileDialog.FileName?.Substring(fileDialog.FileName.Length - 4) != ".wir")
                {
                    MessageBox.Show("Please choose a valid WIR save file");
                    return;
                }
                FileStream fileReader = new FileStream(fileDialog.FileName, FileMode.Open, FileAccess.Read);
                WeatherData = new WeatherInfo[] { };
                byte[] _contentRaw = new byte[] { };
                int cByte;
                while (fileReader.CanRead)
                {
                    cByte = fileReader.ReadByte();
                    if (cByte == -1) break;
                    _contentRaw = _contentRaw.Append((byte)cByte).ToArray();
                }
                string fileContent = Encoding.UTF8.GetString(_contentRaw);
                place = fileContent.Substring(0, fileContent.IndexOf('\n'));
                fileContent = fileContent.Substring(fileContent.IndexOf('\n') + 1);
                string[] _dataUnits = fileContent.Split('\n');
                foreach(string i in _dataUnits)
                {
                    if (String.IsNullOrWhiteSpace(i)) break;
                    WeatherData = WeatherData.Append(new WeatherInfo(i)).ToArray();
                    datetimeMenu.Items.Add(WeatherData.Last().date.ToString());
                }
                fileReader.Close();
            }
            catch(Exception exception)
            {
                MessageBox.Show("File Format Corrupted : " + exception.Message);
                return;
            }
            // //
            DisplayForecastName(place);
            datetimeMenu.SelectedItem = WeatherData.First();
            Display(WeatherData.First());
            //
            panelWeather.Visible = true;
            panelWeather.Enabled = true;
            panelMain.Visible = false;
            panelMain.Enabled = false;
        }

        //
        public async void Save(WeatherInfo[] wData, string _place)
        {
            //MessageBox.Show(workingDirectory + @"\Saved\" + DateTime.Now.ToString().Replace(' ', '-').Replace('/', '-').Replace(':', '-') + ".wir");
            FileStream _saveStream = File.Create(workingDirectory + @"\Saved\" + DateTime.Now.ToString().Replace(' ','-').Replace('/', '-').Replace(':', '-') + ".wir");
            byte[] _bts = Encoding.UTF8.GetBytes(_place + "\n");
            await _saveStream.WriteAsync(_bts, 0, _bts.Length);
            foreach (WeatherInfo i in wData) {
                _bts = Encoding.UTF8.GetBytes(i.ToString() + "\n");
                await _saveStream.WriteAsync(_bts, 0, _bts.Length);
            }
            _saveStream.SetLength(_saveStream.Length - 1);
            _saveStream.Close();
        }
        private async Task<string> ParseCity()
        {
            try
            {
                string _fnOut = String.Concat(cityTBox.Text, ", ", countryTBox.Text);
                if (_fnOut.LastIndexOf(',') != _fnOut.IndexOf(','))
                {
                    MessageBox.Show("Commas not allowed in City search");
                    return "fail";
                }
                if (_fnOut == ", ") return "notSearchingCity";
                HttpClient api = new HttpClient();
                _fnOut = Uri.EscapeDataString(_fnOut);
                string result = await api.GetStringAsync($"https://api.geoapify.com/v1/geocode/search?text={_fnOut}&format=xml&apiKey=b4b9eb9ae0b24222963bfeead11fcaea");
                XmlDocument reader = new XmlDocument();
                reader.LoadXml(result);
                try
                {
                    _fnOut = String.Concat(reader.GetElementsByTagName("lat")[0].InnerXml, ",", reader.GetElementsByTagName("lon")[0].InnerXml);
                    place = String.Concat(reader.GetElementsByTagName("city")[0]?.InnerXml, ", ", reader.GetElementsByTagName("country")[0]?.InnerXml);
                }
                catch
                {
                    MessageBox.Show("Something went wrong (check Country/City input, must be blank if you use coordinates)");
                    return "fail";
                }
                return _fnOut;
            }
            catch(Exception e)
            {
                if (e.Message.Contains("sending")) MessageBox.Show("Error: check your internet connection");
                return "fail";
            }
        }

        private async Task<string> ParseCoordinates()
        {
            try
            {
                double _lon, _lat;
                string tempRef = latitudeTBox.Text;
                ParseCoordinate(tempRef, out _lat);
                tempRef = longitudeTBox.Text;
                ParseCoordinate(tempRef, out _lon);
                HttpClient api = new HttpClient();
                string result = await api.GetStringAsync($"https://api.geoapify.com/v1/geocode/reverse?lat={_lat}&lon={_lon}&format=xml&apiKey=fca48bed69ee48fbb95e26f965a7dce3");
                //if (result.StatusCode != System.Net.HttpStatusCode.OK) MessageBox.Show(result.Headers.ToString());
                XmlDocument reader = new XmlDocument();
                reader.LoadXml(result);
                if (reader.GetElementsByTagName("city")[0]?.InnerXml == null)
                {
                    return String.Concat(_lat, ",", _lon, ";, ", reader.GetElementsByTagName("country")[0]?.InnerXml ?? reader.GetElementsByTagName("name")[0].InnerXml);
                }
                tempRef = String.Concat(_lat, ",", _lon, ";", reader.GetElementsByTagName("city")[0].InnerXml, ", ", reader.GetElementsByTagName("country")[0].InnerXml);
                return tempRef;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return "Error: " + e.Message + " / " + e.Source.GetType().ToString();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys e)
        {
            if (e == Keys.Enter)
            {
                button1_Click(new object(), new EventArgs());
                ;
                return true;
            }
            return base.ProcessCmdKey(ref msg, e);
        }
        
        private void ParseCoordinate(string _s, out double _r)
        {
            _r = 0;
            _s = _s.Replace(",", ".");
            if (!Double.TryParse(_s, (System.Globalization.NumberStyles)(0b01101111), System.Globalization.NumberFormatInfo.InvariantInfo, out _r))
            {
                var SplitData = _s.Split(':');
                _r = Double.Parse(SplitData[0]);
                _r += Double.Parse(SplitData[1]) / 60;
                _r += Double.Parse(SplitData[2]) / 3600;
                if (_s.Last() == 'S' || _s.Last() == 'W') _r *= -1.0;
            }
        }
        private void DisplayForecastName(string _name)
        {
            try
            {
                _name = _name.Substring(0, _name.IndexOf('.') + 3).Replace(",","") + _name.Substring(_name.IndexOf(','),_name.LastIndexOf('.') - _name.IndexOf(',') + 3);
            }
            catch { }
            forecastLocationLabel.Text = _name;
            forecastLocationLabel.Width = Size.Width;
            forecastLocationLabel.Location = new Point(0, forecastLocationLabel.Location.Y);
        }

        private void Display(WeatherInfo wInfo)
        {
            current = wInfo;
            cloudInfo.Text = wInfo.cloudCover.ToString();
            humidityInfo.Text = wInfo.relativeHumidity;
            thunderInfo.Text = wInfo.li.ToString();
            windDirectionInfo.Text = wInfo.windDirection;
            windSpeedInfo.Text = wInfo.windSpeed;
            precipitationTypeInfo.Text = wInfo.precipitationType;
            if (wInfo.precipitationType == "None") precipitationAmountInfo.Text = "-";
            else precipitationAmountInfo.Text = wInfo.precipitationAmount;
            datetimeMenu.Text = wInfo.date.ToString();
            weatherPictureBox.Image = (Image)wInfo.weatherIcon;
        }

        //

        private void forecastLocationLabel_Click(object sender, EventArgs e)
        {

        }

        private void latitudeTBox_TextChanged(object sender, EventArgs e)
        {
            ;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ;
        }
        private void cityTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
