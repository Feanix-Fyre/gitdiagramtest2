using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace System.Xml;

internal class XmlTextReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver
{
	private enum ParsingFunction
	{
		ElementContent = 0,
		NoData = 1,
		OpenUrl = 2,
		SwitchToInteractive = 3,
		SwitchToInteractiveXmlDecl = 4,
		DocumentContent = 5,
		MoveToElementContent = 6,
		PopElementContext = 7,
		PopEmptyElementContext = 8,
		ResetAttributesRootLevel = 9,
		Error = 10,
		Eof = 11,
		ReaderClosed = 12,
		EntityReference = 13,
		InIncrementalRead = 14,
		FragmentAttribute = 15,
		ReportEndEntity = 16,
		AfterResolveEntityInContent = 17,
		AfterResolveEmptyEntityInContent = 18,
		XmlDeclarationFragment = 19,
		GoToEof = 20,
		PartialTextValue = 21,
		InReadAttributeValue = 22,
		InReadValueChunk = 23,
		InReadContentAsBinary = 24,
		InReadElementContentAsBinary = 25
	}

	private enum ParsingMode
	{
		Full = 0,
		SkipNode = 1,
		SkipContent = 2
	}

	private enum EntityType
	{
		CharacterDec = 0,
		CharacterHex = 1,
		CharacterNamed = 2,
		Expanded = 3,
		Skipped = 4,
		FakeExpanded = 5,
		Unexpanded = 6,
		ExpandedInAttribute = 7
	}

	private enum EntityExpandType
	{
		All = 0,
		OnlyGeneral = 1,
		OnlyCharacter = 2
	}

	private enum IncrementalReadState
	{
		Text = 0,
		StartTag = 1,
		PI = 2,
		CDATA = 3,
		Comment = 4,
		Attributes = 5,
		AttributeValue = 6,
		ReadData = 7,
		EndElement = 8,
		End = 9,
		ReadValueChunk_OnCachedValue = 10,
		ReadValueChunk_OnPartialValue = 11,
		ReadContentAsBinary_OnCachedValue = 12,
		ReadContentAsBinary_OnPartialValue = 13,
		ReadContentAsBinary_End = 14
	}

	private class LaterInitParam
	{
		public bool useAsync;

		public Stream inputStream;

		public byte[] inputBytes;

		public int inputByteCount;

		public Uri inputbaseUri;

		public string inputUriStr;

		public XmlResolver inputUriResolver;

		public XmlParserContext inputContext;

		public TextReader inputTextReader;

		public InitInputType initType;
	}

	private enum InitInputType
	{
		UriString = 0,
		Stream = 1,
		TextReader = 2,
		Invalid = 3
	}

	private struct ParsingState
	{
		internal char[] chars;

		internal int charPos;

		internal int charsUsed;

		internal Encoding encoding;

		internal bool appendMode;

		internal Stream stream;

		internal Decoder decoder;

		internal byte[] bytes;

		internal int bytePos;

		internal int bytesUsed;

		internal TextReader textReader;

		internal int lineNo;

		internal int lineStartPos;

		internal string baseUriStr;

		internal Uri baseUri;

		internal bool isEof;

		internal bool isStreamEof;

		internal IDtdEntityInfo entity;

		internal int entityId;

		internal bool eolNormalized;

		internal bool entityResolvedManually;

		internal int LineNo => 0;

		internal int LinePos => 0;

		internal void Clear()
		{
		}

		internal void Close(bool closeInput)
		{
		}
	}

	private class XmlContext
	{
		internal XmlSpace xmlSpace;

		internal string xmlLang;

		internal string defaultNamespace;

		internal XmlContext previousContext;

		internal XmlContext()
		{
		}

		internal XmlContext(XmlContext previousContext)
		{
		}
	}

	private class NoNamespaceManager : XmlNamespaceManager
	{
		public override string DefaultNamespace => null;

		public override void PushScope()
		{
		}

		public override bool PopScope()
		{
			return false;
		}

		public override void AddNamespace(string prefix, string uri)
		{
		}

		public override void RemoveNamespace(string prefix, string uri)
		{
		}

		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		public override IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
		{
			return null;
		}

		public override string LookupNamespace(string prefix)
		{
			return null;
		}

		public override string LookupPrefix(string uri)
		{
			return null;
		}
	}

	internal class DtdParserProxy : IDtdParserAdapterV1, IDtdParserAdapterWithValidation, IDtdParserAdapter
	{
		private XmlTextReaderImpl reader;

		XmlNameTable IDtdParserAdapter.NameTable => null;

		IXmlNamespaceResolver IDtdParserAdapter.NamespaceResolver => null;

		Uri IDtdParserAdapter.BaseUri => null;

		bool IDtdParserAdapter.IsEof => false;

		char[] IDtdParserAdapter.ParsingBuffer => null;

		int IDtdParserAdapter.ParsingBufferLength => 0;

		int IDtdParserAdapter.CurrentPosition
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		int IDtdParserAdapter.EntityStackLength => 0;

		bool IDtdParserAdapter.IsEntityEolNormalized => false;

		int IDtdParserAdapter.LineNo => 0;

		int IDtdParserAdapter.LineStartPosition => 0;

		bool IDtdParserAdapterWithValidation.DtdValidation => false;

		IValidationEventHandling IDtdParserAdapterWithValidation.ValidationEventHandling => null;

		bool IDtdParserAdapterV1.Normalization => false;

		bool IDtdParserAdapterV1.Namespaces => false;

		bool IDtdParserAdapterV1.V1CompatibilityMode => false;

		internal DtdParserProxy(XmlTextReaderImpl reader)
		{
		}

		void IDtdParserAdapter.OnNewLine(int pos)
		{
		}

		int IDtdParserAdapter.ReadData()
		{
			return 0;
		}

		int IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder)
		{
			return 0;
		}

		int IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
		{
			return 0;
		}

		void IDtdParserAdapter.ParsePI(StringBuilder sb)
		{
		}

		void IDtdParserAdapter.ParseComment(StringBuilder sb)
		{
		}

		bool IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, out int entityId)
		{
			entityId = default(int);
			return false;
		}

		bool IDtdParserAdapter.PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId)
		{
			oldEntity = null;
			newEntityId = default(int);
			return false;
		}

		bool IDtdParserAdapter.PushExternalSubset(string systemId, string publicId)
		{
			return false;
		}

		void IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd)
		{
		}

		void IDtdParserAdapter.Throw(Exception e)
		{
		}

		void IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo)
		{
		}

		void IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo)
		{
		}
	}

	private class NodeData : IComparable
	{
		private static NodeData s_None;

		internal XmlNodeType type;

		internal string localName;

		internal string prefix;

		internal string ns;

		internal string nameWPrefix;

		private string value;

		private char[] chars;

		private int valueStartPos;

		private int valueLength;

		internal LineInfo lineInfo;

		internal LineInfo lineInfo2;

		internal char quoteChar;

		internal int depth;

		private bool isEmptyOrDefault;

		internal int entityId;

		internal bool xmlContextPushed;

		internal NodeData nextAttrValueChunk;

		internal object schemaType;

		internal object typedValue;

		internal static NodeData None => null;

		internal int LineNo => 0;

		internal int LinePos => 0;

		internal bool IsEmptyElement
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool IsDefaultAttribute
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool ValueBuffered => false;

		internal string StringValue => null;

		internal NodeData()
		{
		}

		internal void TrimSpacesInValue()
		{
		}

		internal void Clear(XmlNodeType type)
		{
		}

		internal void ClearName()
		{
		}

		internal void SetLineInfo(int lineNo, int linePos)
		{
		}

		internal void SetLineInfo2(int lineNo, int linePos)
		{
		}

		internal void SetValueNode(XmlNodeType type, string value)
		{
		}

		internal void SetValueNode(XmlNodeType type, char[] chars, int startPos, int len)
		{
		}

		internal void SetNamedNode(XmlNodeType type, string localName)
		{
		}

		internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix)
		{
		}

		internal void SetValue(string value)
		{
		}

		internal void SetValue(char[] chars, int startPos, int len)
		{
		}

		internal void OnBufferInvalidated()
		{
		}

		internal void CopyTo(int valueOffset, StringBuilder sb)
		{
		}

		internal int CopyTo(int valueOffset, char[] buffer, int offset, int length)
		{
			return 0;
		}

		internal string GetNameWPrefix(XmlNameTable nt)
		{
			return null;
		}

		internal string CreateNameWPrefix(XmlNameTable nt)
		{
			return null;
		}

		int IComparable.CompareTo(object obj)
		{
			return 0;
		}
	}

	private class DtdDefaultAttributeInfoToNodeDataComparer : IComparer<object>
	{
		private static IComparer<object> s_instance;

		internal static IComparer<object> Instance => null;

		public int Compare(object x, object y)
		{
			return 0;
		}
	}

	internal delegate void OnDefaultAttributeUseDelegate(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader);

	private readonly bool useAsync;

	private LaterInitParam laterInitParam;

	private XmlCharType xmlCharType;

	private ParsingState ps;

	private ParsingFunction parsingFunction;

	private ParsingFunction nextParsingFunction;

	private ParsingFunction nextNextParsingFunction;

	private NodeData[] nodes;

	private NodeData curNode;

	private int index;

	private int curAttrIndex;

	private int attrCount;

	private int attrHashtable;

	private int attrDuplWalkCount;

	private bool attrNeedNamespaceLookup;

	private bool fullAttrCleanup;

	private NodeData[] attrDuplSortingArray;

	private XmlNameTable nameTable;

	private bool nameTableFromSettings;

	private XmlResolver xmlResolver;

	private string url;

	private bool normalize;

	private bool supportNamespaces;

	private WhitespaceHandling whitespaceHandling;

	private DtdProcessing dtdProcessing;

	private EntityHandling entityHandling;

	private bool ignorePIs;

	private bool ignoreComments;

	private bool checkCharacters;

	private int lineNumberOffset;

	private int linePositionOffset;

	private bool closeInput;

	private long maxCharactersInDocument;

	private long maxCharactersFromEntities;

	private bool v1Compat;

	private XmlNamespaceManager namespaceManager;

	private string lastPrefix;

	private XmlContext xmlContext;

	private ParsingState[] parsingStatesStack;

	private int parsingStatesStackTop;

	private string reportedBaseUri;

	private Encoding reportedEncoding;

	private IDtdInfo dtdInfo;

	private XmlNodeType fragmentType;

	private XmlParserContext fragmentParserContext;

	private bool fragment;

	private IncrementalReadDecoder incReadDecoder;

	private IncrementalReadState incReadState;

	private LineInfo incReadLineInfo;

	private int incReadDepth;

	private int incReadLeftStartPos;

	private int incReadLeftEndPos;

	private int attributeValueBaseEntityId;

	private bool emptyEntityInAttributeResolved;

	private IValidationEventHandling validationEventHandling;

	private OnDefaultAttributeUseDelegate onDefaultAttributeUse;

	private bool validatingReaderCompatFlag;

	private bool addDefaultAttributesAndNormalize;

	private StringBuilder stringBuilder;

	private bool rootElementParsed;

	private bool standalone;

	private int nextEntityId;

	private ParsingMode parsingMode;

	private ReadState readState;

	private IDtdEntityInfo lastEntity;

	private bool afterResetState;

	private int documentStartBytePos;

	private int readValueOffset;

	private long charactersInDocument;

	private long charactersFromEntities;

	private Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities;

	private bool disableUndeclaredEntityCheck;

	private XmlReader outerReader;

	private bool xmlResolverIsSet;

	private string Xml;

	private string XmlNs;

	private Task<Tuple<int, int, int, bool>> parseText_dummyTask;

	public override XmlReaderSettings Settings => null;

	public override XmlNodeType NodeType => default(XmlNodeType);

	public override string Name => null;

	public override string LocalName => null;

	public override string NamespaceURI => null;

	public override string Prefix => null;

	public override string Value => null;

	public override int Depth => 0;

	public override string BaseURI => null;

	public override bool IsEmptyElement => false;

	public override bool IsDefault => false;

	public override char QuoteChar => '\0';

	public override XmlSpace XmlSpace => default(XmlSpace);

	public override string XmlLang => null;

	public override ReadState ReadState => default(ReadState);

	public override bool EOF => false;

	public override XmlNameTable NameTable => null;

	public override bool CanResolveEntity => false;

	public override int AttributeCount => 0;

	internal XmlReader OuterReader
	{
		set
		{
		}
	}

	public override bool CanReadValueChunk => false;

	public int LineNumber => 0;

	public int LinePosition => 0;

	internal bool Namespaces
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool Normalization
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal WhitespaceHandling WhitespaceHandling
	{
		set
		{
		}
	}

	internal EntityHandling EntityHandling
	{
		set
		{
		}
	}

	internal bool IsResolverSet => false;

	internal XmlResolver XmlResolver
	{
		set
		{
		}
	}

	internal XmlNameTable DtdParserProxy_NameTable => null;

	internal IXmlNamespaceResolver DtdParserProxy_NamespaceResolver => null;

	internal bool DtdParserProxy_DtdValidation => false;

	internal bool DtdParserProxy_Normalization => false;

	internal bool DtdParserProxy_Namespaces => false;

	internal bool DtdParserProxy_V1CompatibilityMode => false;

	internal Uri DtdParserProxy_BaseUri => null;

	internal bool DtdParserProxy_IsEof => false;

	internal char[] DtdParserProxy_ParsingBuffer => null;

	internal int DtdParserProxy_ParsingBufferLength => 0;

	internal int DtdParserProxy_CurrentPosition
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int DtdParserProxy_EntityStackLength => 0;

	internal bool DtdParserProxy_IsEntityEolNormalized => false;

	internal IValidationEventHandling DtdParserProxy_ValidationEventHandling => null;

	internal int DtdParserProxy_LineNo => 0;

	internal int DtdParserProxy_LineStartPosition => 0;

	private bool IsResolverNull => false;

	private bool InAttributeValueIterator => false;

	private bool DtdValidation => false;

	private bool InEntity => false;

	internal override IDtdInfo DtdInfo => null;

	internal IValidationEventHandling ValidationEventHandling
	{
		set
		{
		}
	}

	internal OnDefaultAttributeUseDelegate OnDefaultAttributeUse
	{
		set
		{
		}
	}

	internal bool XmlValidatingReaderCompatibilityMode
	{
		set
		{
		}
	}

	internal XmlNodeType FragmentType => default(XmlNodeType);

	internal object InternalSchemaType
	{
		set
		{
		}
	}

	internal object InternalTypedValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool StandAlone => false;

	internal override XmlNamespaceManager NamespaceManager => null;

	internal bool V1Compat => false;

	internal bool DisableUndeclaredEntityCheck
	{
		set
		{
		}
	}

	internal XmlTextReaderImpl(XmlNameTable nt)
	{
	}

	private XmlTextReaderImpl(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context)
	{
	}

	internal XmlTextReaderImpl(Stream input)
	{
	}

	internal XmlTextReaderImpl(string url, Stream input, XmlNameTable nt)
	{
	}

	internal XmlTextReaderImpl(TextReader input)
	{
	}

	internal XmlTextReaderImpl(TextReader input, XmlNameTable nt)
	{
	}

	internal XmlTextReaderImpl(string url, TextReader input, XmlNameTable nt)
	{
	}

	internal XmlTextReaderImpl(string xmlFragment, XmlNodeType fragType, XmlParserContext context)
	{
	}

	internal XmlTextReaderImpl(string xmlFragment, XmlParserContext context)
	{
	}

	public XmlTextReaderImpl(string url, XmlNameTable nt)
	{
	}

	private void FinishInitUriString()
	{
	}

	internal XmlTextReaderImpl(Stream stream, byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput)
	{
	}

	private void FinishInitStream()
	{
	}

	internal XmlTextReaderImpl(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context)
	{
	}

	private void FinishInitTextReader()
	{
	}

	internal XmlTextReaderImpl(string xmlFragment, XmlParserContext context, XmlReaderSettings settings)
	{
	}

	public override string GetAttribute(string name)
	{
		return null;
	}

	public override string GetAttribute(string localName, string namespaceURI)
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

	private void FinishInit()
	{
	}

	public override bool Read()
	{
		return false;
	}

	public override void Close()
	{
	}

	public override void Skip()
	{
	}

	public override string LookupNamespace(string prefix)
	{
		return null;
	}

	public override bool ReadAttributeValue()
	{
		return false;
	}

	public override void ResolveEntity()
	{
	}

	internal void MoveOffEntityReference()
	{
	}

	public override string ReadString()
	{
		return null;
	}

	public override int ReadValueChunk(char[] buffer, int index, int count)
	{
		return 0;
	}

	public bool HasLineInfo()
	{
		return false;
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

	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
	{
		return null;
	}

	internal string LookupPrefix(string namespaceName)
	{
		return null;
	}

	internal void DtdParserProxy_OnNewLine(int pos)
	{
	}

	internal int DtdParserProxy_ReadData()
	{
		return 0;
	}

	internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder)
	{
		return 0;
	}

	internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
	{
		return 0;
	}

	internal void DtdParserProxy_ParsePI(StringBuilder sb)
	{
	}

	internal void DtdParserProxy_ParseComment(StringBuilder sb)
	{
	}

	private XmlResolver GetTempResolver()
	{
		return null;
	}

	internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId)
	{
		entityId = default(int);
		return false;
	}

	internal bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId)
	{
		oldEntity = null;
		newEntityId = default(int);
		return false;
	}

	internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId)
	{
		return false;
	}

	internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd)
	{
	}

	internal void DtdParserProxy_Throw(Exception e)
	{
	}

	internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo)
	{
	}

	internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo)
	{
	}

	private void Throw(int pos, string res, string arg)
	{
	}

	private void Throw(int pos, string res, string[] args)
	{
	}

	private void Throw(int pos, string res)
	{
	}

	private void Throw(string res)
	{
	}

	private void Throw(string res, int lineNo, int linePos)
	{
	}

	private void Throw(string res, string arg)
	{
	}

	private void Throw(string res, string arg, int lineNo, int linePos)
	{
	}

	private void Throw(string res, string[] args)
	{
	}

	private void Throw(string res, string arg, Exception innerException)
	{
	}

	private void Throw(string res, string[] args, Exception innerException)
	{
	}

	private void Throw(Exception e)
	{
	}

	private void ReThrow(Exception e, int lineNo, int linePos)
	{
	}

	private void ThrowWithoutLineInfo(string res)
	{
	}

	private void ThrowWithoutLineInfo(string res, string arg)
	{
	}

	private void ThrowWithoutLineInfo(string res, string[] args, Exception innerException)
	{
	}

	private void ThrowInvalidChar(char[] data, int length, int invCharPos)
	{
	}

	private void SetErrorState()
	{
	}

	private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos)
	{
	}

	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception)
	{
	}

	private void FinishAttributeValueIterator()
	{
	}

	private void InitStreamInput(Stream stream, Encoding encoding)
	{
	}

	private void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding)
	{
	}

	private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding)
	{
	}

	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding)
	{
	}

	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, byte[] bytes, int byteCount, Encoding encoding)
	{
	}

	private void InitTextReaderInput(string baseUriStr, TextReader input)
	{
	}

	private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input)
	{
	}

	private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str)
	{
	}

	private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment)
	{
	}

	private void ProcessDtdFromParserContext(XmlParserContext context)
	{
	}

	private void OpenUrl()
	{
	}

	private void OpenUrlDelegate(object xmlResolver)
	{
	}

	private Encoding DetectEncoding()
	{
		return null;
	}

	private void SetupEncoding(Encoding encoding)
	{
	}

	private void SwitchEncoding(Encoding newEncoding)
	{
	}

	private Encoding CheckEncoding(string newEncodingName)
	{
		return null;
	}

	private void UnDecodeChars()
	{
	}

	private void SwitchEncodingToUTF8()
	{
	}

	private int ReadData()
	{
		return 0;
	}

	private int GetChars(int maxCharsCount)
	{
		return 0;
	}

	private void InvalidCharRecovery(ref int bytesCount, out int charsCount)
	{
		charsCount = default(int);
	}

	internal void Close(bool closeInput)
	{
	}

	private void ShiftBuffer(int sourcePos, int destPos, int count)
	{
	}

	private bool ParseXmlDeclaration(bool isTextDecl)
	{
		return false;
	}

	private bool ParseDocumentContent()
	{
		return false;
	}

	private bool ParseElementContent()
	{
		return false;
	}

	private void ThrowUnclosedElements()
	{
	}

	private void ParseElement()
	{
	}

	private void AddDefaultAttributesAndNormalize()
	{
	}

	private void ParseEndElement()
	{
	}

	private void ThrowTagMismatch(NodeData startTag)
	{
	}

	private void ParseAttributes()
	{
	}

	private void ElementNamespaceLookup()
	{
	}

	private void AttributeNamespaceLookup()
	{
	}

	private void AttributeDuplCheck()
	{
	}

	private void OnDefaultNamespaceDecl(NodeData attr)
	{
	}

	private void OnNamespaceDecl(NodeData attr)
	{
	}

	private void OnXmlReservedAttribute(NodeData attr)
	{
	}

	private void ParseAttributeValueSlow(int curPos, char quoteChar, NodeData attr)
	{
	}

	private void AddAttributeChunkToList(NodeData attr, NodeData chunk, ref NodeData lastChunk)
	{
	}

	private bool ParseText()
	{
		return false;
	}

	private bool ParseText(out int startPos, out int endPos, ref int outOrChars)
	{
		startPos = default(int);
		endPos = default(int);
		return false;
	}

	private void FinishPartialValue()
	{
	}

	private void FinishOtherValueIterator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SkipPartialTextValue()
	{
	}

	private void FinishReadValueChunk()
	{
	}

	private void FinishReadContentAsBinary()
	{
	}

	private void FinishReadElementContentAsBinary()
	{
	}

	private bool ParseRootLevelWhitespace()
	{
		return false;
	}

	private void ParseEntityReference()
	{
	}

	private EntityType HandleEntityReference(bool isInAttributeValue, EntityExpandType expandType, out int charRefEndPos)
	{
		charRefEndPos = default(int);
		return default(EntityType);
	}

	private EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos)
	{
		return default(EntityType);
	}

	private bool HandleEntityEnd(bool checkEntityNesting)
	{
		return false;
	}

	private void SetupEndEntityNodeInContent()
	{
	}

	private void SetupEndEntityNodeInAttribute()
	{
	}

	private bool ParsePI()
	{
		return false;
	}

	private bool ParsePI(StringBuilder piInDtdStringBuilder)
	{
		return false;
	}

	private bool ParsePIValue(out int outStartPos, out int outEndPos)
	{
		outStartPos = default(int);
		outEndPos = default(int);
		return false;
	}

	private bool ParseComment()
	{
		return false;
	}

	private void ParseCData()
	{
	}

	private void ParseCDataOrComment(XmlNodeType type)
	{
	}

	private bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos)
	{
		outStartPos = default(int);
		outEndPos = default(int);
		return false;
	}

	private bool ParseDoctypeDecl()
	{
		return false;
	}

	private void ParseDtd()
	{
	}

	private void SkipDtd()
	{
	}

	private void SkipPublicOrSystemIdLiteral()
	{
	}

	private void SkipUntil(char stopChar, bool recognizeLiterals)
	{
	}

	private int EatWhitespaces(StringBuilder sb)
	{
		return 0;
	}

	private int ParseCharRefInline(int startPos, out int charCount, out EntityType entityType)
	{
		charCount = default(int);
		entityType = default(EntityType);
		return 0;
	}

	private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out EntityType entityType)
	{
		entityType = default(EntityType);
		return 0;
	}

	private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out EntityType entityType)
	{
		charCount = default(int);
		entityType = default(EntityType);
		return 0;
	}

	private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
	{
		return 0;
	}

	private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder)
	{
		return 0;
	}

	private int ParseName()
	{
		return 0;
	}

	private int ParseQName(out int colonPos)
	{
		colonPos = default(int);
		return 0;
	}

	private int ParseQName(bool isQName, int startOffset, out int colonPos)
	{
		colonPos = default(int);
		return 0;
	}

	private bool ReadDataInName(ref int pos)
	{
		return false;
	}

	private string ParseEntityName()
	{
		return null;
	}

	private NodeData AddNode(int nodeIndex, int nodeDepth)
	{
		return null;
	}

	private NodeData AllocNode(int nodeIndex, int nodeDepth)
	{
		return null;
	}

	private NodeData AddAttributeNoChecks(string name, int attrDepth)
	{
		return null;
	}

	private NodeData AddAttribute(int endNamePos, int colonPos)
	{
		return null;
	}

	private NodeData AddAttribute(string localName, string prefix, string nameWPrefix)
	{
		return null;
	}

	private void PopElementContext()
	{
	}

	private void OnNewLine(int pos)
	{
	}

	private void OnEof()
	{
	}

	private string LookupNamespace(NodeData node)
	{
		return null;
	}

	private void AddNamespace(string prefix, string uri, NodeData attr)
	{
	}

	private void ResetAttributes()
	{
	}

	private void FullAttributeCleanup()
	{
	}

	private void PushXmlContext()
	{
	}

	private void PopXmlContext()
	{
	}

	private XmlNodeType GetWhitespaceType()
	{
		return default(XmlNodeType);
	}

	private XmlNodeType GetTextNodeType(int orChars)
	{
		return default(XmlNodeType);
	}

	private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName)
	{
	}

	private bool OpenAndPush(Uri uri)
	{
		return false;
	}

	private bool PushExternalEntity(IDtdEntityInfo entity)
	{
		return false;
	}

	private void PushInternalEntity(IDtdEntityInfo entity)
	{
	}

	private void PopEntity()
	{
	}

	private void RegisterEntity(IDtdEntityInfo entity)
	{
	}

	private void UnregisterEntity()
	{
	}

	private void PushParsingState()
	{
	}

	private void PopParsingState()
	{
	}

	private int IncrementalRead()
	{
		return 0;
	}

	private void FinishIncrementalRead()
	{
	}

	private bool ParseFragmentAttribute()
	{
		return false;
	}

	private bool ParseAttributeValueChunk()
	{
		return false;
	}

	private void ParseXmlDeclarationFragment()
	{
	}

	private void ThrowUnexpectedToken(int pos, string expectedToken)
	{
	}

	private void ThrowUnexpectedToken(string expectedToken1)
	{
	}

	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2)
	{
	}

	private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2)
	{
	}

	private string ParseUnexpectedToken(int pos)
	{
		return null;
	}

	private string ParseUnexpectedToken()
	{
		return null;
	}

	private void ThrowExpectingWhitespace(int pos)
	{
	}

	private int GetIndexOfAttributeWithoutPrefix(string name)
	{
		return 0;
	}

	private int GetIndexOfAttributeWithPrefix(string name)
	{
		return 0;
	}

	private bool ZeroEndingStream(int pos)
	{
		return false;
	}

	private void ParseDtdFromParserContext()
	{
	}

	private bool MoveToNextContentNode(bool moveIfOnContentNode)
	{
		return false;
	}

	private void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings)
	{
	}

	internal void SetDtdInfo(IDtdInfo newDtdInfo)
	{
	}

	internal void ChangeCurrentNodeType(XmlNodeType newNodeType)
	{
	}

	internal XmlResolver GetResolver()
	{
		return null;
	}

	private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, NodeData[] nameSortedNodeData)
	{
		return false;
	}

	internal bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef)
	{
		return false;
	}

	private NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute)
	{
		return null;
	}

	private bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver)
	{
		return false;
	}

	private void RegisterConsumedCharacters(long characters, bool inEntityReference)
	{
	}

	internal static string StripSpaces(string value)
	{
		return null;
	}

	internal static void StripSpaces(char[] value, int index, ref int len)
	{
	}

	internal static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count)
	{
	}

	internal static void BlockCopy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count)
	{
	}
}
