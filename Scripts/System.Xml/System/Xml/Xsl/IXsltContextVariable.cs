using System.Xml.XPath;

namespace System.Xml.Xsl;

/// <summary>Provides an interface to a given variable that is defined in the style sheet during runtime execution.</summary>
public interface IXsltContextVariable
{
	/// <summary>Gets the <see cref="T:System.Xml.XPath.XPathResultType" /> representing the XML Path Language (XPath) type of the variable.</summary>
	/// <returns>The <see cref="T:System.Xml.XPath.XPathResultType" /> representing the XPath type of the variable.</returns>
	XPathResultType VariableType { get; }

	/// <summary>Evaluates the variable at runtime and returns an object that represents the value of the variable.</summary>
	/// <param name="xsltContext">An <see cref="T:System.Xml.Xsl.XsltContext" /> representing the execution context of the variable. </param>
	/// <returns>An <see cref="T:System.Object" /> representing the value of the variable. Possible return types include number, string, Boolean, document fragment, or node set.</returns>
	object Evaluate(XsltContext xsltContext);
}
