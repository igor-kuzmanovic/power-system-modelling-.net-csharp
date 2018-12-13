using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GDAClient
{
    public partial class GDAClientForm
    {
        private void InitializeOutputWindow()
        {
        }

        private void richTextBoxOutput_TextChanged(object sender, EventArgs e)
        {
            buttonSaveOutput.Enabled = false;
            if (richTextBoxOutput.Text.Any())
            {
                buttonSaveOutput.Enabled = true;
            }
        }

        private void buttonClearOutput_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Text = string.Empty;
        }

        private void buttonSaveOutput_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.SaveFile(outputPath, RichTextBoxStreamType.UnicodePlainText);
            MessageBox.Show($"Output saved to: '{outputPath}'.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
