
namespace WIRWeatherApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.countryTBox = new System.Windows.Forms.TextBox();
            this.latitudeTBox = new System.Windows.Forms.TextBox();
            this.cityTBox = new System.Windows.Forms.TextBox();
            this.longitudeTBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.forecastLocationLabel = new System.Windows.Forms.Label();
            this.weatherPictureBox = new System.Windows.Forms.PictureBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.datetimeMenu = new System.Windows.Forms.ComboBox();
            this.cloudLabel = new System.Windows.Forms.Label();
            this.precipitationAmountInfo = new System.Windows.Forms.Label();
            this.precipitationTypeInfo = new System.Windows.Forms.Label();
            this.humidityInfo = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.windSpeedInfo = new System.Windows.Forms.Label();
            this.windDirectionInfo = new System.Windows.Forms.Label();
            this.precipitationLabel = new System.Windows.Forms.Label();
            this.cloudInfo = new System.Windows.Forms.Label();
            this.panelWeather = new System.Windows.Forms.Panel();
            this.thunderInfo = new System.Windows.Forms.Label();
            this.thunderLabel = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPictureBox)).BeginInit();
            this.panelWeather.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 26F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specify your location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Country";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "  Latitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Longitude";
            // 
            // countryTBox
            // 
            this.countryTBox.Location = new System.Drawing.Point(37, 141);
            this.countryTBox.Name = "countryTBox";
            this.countryTBox.Size = new System.Drawing.Size(174, 20);
            this.countryTBox.TabIndex = 5;
            // 
            // latitudeTBox
            // 
            this.latitudeTBox.Location = new System.Drawing.Point(421, 141);
            this.latitudeTBox.Name = "latitudeTBox";
            this.latitudeTBox.Size = new System.Drawing.Size(182, 20);
            this.latitudeTBox.TabIndex = 6;
            this.latitudeTBox.Text = "DD:MM:SS:[W/E] or signed number";
            this.latitudeTBox.TextChanged += new System.EventHandler(this.latitudeTBox_TextChanged);
            // 
            // cityTBox
            // 
            this.cityTBox.Location = new System.Drawing.Point(37, 207);
            this.cityTBox.Name = "cityTBox";
            this.cityTBox.Size = new System.Drawing.Size(174, 20);
            this.cityTBox.TabIndex = 7;
            this.cityTBox.TextChanged += new System.EventHandler(this.cityTBox_TextChanged);
            // 
            // longitudeTBox
            // 
            this.longitudeTBox.Location = new System.Drawing.Point(421, 207);
            this.longitudeTBox.Name = "longitudeTBox";
            this.longitudeTBox.Size = new System.Drawing.Size(182, 20);
            this.longitudeTBox.TabIndex = 8;
            this.longitudeTBox.Text = "DD:MM:SS:[N/S] or signed number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "or";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(256, 285);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(119, 56);
            this.button1.TabIndex = 10;
            this.button1.Text = "Will It Rain?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.buttonLoad);
            this.panelMain.Controls.Add(this.button1);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.longitudeTBox);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.cityTBox);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.latitudeTBox);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.countryTBox);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Location = new System.Drawing.Point(82, 46);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(652, 384);
            this.panelMain.TabIndex = 11;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(256, 347);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(119, 23);
            this.buttonLoad.TabIndex = 11;
            this.buttonLoad.Text = "Load from Saved";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(614, 39);
            this.label7.TabIndex = 12;
            this.label7.Text = "Weather Forecast";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forecastLocationLabel
            // 
            this.forecastLocationLabel.Font = new System.Drawing.Font("Malgun Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLocationLabel.Location = new System.Drawing.Point(96, 43);
            this.forecastLocationLabel.Name = "forecastLocationLabel";
            this.forecastLocationLabel.Size = new System.Drawing.Size(609, 66);
            this.forecastLocationLabel.TabIndex = 13;
            this.forecastLocationLabel.Text = "Jelenia, Polska";
            this.forecastLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forecastLocationLabel.Click += new System.EventHandler(this.forecastLocationLabel_Click);
            // 
            // weatherPictureBox
            // 
            this.weatherPictureBox.Location = new System.Drawing.Point(21, 239);
            this.weatherPictureBox.Name = "weatherPictureBox";
            this.weatherPictureBox.Size = new System.Drawing.Size(132, 132);
            this.weatherPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weatherPictureBox.TabIndex = 14;
            this.weatherPictureBox.TabStop = false;
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(10, 153);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 15;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(91, 153);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 16;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(10, 8);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // datetimeMenu
            // 
            this.datetimeMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.datetimeMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.datetimeMenu.FormattingEnabled = true;
            this.datetimeMenu.Location = new System.Drawing.Point(10, 182);
            this.datetimeMenu.Name = "datetimeMenu";
            this.datetimeMenu.Size = new System.Drawing.Size(156, 21);
            this.datetimeMenu.TabIndex = 19;
            this.datetimeMenu.SelectedIndexChanged += new System.EventHandler(this.datetimeMenu_SelectedIndexChanged);
            // 
            // cloudLabel
            // 
            this.cloudLabel.AutoSize = true;
            this.cloudLabel.Font = new System.Drawing.Font("Malgun Gothic", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloudLabel.Location = new System.Drawing.Point(191, 159);
            this.cloudLabel.Name = "cloudLabel";
            this.cloudLabel.Size = new System.Drawing.Size(112, 40);
            this.cloudLabel.TabIndex = 20;
            this.cloudLabel.Text = "Clouds:";
            this.cloudLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // precipitationAmountInfo
            // 
            this.precipitationAmountInfo.AutoSize = true;
            this.precipitationAmountInfo.Font = new System.Drawing.Font("Malgun Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipitationAmountInfo.Location = new System.Drawing.Point(579, 331);
            this.precipitationAmountInfo.Name = "precipitationAmountInfo";
            this.precipitationAmountInfo.Size = new System.Drawing.Size(200, 40);
            this.precipitationAmountInfo.TabIndex = 21;
            this.precipitationAmountInfo.Text = "00000mm/hrs";
            // 
            // precipitationTypeInfo
            // 
            this.precipitationTypeInfo.AutoSize = true;
            this.precipitationTypeInfo.Font = new System.Drawing.Font("Malgun Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipitationTypeInfo.Location = new System.Drawing.Point(583, 291);
            this.precipitationTypeInfo.Name = "precipitationTypeInfo";
            this.precipitationTypeInfo.Size = new System.Drawing.Size(151, 40);
            this.precipitationTypeInfo.TabIndex = 22;
            this.precipitationTypeInfo.Text = "Ice Pellets";
            // 
            // humidityInfo
            // 
            this.humidityInfo.AutoSize = true;
            this.humidityInfo.Font = new System.Drawing.Font("Malgun Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityInfo.Location = new System.Drawing.Point(300, 301);
            this.humidityInfo.Name = "humidityInfo";
            this.humidityInfo.Size = new System.Drawing.Size(89, 40);
            this.humidityInfo.TabIndex = 23;
            this.humidityInfo.Text = "100%";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.Font = new System.Drawing.Font("Malgun Gothic", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.Location = new System.Drawing.Point(161, 279);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(142, 80);
            this.humidityLabel.TabIndex = 24;
            this.humidityLabel.Text = "Relative\r\nHumidity:";
            // 
            // windLabel
            // 
            this.windLabel.AutoSize = true;
            this.windLabel.Font = new System.Drawing.Font("Malgun Gothic", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLabel.Location = new System.Drawing.Point(478, 159);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(92, 40);
            this.windLabel.TabIndex = 25;
            this.windLabel.Text = "Wind:";
            // 
            // windSpeedInfo
            // 
            this.windSpeedInfo.AutoSize = true;
            this.windSpeedInfo.Font = new System.Drawing.Font("Malgun Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeedInfo.Location = new System.Drawing.Point(595, 142);
            this.windSpeedInfo.Name = "windSpeedInfo";
            this.windSpeedInfo.Size = new System.Drawing.Size(104, 40);
            this.windSpeedInfo.TabIndex = 26;
            this.windSpeedInfo.Text = "Strong";
            // 
            // windDirectionInfo
            // 
            this.windDirectionInfo.AutoSize = true;
            this.windDirectionInfo.Font = new System.Drawing.Font("Malgun Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windDirectionInfo.Location = new System.Drawing.Point(595, 182);
            this.windDirectionInfo.Name = "windDirectionInfo";
            this.windDirectionInfo.Size = new System.Drawing.Size(147, 40);
            this.windDirectionInfo.TabIndex = 27;
            this.windDirectionInfo.Text = "Northeast";
            // 
            // precipitationLabel
            // 
            this.precipitationLabel.AutoSize = true;
            this.precipitationLabel.Font = new System.Drawing.Font("Malgun Gothic", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipitationLabel.Location = new System.Drawing.Point(392, 301);
            this.precipitationLabel.Name = "precipitationLabel";
            this.precipitationLabel.Size = new System.Drawing.Size(187, 40);
            this.precipitationLabel.TabIndex = 28;
            this.precipitationLabel.Text = "Precipitation:";
            // 
            // cloudInfo
            // 
            this.cloudInfo.AutoSize = true;
            this.cloudInfo.Font = new System.Drawing.Font("Malgun Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloudInfo.Location = new System.Drawing.Point(300, 159);
            this.cloudInfo.Name = "cloudInfo";
            this.cloudInfo.Size = new System.Drawing.Size(181, 40);
            this.cloudInfo.TabIndex = 29;
            this.cloudInfo.Text = "Enshrouding";
            // 
            // panelWeather
            // 
            this.panelWeather.Controls.Add(this.thunderLabel);
            this.panelWeather.Controls.Add(this.thunderInfo);
            this.panelWeather.Controls.Add(this.cloudInfo);
            this.panelWeather.Controls.Add(this.precipitationAmountInfo);
            this.panelWeather.Controls.Add(this.precipitationLabel);
            this.panelWeather.Controls.Add(this.windDirectionInfo);
            this.panelWeather.Controls.Add(this.windSpeedInfo);
            this.panelWeather.Controls.Add(this.windLabel);
            this.panelWeather.Controls.Add(this.humidityLabel);
            this.panelWeather.Controls.Add(this.humidityInfo);
            this.panelWeather.Controls.Add(this.precipitationTypeInfo);
            this.panelWeather.Controls.Add(this.cloudLabel);
            this.panelWeather.Controls.Add(this.datetimeMenu);
            this.panelWeather.Controls.Add(this.backButton);
            this.panelWeather.Controls.Add(this.nextButton);
            this.panelWeather.Controls.Add(this.previousButton);
            this.panelWeather.Controls.Add(this.weatherPictureBox);
            this.panelWeather.Controls.Add(this.forecastLocationLabel);
            this.panelWeather.Controls.Add(this.label7);
            this.panelWeather.Location = new System.Drawing.Point(861, 403);
            this.panelWeather.Name = "panelWeather";
            this.panelWeather.Size = new System.Drawing.Size(782, 435);
            this.panelWeather.TabIndex = 30;
            // 
            // thunderInfo
            // 
            this.thunderInfo.AutoSize = true;
            this.thunderInfo.Font = new System.Drawing.Font("Malgun Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thunderInfo.Location = new System.Drawing.Point(412, 228);
            this.thunderInfo.Name = "thunderInfo";
            this.thunderInfo.Size = new System.Drawing.Size(167, 40);
            this.thunderInfo.TabIndex = 30;
            this.thunderInfo.Text = "Improbable";
            // 
            // thunderLabel
            // 
            this.thunderLabel.AutoSize = true;
            this.thunderLabel.Font = new System.Drawing.Font("Malgun Gothic", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thunderLabel.Location = new System.Drawing.Point(273, 228);
            this.thunderLabel.Name = "thunderLabel";
            this.thunderLabel.Size = new System.Drawing.Size(132, 40);
            this.thunderLabel.TabIndex = 31;
            this.thunderLabel.Text = "Thunder:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelWeather);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Will It Rain Weather App";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPictureBox)).EndInit();
            this.panelWeather.ResumeLayout(false);
            this.panelWeather.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox countryTBox;
        private System.Windows.Forms.TextBox latitudeTBox;
        private System.Windows.Forms.TextBox cityTBox;
        private System.Windows.Forms.TextBox longitudeTBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label forecastLocationLabel;
        private System.Windows.Forms.PictureBox weatherPictureBox;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox datetimeMenu;
        private System.Windows.Forms.Label cloudLabel;
        private System.Windows.Forms.Label precipitationAmountInfo;
        private System.Windows.Forms.Label precipitationTypeInfo;
        private System.Windows.Forms.Label humidityInfo;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label windSpeedInfo;
        private System.Windows.Forms.Label windDirectionInfo;
        private System.Windows.Forms.Label precipitationLabel;
        private System.Windows.Forms.Label cloudInfo;
        private System.Windows.Forms.Panel panelWeather;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label thunderLabel;
        private System.Windows.Forms.Label thunderInfo;
    }
}

