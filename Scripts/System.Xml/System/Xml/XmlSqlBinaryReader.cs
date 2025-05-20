using System.Collections.Generic;
using System.IO;
using System.Text;

namespace System.Xml;

internal sealed class XmlSqlBinaryReader : XmlReader, IXmlNamespaceResolver
{
	private enum ScanState
	{
		Doc = 0,
		XmlText = 1,
		Attr = 2,
		AttrVal = 3,
		AttrValPseudoValue = 4,
		Init = 5,
		Error = 6,
		EOF = 7,
		Closed = 8
	}

	internal struct QName
	{
		public string prefix;

		public string localname;

		public string namespaceUri;

		public QName(string prefix, string lname, string nsUri)
		{
			this.prefix = null;
			localname = null;
			namespaceUri = null;
		}

		public void Set(string prefix, string lname, string nsUri)
		{
		}

		public void Clear()
		{
		}

		public bool MatchNs(string lname, string nsUri)
		{
			return false;
		}

		public bool MatchPrefix(string prefix, string lname)
		{
			return false;
		}

		public void CheckPrefixNS(string prefix, string namespaceUri)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public int GetNSHashCode(SecureStringHasher hasher)
		{
			return 0;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public static bool operator ==(QName a, QName b)
		{
			return false;
		}
	}

	private struct ElemInfo
	{
		public QName name;

		public string xmlLang;

		public XmlSpace xmlSpace;

		public bool xmlspacePreserve;

		public NamespaceDecl nsdecls;

		public void Set(QName name, bool xmlspacePreserve)
		{
		}

		public NamespaceDecl Clear()
		{
			return null;
		}
	}

	private struct AttrInfo
	{
		public QName name;

		public string val;

		public int contentPos;

		public int hashCode;

		public int prevHash;

		public void Set(QName n, string v)
		{
		}

		public void Set(QName n, int pos)
		{
		}

		public void GetLocalnameAndNamespaceUri(out string localname, out string namespaceUri)
		{
			localname = null;
			namespaceUri = null;
		}

		public int GetLocalnameAndNamespaceUriAndHash(SecureStringHasher hasher, out string localname, out string namespaceUri)
		{
			localname = null;
			namespaceUri = null;
			return 0;
		}

		public bool MatchNS(string localname, string namespaceUri)
		{
			return false;
		}

		public bool MatchHashNS(int hash, string localname, string namespaceUri)
		{
			return false;
		}

		public void AdjustPosition(int adj)
		{
		}
	}

	private class NamespaceDecl
	{
		public string prefix;

		public string uri;

		public NamespaceDecl scopeLink;

		public NamespaceDecl prevLink;

		public int scope;

		public bool implied;

		public NamespaceDecl(string prefix, string nsuri, NamespaceDecl nextInScope, NamespaceDecl prevDecl, int scope, bool implied)
		{
		}
	}

	private struct SymbolTables
	{
		public string[] symtable;

		public int symCount;

		public QName[] qnametable;

		public int qnameCount;

		public void Init()
		{
		}
	}

	private class NestedBinXml
	{
		public SymbolTables symbolTables;

		public int docState;

		public NestedBinXml next;

		public NestedBinXml(SymbolTables symbolTables, int docState, NestedBinXml next)
		{
		}
	}

	internal static readonly Type TypeOfObject;

	internal static readonly Type TypeOfString;

	private static Type[] TokenTypeMap;

	private static byte[] XsdKatmaiTimeScaleToValueLengthMap;

	private static ReadState[] ScanState2ReadState;

	private Stream inStrm;

	private byte[] data;

	private int pos;

	private int mark;

	private int end;

	private long offset;

	private bool eof;

	private bool sniffed;

	private bool isEmpty;

	private int docState;

	private SymbolTables symbolTables;

	private XmlNameTable xnt;

	private bool xntFromSettings;

	private string xml;

	private string xmlns;

	private string nsxmlns;

	private string baseUri;

	private ScanState state;

	private XmlNodeType nodetype;

	private BinXmlToken token;

	private int attrIndex;

	private QName qnameOther;

	private QName qnameElement;

	private XmlNodeType parentNodeType;

	private ElemInfo[] elementStack;

	private int elemDepth;

	private AttrInfo[] attributes;

	private int[] attrHashTbl;

	private int attrCount;

	private int posAfterAttrs;

	private bool xmlspacePreserve;

	private int tokLen;

	private int tokDataPos;

	private bool hasTypedValue;

	private Type valueType;

	private string stringValue;

	private Dictionary<string, NamespaceDecl> namespaces;

	private NestedBinXml prevNameInfo;

	private XmlReader textXmlReader;

	private bool closeInput;

	private bool checkCharacters;

	private bool ignoreWhitespace;

	private bool ignorePIs;

	private bool ignoreComments;

	private DtdProcessing dtdProcessing;

	private SecureStringHasher hasher;

	private XmlCharType xmlCharType;

	private Encoding unicode;

	private byte version;

	public override XmlReaderSettings Settings => null;

	public override XmlNodeType NodeType => default(XmlNodeType);

	public override string LocalName => null;

	public override string NamespaceURI => null;

	public override string Prefix => null;

	public override string Value => null;

	public override int Depth => 0;

	public override string BaseURI => null;

	public override bool IsEmptyElement => false;

	public override XmlSpace XmlSpace => default(XmlSpace);

	public override string XmlLang => null;

	public override Type ValueType => null;

	public override int AttributeCount => 0;

	public override bool EOF => false;

	public override XmlNameTable NameTable => null;

	public override ReadState ReadState => default(ReadState);

	public XmlSqlBinaryReader(Stream stream, byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings)
	{
	}

	public override string GetAttribute(string name, string ns)
	{
		return null;
	}

	public override string GetAttribute(string name)
	{
		return null;
	}

	public override string GetAttribute(int i)
	{
		return null;
	}

	public override bool MoveToAttribute(string name)
	{
		return false;
	}

	public override void MoveToAttribute(int i)
	{
	}

	public override bool MoveToFirstAttribute()
	{
		return false;
	}

	public override bool MoveToNextAttribute()
	{
		return false;
	}

	public override bool MoveToElement()
	{
		return false;
	}

	public override bool ReadAttributeValue()
	{
		return false;
	}

	public override void Close()
	{
	}

	public override string LookupNamespace(string prefix)
	{
		return null;
	}

	public override void ResolveEntity()
	{
	}

	public override bool Read()
	{
		return false;
	}

	IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
	{
		return null;
	}

	string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
	{
		return null;
	}

	private void VerifyVersion(int requiredVersion, BinXmlToken token)
	{
	}

	private void AddInitNamespace(string prefix, string uri)
	{
	}

	private void AddName()
	{
	}

	private void AddQName()
	{
	}

	private void NameFlush()
	{
	}

	private void SkipExtn()
	{
	}

	private int ReadQNameRef()
	{
		return 0;
	}

	private int ReadNameRef()
	{
		return 0;
	}

	private bool FillAllowEOF()
	{
		return false;
	}

	private void Fill_(int require)
	{
	}

	private void Fill(int require)
	{
	}

	private byte ReadByte()
	{
		return 0;
	}

	private ushort ReadUShort()
	{
		return 0;
	}

	private int ParseMB32()
	{
		return 0;
	}

	private int ParseMB32_(byte b)
	{
		return 0;
	}

	private int ParseMB32(int pos)
	{
		return 0;
	}

	private int ParseMB64()
	{
		return 0;
	}

	private BinXmlToken PeekToken()
	{
		return default(BinXmlToken);
	}

	private BinXmlToken ReadToken()
	{
		return default(BinXmlToken);
	}

	private BinXmlToken NextToken2(BinXmlToken token)
	{
		return default(BinXmlToken);
	}

	private BinXmlToken NextToken1()
	{
		return default(BinXmlToken);
	}

	private BinXmlToken NextToken()
	{
		return default(BinXmlToken);
	}

	private BinXmlToken PeekNextToken()
	{
		return default(BinXmlToken);
	}

	private BinXmlToken RescanNextToken()
	{
		return default(BinXmlToken);
	}

	private string ParseText()
	{
		return null;
	}

	private int ScanText(out int start)
	{
		start = default(int);
		return 0;
	}

	private string GetString(int pos, int cch)
	{
		return null;
	}

	private string GetStringAligned(byte[] data, int offset, int cch)
	{
		return null;
	}

	private string GetAttributeText(int i)
	{
		return null;
	}

	private int LocateAttribute(string name, string ns)
	{
		return 0;
	}

	private int LocateAttribute(string name)
	{
		return 0;
	}

	private void PositionOnAttribute(int i)
	{
	}

	private void GrowElements()
	{
	}

	private void GrowAttributes()
	{
	}

	private void ClearAttributes()
	{
	}

	private void PushNamespace(string prefix, string ns, bool implied)
	{
	}

	private void PopNamespaces(NamespaceDecl firstInScopeChain)
	{
	}

	private void GenerateImpliedXmlnsAttrs()
	{
	}

	private bool ReadInit(bool skipXmlDecl)
	{
		return false;
	}

	private void ScanAttributes()
	{
	}

	private void SimpleCheckForDuplicateAttributes()
	{
	}

	private void HashCheckForDuplicateAttributes()
	{
	}

	private string XmlDeclValue()
	{
		return null;
	}

	private string CDATAValue()
	{
		return null;
	}

	private void FinishCDATA()
	{
	}

	private void FinishEndElement()
	{
	}

	private bool ReadDoc()
	{
		return false;
	}

	private void ImplReadData(BinXmlToken tokenType)
	{
	}

	private void ImplReadElement()
	{
	}

	private void ImplReadEndElement()
	{
	}

	private void ImplReadDoctype()
	{
	}

	private void ImplReadPI()
	{
	}

	private void ImplReadComment()
	{
	}

	private void ImplReadCDATA()
	{
	}

	private void ImplReadNest()
	{
	}

	private void ImplReadEndNest()
	{
	}

	private void ImplReadXmlText()
	{
	}

	private void UpdateFromTextReader()
	{
	}

	private bool UpdateFromTextReader(bool needUpdate)
	{
		return false;
	}

	private void CheckAllowContent()
	{
	}

	private void GenerateTokenTypeMap()
	{
	}

	private Type GetValueType(BinXmlToken token)
	{
		return null;
	}

	private void ReScanOverValue(BinXmlToken token)
	{
	}

	private XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars)
	{
		return default(XmlNodeType);
	}

	private XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars)
	{
		return default(XmlNodeType);
	}

	private XmlNodeType CheckText(bool attr)
	{
		return default(XmlNodeType);
	}

	private XmlNodeType CheckTextIsWS()
	{
		return default(XmlNodeType);
	}

	private void CheckValueTokenBounds()
	{
	}

	private int GetXsdKatmaiTokenLength(BinXmlToken token)
	{
		return 0;
	}

	private int XsdKatmaiTimeScaleToValueLength(byte scale)
	{
		return 0;
	}

	private long ValueAsLong()
	{
		return 0L;
	}

	private ulong ValueAsULong()
	{
		return 0uL;
	}

	private decimal ValueAsDecimal()
	{
		return default(decimal);
	}

	private double ValueAsDouble()
	{
		return 0.0;
	}

	private string ValueAsDateTimeString()
	{
		return null;
	}

	private string ValueAsString(BinXmlToken token)
	{
		return null;
	}

	private short GetInt16(int pos)
	{
		return 0;
	}

	private ushort GetUInt16(int pos)
	{
		return 0;
	}

	private int GetInt32(int pos)
	{
		return 0;
	}

	private uint GetUInt32(int pos)
	{
		return 0u;
	}

	private long GetInt64(int pos)
	{
		return 0L;
	}

	private ulong GetUInt64(int pos)
	{
		return 0uL;
	}

	private float GetSingle(int offset)
	{
		return 0f;
	}

	private double GetDouble(int offset)
	{
		return 0.0;
	}

	private Exception ThrowUnexpectedToken(BinXmlToken token)
	{
		return null;
	}

	private Exception ThrowXmlException(string res)
	{
		return null;
	}

	private Exception ThrowXmlException(string res, string arg1, string arg2)
	{
		return null;
	}

	private Exception ThrowNotSupported(string res)
	{
		return null;
	}
}
