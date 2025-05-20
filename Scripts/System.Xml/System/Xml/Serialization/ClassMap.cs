using System.Collections;

namespace System.Xml.Serialization;

internal class ClassMap : ObjectMap
{
	private Hashtable _elements;

	private ArrayList _elementMembers;

	private Hashtable _attributeMembers;

	private XmlTypeMapMemberAttribute[] _attributeMembersArray;

	private ArrayList _flatLists;

	private ArrayList _allMembers;

	private ArrayList _membersWithDefault;

	private ArrayList _listMembers;

	private XmlTypeMapMemberAnyElement _defaultAnyElement;

	private XmlTypeMapMemberAnyAttribute _defaultAnyAttribute;

	private XmlTypeMapMemberNamespaces _namespaceDeclarations;

	private XmlTypeMapMember _xmlTextCollector;

	private XmlTypeMapMember _returnMember;

	private bool _ignoreMemberNamespace;

	private bool _canBeSimpleType;

	private bool? _isOrderDependentMap;

	public bool IsOrderDependentMap => false;

	public XmlTypeMapMemberAnyElement DefaultAnyElementMember => null;

	public XmlTypeMapMemberAnyAttribute DefaultAnyAttributeMember => null;

	public XmlTypeMapMemberNamespaces NamespaceDeclarations => null;

	public ICollection AttributeMembers => null;

	public ICollection ElementMembers => null;

	public ArrayList AllMembers => null;

	public ArrayList FlatLists => null;

	public ArrayList ListMembers => null;

	public XmlTypeMapMember XmlTextCollector => null;

	public XmlTypeMapMember ReturnMember => null;

	public XmlQualifiedName SimpleContentBaseType => null;

	public bool HasSimpleContent => false;

	public void AddMember(XmlTypeMapMember member)
	{
	}

	private void RegisterFlatList(XmlTypeMapMemberExpandable member)
	{
	}

	public XmlTypeMapMemberAttribute GetAttribute(string name, string ns)
	{
		return null;
	}

	public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder)
	{
		return null;
	}

	public XmlTypeMapElementInfo GetElement(string name, string ns)
	{
		return null;
	}

	private string BuildKey(string name, string ns, int explicitOrder)
	{
		return null;
	}

	public void SetCanBeSimpleType(bool can)
	{
	}
}
