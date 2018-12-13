using FTN.Common;
using FTN.ServiceContracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace GDAClient
{
    public partial class GDAClientForm
    {
        private void InitializeGetExtentValuesWindow()
        {
            List<DMSType> types = modelResourcesDesc.GetLeaves(ModelCode.IDOBJ);
            object[] typeCollection = types.Select(t => (object)t).ToArray();
            comboBoxTargetType2.Items.AddRange(typeCollection);
        }

        private void comboBoxTargetType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxProperties2.Items.Clear();
            ModelCodeHelper.GetModelCodeFromString(comboBoxTargetType2.SelectedItem.ToString(), out ModelCode modelCode);
            List<ModelCode> properties = modelResourcesDesc.GetAllPropertyIds(modelCode);
            object[] propertyCollection = properties.Select(p => (object)p).ToArray();
            listBoxProperties2.Items.AddRange(propertyCollection);
            buttonQuery2.Enabled = true;
        }

        private void buttonClearProperties2_Click(object sender, EventArgs e)
        {
            listBoxProperties2.ClearSelected();
        }

        private void buttonSelectAllProperties2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxProperties2.Items.Count; i++)
            {
                listBoxProperties2.SetSelected(i, true);
            }
        }

        private void buttonQuery2_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Text = string.Empty;   
            ModelCodeHelper.GetModelCodeFromString(comboBoxTargetType2.SelectedItem.ToString(), out ModelCode entityType);
            List<ModelCode> propertyIDs = new List<ModelCode>();
            foreach (object selectedItem in listBoxProperties2.SelectedItems)
            {
                ModelCodeHelper.GetModelCodeFromString(selectedItem.ToString(), out ModelCode modelCode);
                propertyIDs.Add(modelCode);
            }
            try
            {
                NetworkModelGDAProxy networkModelGDAProxy = new NetworkModelGDAProxy("NetworkModelGDAEndpoint");
                int iteratorID = networkModelGDAProxy.GetExtentValues(entityType, propertyIDs);
                int resourcesLeft = networkModelGDAProxy.IteratorResourcesLeft(iteratorID);
                List<ResourceDescription> resourceDescriptions = null;
                using (StringWriter stringWriter = new StringWriter())
                using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
                {
                    xmlTextWriter.Formatting = Formatting.Indented;
                    while (resourcesLeft > 0)
                    {
                        resourceDescriptions = networkModelGDAProxy.IteratorNext(numberOfResources, iteratorID);
                        foreach (ResourceDescription resourceDescription in resourceDescriptions)
                        {
                            resourceDescription.ExportToXml(xmlTextWriter);
                        }
                        resourcesLeft = networkModelGDAProxy.IteratorResourcesLeft(iteratorID);
                    }
                    richTextBoxOutput.Text = stringWriter.ToString();
                }
                networkModelGDAProxy.IteratorClose(iteratorID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Extent Values - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
