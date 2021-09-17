#include "XslTransformerWrapper.h"
#include <vcclr.h>

using namespace System;
using namespace XslTransformer;

////////////////////////////////////////////////////////////////////////////////////////////////////
/// <summary>	Xsl Transformer wrapper implementation class. 
/// 			The class definition and implementation are both in this file.</summary>
///
/// <remarks>	V 8i, 05/03/2011. </remarks>
////////////////////////////////////////////////////////////////////////////////////////////////////
class XslTransformerWrapperImpl
{
	gcroot<XslTransformer::Engine ^>	engine_;

public:

	////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary>	Pass-through methods </summary>
	////////////////////////////////////////////////////////////////////////////////////////////////////
	bool			Display			()	const					{	return engine_->Display ();	}
	bool			Transform		()	const					{	return engine_->Transform ();	}
	bool			Validate		(bool		alert)	const	{	return engine_->Validate (alert);	}
	////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary>	Pass-through properties </summary>
	////////////////////////////////////////////////////////////////////////////////////////////////////
	CString			XmlFile			()	const;
	void			XmlFile			(CString const&	s);
	CString			XslFile			()	const;
	void			XslFile			(CString const&	s);
	CString			HtmlFile		()	const;
	void			HtmlFile		(CString const&	s);
	CString			DotNetString	()	const;
	void			DotNetString	(CString const&	s);

	XslTransformerWrapperImpl	()
	{
		engine_ = gcnew XslTransformer::Engine ();
	}
	~XslTransformerWrapperImpl	()
	{
	}
private:
	////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary>	No copying or assignment </summary>
	XslTransformerWrapperImpl	(XslTransformerWrapperImpl const&);
	XslTransformerWrapperImpl&	operator=(XslTransformerWrapperImpl const&);
};
////////////////////////////////////////////////////////////////////////////////////////////////////
/// <summary>	The C++ wrapper class. </summary>
///
/// <remarks>	V 8i, 05/03/2011. </remarks>
////////////////////////////////////////////////////////////////////////////////////////////////////
XslTransformerWrapper::XslTransformerWrapper	()
: pimpl_	(new XslTransformerWrapperImpl ())
{
}
XslTransformerWrapper::~XslTransformerWrapper	()
{
	delete pimpl_;
}
////////////////////////////////////////////////////////////////////////////////////////////////////
bool		XslTransformerWrapper::Validate			(bool			alert)	const
{
	return pimpl_->Validate (alert);
}
////////////////////////////////////////////////////////////////////////////////////////////////////
bool		XslTransformerWrapper::Display			()	const
{
	return pimpl_->Display ();
}
////////////////////////////////////////////////////////////////////////////////////////////////////
bool		XslTransformerWrapper::Transform		()	const
{
	return pimpl_->Transform ();
}
////////////////////////////////////////////////////////////////////////////////////////////////////
CString		XslTransformerWrapper::XmlFile			()	const	{	return pimpl_->XmlFile ();	}
void		XslTransformerWrapper::XmlFile			(CString const&	xml)	{	pimpl_->XmlFile (xml);	}
////////////////////////////////////////////////////////////////////////////////////////////////////
CString		XslTransformerWrapper::XslFile			()	const	{	return pimpl_->XslFile ();	}
void		XslTransformerWrapper::XslFile			(CString const&	xsl)	{	pimpl_->XslFile (xsl);	}
////////////////////////////////////////////////////////////////////////////////////////////////////
CString		XslTransformerWrapper::HtmlFile			()	const	{	return pimpl_->HtmlFile ();	}
void		XslTransformerWrapper::HtmlFile			(CString const&	html)	{	pimpl_->HtmlFile (html);	}
////////////////////////////////////////////////////////////////////////////////////////////////////
CString		XslTransformerWrapper::DotNetString		()	const	{	return pimpl_->DotNetString ();	}
void		XslTransformerWrapper::DotNetString		(CString const&	s)	{	pimpl_->DotNetString (s);	}
////////////////////////////////////////////////////////////////////////////////////////////////////
CString		XslTransformerWrapperImpl::XmlFile	()	const	{	return engine_->XmlFile;	}
void		XslTransformerWrapperImpl::XmlFile	(CString const&	s)
{ 
	String ^systemstring = gcnew String(s);
	engine_->XmlFile	= systemstring;	
	delete systemstring;
}
////////////////////////////////////////////////////////////////////////////////////////////////////
CString		XslTransformerWrapperImpl::XslFile	()	const	{	return engine_->XslFile;	}
void		XslTransformerWrapperImpl::XslFile	(CString const&	s)
{ 
	String ^systemstring = gcnew String(s);
	engine_->XslFile	= systemstring;	
	delete systemstring;
}
////////////////////////////////////////////////////////////////////////////////////////////////////
CString		XslTransformerWrapperImpl::HtmlFile	()	const	{	return engine_->HtmlFile;	}
void		XslTransformerWrapperImpl::HtmlFile	(CString const&	s)
{ 
	String ^systemstring = gcnew String(s);
	engine_->HtmlFile	= systemstring;	
	delete systemstring;
}
////////////////////////////////////////////////////////////////////////////////////////////////////
CString		XslTransformerWrapperImpl::DotNetString	()	const	{	return engine_->DotNetString;	}
void		XslTransformerWrapperImpl::DotNetString	(CString const&	s)
{ 
	String ^systemstring = gcnew String(s);
	engine_->DotNetString	= systemstring;	
	delete systemstring;
}
////////////////////////////////////////////////////////////////////////////////////////////////////

