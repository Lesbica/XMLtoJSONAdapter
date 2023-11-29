using System.Text;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace Adapter
{
    public class XmlToJsonAdapter : IDataAdapter
    {
        public string ConvertData(string xmlData)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xmlData);

                StringBuilder jsonBuilder = new StringBuilder();
                ConvertXmlNodeToJson(xmlDoc.DocumentElement, jsonBuilder);

                return jsonBuilder.ToString();
            }
            catch (Exception ex)
            {
                return $"Error converting XML to JSON: {ex.Message}";
            }
        }

        private void ConvertXmlNodeToJson(XmlNode node, StringBuilder jsonBuilder)
        {
            switch (node.NodeType)
            {
                case XmlNodeType.Element:
                    jsonBuilder.Append("{");
                    jsonBuilder.Append($"\"{node.Name}\": ");
                    if (node.HasChildNodes)
                    {
                        jsonBuilder.Append("[");
                        foreach (XmlNode childNode in node.ChildNodes)
                        {
                            ConvertXmlNodeToJson(childNode, jsonBuilder);
                            jsonBuilder.Append(",");
                        }
                        jsonBuilder.Remove(jsonBuilder.Length - 1, 1); // Remove trailing comma
                        jsonBuilder.Append("]");
                    }
                    else
                    {
                        jsonBuilder.Append("null");
                    }
                    jsonBuilder.Append("}");
                    break;
                case XmlNodeType.Text:
                    jsonBuilder.Append($"\"{node.InnerText}\"");
                    break;
            }
        }
    }
}