using System.Collections.Generic;
using System.Xml.Xsl.Runtime;

namespace System.Xml;

internal sealed class XmlEventCache : XmlRawWriter
{
	private enum XmlEventType
	{
		Unknown = 0,
		DocType = 1,
		StartElem = 2,
		StartAttr = 3,
		EndAttr = 4,
		CData = 5,
		Comment = 6,
		PI = 7,
		Whitespace = 8,
		String = 9,
		Raw = 10,
		EntRef = 11,
		CharEnt = 12,
		SurrCharEnt = 13,
		Base64 = 14,
		BinHex = 15,
		XmlDecl1 = 16,
		XmlDecl2 = 17,
		StartContent = 18,
		EndElem = 19,
		FullEndElem = 20,
		Nmsp = 21,
		EndBase64 = 22,
		Close = 23,
		Flush = 24,
		Dispose = 25
	}

	private struct XmlEvent
	{
		private XmlEventType eventType;

		private string s1;

		private string s2;

		private string s3;

		private object o;

		public XmlEventType EventType => default(XmlEventType);

		public string String1 => null;

		public string String2 => null;

		public string String3 => null;

		public object Object => null;

		public void InitEvent(XmlEventType eventType)
		{
		}

		public void InitEvent(XmlEventType eventType, string s1)
		{
		}

		public void InitEvent(XmlEventType eventType, string s1, string s2)
		{
		}

		public void InitEvent(XmlEventType eventType, string s1, string s2, string s3)
		{
		}

		public void InitEvent(XmlEventType eventType, string s1, string s2, string s3, object o)
		{
		}

		public void InitEvent(XmlEventType eventType, object o)
		{
		}
	}

	private List<XmlEvent[]> pages;

	private XmlEvent[] pageCurr;

	private int pageSize;

	private bool hasRootNode;

	private StringConcat singleText;

	private string baseUri;

	public XmlEventCache(string baseUri, bool hasRootNode)
	{
	}

	public void EndEvents()
	{
	}

	public void EventsToWriter(XmlWriter writer)
	{
	}

	public override void WriteDocType(string name, string pubid, string sysid, string subset)
	{
	}

	public override void WriteStartElement(string prefix, string localName, string ns)
	{
	}

	public override void WriteStartAttribute(string prefix, string localName, string ns)
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

	public override void WriteEntityRef(string name)
	{
	}

	public override void WriteCharEntity(char ch)
	{
	}

	public override void WriteSurrogateCharEntity(char lowChar, char highChar)
	{
	}

	public override void WriteBase64(byte[] buffer, int index, int count)
	{
	}

	public override void WriteBinHex(byte[] buffer, int index, int count)
	{
	}

	public override void Close()
	{
	}

	public override void Flush()
	{
	}

	public override void WriteValue(string value)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	internal override void WriteXmlDeclaration(XmlStandalone standalone)
	{
	}

	internal override void WriteXmlDeclaration(string xmldecl)
	{
	}

	internal override void StartElementContent()
	{
	}

	internal override void WriteEndElement(string prefix, string localName, string ns)
	{
	}

	internal override void WriteFullEndElement(string prefix, string localName, string ns)
	{
	}

	internal override void WriteNamespaceDeclaration(string prefix, string ns)
	{
	}

	internal override void WriteEndBase64()
	{
	}

	private void AddEvent(XmlEventType eventType)
	{
	}

	private void AddEvent(XmlEventType eventType, string s1)
	{
	}

	private void AddEvent(XmlEventType eventType, string s1, string s2)
	{
	}

	private void AddEvent(XmlEventType eventType, string s1, string s2, string s3)
	{
	}

	private void AddEvent(XmlEventType eventType, string s1, string s2, string s3, object o)
	{
	}

	private void AddEvent(XmlEventType eventType, object o)
	{
	}

	private int NewEvent()
	{
		return 0;
	}

	private static byte[] ToBytes(byte[] buffer, int index, int count)
	{
		return null;
	}
}
