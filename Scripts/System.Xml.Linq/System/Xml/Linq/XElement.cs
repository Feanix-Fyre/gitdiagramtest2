using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Xml.Linq;

/// <summary>Represents an XML element.  See XElement Class Overview and the Remarks section on this page for usage information and examples.</summary>
[XmlSchemaProvider(null, IsAny = true)]
[XmlTypeConvertor("ConvertForAssignment")]
public class XElement : XContainer, IXmlSerializable
{
	[CompilerGenerated]
	private sealed class _003CGetAttributes_003Ed__116 : IEnumerable<XAttribute>, IEnumerable, IEnumerator<XAttribute>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private XAttribute _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public XElement _003C_003E4__this;

		private XName name;

		public XName _003C_003E3__name;

		private XAttribute _003Ca_003E5__2;

		XAttribute IEnumerator<XAttribute>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CGetAttributes_003Ed__116(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<XAttribute> IEnumerable<XAttribute>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	internal XName name;

	internal XAttribute lastAttr;

	/// <summary>Gets a value indicating whether this element has at least one attribute.</summary>
	/// <returns>
	///   <see langword="true" /> if this element has at least one attribute; otherwise <see langword="false" />.</returns>
	public bool HasAttributes => false;

	/// <summary>Gets a value indicating whether this element contains no content.</summary>
	/// <returns>
	///   <see langword="true" /> if this element contains no content; otherwise <see langword="false" />.</returns>
	public bool IsEmpty => false;

	/// <summary>Gets or sets the name of this element.</summary>
	/// <returns>An <see cref="T:System.Xml.Linq.XName" /> that contains the name of this element.</returns>
	public XName Name => null;

	/// <summary>Gets the node type for this node.</summary>
	/// <returns>The node type. For <see cref="T:System.Xml.Linq.XElement" /> objects, this value is <see cref="F:System.Xml.XmlNodeType.Element" />.</returns>
	public override XmlNodeType NodeType => default(XmlNodeType);

	/// <summary>Gets or sets the concatenated text contents of this element.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains all of the text content of this element. If there are multiple text nodes, they will be concatenated.</returns>
	public string Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XElement" /> class with the specified name.</summary>
	/// <param name="name">An <see cref="T:System.Xml.Linq.XName" /> that contains the name of the element.</param>
	public XElement(XName name)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XElement" /> class from another <see cref="T:System.Xml.Linq.XElement" /> object.</summary>
	/// <param name="other">An <see cref="T:System.Xml.Linq.XElement" /> object to copy from.</param>
	public XElement(XElement other)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XElement" /> class from an <see cref="T:System.Xml.Linq.XStreamingElement" /> object.</summary>
	/// <param name="other">An <see cref="T:System.Xml.Linq.XStreamingElement" /> that contains unevaluated queries that will be iterated for the contents of this <see cref="T:System.Xml.Linq.XElement" />.</param>
	public XElement(XStreamingElement other)
	{
	}

	/// <summary>Returns the <see cref="T:System.Xml.Linq.XAttribute" /> of this <see cref="T:System.Xml.Linq.XElement" /> that has the specified <see cref="T:System.Xml.Linq.XName" />.</summary>
	/// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> of the <see cref="T:System.Xml.Linq.XAttribute" /> to get.</param>
	/// <returns>An <see cref="T:System.Xml.Linq.XAttribute" /> that has the specified <see cref="T:System.Xml.Linq.XName" />; <see langword="null" /> if there is no attribute with the specified name.</returns>
	public XAttribute Attribute(XName name)
	{
		return null;
	}

	/// <summary>Returns a collection of attributes of this element.</summary>
	/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XAttribute" /> of attributes of this element.</returns>
	public IEnumerable<XAttribute> Attributes()
	{
		return null;
	}

	/// <summary>Gets the prefix associated with a namespace for this <see cref="T:System.Xml.Linq.XElement" />.</summary>
	/// <param name="ns">An <see cref="T:System.Xml.Linq.XNamespace" /> to look up.</param>
	/// <returns>A <see cref="T:System.String" /> that contains the namespace prefix.</returns>
	public string GetPrefixOfNamespace(XNamespace ns)
	{
		return null;
	}

	/// <summary>Write this element to an <see cref="T:System.Xml.XmlWriter" />.</summary>
	/// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
	public override void WriteTo(XmlWriter writer)
	{
	}

	/// <summary>Gets an XML schema definition that describes the XML representation of this object.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchema" /> that describes the XML representation of the object that is produced by the <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" /> method and consumed by the <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" /> method.</returns>
	XmlSchema IXmlSerializable.GetSchema()
	{
		return null;
	}

	/// <summary>Generates an object from its XML representation.</summary>
	/// <param name="reader">The <see cref="T:System.Xml.XmlReader" /> from which the object is deserialized.</param>
	void IXmlSerializable.ReadXml(XmlReader reader)
	{
	}

	/// <summary>Converts an object into its XML representation.</summary>
	/// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> to which this object is serialized.</param>
	void IXmlSerializable.WriteXml(XmlWriter writer)
	{
	}

	internal override void AddAttribute(XAttribute a)
	{
	}

	internal override void AddAttributeSkipNotify(XAttribute a)
	{
	}

	internal void AppendAttribute(XAttribute a)
	{
	}

	internal void AppendAttributeSkipNotify(XAttribute a)
	{
	}

	internal override XNode CloneNode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetAttributes_003Ed__116))]
	private IEnumerable<XAttribute> GetAttributes(XName name)
	{
		return null;
	}

	private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope)
	{
		return null;
	}

	private void ReadElementFrom(XmlReader r, LoadOptions o)
	{
	}

	private void ReadElementFromImpl(XmlReader r, LoadOptions o)
	{
	}

	internal void SetEndElementLineInfo(int lineNumber, int linePosition)
	{
	}

	internal override void ValidateNode(XNode node, XNode previous)
	{
	}
}
