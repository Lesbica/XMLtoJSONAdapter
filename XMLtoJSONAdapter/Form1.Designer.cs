namespace XMLtoJSONAdapter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            radioXmlToJson = new RadioButton();
            radioJsonToXml = new RadioButton();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // radioXmlToJson
            // 
            radioXmlToJson.AutoSize = true;
            radioXmlToJson.Location = new Point(12, 40);
            radioXmlToJson.Name = "radioXmlToJson";
            radioXmlToJson.Size = new Size(100, 24);
            radioXmlToJson.TabIndex = 0;
            radioXmlToJson.TabStop = true;
            radioXmlToJson.Text = "XmlToJson";
            radioXmlToJson.UseVisualStyleBackColor = true;
            radioXmlToJson.CheckedChanged += radioXmlToJson_CheckedChanged;
            // 
            // radioJsonToXml
            // 
            radioJsonToXml.AutoSize = true;
            radioJsonToXml.Location = new Point(12, 85);
            radioJsonToXml.Name = "radioJsonToXml";
            radioJsonToXml.Size = new Size(100, 24);
            radioJsonToXml.TabIndex = 1;
            radioJsonToXml.TabStop = true;
            radioJsonToXml.Text = "JsonToXml";
            radioJsonToXml.UseVisualStyleBackColor = true;
            radioJsonToXml.CheckedChanged += radioJsonToXml_CheckedChanged;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(89, 134);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(281, 164);
            txtInput.TabIndex = 2;
            // 
            // txtOutput
            // 
            txtOutput.Enabled = false;
            txtOutput.Location = new Point(89, 304);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(281, 162);
            txtOutput.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 141);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 4;
            label1.Text = "Input";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 304);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 5;
            label2.Text = "Output";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(12, 472);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(94, 29);
            btnConvert.TabIndex = 6;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 562);
            Controls.Add(btnConvert);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(radioJsonToXml);
            Controls.Add(radioXmlToJson);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioXmlToJson;
        private RadioButton radioJsonToXml;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Label label1;
        private Label label2;
        private Button btnConvert;
    }
}