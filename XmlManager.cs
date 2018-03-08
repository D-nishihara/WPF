using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WpfApp1
{

    public class XmlManager
    {
        public string Value;
        public void Xmlcreater(string value)
        {

            const string xmlFile = @"C:\test\test.xml";

            var xmlhozi = new Xmlhozi();
            xmlhozi.text = value;

            var xmlSerializer1 = new XmlSerializer(typeof(Xmlhozi));
            using (var streamWriter = new StreamWriter(xmlFile, true, Encoding.UTF8))
            {
                xmlSerializer1.Serialize(streamWriter, xmlhozi);
                streamWriter.Flush();


                //streamWriter.Write(value.Text);
                //streamWriter.Close();
                //xmlSerializer1.Serialize(streamWriter, xmltext);
            }

        }

    }

    public class Xmlhozi
    {
        public string text;
    }
}
