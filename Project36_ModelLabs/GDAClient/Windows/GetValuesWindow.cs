using FTN.Common;
using FTN.ServiceContracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace GDAClient
{
    public partial class GDAClientForm
    {
        private void InitializeGetValuesWindow()
        {
        }

        private void textBoxTargetGID1_TextChanged(object sender, EventArgs e)
        {
            buttonQuery1.Enabled = false;
            listBoxProperties1.Items.Clear();
            if (Regex.IsMatch(textBoxTargetGID1.Text, globalIDRegex))
            {
                long globalID = Convert.ToInt64(textBoxTargetGID1.Text, 16);
                short type = ModelCodeHelper.ExtractTypeFromGlobalId(globalID);
                List<ModelCode> properties = modelResourcesDesc.GetAllPropertyIds(type);
                object[] propertyCollection = properties.Select(p => (object)p).ToArray();
                listBoxProperties1.Items.AddRange(propertyCollection);
                buttonQuery1.Enabled = true;
            }
        }

        private void buttonClearProperties1_Click(object sender, EventArgs e)
        {
            listBoxProperties1.ClearSelected();
        }

        private void buttonSelectAllProperties1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxProperties1.Items.Count; i++)
            {
                listBoxProperties1.SetSelected(i, true);
            }
        }

        private void buttonQuery1_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Text = string.Empty;
            long resourceID = Convert.ToInt64(textBoxTargetGID1.Text, 16);
            List<ModelCode> propertyIDs = new List<ModelCode>();
            foreach(object selectedItem in listBoxProperties1.SelectedItems)
            {
                propertyIDs.Add((ModelCode)selectedItem);
            }
            NetworkModelGDAProxy networkModelGDAProxy = new NetworkModelGDAProxy("NetworkModelGDAEndpoint");
            try
            {
                ResourceDescription resourceDescription = networkModelGDAProxy.GetValues(resourceID, propertyIDs);
                using (StringWriter stringWriter = new StringWriter())
                {
                    using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
                    {
                        xmlTextWriter.Formatting = Formatting.Indented;
                        resourceDescription.ExportToXml(xmlTextWriter);
                    }
                    richTextBoxOutput.Text = stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Values - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
