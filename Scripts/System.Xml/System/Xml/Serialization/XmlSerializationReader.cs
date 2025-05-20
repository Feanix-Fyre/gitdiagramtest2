using System.Collections;

namespace System.Xml.Serialization;

/// <summary>Controls deserialization by the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class. </summary>
[System.MonoTODO]
public abstract class XmlSerializationReader : XmlSerializationGeneratedCode
{
	private class WriteCallbackInfo
	{
		public Type Type;

		public string TypeName;

		public string TypeNs;

		public XmlSerializationReadCallback Callback;
	}

	/// <summary>Holds an <see cref="T:System.Xml.Serialization.XmlSerializationCollectionFixupCallback" /> delegate instance, plus the method's inputs; also supplies the method's parameters. </summary>
	protected class CollectionFixup
	{
		private XmlSerializationCollectionFixupCallback callback;

		private object collection;

		private object collectionItems;

		private string id;

		/// <summary>Gets the callback method that instantiates the <see cref="T:System.Xml.Serialization.XmlSerializationCollectionFixupCallback" /> delegate. </summary>
		/// <returns>The <see cref="T:System.Xml.Serialization.XmlSerializationCollectionFixupCallback" /> delegate that points to the callback method.</returns>
		public XmlSerializationCollectionFixupCallback Callback => null;

		/// <summary>Gets the <paramref name="object collection" /> for the callback method. </summary>
		/// <returns>The collection that is used for the fixup.</returns>
		public object Collection => null;

		internal object Id => null;

		/// <summary>Gets the array into which the callback method copies a collection. </summary>
		/// <returns>The array into which the callback method copies a collection.</returns>
		public object CollectionItems
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		internal CollectionFixup(object collection, XmlSerializationCollectionFixupCallback callback, string id)
		{
		}
	}

	/// <summary>Holds an <see cref="T:System.Xml.Serialization.XmlSerializationFixupCallback" /> delegate instance, plus the method's inputs; also serves as the parameter for the method.</summary>
	protected class Fixup
	{
		private object source;

		private string[] ids;

		private XmlSerializationFixupCallback callback;

		/// <summary>Gets the callback method that creates an instance of the <see cref="T:System.Xml.Serialization.XmlSerializationFixupCallback" /> delegate.</summary>
		/// <returns>The callback method that creates an instance of the <see cref="T:System.Xml.Serialization.XmlSerializationFixupCallback" /> delegate.</returns>
		public XmlSerializationFixupCallback Callback => null;

		/// <summary>Gets or sets an array of keys for the objects that belong to the <see cref="P:System.Xml.Serialization.XmlSerializationReader.Fixup.Source" /> property whose values get filled in by the callback implementation.</summary>
		/// <returns>The array of keys.</returns>
		public string[] Ids => null;

		/// <summary>Gets or sets the object that contains other objects whose values get filled in by the callback implementation.</summary>
		/// <returns>The source containing objects with values to fill.</returns>
		public object Source => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializationReader.Fixup" /> class.</summary>
		/// <param name="o">The object that contains other objects whose values get filled in by the callback implementation.</param>
		/// <param name="callback">A method that instantiates the <see cref="T:System.Xml.Serialization.XmlSerializationFixupCallback" /> delegate.</param>
		/// <param name="count">The size of the string array obtained through the <see cref="P:System.Xml.Serialization.XmlSerializationReader.Fixup.Ids" /> property.</param>
		public Fixup(object o, XmlSerializationFixupCallback callback, int count)
		{
		}
	}

	private class CollectionItemFixup
	{
		private Array list;

		private int index;

		private string id;

		public Array Collection => null;

		public int Index => 0;

		public string Id => null;

		public CollectionItemFixup(Array list, int index, string id)
		{
		}
	}

	private XmlDocument document;

	private XmlReader reader;

	private ArrayList fixups;

	private Hashtable collFixups;

	private ArrayList collItemFixups;

	private Hashtable typesCallbacks;

	private ArrayList noIDTargets;

	private Hashtable targets;

	private Hashtable delayedListFixups;

	private XmlSerializer eventSource;

	private int delayedFixupId;

	private Hashtable referencedObjects;

	private int readCount;

	private int whileIterationCount;

	private string w3SchemaNS;

	private string w3InstanceNS;

	private string w3InstanceNS2000;

	private string w3InstanceNS1999;

	private string soapNS;

	private string wsdlNS;

	private string nullX;

	private string nil;

	private string typeX;

	private string arrayType;

	private XmlQualifiedName arrayQName;

	/// <summary>Gets the XML document object into which the XML document is being deserialized. </summary>
	/// <returns>An <see cref="T:System.Xml.XmlDocument" /> that represents the deserialized <see cref="T:System.Xml.XmlDocument" /> data.</returns>
	protected XmlDocument Document => null;

	/// <summary>Gets the <see cref="T:System.Xml.XmlReader" /> object that is being used by <see cref="T:System.Xml.Serialization.XmlSerializationReader" />. </summary>
	/// <returns>The <see cref="T:System.Xml.XmlReader" /> that is being used by the <see cref="T:System.Xml.Serialization.XmlSerializationReader" />.</returns>
	protected XmlReader Reader => null;

	internal void Initialize(XmlReader reader, XmlSerializer eventSource)
	{
	}

	private ArrayList EnsureArrayList(ArrayList list)
	{
		return null;
	}

	private Hashtable EnsureHashtable(Hashtable hash)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializationReader" /> class.</summary>
	protected XmlSerializationReader()
	{
	}

	/// <summary>Stores an object that contains a callback method that will be called, as necessary, to fill in .NET Framework collections or enumerations that map to SOAP-encoded arrays or SOAP-encoded, multi-referenced elements. </summary>
	/// <param name="fixup">A <see cref="T:System.Xml.Serialization.XmlSerializationCollectionFixupCallback" /> delegate and the callback method's input data.</param>
	protected void AddFixup(CollectionFixup fixup)
	{
	}

	/// <summary>Stores an object that contains a callback method instance that will be called, as necessary, to fill in the objects in a SOAP-encoded array. </summary>
	/// <param name="fixup">An <see cref="T:System.Xml.Serialization.XmlSerializationFixupCallback" /> delegate and the callback method's input data.</param>
	protected void AddFixup(Fixup fixup)
	{
	}

	private void AddFixup(CollectionItemFixup fixup)
	{
	}

	/// <summary>Stores an implementation of the <see cref="T:System.Xml.Serialization.XmlSerializationReadCallback" /> delegate and its input data for a later invocation. </summary>
	/// <param name="name">The name of the .NET Framework type that is being deserialized.</param>
	/// <param name="ns">The namespace of the .NET Framework type that is being deserialized.</param>
	/// <param name="type">The <see cref="T:System.Type" /> to be deserialized.</param>
	/// <param name="read">An <see cref="T:System.Xml.Serialization.XmlSerializationReadCallback" /> delegate.</param>
	protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read)
	{
	}

	/// <summary>Stores an object that is being deserialized from a SOAP-encoded <see langword="multiRef" /> element for later access through the <see cref="M:System.Xml.Serialization.XmlSerializationReader.GetTarget(System.String)" /> method. </summary>
	/// <param name="id">The value of the <see langword="id" /> attribute of a <see langword="multiRef" /> element that identifies the element.</param>
	/// <param name="o">The object that is deserialized from the XML element.</param>
	protected void AddTarget(string id, object o)
	{
	}

	private string CurrentTag()
	{
		return null;
	}

	/// <summary>Creates an <see cref="T:System.InvalidOperationException" /> that indicates that a SOAP-encoded collection type cannot be modified and its values cannot be filled in. </summary>
	/// <param name="name">The fully qualified name of the .NET Framework type for which there is a mapping.</param>
	/// <returns>An <see cref="T:System.InvalidOperationException" /> exception.</returns>
	protected Exception CreateReadOnlyCollectionException(string name)
	{
		return null;
	}

	/// <summary>Creates an <see cref="T:System.InvalidOperationException" /> that indicates that an enumeration value is not valid. </summary>
	/// <param name="value">The enumeration value that is not valid.</param>
	/// <param name="enumType">The enumeration type.</param>
	/// <returns>An <see cref="T:System.InvalidOperationException" /> exception.</returns>
	protected Exception CreateUnknownConstantException(string value, Type enumType)
	{
		return null;
	}

	/// <summary>Creates an <see cref="T:System.InvalidOperationException" /> that indicates that the current position of <see cref="T:System.Xml.XmlReader" /> represents an unknown XML node. </summary>
	/// <returns>An <see cref="T:System.InvalidOperationException" /> exception.</returns>
	protected Exception CreateUnknownNodeException()
	{
		return null;
	}

	/// <summary>Creates an <see cref="T:System.InvalidOperationException" /> that indicates that a type is unknown. </summary>
	/// <param name="type">An <see cref="T:System.Xml.XmlQualifiedName" /> that represents the name of the unknown type.</param>
	/// <returns>An <see cref="T:System.InvalidOperationException" /> exception.</returns>
	protected Exception CreateUnknownTypeException(XmlQualifiedName type)
	{
		return null;
	}

	/// <summary>Ensures that a given array, or a copy, is large enough to contain a specified index. </summary>
	/// <param name="a">The <see cref="T:System.Array" /> that is being checked.</param>
	/// <param name="index">The required index.</param>
	/// <param name="elementType">The <see cref="T:System.Type" /> of the array's elements.</param>
	/// <returns>The existing <see cref="T:System.Array" />, if it is already large enough; otherwise, a new, larger array that contains the original array's elements.</returns>
	protected Array EnsureArrayIndex(Array a, int index, Type elementType)
	{
		return null;
	}

	/// <summary>Determines whether the XML element where the <see cref="T:System.Xml.XmlReader" /> is currently positioned has a null attribute set to the value <see langword="true" />.</summary>
	/// <returns>
	///     <see langword="true" /> if <see cref="T:System.Xml.XmlReader" /> is currently positioned over a null attribute with the value <see langword="true" />; otherwise, <see langword="false" />.</returns>
	protected bool GetNullAttr()
	{
		return false;
	}

	/// <summary>Gets an object that is being deserialized from a SOAP-encoded <see langword="multiRef" /> element and that was stored earlier by <see cref="M:System.Xml.Serialization.XmlSerializationReader.AddTarget(System.String,System.Object)" />.  </summary>
	/// <param name="id">The value of the <see langword="id" /> attribute of a <see langword="multiRef" /> element that identifies the element.</param>
	/// <returns>An object to be deserialized from a SOAP-encoded <see langword="multiRef" /> element.</returns>
	protected object GetTarget(string id)
	{
		return null;
	}

	private bool TargetReady(string id)
	{
		return false;
	}

	/// <summary>Gets the value of the <see langword="xsi:type" /> attribute for the XML element at the current location of the <see cref="T:System.Xml.XmlReader" />. </summary>
	/// <returns>An XML qualified name that indicates the data type of an XML element.</returns>
	protected XmlQualifiedName GetXsiType()
	{
		return null;
	}

	/// <summary>Initializes callback methods that populate objects that map to SOAP-encoded XML data. </summary>
	protected abstract void InitCallbacks();

	/// <summary>Stores element and attribute names in a <see cref="T:System.Xml.NameTable" /> object. </summary>
	protected abstract void InitIDs();

	/// <summary>Determines whether an XML attribute name indicates an XML namespace. </summary>
	/// <param name="name">The name of an XML attribute.</param>
	/// <returns>
	///     <see langword="true " />if the XML attribute name indicates an XML namespace; otherwise, <see langword="false" />.</returns>
	protected bool IsXmlnsAttribute(string name)
	{
		return false;
	}

	/// <summary>Sets the value of the XML attribute if it is of type <see langword="arrayType" /> from the Web Services Description Language (WSDL) namespace. </summary>
	/// <param name="attr">An <see cref="T:System.Xml.XmlAttribute" /> that may have the type <see langword="wsdl:array" />.</param>
	protected void ParseWsdlArrayType(XmlAttribute attr)
	{
	}

	/// <summary>Makes the <see cref="T:System.Xml.XmlReader" /> read the fully qualified name of the element where it is currently positioned. </summary>
	/// <returns>The fully qualified name of the current XML element.</returns>
	protected XmlQualifiedName ReadElementQualifiedName()
	{
		return null;
	}

	/// <summary>Makes the <see cref="T:System.Xml.XmlReader" /> read an XML end tag.</summary>
	protected void ReadEndElement()
	{
	}

	/// <summary>Instructs the <see cref="T:System.Xml.XmlReader" /> to read the current XML element if the element has a null attribute with the value true. </summary>
	/// <returns>
	///     <see langword="true" /> if the element has a null="true" attribute value and has been read; otherwise, <see langword="false" />.</returns>
	protected bool ReadNull()
	{
		return false;
	}

	/// <summary>Instructs the <see cref="T:System.Xml.XmlReader" /> to read the fully qualified name of the element where it is currently positioned. </summary>
	/// <returns>A <see cref="T:System.Xml.XmlQualifiedName" /> that represents the fully qualified name of the current XML element; otherwise, <see langword="null" /> if a null="true" attribute value is present.</returns>
	protected XmlQualifiedName ReadNullableQualifiedName()
	{
		return null;
	}

	/// <summary>Instructs the <see cref="T:System.Xml.XmlReader" /> to read a simple, text-only XML element that could be <see langword="null" />. </summary>
	/// <returns>The string value; otherwise, <see langword="null" />.</returns>
	protected string ReadNullableString()
	{
		return null;
	}

	/// <summary>Deserializes an object from a SOAP-encoded <see langword="multiRef" /> XML element. </summary>
	/// <returns>The value of the referenced element in the document.</returns>
	protected object ReadReferencedElement()
	{
		return null;
	}

	private WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname)
	{
		return null;
	}

	/// <summary>Deserializes an object from a SOAP-encoded <see langword="multiRef" /> XML element. </summary>
	/// <param name="name">The local name of the element's XML Schema data type.</param>
	/// <param name="ns">The namespace of the element's XML Schema data type.</param>
	/// <returns>The value of the referenced element in the document.</returns>
	protected object ReadReferencedElement(string name, string ns)
	{
		return null;
	}

	private bool ReadList(out object resultList)
	{
		resultList = null;
		return false;
	}

	/// <summary>Deserializes objects from the SOAP-encoded <see langword="multiRef" /> elements in a SOAP message. </summary>
	protected void ReadReferencedElements()
	{
	}

	/// <summary>Deserializes an object from an XML element in a SOAP message that contains a reference to a <see langword="multiRef" /> element. </summary>
	/// <param name="fixupReference">An output string into which the <see langword="href" /> attribute value is read.</param>
	/// <returns>The deserialized object.</returns>
	protected object ReadReferencingElement(out string fixupReference)
	{
		fixupReference = null;
		return null;
	}

	/// <summary>Deserializes an object from an XML element in a SOAP message that contains a reference to a <see langword="multiRef" /> element. </summary>
	/// <param name="name">The local name of the element's XML Schema data type.</param>
	/// <param name="ns">The namespace of the element's XML Schema data type.</param>
	/// <param name="fixupReference">An output string into which the <see langword="href" /> attribute value is read.</param>
	/// <returns>The deserialized object.</returns>
	protected object ReadReferencingElement(string name, string ns, out string fixupReference)
	{
		fixupReference = null;
		return null;
	}

	/// <summary>Deserializes an object from an XML element in a SOAP message that contains a reference to a <see langword="multiRef" /> element.</summary>
	/// <param name="name">The local name of the element's XML Schema data type.</param>
	/// <param name="ns">The namespace of the element's XML Schema data type.</param>
	/// <param name="elementCanBeType">
	///       <see langword="true" /> if the element name is also the XML Schema data type name; otherwise, <see langword="false" />.</param>
	/// <param name="fixupReference">An output string into which the value of the <see langword="href" /> attribute is read.</param>
	/// <returns>The deserialized object.</returns>
	protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference)
	{
		fixupReference = null;
		return null;
	}

	/// <summary>Populates an object from its XML representation at the current location of the <see cref="T:System.Xml.XmlReader" />. </summary>
	/// <param name="serializable">An <see cref="T:System.Xml.Serialization.IXmlSerializable" /> that corresponds to the current position of the <see cref="T:System.Xml.XmlReader" />.</param>
	/// <returns>An object that implements the <see cref="T:System.Xml.Serialization.IXmlSerializable" /> interface with its members populated from the location of the <see cref="T:System.Xml.XmlReader" />.</returns>
	protected IXmlSerializable ReadSerializable(IXmlSerializable serializable)
	{
		return null;
	}

	/// <summary>Gets the value of the XML node at which the <see cref="T:System.Xml.XmlReader" /> is currently positioned. </summary>
	/// <param name="type">The <see cref="T:System.Xml.XmlQualifiedName" /> that represents the simple data type for the current location of the <see cref="T:System.Xml.XmlReader" />.</param>
	/// <returns>The value of the node as a .NET Framework value type, if the value is a simple XML Schema data type.</returns>
	protected object ReadTypedPrimitive(XmlQualifiedName type)
	{
		return null;
	}

	private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown)
	{
		return null;
	}

	/// <summary>Instructs the <see cref="T:System.Xml.XmlReader" /> to read the XML node at its current position. </summary>
	/// <param name="wrapped">
	///       <see langword="true" /> to read content only after reading the element's start element; otherwise, <see langword="false" />.</param>
	/// <returns>An <see cref="T:System.Xml.XmlNode" /> that represents the XML node that has been read.</returns>
	protected XmlNode ReadXmlNode(bool wrapped)
	{
		return null;
	}

	/// <summary>Instructs the <see cref="T:System.Xml.XmlReader" /> to read an XML document root element at its current position.</summary>
	/// <param name="wrapped">
	///       <see langword="true" /> if the method should read content only after reading the element's start element; otherwise, <see langword="false" />.</param>
	/// <returns>An <see cref="T:System.Xml.XmlDocument" /> that contains the root element that has been read.</returns>
	protected XmlDocument ReadXmlDocument(bool wrapped)
	{
		return null;
	}

	/// <summary>Ensures that a given array, or a copy, is no larger than a specified length. </summary>
	/// <param name="a">The array that is being checked.</param>
	/// <param name="length">The maximum length of the array.</param>
	/// <param name="elementType">The <see cref="T:System.Type" /> of the array's elements.</param>
	/// <param name="isNullable">
	///       <see langword="true" /> if <see langword="null" /> for the array, if present for the input array, can be returned; otherwise, a new, smaller array.</param>
	/// <returns>The existing <see cref="T:System.Array" />, if it is already small enough; otherwise, a new, smaller array that contains the original array's elements up to the size of<paramref name=" length" />.</returns>
	protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable)
	{
		return null;
	}

	/// <summary>Obtains an <see cref="T:System.Xml.XmlQualifiedName" /> from a name that may contain a prefix. </summary>
	/// <param name="value">A name that may contain a prefix.</param>
	/// <returns>An <see cref="T:System.Xml.XmlQualifiedName" /> that represents a namespace-qualified XML name.</returns>
	protected XmlQualifiedName ToXmlQualifiedName(string value)
	{
		return null;
	}

	/// <summary>Raises an <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownAttribute" /> event for the current position of the <see cref="T:System.Xml.XmlReader" />.</summary>
	/// <param name="o">An object that the <see cref="T:System.Xml.Serialization.XmlSerializer" /> is attempting to deserialize, subsequently accessible through the <see cref="P:System.Xml.Serialization.XmlAttributeEventArgs.ObjectBeingDeserialized" /> property.</param>
	/// <param name="attr">A <see cref="T:System.Xml.XmlAttribute" /> that represents the attribute in question.</param>
	/// <param name="qnames">A comma-delimited list of XML qualified names.</param>
	protected void UnknownAttribute(object o, XmlAttribute attr, string qnames)
	{
	}

	/// <summary>Raises an <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownElement" /> event for the current position of the <see cref="T:System.Xml.XmlReader" />.</summary>
	/// <param name="o">An object that the <see cref="T:System.Xml.Serialization.XmlSerializer" /> is attempting to deserialize, subsequently accessible through the <see cref="P:System.Xml.Serialization.XmlAttributeEventArgs.ObjectBeingDeserialized" /> property.</param>
	/// <param name="elem">The <see cref="T:System.Xml.XmlElement" /> for which an event is raised.</param>
	/// <param name="qnames">A comma-delimited list of XML qualified names.</param>
	protected void UnknownElement(object o, XmlElement elem, string qnames)
	{
	}

	/// <summary>Raises an <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownNode" /> event for the current position of the <see cref="T:System.Xml.XmlReader" />. </summary>
	/// <param name="o">The object that is being deserialized.</param>
	protected void UnknownNode(object o)
	{
	}

	/// <summary>Raises an <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownNode" /> event for the current position of the <see cref="T:System.Xml.XmlReader" />.</summary>
	/// <param name="o">The object being deserialized.</param>
	/// <param name="qnames">A comma-delimited list of XML qualified names.</param>
	protected void UnknownNode(object o, string qnames)
	{
	}

	private void OnUnknownNode(XmlNode node, object o, string qnames)
	{
	}

	/// <summary>Raises an <see cref="E:System.Xml.Serialization.XmlSerializer.UnreferencedObject" /> event for the current position of the <see cref="T:System.Xml.XmlReader" />.</summary>
	/// <param name="id">A unique string that is used to identify the unreferenced object, subsequently accessible through the <see cref="P:System.Xml.Serialization.UnreferencedObjectEventArgs.UnreferencedId" /> property.</param>
	/// <param name="o">An object that the <see cref="T:System.Xml.Serialization.XmlSerializer" /> is attempting to deserialize, subsequently accessible through the <see cref="P:System.Xml.Serialization.UnreferencedObjectEventArgs.UnreferencedObject" /> property.</param>
	protected void UnreferencedObject(string id, object o)
	{
	}
}
