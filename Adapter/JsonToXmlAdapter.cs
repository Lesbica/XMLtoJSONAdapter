using System.Xml.Linq;
using Newtonsoft.Json;

namespace Adapter
{
    public class JsonToXmlAdapter : IDataAdapter
    {
        public string ConvertData(string jsonData)
        {
            try
            {
                var xmlData = JsonConvert.DeserializeXNode(jsonData, "Root");
                return xmlData.ToString();
            }
            catch (Exception ex)
            {
                return $"Error converting JSON to XML: {ex.Message}";
            }
        }
    }
}
