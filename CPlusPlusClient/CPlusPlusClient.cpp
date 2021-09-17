// CPlusPlusClient.cpp : main project file.

#include "stdafx.h"

using namespace System;
using namespace XslTransformer;

int main(array<System::String ^> ^args)
{
	if (2 < args->Length)
	{
		Console::WriteLine (L"XSL Transformer C++ Client xml: {0} xsl:{1} html:{2}", args [0], args [1], args [2]);
		//Console::WriteLine (L"XSL Transformer C++ Client xml:{0} ", args [0], args [1], args [2]);
		XslTransformer::Engine^ engine = gcnew XslTransformer::Engine ();
		engine->XmlFile = args [0];
		engine->XslFile = args [1];
		engine->HtmlFile = args [2];
		if (engine->Validate (true))
		{
			if (engine->Transform ())
			{
				engine->Display ();
			}
		}
	}
	else
	{
		Console::WriteLine(L"XSL Transformer: insufficent args.  Usage: CPlusPlusClient [in] xml, [in] xsl, [out] html");
	}
    return 0;
}
