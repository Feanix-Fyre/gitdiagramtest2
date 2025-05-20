namespace System.Xml;

/// <summary>Represents an XML qualified name.</summary>
[Serializable]
public class XmlQualifiedName
{
	private delegate int HashCodeOfStringDelegate(string s, int sLen, long additionalEntropy);

	private static HashCodeOfStringDelegate hashCodeDelegate;

	private string name;

	private string ns;

	[NonSerialized]
	private int hash;

	/// <summary>Provides an empty <see cref="T:System.Xml.XmlQualifiedName" />.</summary>
	public static readonly XmlQualifiedName Empty;

	/// <summary>Gets a string representation of the namespace of the <see cref="T:System.Xml.XmlQualifiedName" />.</summary>
	/// <returns>A string representation of the namespace or String.Empty if a namespace is not defined for the object.</returns>
	public string Namespace => null;

	/// <summary>Gets a string representation of the qualified name of the <see cref="T:System.Xml.XmlQualifiedName" />.</summary>
	/// <returns>A string representation of the qualified name or String.Empty if a name is not defined for the object.</returns>
	public string Name => null;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Xml.XmlQualifiedName" /> is empty.</summary>
	/// <returns>
	///     <see langword="true" /> if name and namespace are empty strings; otherwise, <see langword="false" />.</returns>
	public bool IsEmpty => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlQualifiedName" /> class.</summary>
	public XmlQualifiedName()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlQualifiedName" /> class with the specified name.</summary>
	/// <param name="name">The local name to use as the name of the <see cref="T:System.Xml.XmlQualifiedName" /> object. </param>
	public XmlQualifiedName(string name)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlQualifiedName" /> class with the specified name and namespace.</summary>
	/// <param name="name">The local name to use as the name of the <see cref="T:System.Xml.XmlQualifiedName" /> object. </param>
	/// <param name="ns">The namespace for the <see cref="T:System.Xml.XmlQualifiedName" /> object. </param>
	public XmlQualifiedName(string name, string ns)
	{
	}

	/// <summary>Returns the hash code for the <see cref="T:System.Xml.XmlQualifiedName" />.</summary>
	/// <returns>A hash code for this object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Returns the string value of the <see cref="T:System.Xml.XmlQualifiedName" />.</summary>
	/// <returns>The string value of the <see cref="T:System.Xml.XmlQualifiedName" /> in the format of <see langword="namespace:localname" />. If the object does not have a namespace defined, this method returns just the local name.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Determines whether the specified <see cref="T:System.Xml.XmlQualifiedName" /> object is equal to the current <see cref="T:System.Xml.XmlQualifiedName" /> object. </summary>
	/// <param name="other">The <see cref="T:System.Xml.XmlQualifiedName" /> to compare. </param>
	/// <returns>
	///     <see langword="true" /> if the two are the same instance object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object other)
	{
		return false;
	}

	/// <summary>Compares two <see cref="T:System.Xml.XmlQualifiedName" /> objects.</summary>
	/// <param name="a">An <see cref="T:System.Xml.XmlQualifiedName" /> to compare. </param>
	/// <param name="b">An <see cref="T:System.Xml.XmlQualifiedName" /> to compare. </param>
	/// <returns>
	///     <see langword="true" /> if the two objects have the same name and namespace values; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(XmlQualifiedName a, XmlQualifiedName b)
	{
		return false;
	}

	/// <summary>Compares two <see cref="T:System.Xml.XmlQualifiedName" /> objects.</summary>
	/// <param name="a">An <see cref="T:System.Xml.XmlQualifiedName" /> to compare. </param>
	/// <param name="b">An <see cref="T:System.Xml.XmlQualifiedName" /> to compare. </param>
	/// <returns>
	///     <see langword="true" /> if the name and namespace values for the two objects differ; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(XmlQualifiedName a, XmlQualifiedName b)
	{
		return false;
	}

	/// <summary>Returns the string value of the <see cref="T:System.Xml.XmlQualifiedName" />.</summary>
	/// <param name="name">The name of the object. </param>
	/// <param name="ns">The namespace of the object. </param>
	/// <returns>The string value of the <see cref="T:System.Xml.XmlQualifiedName" /> in the format of <see langword="namespace:localname" />. If the object does not have a namespace defined, this method returns just the local name.</returns>
	public static string ToString(string name, string ns)
	{
		return null;
	}

	private static HashCodeOfStringDelegate GetHashCodeDelegate()
	{
		return null;
	}

	private static bool IsRandomizedHashingDisabled()
	{
		return false;
	}

	private static int GetHashCodeOfString(string s, int length, long additionalEntropy)
	{
		return 0;
	}

	internal void Init(string name, string ns)
	{
	}

	internal void SetNamespace(string ns)
	{
	}

	internal void Verify()
	{
	}

	internal void Atomize(XmlNameTable nameTable)
	{
	}

	internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix)
	{
		prefix = null;
		return null;
	}

	internal XmlQualifiedName Clone()
	{
		return null;
	}
}
