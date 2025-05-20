using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace System.Xml;

internal class DtdParser : IDtdParser
{
	private enum Token
	{
		CDATA = 0,
		ID = 1,
		IDREF = 2,
		IDREFS = 3,
		ENTITY = 4,
		ENTITIES = 5,
		NMTOKEN = 6,
		NMTOKENS = 7,
		NOTATION = 8,
		None = 9,
		PERef = 10,
		AttlistDecl = 11,
		ElementDecl = 12,
		EntityDecl = 13,
		NotationDecl = 14,
		Comment = 15,
		PI = 16,
		CondSectionStart = 17,
		CondSectionEnd = 18,
		Eof = 19,
		REQUIRED = 20,
		IMPLIED = 21,
		FIXED = 22,
		QName = 23,
		Name = 24,
		Nmtoken = 25,
		Quote = 26,
		LeftParen = 27,
		RightParen = 28,
		GreaterThan = 29,
		Or = 30,
		LeftBracket = 31,
		RightBracket = 32,
		PUBLIC = 33,
		SYSTEM = 34,
		Literal = 35,
		DOCTYPE = 36,
		NData = 37,
		Percent = 38,
		Star = 39,
		QMark = 40,
		Plus = 41,
		PCDATA = 42,
		Comma = 43,
		ANY = 44,
		EMPTY = 45,
		IGNORE = 46,
		INCLUDE = 47
	}

	private enum ScanningFunction
	{
		SubsetContent = 0,
		Name = 1,
		QName = 2,
		Nmtoken = 3,
		Doctype1 = 4,
		Doctype2 = 5,
		Element1 = 6,
		Element2 = 7,
		Element3 = 8,
		Element4 = 9,
		Element5 = 10,
		Element6 = 11,
		Element7 = 12,
		Attlist1 = 13,
		Attlist2 = 14,
		Attlist3 = 15,
		Attlist4 = 16,
		Attlist5 = 17,
		Attlist6 = 18,
		Attlist7 = 19,
		Entity1 = 20,
		Entity2 = 21,
		Entity3 = 22,
		Notation1 = 23,
		CondSection1 = 24,
		CondSection2 = 25,
		CondSection3 = 26,
		Literal = 27,
		SystemId = 28,
		PublicId1 = 29,
		PublicId2 = 30,
		ClosingTag = 31,
		ParamEntitySpace = 32,
		None = 33
	}

	private enum LiteralType
	{
		AttributeValue = 0,
		EntityReplText = 1,
		SystemOrPublicID = 2
	}

	private class UndeclaredNotation
	{
		internal string name;

		internal int lineNo;

		internal int linePos;

		internal UndeclaredNotation next;

		internal UndeclaredNotation(string name, int lineNo, int linePos)
		{
		}
	}

	private class ParseElementOnlyContent_LocalFrame
	{
		public int startParenEntityId;

		public Token parsingSchema;

		public ParseElementOnlyContent_LocalFrame(int startParentEntityIdParam)
		{
		}
	}

	private IDtdParserAdapter readerAdapter;

	private IDtdParserAdapterWithValidation readerAdapterWithValidation;

	private XmlNameTable nameTable;

	private SchemaInfo schemaInfo;

	private XmlCharType xmlCharType;

	private string systemId;

	private string publicId;

	private bool normalize;

	private bool validate;

	private bool supportNamespaces;

	private bool v1Compat;

	private char[] chars;

	private int charsUsed;

	private int curPos;

	private ScanningFunction scanningFunction;

	private ScanningFunction nextScaningFunction;

	private ScanningFunction savedScanningFunction;

	private bool whitespaceSeen;

	private int tokenStartPos;

	private int colonPos;

	private StringBuilder internalSubsetValueSb;

	private int externalEntitiesDepth;

	private int currentEntityId;

	private bool freeFloatingDtd;

	private bool hasFreeFloatingInternalSubset;

	private StringBuilder stringBuilder;

	private int condSectionDepth;

	private LineInfo literalLineInfo;

	private char literalQuoteChar;

	private string documentBaseUri;

	private string externalDtdBaseUri;

	private Dictionary<string, UndeclaredNotation> undeclaredNotations;

	private int[] condSectionEntityIds;

	private bool ParsingInternalSubset => false;

	private bool IgnoreEntityReferences => false;

	private bool SaveInternalSubsetValue => false;

	private bool ParsingTopLevelMarkup => false;

	private bool SupportNamespaces => false;

	private bool Normalize => false;

	private int LineNo => 0;

	private int LinePos => 0;

	private string BaseUriStr => null;

	private DtdParser()
	{
	}

	internal static IDtdParser Create()
	{
		return null;
	}

	private void Initialize(IDtdParserAdapter readerAdapter)
	{
	}

	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter)
	{
	}

	IDtdInfo IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset)
	{
		return null;
	}

	IDtdInfo IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter)
	{
		return null;
	}

	private void Parse(bool saveInternalSubset)
	{
	}

	private void ParseInDocumentDtd(bool saveInternalSubset)
	{
	}

	private void ParseFreeFloatingDtd()
	{
	}

	private void ParseInternalSubset()
	{
	}

	private void ParseExternalSubset()
	{
	}

	private void ParseSubset()
	{
	}

	private void ParseAttlistDecl()
	{
	}

	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors)
	{
	}

	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors)
	{
	}

	private void ParseElementDecl()
	{
	}

	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId)
	{
	}

	private void ParseHowMany(ParticleContentValidator pcv)
	{
	}

	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId)
	{
	}

	private void ParseEntityDecl()
	{
	}

	private void ParseNotationDecl()
	{
	}

	private void AddUndeclaredNotation(string notationName)
	{
	}

	private void ParseComment()
	{
	}

	private void ParsePI()
	{
	}

	private void ParseCondSection()
	{
	}

	private void ParseExternalId(Token idTokenType, Token declType, out string publicId, out string systemId)
	{
		publicId = null;
		systemId = null;
	}

	private Token GetToken(bool needWhiteSpace)
	{
		return default(Token);
	}

	private Token ScanSubsetContent()
	{
		return default(Token);
	}

	private Token ScanNameExpected()
	{
		return default(Token);
	}

	private Token ScanQNameExpected()
	{
		return default(Token);
	}

	private Token ScanNmtokenExpected()
	{
		return default(Token);
	}

	private Token ScanDoctype1()
	{
		return default(Token);
	}

	private Token ScanDoctype2()
	{
		return default(Token);
	}

	private Token ScanClosingTag()
	{
		return default(Token);
	}

	private Token ScanElement1()
	{
		return default(Token);
	}

	private Token ScanElement2()
	{
		return default(Token);
	}

	private Token ScanElement3()
	{
		return default(Token);
	}

	private Token ScanElement4()
	{
		return default(Token);
	}

	private Token ScanElement5()
	{
		return default(Token);
	}

	private Token ScanElement6()
	{
		return default(Token);
	}

	private Token ScanElement7()
	{
		return default(Token);
	}

	private Token ScanAttlist1()
	{
		return default(Token);
	}

	private Token ScanAttlist2()
	{
		return default(Token);
	}

	private Token ScanAttlist3()
	{
		return default(Token);
	}

	private Token ScanAttlist4()
	{
		return default(Token);
	}

	private Token ScanAttlist5()
	{
		return default(Token);
	}

	private Token ScanAttlist6()
	{
		return default(Token);
	}

	private Token ScanAttlist7()
	{
		return default(Token);
	}

	private Token ScanLiteral(LiteralType literalType)
	{
		return default(Token);
	}

	private XmlQualifiedName ScanEntityName()
	{
		return null;
	}

	private Token ScanNotation1()
	{
		return default(Token);
	}

	private Token ScanSystemId()
	{
		return default(Token);
	}

	private Token ScanEntity1()
	{
		return default(Token);
	}

	private Token ScanEntity2()
	{
		return default(Token);
	}

	private Token ScanEntity3()
	{
		return default(Token);
	}

	private Token ScanPublicId1()
	{
		return default(Token);
	}

	private Token ScanPublicId2()
	{
		return default(Token);
	}

	private Token ScanCondSection1()
	{
		return default(Token);
	}

	private Token ScanCondSection2()
	{
		return default(Token);
	}

	private Token ScanCondSection3()
	{
		return default(Token);
	}

	private void ScanName()
	{
	}

	private void ScanQName()
	{
	}

	private void ScanQName(bool isQName)
	{
	}

	private bool ReadDataInName()
	{
		return false;
	}

	private void ScanNmtoken()
	{
	}

	private bool EatPublicKeyword()
	{
		return false;
	}

	private bool EatSystemKeyword()
	{
		return false;
	}

	private XmlQualifiedName GetNameQualified(bool canHavePrefix)
	{
		return null;
	}

	private string GetNameString()
	{
		return null;
	}

	private string GetNmtokenString()
	{
		return null;
	}

	private string GetValue()
	{
		return null;
	}

	private string GetValueWithStrippedSpaces()
	{
		return null;
	}

	private int ReadData()
	{
		return 0;
	}

	private void LoadParsingBuffer()
	{
	}

	private void SaveParsingBuffer()
	{
	}

	private void SaveParsingBuffer(int internalSubsetValueEndPos)
	{
	}

	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute)
	{
		return false;
	}

	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute)
	{
		return false;
	}

	private bool HandleEntityEnd(bool inLiteral)
	{
		return false;
	}

	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute)
	{
		return null;
	}

	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg)
	{
	}

	private void SendValidationEvent(XmlSeverityType severity, string code, string arg)
	{
	}

	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e)
	{
	}

	private bool IsAttributeValueType(Token token)
	{
		return false;
	}

	private void OnUnexpectedError()
	{
	}

	private void Throw(int curPos, string res)
	{
	}

	private void Throw(int curPos, string res, string arg)
	{
	}

	private void Throw(int curPos, string res, string[] args)
	{
	}

	private void Throw(string res, string arg, int lineNo, int linePos)
	{
	}

	private void ThrowInvalidChar(int pos, string data, int invCharPos)
	{
	}

	private void ThrowInvalidChar(char[] data, int length, int invCharPos)
	{
	}

	private void ThrowUnexpectedToken(int pos, string expectedToken)
	{
	}

	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2)
	{
	}

	private string ParseUnexpectedToken(int startPos)
	{
		return null;
	}

	internal static string StripSpaces(string value)
	{
		return null;
	}
}
