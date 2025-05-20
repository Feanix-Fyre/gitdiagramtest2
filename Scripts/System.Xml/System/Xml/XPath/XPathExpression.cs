namespace System.Xml.XPath;

/// <summary>Provides a typed class that represents a compiled XPath expression.</summary>
public abstract class XPathExpression
{
	internal XPathExpression()
	{
	}

	/// <summary>When overridden in a derived class, specifies the <see cref="T:System.Xml.IXmlNamespaceResolver" /> object to use for namespace resolution.</summary>
	/// <param name="nsResolver">An object that implements the <see cref="T:System.Xml.IXmlNamespaceResolver" /> interface to use for namespace resolution.</param>
	/// <exception cref="T:System.Xml.XPath.XPathException">The <see cref="T:System.Xml.IXmlNamespaceResolver" /> object parameter is not derived from <see cref="T:System.Xml.IXmlNamespaceResolver" />. </exception>
	public abstract void SetContext(IXmlNamespaceResolver nsResolver);

	/// <summary>Compiles the XPath expression specified and returns an <see cref="T:System.Xml.XPath.XPathExpression" /> object representing the XPath expression.</summary>
	/// <param name="xpath">An XPath expression.</param>
	/// <returns>An <see cref="T:System.Xml.XPath.XPathExpression" /> object.</returns>
	/// <exception cref="T:System.ArgumentException">The XPath expression parameter is not a valid XPath expression.</exception>
	/// <exception cref="T:System.Xml.XPath.XPathException">The XPath expression is not valid.</exception>
	public static XPathExpression Compile(string xpath)
	{
		return null;
	}

	/// <summary>Compiles the specified XPath expression, with the <see cref="T:System.Xml.IXmlNamespaceResolver" /> object specified for namespace resolution, and returns an <see cref="T:System.Xml.XPath.XPathExpression" /> object that represents the XPath expression.</summary>
	/// <param name="xpath">An XPath expression.</param>
	/// <param name="nsResolver">An object that implements the <see cref="T:System.Xml.IXmlNamespaceResolver" /> interface for namespace resolution.</param>
	/// <returns>An <see cref="T:System.Xml.XPath.XPathExpression" /> object.</returns>
	/// <exception cref="T:System.ArgumentException">The XPath expression parameter is not a valid XPath expression.</exception>
	/// <exception cref="T:System.Xml.XPath.XPathException">The XPath expression is not valid.</exception>
	public static XPathExpression Compile(string xpath, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}
}
