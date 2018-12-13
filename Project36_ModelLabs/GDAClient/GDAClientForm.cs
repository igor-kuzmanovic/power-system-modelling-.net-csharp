using FTN.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDAClient
{
    public partial class GDAClientForm : Form
    {
        private const string outputPath = @"..\Output\GDAClient_Output.xml";
        private const string globalIDRegex = "0x0000000[1-9][a-fA-F0-9]{7}[a-fA-F1-9]";
        private const int numberOfResources = 100;

        private static ModelResourcesDesc modelResourcesDesc = new ModelResourcesDesc();

        public GDAClientForm()
        {
            InitializeComponent();

            InitializeOutputWindow();
            InitializeGetValuesWindow();
            InitializeGetExtentValuesWindow();
            InitializeGetRelatedValuesWindow();
        }
    }
}
