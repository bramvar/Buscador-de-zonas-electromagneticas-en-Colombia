using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class ZoneEM
    {
        private String name;
        private String city;
        private double longit;
        private double lat;
        private double measuredValueZoneEM;
        

        public ZoneEM(String name, String city, double lat, double longit, double mvz)
        {
            this.name = name;
            this.city = city;
            this.longit = longit;
            this.lat = lat;
            measuredValueZoneEM = mvz;
          
        }

        public String Name { get => name; set => name = value; }
        public double Lat { get => lat; set => lat = value; }
        public double Longit { get => longit; set => longit = value; }
    }
}
