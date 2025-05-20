using System.Collections;
using System.Text.RegularExpressions;

namespace System.Xml.Schema;

internal class StringFacetsChecker : FacetsChecker
{
	private static Regex languagePattern;

	private static Regex LanguagePattern => null;

	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri)
	{
		return null;
	}

	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
	{
		return false;
	}

	private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype)
	{
		return false;
	}

	private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri)
	{
		return null;
	}
}
