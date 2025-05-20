namespace System.Xml;

/// <summary>Specifies the options for processing DTDs. The <see cref="T:System.Xml.DtdProcessing" /> enumeration is used by the <see cref="T:System.Xml.XmlReaderSettings" /> class.</summary>
public enum DtdProcessing
{
	/// <summary>Specifies that when a DTD is encountered, an <see cref="T:System.Xml.XmlException" /> is thrown with a message that states that DTDs are prohibited. This is the default behavior.</summary>
	Prohibit = 0,
	/// <summary>Causes the DOCTYPE element to be ignored. No DTD processing occurs. </summary>
	Ignore = 1,
	/// <summary>Used for parsing DTDs.</summary>
	Parse = 2
}
