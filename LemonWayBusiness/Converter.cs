using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace LemonWayBusiness
{
    public static class Converter
    {
        public static string XmlToJson(string xml)
        {
            try
            {
                XmlDocument doc = new XmlDocument();

                doc.LoadXml(xml);

                return JsonConvert.SerializeXmlNode(doc);
            }
            catch (XmlException)
            {
                return "Bad Xml format";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
