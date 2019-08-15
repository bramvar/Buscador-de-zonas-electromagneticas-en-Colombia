namespace proy3
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
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.zoomOutBt = new System.Windows.Forms.Button();
            this.zoomInBt = new System.Windows.Forms.Button();
            this.loadDataBt = new System.Windows.Forms.Button();
            this.locateZonesBt = new System.Windows.Forms.Button();
            this.locateAllOpc = new System.Windows.Forms.RadioButton();
            this.locateByCityOpc = new System.Windows.Forms.RadioButton();
            this.infoBt = new System.Windows.Forms.Button();
            this.cityCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(26, 68);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 100;
            this.map.MinZoom = 1;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(566, 475);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.Map_Load);
            // 
            // zoomOutBt
            // 
            this.zoomOutBt.Location = new System.Drawing.Point(649, 485);
            this.zoomOutBt.Name = "zoomOutBt";
            this.zoomOutBt.Size = new System.Drawing.Size(66, 50);
            this.zoomOutBt.TabIndex = 1;
            this.zoomOutBt.Text = "-";
            this.zoomOutBt.UseVisualStyleBackColor = true;
            this.zoomOutBt.Click += new System.EventHandler(this.ZoomOutBt_Click);
            // 
            // zoomInBt
            // 
            this.zoomInBt.Location = new System.Drawing.Point(736, 485);
            this.zoomInBt.Name = "zoomInBt";
            this.zoomInBt.Size = new System.Drawing.Size(65, 50);
            this.zoomInBt.TabIndex = 2;
            this.zoomInBt.Text = "+";
            this.zoomInBt.UseVisualStyleBackColor = true;
            this.zoomInBt.Click += new System.EventHandler(this.ZoomInBt_Click);
            // 
            // loadDataBt
            // 
            this.loadDataBt.Location = new System.Drawing.Point(404, 12);
            this.loadDataBt.Name = "loadDataBt";
            this.loadDataBt.Size = new System.Drawing.Size(188, 39);
            this.loadDataBt.TabIndex = 3;
            this.loadDataBt.Text = "Load Data";
            this.loadDataBt.UseVisualStyleBackColor = true;
            this.loadDataBt.Click += new System.EventHandler(this.LoadDataBt_Click);
            // 
            // locateZonesBt
            // 
            this.locateZonesBt.Location = new System.Drawing.Point(672, 371);
            this.locateZonesBt.Name = "locateZonesBt";
            this.locateZonesBt.Size = new System.Drawing.Size(115, 44);
            this.locateZonesBt.TabIndex = 4;
            this.locateZonesBt.Text = "locate zones";
            this.locateZonesBt.UseVisualStyleBackColor = true;
            this.locateZonesBt.Click += new System.EventHandler(this.LocateZonesBt_Click);
            // 
            // locateAllOpc
            // 
            this.locateAllOpc.AutoSize = true;
            this.locateAllOpc.Location = new System.Drawing.Point(672, 97);
            this.locateAllOpc.Name = "locateAllOpc";
            this.locateAllOpc.Size = new System.Drawing.Size(90, 21);
            this.locateAllOpc.TabIndex = 5;
            this.locateAllOpc.Text = "Locate all";
            this.locateAllOpc.UseVisualStyleBackColor = true;
            this.locateAllOpc.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // locateByCityOpc
            // 
            this.locateByCityOpc.AutoSize = true;
            this.locateByCityOpc.Location = new System.Drawing.Point(672, 139);
            this.locateByCityOpc.Name = "locateByCityOpc";
            this.locateByCityOpc.Size = new System.Drawing.Size(111, 21);
            this.locateByCityOpc.TabIndex = 6;
            this.locateByCityOpc.TabStop = true;
            this.locateByCityOpc.Text = "locate by city";
            this.locateByCityOpc.UseVisualStyleBackColor = true;
            // 
            // infoBt
            // 
            this.infoBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.infoBt.Location = new System.Drawing.Point(598, 18);
            this.infoBt.Name = "infoBt";
            this.infoBt.Size = new System.Drawing.Size(23, 27);
            this.infoBt.TabIndex = 7;
            this.infoBt.Text = "?";
            this.infoBt.UseVisualStyleBackColor = true;
            this.infoBt.Click += new System.EventHandler(this.InfoBt_Click);
            // 
            // cityCb
            // 
            this.cityCb.FormattingEnabled = true;
            this.cityCb.Location = new System.Drawing.Point(640, 275);
            this.cityCb.Name = "cityCb";
            this.cityCb.Size = new System.Drawing.Size(175, 24);
            this.cityCb.TabIndex = 8;
            this.cityCb.Text = "+";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 547);
            this.Controls.Add(this.cityCb);
            this.Controls.Add(this.infoBt);
            this.Controls.Add(this.locateByCityOpc);
            this.Controls.Add(this.locateAllOpc);
            this.Controls.Add(this.locateZonesBt);
            this.Controls.Add(this.loadDataBt);
            this.Controls.Add(this.zoomInBt);
            this.Controls.Add(this.zoomOutBt);
            this.Controls.Add(this.map);
            this.Name = "Form1";
            this.Text = "MapZEM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Button zoomOutBt;
        private System.Windows.Forms.Button zoomInBt;
        private System.Windows.Forms.Button loadDataBt;
        private System.Windows.Forms.Button locateZonesBt;
        private System.Windows.Forms.RadioButton locateAllOpc;
        private System.Windows.Forms.RadioButton locateByCityOpc;
        private System.Windows.Forms.Button infoBt;
        private System.Windows.Forms.ComboBox cityCb;
    }
}

