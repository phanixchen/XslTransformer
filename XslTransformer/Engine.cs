using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Runtime.InteropServices;    //  Defines ClassInterfaceAttribute
using System.ComponentModel;             //  Provides Description attribute

namespace XslTransformer
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   The XmlTransformer.Engine processes an XML data file
    /// 			using XSL rules to create an HTML output file.
    /// 			<para>Usage: set the three file names, then call the Transform method.</para>. 
    /// 			<para>The Engine will complain if either of the two input files does not exist,
    /// 				  or if the specified folder of the output file does not exist.</para>. 
    /// 				  </summary>
    ///
    /// <remarks>   V 8i, 02/03/2011. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    [Guid("786ABA15-86A8-4b62-8272-621C88C30C1E"), Description("XslTransformer class")]
    [ComVisible(true), ClassInterface(ClassInterfaceType.None)]
    public class Engine : IEngine
    {
        /// <summary>
        /// Default constructor for a XslTransformer::Engine instance.
        /// This parameterless constructor is required by COM
        /// </summary>
        public Engine() { }
         /// <summary>
        /// Describe this XslTransformer Engine
        /// </summary>
        [ComVisible(true), Description("Description of this XslTransformer Engine")]
        public new String ToString
        {
            get
            {
                StringBuilder s = new StringBuilder();
                s.AppendFormat("XslTransformer::Engine XML file [in] {0} XSL file [in] {1} HTML file [out] {2}", XmlFile, XslFile, HtmlFile);
                return s.ToString();
            }
        }
        /// <summary>
        /// Get/set the XML File Name
        /// </summary>
        [ComVisible(true), Description("XML File Name")]
        public String XmlFile { get; set; }
        /// <summary>
        /// Get/set the XSL File Name
        /// </summary>
        [ComVisible(true), Description("XSL File Name")]
        public String XslFile { get; set; }
        /// <summary>
        /// Get/set the HTML File Name
        /// </summary>
        [ComVisible(true), Description("HTML File Name")]
        public String HtmlFile { get; set; }
        /// <summary>
        /// Transform the input XML file using the XSL rules to create the HTML output
        /// </summary>
        [ComVisible(true), Description("Execute tranformation")]
        public bool Transform()
        {
            bool transformed = false;
            XElement report = XElement.Load(XmlFile);
            if (!report.IsEmpty)
            {
                System.Xml.XmlReader reader = System.Xml.XmlReader.Create(XmlFile);
                // Create and load the transform with script execution enabled.
                System.Xml.Xsl.XslCompiledTransform transform = new System.Xml.Xsl.XslCompiledTransform();
                System.Xml.Xsl.XsltSettings settings = new System.Xml.Xsl.XsltSettings();
                settings.EnableScript = false;
                transform.Load(XslFile, settings, null);
                //  Transfer the xsl:output specification to our XmlWriter
                System.Xml.XmlWriter result = System.Xml.XmlWriter.Create(HtmlFile, transform.OutputSettings);
                // Execute the transformation.
                transform.Transform(reader, result);
                result.Close();
                transformed = true;
            }
            return transformed;
        }
        /// <summary>
        /// Display the HTML output in the default browser
        /// </summary>
        [ComVisible(true), Description("Display the HTML output in the default browser")]
        public bool Display()
        {
            bool displayed = false;
            if (0 != HtmlFile.Length)
            {
                System.Diagnostics.Process.Start(HtmlFile);
                displayed = true;
            }
            return displayed;
        }
        /// <summary>
        /// Verify that XML and XSL files exist and that the HTML output folder exists
        /// </summary>
        /// <returns>True if files &amp; folder exist</returns>
        [ComVisible(true), Description("Verify that XML and XSL files exist and that the HTML output folder exists")]
        public bool Validate(bool   showAlert)
        {
            int nValid = 0;
            FileChecker checker = new FileChecker(XmlFile);
            if (checker.IsValidFile(showAlert))
            {
                ++nValid;
            }

            checker.FilePath = XslFile;
            if (checker.IsValidFile(showAlert))
            {
                ++nValid;
            }

            checker.FilePath = checker.GetDirectoryName(HtmlFile);
            if (checker.IsValidPath (showAlert))
            {
                ++nValid;
            }

            return 3 == nValid;
        }
        /// <summary>
        /// This interface property works only with a .NET client
        /// </summary>
        [ComVisible(false), Description("Property visible only to .NET")]
        public String DotNetString { get; set; }
    }
}
