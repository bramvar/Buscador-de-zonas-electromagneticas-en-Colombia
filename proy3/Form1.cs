using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;

namespace proy3
{
    public partial class Form1 : Form
    {
        MapCenter mc;
 
        public Form1()
        {
            InitializeComponent();
            mc = new MapCenter();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            map.SetPositionByKeywords("Colombia, Bogota"); 
            
        }

        private void LoadDataBt_Click(object sender, EventArgs e)
        {
            String path;
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                path = openFile.FileName;
                mc.loadData(path);
                setEnableLocateTools(true);
            }
        }

        private void ZoomOutBt_Click(object sender, EventArgs e)
        {
            map.Zoom -= 3;
        }

        private void ZoomInBt_Click(object sender, EventArgs e)
        {
            map.Zoom += 3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setEnableLocateTools(false);
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
        }

        private void setEnableLocateTools(Boolean b)
        {
            locateAllOpc.Enabled = b;
            locateByCityOpc.Enabled = b;
            locateZonesBt.Enabled = b;
        }

        private void LocateZonesBt_Click(object sender, EventArgs e)
        {
        ;
            foreach(var aux in mc.Zones)
            {
                GMapOverlay  markOv = new GMapOverlay("marker");
                GMarkerGoogle mark = new GMarkerGoogle(new GMap.NET.PointLatLng(aux.Lat, aux.Longit),GMarkerGoogleType.red);
                markOv.Markers.Add(mark);

                mark.ToolTipMode = MarkerTooltipMode.Always;
                mark.ToolTipText = string.Format("Lat: " + aux.Lat + "\n" + "Lng: " + aux.Longit);

                map.Overlays.Add(markOv);
               // Console.WriteLine(aux.Name + " ");
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InfoBt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have to load data to enable the options below", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
