namespace System.Xml.Linq;

/// <summary>Represents a node or an attribute in an XML tree.</summary>
public abstract class XObject : IXmlLineInfo
{
	internal XContainer parent;

	internal object annotations;

	/// <summary>Gets the base URI for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the base URI for this <see cref="T:System.Xml.Linq.XObject" />.</returns>
	public string BaseUri => null;

	/// <summary>Gets the node type for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
	/// <returns>The node type for this <see cref="T:System.Xml.Linq.XObject" />.</returns>
	public abstract XmlNodeType NodeType { get; }

	/// <summary>Gets the parent <see cref="T:System.Xml.Linq.XElement" /> of this <see cref="T:System.Xml.Linq.XObject" />.</summary>
	/// <returns>The parent <see cref="T:System.Xml.Linq.XElement" /> of this <see cref="T:System.Xml.Linq.XObject" />.</returns>
	public XElement Parent => null;

	/// <summary>Gets the line number that the underlying <see cref="T:System.Xml.XmlReader" /> reported for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
	/// <returns>An <see cref="T:System.Int32" /> that contains the line number reported by the <see cref="T:System.Xml.XmlReader" /> for this <see cref="T:System.Xml.Linq.XObject" />.</returns>
	int IXmlLineInfo.LineNumber => 0;

	/// <summary>Gets the line position that the underlying <see cref="T:System.Xml.XmlReader" /> reported for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
	/// <returns>An <see cref="T:System.Int32" /> that contains the line position reported by the <see cref="T:System.Xml.XmlReader" /> for this <see cref="T:System.Xml.Linq.XObject" />.</returns>
	int IXmlLineInfo.LinePosition => 0;

	internal bool HasBaseUri => false;

	internal XObject()
	{
	}

	/// <summary>Adds an object to the annotation list of this <see cref="T:System.Xml.Linq.XObject" />.</summary>
	/// <param name="annotation">An object that contains the annotation to add.</param>
	public void AddAnnotation(object annotation)
	{
	}

	private object AnnotationForSealedType(Type type)
	{
		return null;
	}

	/// <summary>Gets the first annotation object of the specified type from this <see cref="T:System.Xml.Linq.XObject" />.</summary>
	/// <typeparam name="T">The type of the annotation to retrieve.</typeparam>
	/// <returns>The first annotation object that matches the specified type, or <see langword="null" /> if no annotation is of the specified type.</returns>
	public T Annotation<T>() where T : class
	{
		return null;
	}

	/// <summary>Gets a value indicating whether or not this <see cref="T:System.Xml.Linq.XObject" /> has line information.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Xml.Linq.XObject" /> has line information; otherwise, <see langword="false" />.</returns>
	bool IXmlLineInfo.HasLineInfo()
	{
		return false;
	}

	internal bool NotifyChanged(object sender, XObjectChangeEventArgs e)
	{
		return false;
	}

	internal bool NotifyChanging(object sender, XObjectChangeEventArgs e)
	{
		return false;
	}

	internal void SetBaseUri(string baseUri)
	{
	}

	internal void SetLineInfo(int lineNumber, int linePosition)
	{
	}

	internal bool SkipNotify()
	{
		return false;
	}

	internal SaveOptions GetSaveOptionsFromAnnotations()
	{
		return default(SaveOptions);
	}
}
