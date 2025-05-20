using System.Collections;

namespace System.Xml.Schema;

internal class Numeric2FacetsChecker : FacetsChecker
{
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal override Exception CheckValueFacets(double value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal override Exception CheckValueFacets(float value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
	{
		return false;
	}

	private bool MatchEnumeration(double value, ArrayList enumeration, XmlValueConverter valueConverter)
	{
		return false;
	}
}
