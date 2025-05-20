using System.Collections;
using System.Collections.Generic;

namespace System.Xml;

/// <summary>Resolves, adds, and removes namespaces to a collection and provides scope management for these namespaces. </summary>
public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable
{
	private struct NamespaceDeclaration
	{
		public string prefix;

		public string uri;

		public int scopeId;

		public int previousNsIndex;

		public void Set(string prefix, string uri, int scopeId, int previousNsIndex)
		{
		}
	}

	private NamespaceDeclaration[] nsdecls;

	private int lastDecl;

	private XmlNameTable nameTable;

	private int scopeId;

	private Dictionary<string, int> hashTable;

	private bool useHashtable;

	private string xml;

	private string xmlNs;

	/// <summary>Gets the <see cref="T:System.Xml.XmlNameTable" /> associated with this object.</summary>
	/// <returns>The <see cref="T:System.Xml.XmlNameTable" /> used by this object.</returns>
	public virtual XmlNameTable NameTable => null;

	/// <summary>Gets the namespace URI for the default namespace.</summary>
	/// <returns>Returns the namespace URI for the default namespace, or String.Empty if there is no default namespace.</returns>
	public virtual string DefaultNamespace => null;

	internal XmlNamespaceManager()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlNamespaceManager" /> class with the specified <see cref="T:System.Xml.XmlNameTable" />.</summary>
	/// <param name="nameTable">The <see cref="T:System.Xml.XmlNameTable" /> to use. </param>
	/// <exception cref="T:System.NullReferenceException">
	///         <see langword="null" /> is passed to the constructor </exception>
	public XmlNamespaceManager(XmlNameTable nameTable)
	{
	}

	/// <summary>Pushes a namespace scope onto the stack.</summary>
	public virtual void PushScope()
	{
	}

	/// <summary>Pops a namespace scope off the stack.</summary>
	/// <returns>
	///     <see langword="true" /> if there are namespace scopes left on the stack; <see langword="false" /> if there are no more namespaces to pop.</returns>
	public virtual bool PopScope()
	{
		return false;
	}

	/// <summary>Adds the given namespace to the collection.</summary>
	/// <param name="prefix">The prefix to associate with the namespace being added. Use String.Empty to add a default namespace.
	///       NoteIf the <see cref="T:System.Xml.XmlNamespaceManager" /> will be used for resolving namespaces in an XML Path Language (XPath) expression, a prefix must be specified. If an XPath expression does not include a prefix, it is assumed that the namespace Uniform Resource Identifier (URI) is the empty namespace. For more information about XPath expressions and the <see cref="T:System.Xml.XmlNamespaceManager" />, refer to the <see cref="M:System.Xml.XmlNode.SelectNodes(System.String)" /> and <see cref="M:System.Xml.XPath.XPathExpression.SetContext(System.Xml.XmlNamespaceManager)" /> methods.</param>
	/// <param name="uri">The namespace to add. </param>
	/// <exception cref="T:System.ArgumentException">The value for <paramref name="prefix" /> is "xml" or "xmlns". </exception>
	/// <exception cref="T:System.ArgumentNullException">The value for <paramref name="prefix" /> or <paramref name="uri" /> is <see langword="null" />. </exception>
	public virtual void AddNamespace(string prefix, string uri)
	{
	}

	/// <summary>Removes the given namespace for the given prefix.</summary>
	/// <param name="prefix">The prefix for the namespace </param>
	/// <param name="uri">The namespace to remove for the given prefix. The namespace removed is from the current namespace scope. Namespaces outside the current scope are ignored. </param>
	/// <exception cref="T:System.ArgumentNullException">The value of <paramref name="prefix" /> or <paramref name="uri" /> is <see langword="null" />. </exception>
	public virtual void RemoveNamespace(string prefix, string uri)
	{
	}

	/// <summary>Returns an enumerator to use to iterate through the namespaces in the <see cref="T:System.Xml.XmlNamespaceManager" />.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> containing the prefixes stored by the <see cref="T:System.Xml.XmlNamespaceManager" />.</returns>
	public virtual IEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Gets a collection of namespace names keyed by prefix which can be used to enumerate the namespaces currently in scope.</summary>
	/// <param name="scope">An enumeration value that specifies the type of namespace nodes to return.</param>
	/// <returns>A collection of namespace and prefix pairs currently in scope.</returns>
	public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
	{
		return null;
	}

	/// <summary>Gets the namespace URI for the specified prefix.</summary>
	/// <param name="prefix">The prefix whose namespace URI you want to resolve. To match the default namespace, pass String.Empty. </param>
	/// <returns>Returns the namespace URI for <paramref name="prefix" /> or <see langword="null" /> if there is no mapped namespace. The returned string is atomized.For more information on atomized strings, see the <see cref="T:System.Xml.XmlNameTable" /> class.</returns>
	public virtual string LookupNamespace(string prefix)
	{
		return null;
	}

	private int LookupNamespaceDecl(string prefix)
	{
		return 0;
	}

	/// <summary>Finds the prefix declared for the given namespace URI.</summary>
	/// <param name="uri">The namespace to resolve for the prefix. </param>
	/// <returns>The matching prefix. If there is no mapped prefix, the method returns String.Empty. If a null value is supplied, then <see langword="null" /> is returned.</returns>
	public virtual string LookupPrefix(string uri)
	{
		return null;
	}
}
