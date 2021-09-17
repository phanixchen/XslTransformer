#ifndef LA_SOLUTIONS_XSL_TRANSFORMER_WRAPPER_H_INCLUDED_
#define LA_SOLUTIONS_XSL_TRANSFORMER_WRAPPER_H_INCLUDED_
#pragma once
#include <atlstr.h>		//	For CString

////////////////////////////////////////////////////////////////////////////////////////////////////
/// <summary>	Forward declaration of our implementation class </summary>
/// <remarks> Use of the PIMPL idiom isolates the .NET implementation from a C++ client.</remarks>
class XslTransformerWrapperImpl;
//---------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////////////////////////
/// <summary>	The public interface to this wrapper. 
/// 			Everything here is standard C++, so a client C++ application
/// 			can #include this and link to its lib..
/// 			C++ clients do not see any CLR stuff.</summary>
///
/// <remarks>	The project is built with the /CLR switch, so that the implementation
/// 			can call into the .NET server.
/// 			Standard C++ clients of this lib. do not need to use the /CLR switch. </remarks>
////////////////////////////////////////////////////////////////////////////////////////////////////
class XslTransformerWrapper
{
	////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary>Pointer to a class defined in XslTransformerWrapper.cpp that wraps the CLR-dependent class. </summary>
	/// <remarks>The PIMPL idiom</remarks>
	XslTransformerWrapperImpl*	pimpl_;		

public:
	////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary>	Get/Set the XML source data file. </summary>
	////////////////////////////////////////////////////////////////////////////////////////////////////
	CString					XmlFile			()	const;
	void					XmlFile			(CString const&	xml);
	////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary>	Get/Set the XSL rules file. </summary>
	////////////////////////////////////////////////////////////////////////////////////////////////////
	CString					XslFile			()	const;
	void					XslFile			(CString const&	xsl);
	////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary>	Get/Set the HTML output file. </summary>
	////////////////////////////////////////////////////////////////////////////////////////////////////
	CString					HtmlFile		()	const;
	void					HtmlFile		(CString const&	html);
	////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary>	Get/Set a String property in the .NET DLL interface. </summary>
	/// <remarks>   Illustrates that we can call non-COM interface properties.</remarks>
	////////////////////////////////////////////////////////////////////////////////////////////////////
	CString					DotNetString	()	const;
	void					DotNetString	(CString const&	html);

	////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary>	Validates the input file paths and the output file folder</summary>
	/// <remarks>	V 8i, 06/03/2011. </remarks>
	/// <param name="alert">Pass true to tell the DLL to pop a dialog if a file or folder does not exist. </param>
	/// <returns>	true if the files & paths exist, false if any test fails. </returns>
	////////////////////////////////////////////////////////////////////////////////////////////////////
	bool					Validate		(bool			alert	= false)	const;

	////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary>	Displays the output file using its default application.
	/// 			If the output file is an HTML file, for example, it will display 
	/// 			using the user's default browser such as Firefox.
	/// 			</summary>
	/// <remarks>	This method works for any output file, not only HTML.
	/// 			For example, if you set the Html file to 'C:\folder\word\myfile.doc'
	/// 			then Display starts Word and instructs it to open 'myfile.doc'.</remarks>
	/// <returns>	true if it succeeds, false if it fails. </returns>
	////////////////////////////////////////////////////////////////////////////////////////////////////
	bool					Display			()	const;
	////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary>	Instructs the DLL to apply the XSL rules to the XML data file 
	/// 			and create the HTML output file. </summary>
	/// <remarks>	V 8i, 06/03/2011. </remarks>
	/// <returns>	true if it succeeds, false if it fails. </returns>
	////////////////////////////////////////////////////////////////////////////////////////////////////
	bool					Transform		()	const;
	////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary>	Default standard constructors and destructor. </summary>
	/// <remarks>	V 8i, 05/03/2011. </remarks>
	////////////////////////////////////////////////////////////////////////////////////////////////////
	XslTransformerWrapper	();
	~XslTransformerWrapper	();
private:
	///	<summary>No copying or assignment of this class</summary>
	XslTransformerWrapper	(XslTransformerWrapper const& rhs);
	XslTransformerWrapper&	operator=(XslTransformerWrapper const& rhs);
};

#endif  // LA_SOLUTIONS_XSL_TRANSFORMER_WRAPPER_H_INCLUDED_
