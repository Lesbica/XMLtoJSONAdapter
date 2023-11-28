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
                var xmlDoc = XDocument.Parse(xmlData);
                string jsonData = JsonConvert.SerializeXNode(xmlDoc);
                return jsonData;
            }
            catch (Exception ex)
            {
                return $"Error converting XML to JSON: {ex.Message}";
            }
        }
    }
}