using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WpfApp1
{
    public class Class1
    {
        public string Value;
    }

    public class Class2
    {

        public void Xml(string a)
        {

            MainWindow main = new MainWindow();

            const string xmlFile = @"C:\test\test.xml";

            Class1 obj = new Class1();
            obj.Value = a;

            var xmlSerializer1 = new XmlSerializer(typeof(Class1));
            using (var streamWriter = new StreamWriter(xmlFile, true, Encoding.UTF8))
            {
                xmlSerializer1.Serialize(streamWriter, obj);
                streamWriter.Flush();
            }

        }

        public void Xmlwrite(string value)
        {
            Class1 class1 = new Class1();
            //Class1.Value = value;
            Xml(value);
        }
    }
}
