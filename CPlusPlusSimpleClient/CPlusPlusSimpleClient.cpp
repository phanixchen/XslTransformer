// CPlusPlusSimpleClient.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

//#include "O:/Viz Studio 2008/Projects/XslTransformer/CPlusPlusWrapper/XslTransformerWrapper.h"
//	Note: the include folder is set in the Tools|Options dialog,
//	Projects & Solutions branch, VC++ Directories leaf, option Show Directories for Include Files
#include <XslTransformerWrapper.h>
#include <iostream>

int _tmain(int argc, _TCHAR* argv[])
{
	enum StringControl { BufferSize = 128, };
	TCHAR buffer [BufferSize];
	_sntprintf_s (buffer, BufferSize, BufferSize, _T("%s: argc %d\n"), argv [0], argc);
	std::wcout << buffer;
	for (int i = 0; i != argc; ++i)
	{
		_sntprintf_s (buffer, BufferSize, BufferSize, _T("arg [%d] %s\n"), i, argv [i]);
		std::wcout << buffer;
	}

	XslTransformerWrapper	wrapper;
	if (3 < argc)
	{
		//	With C++, argv [0] is the application name
		wrapper.XmlFile		(argv [1]);
		wrapper.XslFile		(argv [2]);
		wrapper.HtmlFile	(argv [3]);
		if (wrapper.Validate (true)
			&&
			wrapper.Transform ())
		{
			wrapper.Display ();
		}
	}
	else
	{
		std::wcout << _T("XSL Transformer: insufficent args.  Usage: CPlusPlusClient.exe [in] xml, [in] xsl, [out] html");
	}
	return 0;
}

