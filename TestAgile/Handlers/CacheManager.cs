using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TestAgile.Model;

namespace TestAgile.Utils
{
    class CacheManager
    {
        public PictureList GetCache()
        {
            PictureList output = null;
            string path = Environment.CurrentDirectory; 
            
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(PictureList));
                Stream reader = new FileStream(path + @"/PictureCache.xml", FileMode.Open);

                output = (PictureList)xs.Deserialize(reader);

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("*** Error reading PictureCache.xml ***   -->> " + ex.Message);
            }

            return output;
        }

        public void SetCache(PictureList input)
        {
            try
            {
                string path = Environment.CurrentDirectory;
                XmlSerializer xs = new XmlSerializer(typeof(PictureList));
                TextWriter txtWriter = new StreamWriter(path + @"/PictureCache.xml");

                xs.Serialize(txtWriter, input);

                txtWriter.Close();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
