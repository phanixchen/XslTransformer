using System;
using System.Collections.Generic;
using System.Linq;
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
    [Guid("4A15229C-0872-4beb-AEC5-1047DFD0C255"), Description("XslTransformer class interface")]
    public interface IEngine
    {
        /// <remarks>
        /// DispId(0) is default COM property
        /// </remarks>
        [DispId(0), Description("XslTransformer description")]
        String ToString { get; }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the input XML file </summary>
        [DispId(1), Description("XML File Name")]
        String XmlFile { get; set; }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the input XSL transform file </summary>
        [DispId(2), Description("XSL File Name")]
        String XslFile { get; set; }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the output HTML file </summary>
        [DispId(3), Description("HTML File Name")]
        String HtmlFile { get; set; }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Transforms the XML input using the XSL rules to create the HTML output </summary>
        [DispId(4), Description("HTML File Name")]
        bool Transform();
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>  Displays the HTML output in the default web browser </summary>
        [DispId(5), Description("Displays the HTML output")]
        bool Display();
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>  Verifies that necessary files exist and that the output folder exists.</summary>
        /// <remarks>If argument <code>showAlert</code> is true, pop a message box</remarks>
        [DispId(6), Description("Verify that XML and XSL files exist, and that the HTML folder exists")]
        bool Validate(bool showAlert);
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>This interface member is not exposed to COM.</summary>
        /// <remarks>An alternative ToString</remarks>
        String DotNetString { get; set; }
    }
}
