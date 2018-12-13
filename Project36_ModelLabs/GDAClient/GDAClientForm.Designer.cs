namespace GDAClient
{
    partial class GDAClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonQuery1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxProperties1 = new System.Windows.Forms.ListBox();
            this.buttonClearProperties1 = new System.Windows.Forms.Button();
            this.buttonSelectAllProperties1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTargetGID1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonQuery2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxProperties2 = new System.Windows.Forms.ListBox();
            this.buttonClearProperties2 = new System.Windows.Forms.Button();
            this.buttonSelectAllProperties2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTargetType2 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTargetType3 = new System.Windows.Forms.ComboBox();
            this.buttonQuery3 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBoxProperties3 = new System.Windows.Forms.ListBox();
            this.buttonClearProperties3 = new System.Windows.Forms.Button();
            this.buttonSelectAllProperties3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSourceReference3 = new System.Windows.Forms.ComboBox();
            this.textBoxSourceGID3 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.buttonSaveOutput = new System.Windows.Forms.Button();
            this.buttonClearOutput = new System.Windows.Forms.Button();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonQuery1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(536, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Get Values";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonQuery1
            // 
            this.buttonQuery1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuery1.Enabled = false;
            this.buttonQuery1.Location = new System.Drawing.Point(455, 371);
            this.buttonQuery1.Name = "buttonQuery1";
            this.buttonQuery1.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery1.TabIndex = 2;
            this.buttonQuery1.Text = "Query";
            this.buttonQuery1.UseVisualStyleBackColor = true;
            this.buttonQuery1.Click += new System.EventHandler(this.buttonQuery1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.listBoxProperties1);
            this.groupBox2.Controls.Add(this.buttonClearProperties1);
            this.groupBox2.Controls.Add(this.buttonSelectAllProperties1);
            this.groupBox2.Location = new System.Drawing.Point(249, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 357);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Properties";
            // 
            // listBoxProperties1
            // 
            this.listBoxProperties1.FormattingEnabled = true;
            this.listBoxProperties1.HorizontalScrollbar = true;
            this.listBoxProperties1.Location = new System.Drawing.Point(6, 19);
            this.listBoxProperties1.Name = "listBoxProperties1";
            this.listBoxProperties1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxProperties1.Size = new System.Drawing.Size(269, 290);
            this.listBoxProperties1.Sorted = true;
            this.listBoxProperties1.TabIndex = 3;
            // 
            // buttonClearProperties1
            // 
            this.buttonClearProperties1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearProperties1.Location = new System.Drawing.Point(6, 315);
            this.buttonClearProperties1.Name = "buttonClearProperties1";
            this.buttonClearProperties1.Size = new System.Drawing.Size(75, 23);
            this.buttonClearProperties1.TabIndex = 2;
            this.buttonClearProperties1.Text = "Clear";
            this.buttonClearProperties1.UseVisualStyleBackColor = true;
            this.buttonClearProperties1.Click += new System.EventHandler(this.buttonClearProperties1_Click);
            // 
            // buttonSelectAllProperties1
            // 
            this.buttonSelectAllProperties1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelectAllProperties1.Location = new System.Drawing.Point(200, 315);
            this.buttonSelectAllProperties1.Name = "buttonSelectAllProperties1";
            this.buttonSelectAllProperties1.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectAllProperties1.TabIndex = 1;
            this.buttonSelectAllProperties1.Text = "Select All";
            this.buttonSelectAllProperties1.UseVisualStyleBackColor = true;
            this.buttonSelectAllProperties1.Click += new System.EventHandler(this.buttonSelectAllProperties1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxTargetGID1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "GID";
            // 
            // textBoxTargetGID1
            // 
            this.textBoxTargetGID1.Location = new System.Drawing.Point(69, 19);
            this.textBoxTargetGID1.MaxLength = 18;
            this.textBoxTargetGID1.Name = "textBoxTargetGID1";
            this.textBoxTargetGID1.Size = new System.Drawing.Size(162, 20);
            this.textBoxTargetGID1.TabIndex = 0;
            this.textBoxTargetGID1.Text = "0x";
            this.textBoxTargetGID1.TextChanged += new System.EventHandler(this.textBoxTargetGID1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonQuery2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(536, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Get Extent Values";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonQuery2
            // 
            this.buttonQuery2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuery2.Enabled = false;
            this.buttonQuery2.Location = new System.Drawing.Point(455, 371);
            this.buttonQuery2.Name = "buttonQuery2";
            this.buttonQuery2.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery2.TabIndex = 2;
            this.buttonQuery2.Text = "Query";
            this.buttonQuery2.UseVisualStyleBackColor = true;
            this.buttonQuery2.Click += new System.EventHandler(this.buttonQuery2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.listBoxProperties2);
            this.groupBox4.Controls.Add(this.buttonClearProperties2);
            this.groupBox4.Controls.Add(this.buttonSelectAllProperties2);
            this.groupBox4.Location = new System.Drawing.Point(249, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 357);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties";
            // 
            // listBoxProperties2
            // 
            this.listBoxProperties2.FormattingEnabled = true;
            this.listBoxProperties2.HorizontalScrollbar = true;
            this.listBoxProperties2.Location = new System.Drawing.Point(6, 19);
            this.listBoxProperties2.Name = "listBoxProperties2";
            this.listBoxProperties2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxProperties2.Size = new System.Drawing.Size(269, 290);
            this.listBoxProperties2.TabIndex = 2;
            // 
            // buttonClearProperties2
            // 
            this.buttonClearProperties2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearProperties2.Location = new System.Drawing.Point(6, 315);
            this.buttonClearProperties2.Name = "buttonClearProperties2";
            this.buttonClearProperties2.Size = new System.Drawing.Size(75, 23);
            this.buttonClearProperties2.TabIndex = 1;
            this.buttonClearProperties2.Text = "Clear";
            this.buttonClearProperties2.UseVisualStyleBackColor = true;
            this.buttonClearProperties2.Click += new System.EventHandler(this.buttonClearProperties2_Click);
            // 
            // buttonSelectAllProperties2
            // 
            this.buttonSelectAllProperties2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelectAllProperties2.Location = new System.Drawing.Point(200, 315);
            this.buttonSelectAllProperties2.Name = "buttonSelectAllProperties2";
            this.buttonSelectAllProperties2.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectAllProperties2.TabIndex = 0;
            this.buttonSelectAllProperties2.Text = "Select All";
            this.buttonSelectAllProperties2.UseVisualStyleBackColor = true;
            this.buttonSelectAllProperties2.Click += new System.EventHandler(this.buttonSelectAllProperties2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBoxTargetType2);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 59);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Target";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // comboBoxTargetType2
            // 
            this.comboBoxTargetType2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTargetType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTargetType2.DropDownWidth = 162;
            this.comboBoxTargetType2.FormattingEnabled = true;
            this.comboBoxTargetType2.Location = new System.Drawing.Point(69, 19);
            this.comboBoxTargetType2.MaxDropDownItems = 9;
            this.comboBoxTargetType2.Name = "comboBoxTargetType2";
            this.comboBoxTargetType2.Size = new System.Drawing.Size(162, 21);
            this.comboBoxTargetType2.TabIndex = 0;
            this.comboBoxTargetType2.SelectedIndexChanged += new System.EventHandler(this.comboBoxTargetType2_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Controls.Add(this.buttonQuery3);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(536, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Get Related Values";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.AutoSize = true;
            this.groupBox9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox9.Controls.Add(this.label5);
            this.groupBox9.Controls.Add(this.comboBoxTargetType3);
            this.groupBox9.Location = new System.Drawing.Point(6, 97);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(237, 59);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Target";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Type";
            // 
            // comboBoxTargetType3
            // 
            this.comboBoxTargetType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTargetType3.DropDownWidth = 162;
            this.comboBoxTargetType3.Enabled = false;
            this.comboBoxTargetType3.FormattingEnabled = true;
            this.comboBoxTargetType3.Location = new System.Drawing.Point(69, 19);
            this.comboBoxTargetType3.MaxDropDownItems = 9;
            this.comboBoxTargetType3.Name = "comboBoxTargetType3";
            this.comboBoxTargetType3.Size = new System.Drawing.Size(162, 21);
            this.comboBoxTargetType3.TabIndex = 0;
            this.comboBoxTargetType3.SelectedIndexChanged += new System.EventHandler(this.comboBoxTargetType3_SelectedIndexChanged);
            // 
            // buttonQuery3
            // 
            this.buttonQuery3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuery3.Location = new System.Drawing.Point(455, 371);
            this.buttonQuery3.Name = "buttonQuery3";
            this.buttonQuery3.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery3.TabIndex = 2;
            this.buttonQuery3.Text = "Query";
            this.buttonQuery3.UseVisualStyleBackColor = true;
            this.buttonQuery3.Click += new System.EventHandler(this.buttonQuery3_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox6.Controls.Add(this.listBoxProperties3);
            this.groupBox6.Controls.Add(this.buttonClearProperties3);
            this.groupBox6.Controls.Add(this.buttonSelectAllProperties3);
            this.groupBox6.Location = new System.Drawing.Point(249, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(281, 357);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Properties";
            // 
            // listBoxProperties3
            // 
            this.listBoxProperties3.FormattingEnabled = true;
            this.listBoxProperties3.HorizontalScrollbar = true;
            this.listBoxProperties3.Location = new System.Drawing.Point(6, 19);
            this.listBoxProperties3.Name = "listBoxProperties3";
            this.listBoxProperties3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxProperties3.Size = new System.Drawing.Size(269, 290);
            this.listBoxProperties3.TabIndex = 2;
            // 
            // buttonClearProperties3
            // 
            this.buttonClearProperties3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearProperties3.Location = new System.Drawing.Point(6, 315);
            this.buttonClearProperties3.Name = "buttonClearProperties3";
            this.buttonClearProperties3.Size = new System.Drawing.Size(75, 23);
            this.buttonClearProperties3.TabIndex = 1;
            this.buttonClearProperties3.Text = "Clear";
            this.buttonClearProperties3.UseVisualStyleBackColor = true;
            this.buttonClearProperties3.Click += new System.EventHandler(this.buttonClearProperties3_Click);
            // 
            // buttonSelectAllProperties3
            // 
            this.buttonSelectAllProperties3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelectAllProperties3.Location = new System.Drawing.Point(200, 315);
            this.buttonSelectAllProperties3.Name = "buttonSelectAllProperties3";
            this.buttonSelectAllProperties3.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectAllProperties3.TabIndex = 0;
            this.buttonSelectAllProperties3.Text = "Select All";
            this.buttonSelectAllProperties3.UseVisualStyleBackColor = true;
            this.buttonSelectAllProperties3.Click += new System.EventHandler(this.buttonSelectAllProperties3_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.comboBoxSourceReference3);
            this.groupBox5.Controls.Add(this.textBoxSourceGID3);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(237, 85);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Reference";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "GID";
            // 
            // comboBoxSourceReference3
            // 
            this.comboBoxSourceReference3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSourceReference3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSourceReference3.DropDownWidth = 324;
            this.comboBoxSourceReference3.Enabled = false;
            this.comboBoxSourceReference3.FormattingEnabled = true;
            this.comboBoxSourceReference3.Location = new System.Drawing.Point(69, 45);
            this.comboBoxSourceReference3.MaxDropDownItems = 9;
            this.comboBoxSourceReference3.Name = "comboBoxSourceReference3";
            this.comboBoxSourceReference3.Size = new System.Drawing.Size(162, 21);
            this.comboBoxSourceReference3.TabIndex = 0;
            this.comboBoxSourceReference3.SelectedIndexChanged += new System.EventHandler(this.comboBoxSourceReference3_SelectedIndexChanged);
            // 
            // textBoxSourceGID3
            // 
            this.textBoxSourceGID3.Location = new System.Drawing.Point(69, 19);
            this.textBoxSourceGID3.MaxLength = 18;
            this.textBoxSourceGID3.Name = "textBoxSourceGID3";
            this.textBoxSourceGID3.Size = new System.Drawing.Size(162, 20);
            this.textBoxSourceGID3.TabIndex = 0;
            this.textBoxSourceGID3.Text = "0x";
            this.textBoxSourceGID3.TextChanged += new System.EventHandler(this.textBoxSourceGID3_TextChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.AutoSize = true;
            this.groupBox7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox7.Controls.Add(this.buttonSaveOutput);
            this.groupBox7.Controls.Add(this.buttonClearOutput);
            this.groupBox7.Controls.Add(this.richTextBoxOutput);
            this.groupBox7.Location = new System.Drawing.Point(562, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(526, 426);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Output";
            // 
            // buttonSaveOutput
            // 
            this.buttonSaveOutput.Enabled = false;
            this.buttonSaveOutput.Location = new System.Drawing.Point(445, 383);
            this.buttonSaveOutput.Name = "buttonSaveOutput";
            this.buttonSaveOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveOutput.TabIndex = 2;
            this.buttonSaveOutput.Text = "Save";
            this.buttonSaveOutput.UseVisualStyleBackColor = true;
            this.buttonSaveOutput.Click += new System.EventHandler(this.buttonSaveOutput_Click);
            // 
            // buttonClearOutput
            // 
            this.buttonClearOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearOutput.Location = new System.Drawing.Point(6, 384);
            this.buttonClearOutput.Name = "buttonClearOutput";
            this.buttonClearOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonClearOutput.TabIndex = 1;
            this.buttonClearOutput.Text = "Clear";
            this.buttonClearOutput.UseVisualStyleBackColor = true;
            this.buttonClearOutput.Click += new System.EventHandler(this.buttonClearOutput_Click);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.AcceptsTab = true;
            this.richTextBoxOutput.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxOutput.Location = new System.Drawing.Point(6, 22);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(514, 356);
            this.richTextBoxOutput.TabIndex = 0;
            this.richTextBoxOutput.Text = "";
            this.richTextBoxOutput.WordWrap = false;
            this.richTextBoxOutput.TextChanged += new System.EventHandler(this.richTextBoxOutput_TextChanged);
            // 
            // GDAClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "GDAClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GDA Client";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonClearProperties1;
        private System.Windows.Forms.Button buttonSelectAllProperties1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTargetGID1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonQuery1;
        private System.Windows.Forms.Button buttonQuery2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonClearProperties2;
        private System.Windows.Forms.Button buttonSelectAllProperties2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxTargetType2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxSourceGID3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonClearProperties3;
        private System.Windows.Forms.Button buttonSelectAllProperties3;
        private System.Windows.Forms.Button buttonQuery3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox comboBoxTargetType3;
        private System.Windows.Forms.ComboBox comboBoxSourceReference3;
        private System.Windows.Forms.ListBox listBoxProperties1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxProperties2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxProperties3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonClearOutput;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Button buttonSaveOutput;
    }
}

