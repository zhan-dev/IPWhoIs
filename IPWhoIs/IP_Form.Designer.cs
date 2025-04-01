namespace IPWhoIs
{
    partial class WhoIS
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
            this.get_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ipResult_lbl = new System.Windows.Forms.Label();
            this.flag_pb1 = new System.Windows.Forms.PictureBox();
            this.longitude_lbl = new System.Windows.Forms.Label();
            this.latitude_lbl = new System.Windows.Forms.Label();
            this.capital_lbl = new System.Windows.Forms.Label();
            this.utc_lbl = new System.Windows.Forms.Label();
            this.callingCode_lbl = new System.Windows.Forms.Label();
            this.city_lbl = new System.Windows.Forms.Label();
            this.region_lbl = new System.Windows.Forms.Label();
            this.countryCode_lbl = new System.Windows.Forms.Label();
            this.country_lbl = new System.Windows.Forms.Label();
            this.continentCode_lbl = new System.Windows.Forms.Label();
            this.continent_lbl = new System.Windows.Forms.Label();
            this.ip_lbl = new System.Windows.Forms.Label();
            this.ipEnter_lbl = new System.Windows.Forms.Label();
            this.ipInput_txt = new System.Windows.Forms.TextBox();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flag_pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // get_btn
            // 
            this.get_btn.Location = new System.Drawing.Point(3, 339);
            this.get_btn.Name = "get_btn";
            this.get_btn.Size = new System.Drawing.Size(295, 38);
            this.get_btn.TabIndex = 0;
            this.get_btn.Text = "get";
            this.get_btn.UseVisualStyleBackColor = true;
            this.get_btn.Click += new System.EventHandler(this.get_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ipResult_lbl);
            this.panel1.Controls.Add(this.flag_pb1);
            this.panel1.Controls.Add(this.longitude_lbl);
            this.panel1.Controls.Add(this.latitude_lbl);
            this.panel1.Controls.Add(this.capital_lbl);
            this.panel1.Controls.Add(this.utc_lbl);
            this.panel1.Controls.Add(this.callingCode_lbl);
            this.panel1.Controls.Add(this.city_lbl);
            this.panel1.Controls.Add(this.region_lbl);
            this.panel1.Controls.Add(this.countryCode_lbl);
            this.panel1.Controls.Add(this.country_lbl);
            this.panel1.Controls.Add(this.continentCode_lbl);
            this.panel1.Controls.Add(this.continent_lbl);
            this.panel1.Controls.Add(this.ip_lbl);
            this.panel1.Controls.Add(this.ipEnter_lbl);
            this.panel1.Controls.Add(this.ipInput_txt);
            this.panel1.Controls.Add(this.get_btn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 380);
            this.panel1.TabIndex = 1;
            // 
            // ipResult_lbl
            // 
            this.ipResult_lbl.AutoSize = true;
            this.ipResult_lbl.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipResult_lbl.Location = new System.Drawing.Point(145, 55);
            this.ipResult_lbl.Name = "ipResult_lbl";
            this.ipResult_lbl.Size = new System.Drawing.Size(0, 20);
            this.ipResult_lbl.TabIndex = 4;
            // 
            // flag_pb1
            // 
            this.flag_pb1.Location = new System.Drawing.Point(268, 45);
            this.flag_pb1.Name = "flag_pb1";
            this.flag_pb1.Size = new System.Drawing.Size(30, 30);
            this.flag_pb1.TabIndex = 3;
            this.flag_pb1.TabStop = false;
            // 
            // longitude_lbl
            // 
            this.longitude_lbl.AutoSize = true;
            this.longitude_lbl.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitude_lbl.Location = new System.Drawing.Point(3, 275);
            this.longitude_lbl.Name = "longitude_lbl";
            this.longitude_lbl.Size = new System.Drawing.Size(76, 20);
            this.longitude_lbl.TabIndex = 2;
            this.longitude_lbl.Text = "longitude:";
            // 
            // latitude_lbl
            // 
            this.latitude_lbl.AutoSize = true;
            this.latitude_lbl.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitude_lbl.Location = new System.Drawing.Point(3, 255);
            this.latitude_lbl.Name = "latitude_lbl";
            this.latitude_lbl.Size = new System.Drawing.Size(63, 20);
            this.latitude_lbl.TabIndex = 2;
            this.latitude_lbl.Text = "latitude:";
            // 
            // capital_lbl
            // 
            this.capital_lbl.AutoSize = true;
            this.capital_lbl.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capital_lbl.Location = new System.Drawing.Point(3, 215);
            this.capital_lbl.Name = "capital_lbl";
            this.capital_lbl.Size = new System.Drawing.Size(59, 20);
            this.capital_lbl.TabIndex = 2;
            this.capital_lbl.Text = "Capital:";
            // 
            // utc_lbl
            // 
            this.utc_lbl.AutoSize = true;
            this.utc_lbl.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utc_lbl.Location = new System.Drawing.Point(3, 235);
            this.utc_lbl.Name = "utc_lbl";
            this.utc_lbl.Size = new System.Drawing.Size(39, 20);
            this.utc_lbl.TabIndex = 2;
            this.utc_lbl.Text = "UTC:";
            // 
            // callingCode_lbl
            // 
            this.callingCode_lbl.AutoSize = true;
            this.callingCode_lbl.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callingCode_lbl.Location = new System.Drawing.Point(3, 195);
            this.callingCode_lbl.Name = "callingCode_lbl";
            this.callingCode_lbl.Size = new System.Drawing.Size(95, 20);
            this.callingCode_lbl.TabIndex = 2;
            this.callingCode_lbl.Text = "Calling code:";
            // 
            // city_lbl
            // 
            this.city_lbl.AutoSize = true;
            this.city_lbl.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_lbl.Location = new System.Drawing.Point(3, 175);
            this.city_lbl.Name = "city_lbl";
            this.city_lbl.Size = new System.Drawing.Size(37, 20);
            this.city_lbl.TabIndex = 2;
            this.city_lbl.Text = "City:";
            // 
            // region_lbl
            // 
            this.region_lbl.AutoSize = true;
            this.region_lbl.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.region_lbl.Location = new System.Drawing.Point(3, 155);
            this.region_lbl.Name = "region_lbl";
            this.region_lbl.Size = new System.Drawing.Size(59, 20);
            this.region_lbl.TabIndex = 2;
            this.region_lbl.Text = "Region:";
            // 
            // countryCode_lbl
            // 
            this.countryCode_lbl.AutoSize = true;
            this.countryCode_lbl.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryCode_lbl.Location = new System.Drawing.Point(3, 135);
            this.countryCode_lbl.Name = "countryCode_lbl";
            this.countryCode_lbl.Size = new System.Drawing.Size(100, 20);
            this.countryCode_lbl.TabIndex = 2;
            this.countryCode_lbl.Text = "Country code:";
            // 
            // country_lbl
            // 
            this.country_lbl.AutoSize = true;
            this.country_lbl.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country_lbl.Location = new System.Drawing.Point(3, 115);
            this.country_lbl.Name = "country_lbl";
            this.country_lbl.Size = new System.Drawing.Size(63, 20);
            this.country_lbl.TabIndex = 2;
            this.country_lbl.Text = "Country:";
            // 
            // continentCode_lbl
            // 
            this.continentCode_lbl.AutoSize = true;
            this.continentCode_lbl.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continentCode_lbl.Location = new System.Drawing.Point(3, 95);
            this.continentCode_lbl.Name = "continentCode_lbl";
            this.continentCode_lbl.Size = new System.Drawing.Size(113, 20);
            this.continentCode_lbl.TabIndex = 2;
            this.continentCode_lbl.Text = "Continent code:";
            // 
            // continent_lbl
            // 
            this.continent_lbl.AutoSize = true;
            this.continent_lbl.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continent_lbl.Location = new System.Drawing.Point(3, 75);
            this.continent_lbl.Name = "continent_lbl";
            this.continent_lbl.Size = new System.Drawing.Size(76, 20);
            this.continent_lbl.TabIndex = 2;
            this.continent_lbl.Text = "Continent:";
            // 
            // ip_lbl
            // 
            this.ip_lbl.AutoSize = true;
            this.ip_lbl.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_lbl.Location = new System.Drawing.Point(3, 55);
            this.ip_lbl.Name = "ip_lbl";
            this.ip_lbl.Size = new System.Drawing.Size(24, 20);
            this.ip_lbl.TabIndex = 2;
            this.ip_lbl.Text = "IP:";
            // 
            // ipEnter_lbl
            // 
            this.ipEnter_lbl.AutoSize = true;
            this.ipEnter_lbl.Location = new System.Drawing.Point(3, 11);
            this.ipEnter_lbl.Name = "ipEnter_lbl";
            this.ipEnter_lbl.Size = new System.Drawing.Size(117, 21);
            this.ipEnter_lbl.TabIndex = 2;
            this.ipEnter_lbl.Text = "Enter IP Adress:";
            // 
            // ipInput_txt
            // 
            this.ipInput_txt.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipInput_txt.Location = new System.Drawing.Point(144, 8);
            this.ipInput_txt.Multiline = true;
            this.ipInput_txt.Name = "ipInput_txt";
            this.ipInput_txt.Size = new System.Drawing.Size(154, 29);
            this.ipInput_txt.TabIndex = 1;
            this.ipInput_txt.Text = "123.110.113.184";
            this.ipInput_txt.TextChanged += new System.EventHandler(this.ipInput_txt_TextChanged);
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemory = 5;
            this.gMapControl.Location = new System.Drawing.Point(319, 12);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 2;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(682, 380);
            this.gMapControl.TabIndex = 3;
            this.gMapControl.Zoom = 0D;
            this.gMapControl.Load += new System.EventHandler(this.gMapControl_Load);
            // 
            // WhoIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 401);
            this.Controls.Add(this.gMapControl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1030, 440);
            this.MinimumSize = new System.Drawing.Size(1030, 440);
            this.Name = "WhoIS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flag_pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button get_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ipInput_txt;
        private System.Windows.Forms.Label ipEnter_lbl;
        private System.Windows.Forms.Label ip_lbl;
        private System.Windows.Forms.Label city_lbl;
        private System.Windows.Forms.Label region_lbl;
        private System.Windows.Forms.Label countryCode_lbl;
        private System.Windows.Forms.Label country_lbl;
        private System.Windows.Forms.Label continentCode_lbl;
        private System.Windows.Forms.Label continent_lbl;
        private System.Windows.Forms.PictureBox flag_pb1;
        private System.Windows.Forms.Label callingCode_lbl;
        private System.Windows.Forms.Label latitude_lbl;
        private System.Windows.Forms.Label capital_lbl;
        private System.Windows.Forms.Label utc_lbl;
        private System.Windows.Forms.Label longitude_lbl;
        private System.Windows.Forms.Label ipResult_lbl;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
    }
}

