using System.Collections.Generic;
using System.Text;

namespace System.Xml;

internal class XmlWellFormedWriter : XmlWriter
{
	private enum State
	{
		Start = 0,
		TopLevel = 1,
		Document = 2,
		Element = 3,
		Content = 4,
		B64Content = 5,
		B64Attribute = 6,
		AfterRootEle = 7,
		Attribute = 8,
		SpecialAttr = 9,
		EndDocument = 10,
		RootLevelAttr = 11,
		RootLevelSpecAttr = 12,
		RootLevelB64Attr = 13,
		AfterRootLevelAttr = 14,
		Closed = 15,
		Error = 16,
		StartContent = 101,
		StartContentEle = 102,
		StartContentB64 = 103,
		StartDoc = 104,
		StartDocEle = 106,
		EndAttrSEle = 107,
		EndAttrEEle = 108,
		EndAttrSCont = 109,
		EndAttrSAttr = 111,
		PostB64Cont = 112,
		PostB64Attr = 113,
		PostB64RootAttr = 114,
		StartFragEle = 115,
		StartFragCont = 116,
		StartFragB64 = 117,
		StartRootLevelAttr = 118
	}

	private enum Token
	{
		StartDocument = 0,
		EndDocument = 1,
		PI = 2,
		Comment = 3,
		Dtd = 4,
		StartElement = 5,
		EndElement = 6,
		StartAttribute = 7,
		EndAttribute = 8,
		Text = 9,
		CData = 10,
		AtomicValue = 11,
		Base64 = 12,
		RawData = 13,
		Whitespace = 14
	}

	private class NamespaceResolverProxy : IXmlNamespaceResolver
	{
		private XmlWellFormedWriter wfWriter;

		internal NamespaceResolverProxy(XmlWellFormedWriter wfWriter)
		{
		}

		IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
		{
			return null;
		}

		string IXmlNamespaceResolver.LookupNamespace(string prefix)
		{
			return null;
		}

		string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
		{
			return null;
		}
	}

	private struct ElementScope
	{
		internal int prevNSTop;

		internal string prefix;

		internal string localName;

		internal string namespaceUri;

		internal XmlSpace xmlSpace;

		internal string xmlLang;

		internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop)
		{
		}

		internal void WriteEndElement(XmlRawWriter rawWriter)
		{
		}

		internal void WriteFullEndElement(XmlRawWriter rawWriter)
		{
		}
	}

	private enum NamespaceKind
	{
		Written = 0,
		NeedToWrite = 1,
		Implied = 2,
		Special = 3
	}

	private struct Namespace
	{
		internal string prefix;

		internal string namespaceUri;

		internal NamespaceKind kind;

		internal int prevNsIndex;

		internal void Set(string prefix, string namespaceUri, NamespaceKind kind)
		{
		}

		internal void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter)
		{
		}
	}

	private struct AttrName
	{
		internal string prefix;

		internal string namespaceUri;

		internal string localName;

		internal int prev;

		internal void Set(string prefix, string localName, string namespaceUri)
		{
		}

		internal bool IsDuplicate(string prefix, string localName, string namespaceUri)
		{
			return false;
		}
	}

	private enum SpecialAttribute
	{
		No = 0,
		DefaultXmlns = 1,
		PrefixedXmlns = 2,
		XmlSpace = 3,
		XmlLang = 4
	}

	private class AttributeValueCache
	{
		private enum ItemType
		{
			EntityRef = 0,
			CharEntity = 1,
			SurrogateCharEntity = 2,
			Whitespace = 3,
			String = 4,
			StringChars = 5,
			Raw = 6,
			RawChars = 7,
			ValueString = 8
		}

		private class Item
		{
			internal ItemType type;

			internal object data;

			internal Item()
			{
			}

			internal void Set(ItemType type, object data)
			{
			}
		}

		private class BufferChunk
		{
			internal char[] buffer;

			internal int index;

			internal int count;

			internal BufferChunk(char[] buffer, int index, int count)
			{
			}
		}

		private StringBuilder stringValue;

		private string singleStringValue;

		private Item[] items;

		private int firstItem;

		private int lastItem;

		internal string StringValue => null;

		internal void WriteEntityRef(string name)
		{
		}

		internal void WriteCharEntity(char ch)
		{
		}

		internal void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		internal void WriteWhitespace(string ws)
		{
		}

		internal void WriteString(string text)
		{
		}

		internal void WriteChars(char[] buffer, int index, int count)
		{
		}

		internal void WriteRaw(char[] buffer, int index, int count)
		{
		}

		internal void WriteRaw(string data)
		{
		}

		internal void WriteValue(string value)
		{
		}

		internal void Replay(XmlWriter writer)
		{
		}

		internal void Trim()
		{
		}

		internal void Clear()
		{
		}

		private void StartComplexValue()
		{
		}

		private void AddItem(ItemType type, object data)
		{
		}
	}

	private XmlWriter writer;

	private XmlRawWriter rawWriter;

	private IXmlNamespaceResolver predefinedNamespaces;

	private Namespace[] nsStack;

	private int nsTop;

	private Dictionary<string, int> nsHashtable;

	private bool useNsHashtable;

	private ElementScope[] elemScopeStack;

	private int elemTop;

	private AttrName[] attrStack;

	private int attrCount;

	private Dictionary<string, int> attrHashTable;

	private SpecialAttribute specAttr;

	private AttributeValueCache attrValueCache;

	private string curDeclPrefix;

	private State[] stateTable;

	private State currentState;

	private bool checkCharacters;

	private bool omitDuplNamespaces;

	private bool writeEndDocumentOnClose;

	private ConformanceLevel conformanceLevel;

	private bool dtdWritten;

	private bool xmlDeclFollows;

	private XmlCharType xmlCharType;

	private SecureStringHasher hasher;

	internal static readonly string[] stateName;

	internal static readonly string[] tokenName;

	private static WriteState[] state2WriteState;

	private static readonly State[] StateTableDocument;

	private static readonly State[] StateTableAuto;

	public override WriteState WriteState => default(WriteState);

	internal XmlRawWriter RawWriter => null;

	private bool SaveAttrValue => false;

	private bool InBase64 => false;

	private bool IsClosedOrErrorState => false;

	internal XmlWellFormedWriter(XmlWriter writer, XmlWriterSettings settings)
	{
	}

	public override void WriteStartDocument()
	{
	}

	public override void WriteStartDocument(bool standalone)
	{
	}

	public override void WriteEndDocument()
	{
	}

	public override void WriteDocType(string name, string pubid, string sysid, string subset)
	{
	}

	public override void WriteStartElement(string prefix, string localName, string ns)
	{
	}

	public override void WriteEndElement()
	{
	}

	public override void WriteFullEndElement()
	{
	}

	public override void WriteStartAttribute(string prefix, string localName, string namespaceName)
	{
	}

	public override void WriteEndAttribute()
	{
	}

	public override void WriteCData(string text)
	{
	}

	public override void WriteComment(string text)
	{
	}

	public override void WriteProcessingInstruction(string name, string text)
	{
	}

	public override void WriteEntityRef(string name)
	{
	}

	public override void WriteCharEntity(char ch)
	{
	}

	public override void WriteSurrogateCharEntity(char lowChar, char highChar)
	{
	}

	public override void WriteWhitespace(string ws)
	{
	}

	public override void WriteString(string text)
	{
	}

	public override void WriteChars(char[] buffer, int index, int count)
	{
	}

	public override void WriteRaw(char[] buffer, int index, int count)
	{
	}

	public override void WriteRaw(string data)
	{
	}

	public override void WriteBase64(byte[] buffer, int index, int count)
	{
	}

	public override void Close()
	{
	}

	public override void Flush()
	{
	}

	public override string LookupPrefix(string ns)
	{
		return null;
	}

	public override void WriteValue(string value)
	{
	}

	public override void WriteBinHex(byte[] buffer, int index, int count)
	{
	}

	private void SetSpecialAttribute(SpecialAttribute special)
	{
	}

	private void WriteStartDocumentImpl(XmlStandalone standalone)
	{
	}

	private void StartFragment()
	{
	}

	private void PushNamespaceImplicit(string prefix, string ns)
	{
	}

	private bool PushNamespaceExplicit(string prefix, string ns)
	{
		return false;
	}

	private void AddNamespace(string prefix, string ns, NamespaceKind kind)
	{
	}

	private void AddToNamespaceHashtable(int namespaceIndex)
	{
	}

	private int LookupNamespaceIndex(string prefix)
	{
		return 0;
	}

	private void PopNamespaces(int indexFrom, int indexTo)
	{
	}

	private static XmlException DupAttrException(string prefix, string localName)
	{
		return null;
	}

	private void AdvanceState(Token token)
	{
	}

	private void StartElementContent()
	{
	}

	private static string GetStateName(State state)
	{
		return null;
	}

	internal string LookupNamespace(string prefix)
	{
		return null;
	}

	private string LookupLocalNamespace(string prefix)
	{
		return null;
	}

	private string GeneratePrefix()
	{
		return null;
	}

	private void CheckNCName(string ncname)
	{
	}

	private static Exception InvalidCharsException(string name, int badCharIndex)
	{
		return null;
	}

	private void ThrowInvalidStateTransition(Token token, State currentState)
	{
	}

	private void AddAttribute(string prefix, string localName, string namespaceName)
	{
	}

	private void AddToAttrHashTable(int attributeIndex)
	{
	}
}
