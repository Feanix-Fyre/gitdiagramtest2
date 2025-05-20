using System.Xml.XPath;

namespace System.Xml.Xsl;

/// <summary>Provides an interface to a given function defined in the Extensible Stylesheet Language for Transformations (XSLT) style sheet during runtime execution.</summary>
public interface IXsltContextFunction
{
	/// <summary>Gets the <see cref="T:System.Xml.XPath.XPathResultType" /> representing the XPath type returned by the function.</summary>
	/// <returns>An <see cref="T:System.Xml.XPath.XPathResultType" /> representing the XPath type returned by the function </returns>
	XPathResultType ReturnType { get; }

	/// <summary>Provides the method to invoke the function with the given arguments in the given context.</summary>
	/// <param name="xsltContext">The XSLT context for the function call. </param>
	/// <param name="args">The arguments of the function call. Each argument is an element in the array. </param>
	/// <param name="docContext">The context node for the function call. </param>
	/// <returns>An <see cref="T:System.Object" /> representing the return value of the function.</returns>
	object Invoke(XsltContext xsltContext, object[] args, XPathNavigator docContext);
}
