using Adapter;

namespace XMLtoJSONAdapter
{
    public partial class Form1 : Form
    {

        private IDataAdapter dataAdapter;

        public Form1()
        {
            InitializeComponent();
            dataAdapter = new XmlToJsonAdapter();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string inputData = txtInput.Text;
            string resultData = dataAdapter.ConvertData(inputData);
            txtOutput.Text = resultData;
        }

        private void radioXmlToJson_CheckedChanged(object sender, EventArgs e)
        {
            if (radioXmlToJson.Checked)
                dataAdapter = new XmlToJsonAdapter();
        }

        private void radioJsonToXml_CheckedChanged(object sender, EventArgs e)
        {
            if (radioJsonToXml.Checked)
                dataAdapter = new JsonToXmlAdapter();
        }
    }
}