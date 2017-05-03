using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCProject.SensorPackage
{
    public class SensorParser
    {
        public String filename { get; set; }
        public List<String> tags { get; set; }
        public System.IO.StreamReader file { get; set; }

        public SensorParser(string fname)
        {
            this.filename = fname;
            file = new System.IO.StreamReader(@filename);

            //read the first line of the file and save it as exploded list
            //then store tags
            tags = readLine().Split(',').ToList<String>();
        }

        public List<String> getDataTags()
        {
            return tags;
        }

        public string readLine()
        { ///advance to the next line in the file if it isn't at the end.
          ///if at the end, return "null"
          ///else return the line
            // string line = "";
            string line = file.ReadLine();

            if (line != null)
            {
                return line;
            }
            else
            {
                return "null";
            }
        }

        //DEBUG - remove this function before deployment
        public void readFile()
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@filename);
            while ((line = file.ReadLine()) != null)
            {
                foreach(String s in line.Split(','))
                {
                    System.Console.Write(s + " ");
                }
                System.Console.WriteLine();
                counter++;
            }

            file.Close();
        }
    }
}
