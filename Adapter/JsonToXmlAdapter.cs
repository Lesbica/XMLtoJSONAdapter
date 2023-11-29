using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Adapter
{
    public class JsonToXmlAdapter : IDataAdapter
    {
        public string ConvertData(string jsonData)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlNode rootNode = JsonConvertToXmlNode(jsonData, xmlDoc);
                xmlDoc.AppendChild(rootNode);

                return xmlDoc.OuterXml;
            }
            catch (Exception ex)
            {
                return $"Error converting JSON to XML: {ex.Message}";
            }
        }

        private XmlNode JsonConvertToXmlNode(string jsonData, XmlDocument xmlDoc)
        {
            var jsonObject = JsonConvert.DeserializeObject<JObject>(jsonData);
            return ConvertJsonToXmlNode(jsonObject, xmlDoc);
        }

        private XmlNode ConvertJsonToXmlNode(JObject jsonObject, XmlDocument xmlDoc)
        {
            var rootElement = xmlDoc.CreateElement("Root");

            foreach (var property in jsonObject.Properties())
            {
                var childNode = ConvertJsonToXmlNode(property.Name, property.Value, xmlDoc);
                rootElement.AppendChild(childNode);
            }

            return rootElement;
        }

        private XmlNode ConvertJsonToXmlNode(string nodeName, JToken token, XmlDocument xmlDoc)
        {
            var node = xmlDoc.CreateElement(nodeName);

            switch (token.Type)
            {
                case JTokenType.Object:
                    var jsonObject = (JObject)token;
                    foreach (var property in jsonObject.Properties())
                    {
                        var childNode = ConvertJsonToXmlNode(property.Name, property.Value, xmlDoc);
                        node.AppendChild(childNode);
                    }
                    break;

                case JTokenType.Array:
                    var jsonArray = (JArray)token;
                    foreach (var arrayItem in jsonArray)
                    {
                        var childNode = ConvertJsonToXmlNode("Item", arrayItem, xmlDoc);
                        node.AppendChild(childNode);
                    }
                    break;

                case JTokenType.Null:
                    break;

                default:
                    node.InnerText = token.ToString();
                    break;
            }

            return node;
        }
    }
}
