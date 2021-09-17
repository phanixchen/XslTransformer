namespace Client
{
    partial class Form1
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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXmlFile = new System.Windows.Forms.TextBox();
            this.txtXslFile = new System.Windows.Forms.TextBox();
            this.cmdTransform = new System.Windows.Forms.Button();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHtmlFile = new System.Windows.Forms.TextBox();
            this.cmdDisplay = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdXmlBrowse = new System.Windows.Forms.Button();
            this.cmdXslBrowse = new System.Windows.Forms.Button();
            this.cmdHtmlBrowse = new System.Windows.Forms.Button();
            this.grpDotNet = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDotNetString = new System.Windows.Forms.TextBox();
            this.cmdSetDotNetString = new System.Windows.Forms.Button();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.grpDotNet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.cmdXslBrowse);
            this.grpInput.Controls.Add(this.cmdXmlBrowse);
            this.grpInput.Controls.Add(this.txtXslFile);
            this.grpInput.Controls.Add(this.txtXmlFile);
            this.grpInput.Controls.Add(this.label2);
            this.grpInput.Controls.Add(this.label1);
            this.grpInput.Location = new System.Drawing.Point(3, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(372, 86);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input Files";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "XML Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "XSL Rules:";
            // 
            // txtXmlFile
            // 
            this.txtXmlFile.Location = new System.Drawing.Point(116, 25);
            this.txtXmlFile.Name = "txtXmlFile";
            this.txtXmlFile.Size = new System.Drawing.Size(215, 22);
            this.txtXmlFile.TabIndex = 2;
            // 
            // txtXslFile
            // 
            this.txtXslFile.Location = new System.Drawing.Point(116, 55);
            this.txtXslFile.Name = "txtXslFile";
            this.txtXslFile.Size = new System.Drawing.Size(215, 22);
            this.txtXslFile.TabIndex = 3;
            // 
            // cmdTransform
            // 
            this.cmdTransform.Location = new System.Drawing.Point(119, 104);
            this.cmdTransform.Name = "cmdTransform";
            this.cmdTransform.Size = new System.Drawing.Size(124, 25);
            this.cmdTransform.TabIndex = 1;
            this.cmdTransform.Text = "Transform";
            this.cmdTransform.UseVisualStyleBackColor = true;
            this.cmdTransform.Click += new System.EventHandler(this.cmdTransform_Click);
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.cmdHtmlBrowse);
            this.grpOutput.Controls.Add(this.cmdDisplay);
            this.grpOutput.Controls.Add(this.txtHtmlFile);
            this.grpOutput.Controls.Add(this.label3);
            this.grpOutput.Location = new System.Drawing.Point(2, 149);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(372, 93);
            this.grpOutput.TabIndex = 2;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "HTML File:";
            // 
            // txtHtmlFile
            // 
            this.txtHtmlFile.Location = new System.Drawing.Point(117, 20);
            this.txtHtmlFile.Name = "txtHtmlFile";
            this.txtHtmlFile.Size = new System.Drawing.Size(215, 22);
            this.txtHtmlFile.TabIndex = 4;
            // 
            // cmdDisplay
            // 
            this.cmdDisplay.Location = new System.Drawing.Point(117, 55);
            this.cmdDisplay.Name = "cmdDisplay";
            this.cmdDisplay.Size = new System.Drawing.Size(124, 25);
            this.cmdDisplay.TabIndex = 5;
            this.cmdDisplay.Text = "Display";
            this.cmdDisplay.UseVisualStyleBackColor = true;
            this.cmdDisplay.Click += new System.EventHandler(this.cmdDisplay_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdOK.Location = new System.Drawing.Point(261, 336);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(103, 26);
            this.cmdOK.TabIndex = 3;
            this.cmdOK.Text = "Done";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdXmlBrowse
            // 
            this.cmdXmlBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdXmlBrowse.Location = new System.Drawing.Point(337, 21);
            this.cmdXmlBrowse.Name = "cmdXmlBrowse";
            this.cmdXmlBrowse.Size = new System.Drawing.Size(33, 26);
            this.cmdXmlBrowse.TabIndex = 4;
            this.cmdXmlBrowse.Text = "...";
            this.cmdXmlBrowse.UseVisualStyleBackColor = true;
            this.cmdXmlBrowse.Click += new System.EventHandler(this.cmdXmlBrowse_Click);
            // 
            // cmdXslBrowse
            // 
            this.cmdXslBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdXslBrowse.Location = new System.Drawing.Point(337, 54);
            this.cmdXslBrowse.Name = "cmdXslBrowse";
            this.cmdXslBrowse.Size = new System.Drawing.Size(33, 26);
            this.cmdXslBrowse.TabIndex = 5;
            this.cmdXslBrowse.Text = "...";
            this.cmdXslBrowse.UseVisualStyleBackColor = true;
            this.cmdXslBrowse.Click += new System.EventHandler(this.cmdXslBrowse_Click);
            // 
            // cmdHtmlBrowse
            // 
            this.cmdHtmlBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHtmlBrowse.Location = new System.Drawing.Point(338, 20);
            this.cmdHtmlBrowse.Name = "cmdHtmlBrowse";
            this.cmdHtmlBrowse.Size = new System.Drawing.Size(33, 26);
            this.cmdHtmlBrowse.TabIndex = 6;
            this.cmdHtmlBrowse.Text = "...";
            this.cmdHtmlBrowse.UseVisualStyleBackColor = true;
            this.cmdHtmlBrowse.Click += new System.EventHandler(this.cmdHtmlBrowse_Click);
            // 
            // grpDotNet
            // 
            this.grpDotNet.Controls.Add(this.cmdSetDotNetString);
            this.grpDotNet.Controls.Add(this.txtDotNetString);
            this.grpDotNet.Controls.Add(this.label4);
            this.grpDotNet.Location = new System.Drawing.Point(7, 251);
            this.grpDotNet.Name = "grpDotNet";
            this.grpDotNet.Size = new System.Drawing.Size(367, 64);
            this.grpDotNet.TabIndex = 4;
            this.grpDotNet.TabStop = false;
            this.grpDotNet.Text = ".NET Clients Only";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = ".NET String:";
            // 
            // txtDotNetString
            // 
            this.txtDotNetString.Location = new System.Drawing.Point(116, 22);
            this.txtDotNetString.Name = "txtDotNetString";
            this.txtDotNetString.Size = new System.Drawing.Size(179, 22);
            this.txtDotNetString.TabIndex = 1;
            // 
            // cmdSetDotNetString
            // 
            this.cmdSetDotNetString.Location = new System.Drawing.Point(301, 21);
            this.cmdSetDotNetString.Name = "cmdSetDotNetString";
            this.cmdSetDotNetString.Size = new System.Drawing.Size(56, 35);
            this.cmdSetDotNetString.TabIndex = 2;
            this.cmdSetDotNetString.Text = "Set";
            this.cmdSetDotNetString.UseVisualStyleBackColor = true;
            this.cmdSetDotNetString.Click += new System.EventHandler(this.cmdSetDotNetString_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdOK;
            this.ClientSize = new System.Drawing.Size(376, 374);
            this.Controls.Add(this.grpDotNet);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.cmdTransform);
            this.Controls.Add(this.grpInput);
            this.Name = "Form1";
            this.Text = "XSL Transformer Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.grpDotNet.ResumeLayout(false);
            this.grpDotNet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TextBox txtXslFile;
        private System.Windows.Forms.TextBox txtXmlFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdTransform;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Button cmdDisplay;
        private System.Windows.Forms.TextBox txtHtmlFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdXslBrowse;
        private System.Windows.Forms.Button cmdXmlBrowse;
        private System.Windows.Forms.Button cmdHtmlBrowse;
        private System.Windows.Forms.GroupBox grpDotNet;
        private System.Windows.Forms.Button cmdSetDotNetString;
        private System.Windows.Forms.TextBox txtDotNetString;
        private System.Windows.Forms.Label label4;
    }
}

