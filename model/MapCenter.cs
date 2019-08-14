using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
   public class MapCenter
    {
        List<ZoneEM> zones;

        public MapCenter()
        {
            zones = new List<ZoneEM>();
        }

        public List<ZoneEM> Zones { get=>zones; set=>zones=value; }

        public void loadData(String l)
        {
            String link = l;
            Console.WriteLine(link);
            String line = "";
            ZoneEM aux;

            StreamReader read = new StreamReader(@link);

            try
            {
                line = read.ReadLine();

                while (line != null)
                {
                    String[] coll = line.Split(',');

                    double lat = Convert.ToDouble(coll[0]);
                    double longit = Convert.ToDouble(coll[1]);
                    String name = coll[2];
                    double valueZ = Convert.ToDouble(coll[6]);

                    Console.WriteLine(coll.Length + "\n" + lat + " " + longit + " " + name + " " + valueZ);
                    aux = new ZoneEM(name, lat, longit, valueZ);
                    zones.Add(aux);
                   
                    line = read.ReadLine();
                    
                }

                Console.WriteLine("*********"+zones.Count);
                Console.WriteLine(zones[1].Name);
            }
            catch
            {

            }
        }
    }
}
