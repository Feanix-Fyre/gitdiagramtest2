namespace System.Xml.Linq;

/// <summary>Represents an XML namespace. This class cannot be inherited.</summary>
public sealed class XNamespace
{
	private static XHashtable<WeakReference> s_namespaces;

	private static WeakReference s_refNone;

	private static WeakReference s_refXml;

	private static WeakReference s_refXmlns;

	private string _namespaceName;

	private int _hashCode;

	private XHashtable<XName> _names;

	/// <summary>Gets the Uniform Resource Identifier (URI) of this namespace.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the URI of the namespace.</returns>
	public string NamespaceName => null;

	/// <summary>Gets the <see cref="T:System.Xml.Linq.XNamespace" /> object that corresponds to no namespace.</summary>
	/// <returns>The <see cref="T:System.Xml.Linq.XNamespace" /> that corresponds to no namespace.</returns>
	public static XNamespace None => null;

	/// <summary>Gets the <see cref="T:System.Xml.Linq.XNamespace" /> object that corresponds to the XML URI (http://www.w3.org/XML/1998/namespace).</summary>
	/// <returns>The <see cref="T:System.Xml.Linq.XNamespace" /> that corresponds to the XML URI (http://www.w3.org/XML/1998/namespace).</returns>
	public static XNamespace Xml => null;

	/// <summary>Gets the <see cref="T:System.Xml.Linq.XNamespace" /> object that corresponds to the xmlns URI (http://www.w3.org/2000/xmlns/).</summary>
	/// <returns>The <see cref="T:System.Xml.Linq.XNamespace" /> that corresponds to the xmlns URI (http://www.w3.org/2000/xmlns/).</returns>
	public static XNamespace Xmlns => null;

	internal XNamespace(string namespaceName)
	{
	}

	/// <summary>Returns an <see cref="T:System.Xml.Linq.XName" /> object created from this <see cref="T:System.Xml.Linq.XNamespace" /> and the specified local name.</summary>
	/// <param name="localName">A <see cref="T:System.String" /> that contains a local name.</param>
	/// <returns>An <see cref="T:System.Xml.Linq.XName" /> created from this <see cref="T:System.Xml.Linq.XNamespace" /> and the specified local name.</returns>
	public XName GetName(string localName)
	{
		return null;
	}

	/// <summary>Returns the URI of this <see cref="T:System.Xml.Linq.XNamespace" />.</summary>
	/// <returns>The URI of this <see cref="T:System.Xml.Linq.XNamespace" />.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Gets an <see cref="T:System.Xml.Linq.XNamespace" /> for the specified Uniform Resource Identifier (URI).</summary>
	/// <param name="namespaceName">A <see cref="T:System.String" /> that contains a namespace URI.</param>
	/// <returns>An <see cref="T:System.Xml.Linq.XNamespace" /> created from the specified URI.</returns>
	public static XNamespace Get(string namespaceName)
	{
		return null;
	}

	/// <summary>Converts a string containing a Uniform Resource Identifier (URI) to an <see cref="T:System.Xml.Linq.XNamespace" />.</summary>
	/// <param name="namespaceName">A <see cref="T:System.String" /> that contains the namespace URI.</param>
	/// <returns>An <see cref="T:System.Xml.Linq.XNamespace" /> constructed from the URI string.</returns>
	[CLSCompliant(false)]
	public static implicit operator XNamespace(string namespaceName)
	{
		return null;
	}

	/// <summary>Determines whether the specified <see cref="T:System.Xml.Linq.XNamespace" /> is equal to the current <see cref="T:System.Xml.Linq.XNamespace" />.</summary>
	/// <param name="obj">The <see cref="T:System.Xml.Linq.XNamespace" /> to compare to the current <see cref="T:System.Xml.Linq.XNamespace" />.</param>
	/// <returns>A <see cref="T:System.Boolean" /> that indicates whether the specified <see cref="T:System.Xml.Linq.XNamespace" /> is equal to the current <see cref="T:System.Xml.Linq.XNamespace" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Gets a hash code for this <see cref="T:System.Xml.Linq.XNamespace" />.</summary>
	/// <returns>An <see cref="T:System.Int32" /> that contains the hash code for the <see cref="T:System.Xml.Linq.XNamespace" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Returns a value indicating whether two instances of <see cref="T:System.Xml.Linq.XNamespace" /> are equal.</summary>
	/// <param name="left">The first <see cref="T:System.Xml.Linq.XNamespace" /> to compare.</param>
	/// <param name="right">The second <see cref="T:System.Xml.Linq.XNamespace" /> to compare.</param>
	/// <returns>A <see cref="T:System.Boolean" /> that indicates whether <paramref name="left" /> and <paramref name="right" /> are equal.</returns>
	public static bool operator ==(XNamespace left, XNamespace right)
	{
		return false;
	}

	/// <summary>Returns a value indicating whether two instances of <see cref="T:System.Xml.Linq.XNamespace" /> are not equal.</summary>
	/// <param name="left">The first <see cref="T:System.Xml.Linq.XNamespace" /> to compare.</param>
	/// <param name="right">The second <see cref="T:System.Xml.Linq.XNamespace" /> to compare.</param>
	/// <returns>A <see cref="T:System.Boolean" /> that indicates whether <paramref name="left" /> and <paramref name="right" /> are not equal.</returns>
	public static bool operator !=(XNamespace left, XNamespace right)
	{
		return false;
	}

	internal XName GetName(string localName, int index, int count)
	{
		return null;
	}

	internal static XNamespace Get(string namespaceName, int index, int count)
	{
		return null;
	}

	private static string ExtractLocalName(XName n)
	{
		return null;
	}

	private static string ExtractNamespace(WeakReference r)
	{
		return null;
	}

	private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName)
	{
		return null;
	}
}
