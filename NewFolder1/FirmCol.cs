using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba4
{
    public class FirmCol
    {
        static private List<Passenger> firms;

        static public void add_pass(Passenger passenger)
        {
            firms.Add(passenger);
        }

        static public List<Passenger> get_firms()
        {
            return firms;
        }

        static public void AddPassFromFile()
        {
            firms = new List<Passenger>();
            FileStream file = new FileStream("data.csv", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file, Encoding.GetEncoding(1251));

            string str;
            Passenger new_firm;
            while ((str = reader.ReadLine()) != null)
            {
                new_firm = new Passenger();
                string[] elements = str.Split(';');

                for (int i = 0; i < elements.Count<string>(); ++i)
                {
                    new_firm.fields[i].SetValue(elements[i]);
                }
                firms.Add(new_firm);
            }
            reader.Close();
            file.Close();
        }
        
    }
}
