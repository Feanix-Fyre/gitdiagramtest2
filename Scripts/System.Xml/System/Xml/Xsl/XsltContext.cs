using System.Xml.XPath;

namespace System.Xml.Xsl;

/// <summary>Encapsulates the current execution context of the Extensible Stylesheet Language for Transformations (XSLT) processor allowing XML Path Language (XPath) to resolve functions, parameters, and namespaces within XPath expressions.</summary>
public abstract class XsltContext : XmlNamespaceManager
{
	/// <summary>When overridden in a derived class, gets a value indicating whether to include white space nodes in the output.</summary>
	/// <returns>
	///     <see langword="true" /> to check white space nodes in the source document for inclusion in the output; <see langword="false" /> to not evaluate white space nodes. The default is <see langword="true" />.</returns>
	public abstract bool Whitespace { get; }

	internal XsltContext(bool dummy)
	{
	}

	/// <summary>When overridden in a derived class, resolves a variable reference and returns an <see cref="T:System.Xml.Xsl.IXsltContextVariable" /> representing the variable.</summary>
	/// <param name="prefix">The prefix of the variable as it appears in the XPath expression. </param>
	/// <param name="name">The name of the variable. </param>
	/// <returns>An <see cref="T:System.Xml.Xsl.IXsltContextVariable" /> representing the variable at runtime.</returns>
	public abstract IXsltContextVariable ResolveVariable(string prefix, string name);

	/// <summary>When overridden in a derived class, resolves a function reference and returns an <see cref="T:System.Xml.Xsl.IXsltContextFunction" /> representing the function. The <see cref="T:System.Xml.Xsl.IXsltContextFunction" /> is used at execution time to get the return value of the function.</summary>
	/// <param name="prefix">The prefix of the function as it appears in the XPath expression. </param>
	/// <param name="name">The name of the function. </param>
	/// <param name="ArgTypes">An array of argument types for the function being resolved. This allows you to select between methods with the same name (for example, overloaded methods). </param>
	/// <returns>An <see cref="T:System.Xml.Xsl.IXsltContextFunction" /> representing the function.</returns>
	public abstract IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes);

	/// <summary>When overridden in a derived class, evaluates whether to preserve white space nodes or strip them for the given context.</summary>
	/// <param name="node">The white space node that is to be preserved or stripped in the current context. </param>
	/// <returns>Returns <see langword="true" /> if the white space is to be preserved or <see langword="false" /> if the white space is to be stripped.</returns>
	public abstract bool PreserveWhitespace(XPathNavigator node);
}
