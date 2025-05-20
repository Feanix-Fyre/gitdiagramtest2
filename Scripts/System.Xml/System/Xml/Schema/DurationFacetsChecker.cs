using System.Collections;

namespace System.Xml.Schema;

internal class DurationFacetsChecker : FacetsChecker
{
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
	{
		return false;
	}

	private bool MatchEnumeration(TimeSpan value, ArrayList enumeration)
	{
		return false;
	}
}
