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
        private void InitializeGetRelatedValuesWindow()
        {
        }

        private void textBoxSourceGID3_TextChanged(object sender, EventArgs e)
        {
            buttonQuery3.Enabled = false;
            listBoxProperties3.Items.Clear();
            comboBoxSourceReference3.Items.Clear();
            comboBoxSourceReference3.Enabled = false;
            comboBoxTargetType3.Items.Clear();
            comboBoxTargetType3.Enabled = false;
            if (Regex.IsMatch(textBoxSourceGID3.Text, globalIDRegex))
            {
                long globalID = Convert.ToInt64(textBoxSourceGID3.Text, 16);
                DMSType type = (DMSType)ModelCodeHelper.ExtractTypeFromGlobalId(globalID);
                List<ModelCode> references = modelResourcesDesc.GetPropertyIds(type, PropertyType.Reference);
                references.AddRange(modelResourcesDesc.GetPropertyIds(type, PropertyType.ReferenceVector));
                object[] referenceCollection = references.Select(p => (object)p).ToArray();
                comboBoxSourceReference3.Items.AddRange(referenceCollection);
                comboBoxSourceReference3.Enabled = true;
            }
        }

        private void comboBoxSourceReference3_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonQuery3.Enabled = false;
            listBoxProperties3.Items.Clear();
            comboBoxTargetType3.Items.Clear();
            comboBoxTargetType3.Enabled = false;     
            ModelCodeHelper.GetModelCodeFromString(comboBoxSourceReference3.SelectedItem.ToString(), out ModelCode modelCode);
            List<DMSType> types = new List<DMSType>();
            switch (modelCode)
            {
                case ModelCode.CONDUCTINGEQUIPMENT_TERMINALS:
                    types.Add(DMSType.TERMINAL);
                    break;
                case ModelCode.CONTROL_REGULATINGCONDEQ:
                    types.AddRange(modelResourcesDesc.GetLeaves(ModelCode.REGULATINGCONDEQ));
                    break;
                case ModelCode.CURVEDATA_CURVE:
                    types.AddRange(modelResourcesDesc.GetLeaves(ModelCode.CURVE));
                    break;
                case ModelCode.CURVE_CURVEDATAS:
                    types.Add(DMSType.CURVEDATA);
                    break;
                case ModelCode.REACTIVECAPABILITYCURVE_SYNCHRONOUSMACHINES:
                    types.Add(DMSType.SYNCHRONOUSMACHINE);
                    break;
                case ModelCode.REGULATINGCONDEQ_CONTROLS:
                    types.Add(DMSType.CONTROL);
                    break;
                case ModelCode.REGULATINGCONTROL_TERMINAL:
                    types.Add(DMSType.TERMINAL);
                    break;
                case ModelCode.SYNCHRONOUSMACHINE_REACTIVECAPABILITYCURVES:
                    types.Add(DMSType.REACTIVECAPABILITYCURVE);
                    break;
                case ModelCode.TERMINAL_CONDUCTINGEQUIPMENT:
                    types.AddRange(modelResourcesDesc.GetLeaves(ModelCode.CONDUCTINGEQUIPMENT));
                    break;
                case ModelCode.TERMINAL_REGULATINGCONTROL:
                    types.Add(DMSType.REGULATINGCONTROL);
                    break;
            }
            object[] typeCollection = types.Select(t => (object)t).ToArray();
            comboBoxTargetType3.Items.Add("ANY");
            comboBoxTargetType3.Items.AddRange(typeCollection);
            comboBoxTargetType3.Enabled = true;
        }

        private void comboBoxTargetType3_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonQuery3.Enabled = false;
            listBoxProperties3.Items.Clear();
            List<ModelCode> properties = new List<ModelCode>();
            if (comboBoxTargetType3.SelectedItem.ToString() == "ANY")
            {
                ModelCodeHelper.GetModelCodeFromString(comboBoxSourceReference3.SelectedItem.ToString(), out ModelCode modelCode);
                switch (modelCode)
                {
                    case ModelCode.CONDUCTINGEQUIPMENT_TERMINALS:
                        modelCode = ModelCode.TERMINAL;
                        break;
                    case ModelCode.CONTROL_REGULATINGCONDEQ:
                        modelCode = ModelCode.REGULATINGCONDEQ;
                        break;
                    case ModelCode.CURVEDATA_CURVE:
                        modelCode = ModelCode.CURVE;
                        break;
                    case ModelCode.CURVE_CURVEDATAS:
                        modelCode = ModelCode.CURVEDATA;
                        break;
                    case ModelCode.REACTIVECAPABILITYCURVE_SYNCHRONOUSMACHINES:
                        modelCode = ModelCode.SYNCHRONOUSMACHINE;
                        break;
                    case ModelCode.REGULATINGCONDEQ_CONTROLS:
                        modelCode = ModelCode.CONTROL;
                        break;
                    case ModelCode.REGULATINGCONTROL_TERMINAL:
                        modelCode = ModelCode.TERMINAL;
                        break;
                    case ModelCode.SYNCHRONOUSMACHINE_REACTIVECAPABILITYCURVES:
                        modelCode = ModelCode.REACTIVECAPABILITYCURVE;
                        break;
                    case ModelCode.TERMINAL_CONDUCTINGEQUIPMENT:
                        modelCode = ModelCode.CONDUCTINGEQUIPMENT;
                        break;
                    case ModelCode.TERMINAL_REGULATINGCONTROL:
                        modelCode = ModelCode.REGULATINGCONTROL;
                        break;
                }
                List<DMSType> types = modelResourcesDesc.GetLeaves(modelCode);
                Dictionary<ModelCode, int> propertyCount = new Dictionary<ModelCode, int>();
                foreach (DMSType type in types)
                {
                    List<ModelCode> typeProperties = modelResourcesDesc.GetAllPropertyIds(type);
                    foreach (ModelCode property in typeProperties)
                    {
                        if (!propertyCount.ContainsKey(property))
                        {
                            propertyCount.Add(property, 0);
                        }
                        propertyCount[property]++;
                        if (propertyCount[property] == types.Count)
                        {
                            properties.Add(property);
                        }
                    }
                }
            }
            else
            {
                ModelCodeHelper.GetModelCodeFromString(comboBoxTargetType3.SelectedItem.ToString(), out ModelCode modelCode);
                properties.AddRange(modelResourcesDesc.GetAllPropertyIds(modelCode));
            }
            object[] propertyCollection = properties.Select(p => (object)p).ToArray();
            listBoxProperties3.Items.AddRange(propertyCollection);
            buttonQuery3.Enabled = true;
        }

        private void buttonClearProperties3_Click(object sender, EventArgs e)
        {
            listBoxProperties3.ClearSelected();
        }

        private void buttonSelectAllProperties3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxProperties3.Items.Count; i++)
            {
                listBoxProperties3.SetSelected(i, true);
            }
        }

        private void buttonQuery3_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Text = string.Empty;
            long source = Convert.ToInt64(textBoxSourceGID3.Text, 16);
            Association association = new Association();
            ModelCodeHelper.GetModelCodeFromString(comboBoxSourceReference3.SelectedItem.ToString(), out ModelCode propertyID);
            association.PropertyId = propertyID;
            if (comboBoxTargetType3.SelectedItem.ToString() == "ANY")
            {
                association.Type = 0;
            }
            else
            {
                ModelCodeHelper.GetModelCodeFromString(comboBoxTargetType3.SelectedItem.ToString(), out ModelCode type);
                association.Type = type;
            }
            List<ModelCode> propertyIDs = new List<ModelCode>();
            foreach (object selectedItem in listBoxProperties3.SelectedItems)
            {
                ModelCodeHelper.GetModelCodeFromString(selectedItem.ToString(), out ModelCode modelCode);
                propertyIDs.Add(modelCode);
            }
            try
            {
                NetworkModelGDAProxy networkModelGDAProxy = new NetworkModelGDAProxy("NetworkModelGDAEndpoint");
                int iteratorID = networkModelGDAProxy.GetRelatedValues(source, propertyIDs, association);
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
                            stringWriter.Write(stringWriter.NewLine);
                        }
                        resourcesLeft = networkModelGDAProxy.IteratorResourcesLeft(iteratorID);
                    }
                    richTextBoxOutput.Text = stringWriter.ToString();
                }
                networkModelGDAProxy.IteratorClose(iteratorID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Related Values - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
