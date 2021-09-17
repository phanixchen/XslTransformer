using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.txtXmlFile.Text  = "input.xml";
            this.txtXslFile.Text = "rules.xsl";
            this.txtHtmlFile.Text = "output.htm";
            this.txtDotNetString.Text = ".NET Interface";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   User wants to display the file stored in HtmlFile
        /// 			using its default application.  For an HTML file
        /// 			this starts the default browser and passes it 
        /// 			the HTML file name.</summary>
        ///
        /// <remarks>   You can try setting HtmlFile to something else,
        /// 			such as a Word document.   The Display button
        /// 			should start Word and load your document.</remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void cmdDisplay_Click(object sender, EventArgs e)
        {
            XslTransformer.Engine engine = new XslTransformer.Engine();
            engine.HtmlFile = this.txtHtmlFile.Text;
            engine.Display();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   User wants to transform the XML file. 
        /// 			We apply the rules in the XSL transform file to 
        /// 			create the HTML output file</summary>
        ///
        /// <remarks>   V 8i, 04/03/2011. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void cmdTransform_Click(object sender, EventArgs e)
        {
            XslTransformer.Engine engine = new XslTransformer.Engine();
            engine.XmlFile = this.txtXmlFile.Text;
            engine.XslFile = this.txtXslFile.Text;
            engine.HtmlFile = this.txtHtmlFile.Text;
            //  Validate checks that the input files exist and that
            //  the output folder exists
            if (engine.Validate(true))
            {
                engine.Transform();
            }
            else
            {
                MessageBox.Show(engine.ToString());
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Illustrates the .NET-only interface property. </summary>
        ///
        /// <remarks>   V 8i, 04/03/2011. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void cmdSetDotNetString_Click(object sender, EventArgs e)
        {
            XslTransformer.Engine engine = new XslTransformer.Engine();
            engine.DotNetString = this.txtDotNetString.Text;
            MessageBox.Show(".NET String in XslTransformer.Engine=" + engine.DotNetString);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   User wants to browse for the XML file. </summary>
        ///
        /// <remarks>   V 8i, 04/03/2011. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void cmdXmlBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "XML Files|*.xml";
            openFileDialog1.Title = "Select an XML File";
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                this.txtXmlFile.Text = openFileDialog1.FileName;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   User wants to browse for the XSL file. </summary>
        ///
        /// <remarks>   V 8i, 04/03/2011. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void cmdXslBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "XSL Files|*.xsl";
            openFileDialog1.Title = "Select an XSL File";
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                this.txtXslFile.Text = openFileDialog1.FileName;
            }
        }

        private void cmdHtmlBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (DialogResult.OK == browser.ShowDialog())
            {
                this.txtHtmlFile.Text = browser.SelectedPath + "\\output.html";
            }
        }

    }
}
