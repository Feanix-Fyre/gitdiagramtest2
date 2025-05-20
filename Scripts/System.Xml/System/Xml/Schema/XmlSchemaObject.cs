using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the root class for the Xml schema object model hierarchy and serves as a base class for classes such as the <see cref="T:System.Xml.Schema.XmlSchema" /> class.</summary>
public abstract class XmlSchemaObject
{
	private int lineNum;

	private int linePos;

	private string sourceUri;

	private XmlSerializerNamespaces namespaces;

	private XmlSchemaObject parent;

	private bool isProcessing;

	/// <summary>Gets or sets the line number in the file to which the <see langword="schema" /> element refers.</summary>
	/// <returns>The line number.</returns>
	[XmlIgnore]
	public int LineNumber
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the line position in the file to which the <see langword="schema" /> element refers.</summary>
	/// <returns>The line position.</returns>
	[XmlIgnore]
	public int LinePosition
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the source location for the file that loaded the schema.</summary>
	/// <returns>The source location (URI) for the file.</returns>
	[XmlIgnore]
	public string SourceUri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the parent of this <see cref="T:System.Xml.Schema.XmlSchemaObject" />.</summary>
	/// <returns>The parent <see cref="T:System.Xml.Schema.XmlSchemaObject" /> of this <see cref="T:System.Xml.Schema.XmlSchemaObject" />.</returns>
	[XmlIgnore]
	public XmlSchemaObject Parent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> to use with this schema object.</summary>
	/// <returns>The <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> property for the schema object.</returns>
	[XmlNamespaceDeclarations]
	public XmlSerializerNamespaces Namespaces
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[XmlIgnore]
	internal virtual string IdAttribute
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[XmlIgnore]
	internal virtual string NameAttribute
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[XmlIgnore]
	internal bool IsProcessing
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal virtual void OnAdd(XmlSchemaObjectCollection container, object item)
	{
	}

	internal virtual void OnRemove(XmlSchemaObjectCollection container, object item)
	{
	}

	internal virtual void OnClear(XmlSchemaObjectCollection container)
	{
	}

	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes)
	{
	}

	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation)
	{
	}

	internal virtual XmlSchemaObject Clone()
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaObject" /> class.</summary>
	protected XmlSchemaObject()
	{
	}
}
