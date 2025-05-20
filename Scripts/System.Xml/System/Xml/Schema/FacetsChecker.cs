using System.Collections;
using System.Text;

namespace System.Xml.Schema;

internal abstract class FacetsChecker
{
	private struct FacetsCompiler
	{
		private struct Map
		{
			internal char match;

			internal string replacement;

			internal Map(char m, string r)
			{
				match = '\0';
				replacement = null;
			}
		}

		private DatatypeImplementation datatype;

		private RestrictionFacets derivedRestriction;

		private RestrictionFlags baseFlags;

		private RestrictionFlags baseFixedFlags;

		private RestrictionFlags validRestrictionFlags;

		private XmlSchemaDatatype nonNegativeInt;

		private XmlSchemaDatatype builtInType;

		private XmlTypeCode builtInEnum;

		private bool firstPattern;

		private StringBuilder regStr;

		private XmlSchemaPatternFacet pattern_facet;

		private static readonly Map[] c_map;

		public FacetsCompiler(DatatypeImplementation baseDatatype, RestrictionFacets restriction)
		{
			datatype = null;
			derivedRestriction = null;
			baseFlags = default(RestrictionFlags);
			baseFixedFlags = default(RestrictionFlags);
			validRestrictionFlags = default(RestrictionFlags);
			nonNegativeInt = null;
			builtInType = null;
			builtInEnum = default(XmlTypeCode);
			firstPattern = false;
			regStr = null;
			pattern_facet = null;
		}

		internal void CompileLengthFacet(XmlSchemaFacet facet)
		{
		}

		internal void CompileMinLengthFacet(XmlSchemaFacet facet)
		{
		}

		internal void CompileMaxLengthFacet(XmlSchemaFacet facet)
		{
		}

		internal void CompilePatternFacet(XmlSchemaPatternFacet facet)
		{
		}

		internal void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable)
		{
		}

		internal void CompileWhitespaceFacet(XmlSchemaFacet facet)
		{
		}

		internal void CompileMaxInclusiveFacet(XmlSchemaFacet facet)
		{
		}

		internal void CompileMaxExclusiveFacet(XmlSchemaFacet facet)
		{
		}

		internal void CompileMinInclusiveFacet(XmlSchemaFacet facet)
		{
		}

		internal void CompileMinExclusiveFacet(XmlSchemaFacet facet)
		{
		}

		internal void CompileTotalDigitsFacet(XmlSchemaFacet facet)
		{
		}

		internal void CompileFractionDigitsFacet(XmlSchemaFacet facet)
		{
		}

		internal void FinishFacetCompile()
		{
		}

		private void CheckValue(object value, XmlSchemaFacet facet)
		{
		}

		internal void CompileFacetCombinations()
		{
		}

		private void CopyFacetsFromBaseType()
		{
		}

		private object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable)
		{
			return null;
		}

		private static string Preprocess(string pattern)
		{
			return null;
		}

		private void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode)
		{
		}

		private void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode)
		{
		}

		private void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag)
		{
		}

		private void SetFlag(RestrictionFlags flag)
		{
		}
	}

	internal virtual Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal virtual Exception CheckValueFacets(decimal value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal virtual Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype)
	{
		return null;
	}

	internal void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype)
	{
	}

	internal Exception CheckPatternFacets(RestrictionFacets restriction, string value)
	{
		return null;
	}

	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype)
	{
		return false;
	}

	internal virtual RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable)
	{
		return null;
	}

	internal static decimal Power(int x, int y)
	{
		return default(decimal);
	}
}
