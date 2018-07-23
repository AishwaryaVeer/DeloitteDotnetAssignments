using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Assignment3_3
{
    class XMLFile
    {
        List<Parts> p = new List<Parts>();

        public XMLFile()
        {
            p.Add(new Parts { Item = "Motherboard", Manufacturer = "ASUS", Model = "P3B-F", Cost = 123.00 });

            p.Add(new Parts { Item = "Video Card", Manufacturer = "ATI", Model = "All-in-Wonder Pro", Cost = 160.00 });

            p.Add(new Parts { Item = "Sound Card", Manufacturer = "Creative Labs", Model = "Sound Blaster Live", Cost = 80.00 });

            p.Add(new Parts { Item = "inch Monitor", Manufacturer = "LG Electronics", Model = "995E", Cost = 290.00 });
        }

        public void Write()
        {
            XmlWriter w = XmlWriter.Create("c:\\Files\\Parts.xml");
            w.WriteStartDocument();
            w.WriteStartElement("PARTS");
            foreach (var b in p)
            {
                w.WriteStartElement("PART");
                w.WriteElementString("ITEM", b.Item);
                w.WriteElementString("MANUFACTURER", b.Manufacturer);
                w.WriteElementString("MODEL", b.Model);
                w.WriteElementString("COST", b.Cost.ToString());
                
                w.WriteEndElement();

            }
            w.WriteEndElement();
            w.WriteEndDocument();
            w.Close();
            Console.WriteLine("XML created");
        }

        public void Read()
        {
            XElement xe = XElement.Load("c:\\Files\\Parts.xml");
            var data = xe.Elements();

            Console.WriteLine("a)=============================================================================\n");
            //display all elements 
            foreach (var d in data)
            {

                Console.WriteLine(d);
            }

            Console.WriteLine("b)=============================================================================\n");
            //display all parts details whose price is greater than 150 

            var data2 = from t in xe.Elements("PART")
                        where (int)t.Element("COST") > 150
                        select t;


            foreach (var d in data2)
            {
                Console.WriteLine(d);

            }

            Console.WriteLine("c)=============================================================================\n");
            //display item and cost for all parts 
            foreach (var d in data)

            {
                Console.WriteLine(d.Element("ITEM").Value + " " + d.Element("COST").Value);
            }

        }

    }
}
