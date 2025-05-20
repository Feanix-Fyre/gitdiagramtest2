using System.Collections;

namespace System.Xml.Schema;

internal class Numeric10FacetsChecker : FacetsChecker
{
	private static readonly char[] signs;

	private decimal maxValue;

	private decimal minValue;

	internal Numeric10FacetsChecker(decimal minVal, decimal maxVal)
	{
	}

	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal override Exception CheckValueFacets(decimal value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
	{
		return false;
	}

	internal bool MatchEnumeration(decimal value, ArrayList enumeration, XmlValueConverter valueConverter)
	{
		return false;
	}

	internal Exception CheckTotalAndFractionDigits(decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction)
	{
		return null;
	}
}
