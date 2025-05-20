namespace System.Xml.Serialization;

internal class XmlSerializationReaderInterpreter : XmlSerializationReader
{
	private class FixupCallbackInfo
	{
		private XmlSerializationReaderInterpreter _sri;

		private ClassMap _map;

		private bool _isValueList;

		public FixupCallbackInfo(XmlSerializationReaderInterpreter sri, ClassMap map, bool isValueList)
		{
		}

		public void FixupMembers(object fixup)
		{
		}
	}

	private class ReaderCallbackInfo
	{
		private XmlSerializationReaderInterpreter _sri;

		private XmlTypeMapping _typeMap;

		public ReaderCallbackInfo(XmlSerializationReaderInterpreter sri, XmlTypeMapping typeMap)
		{
		}

		internal object ReadObject()
		{
			return null;
		}
	}

	private XmlMapping _typeMap;

	private SerializationFormat _format;

	private static readonly XmlQualifiedName AnyType;

	private static readonly object[] empty_array;

	public XmlSerializationReaderInterpreter(XmlMapping typeMap)
	{
	}

	protected override void InitCallbacks()
	{
	}

	protected override void InitIDs()
	{
	}

	public object ReadRoot()
	{
		return null;
	}

	private object ReadEncodedObject(XmlTypeMapping typeMap)
	{
		return null;
	}

	protected virtual object ReadMessage(XmlMembersMapping typeMap)
	{
		return null;
	}

	private object ReadRoot(XmlTypeMapping rootMap)
	{
		return null;
	}

	protected virtual object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType)
	{
		return null;
	}

	protected virtual object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType)
	{
		return null;
	}

	protected virtual void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob)
	{
	}

	private void ReadAttributeMembers(ClassMap map, object ob, bool isValueList)
	{
	}

	private void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder)
	{
	}

	private void SetListMembersDefaults(ClassMap map, object ob, bool isValueList)
	{
	}

	internal void FixupMembers(ClassMap map, object obfixup, bool isValueList)
	{
	}

	protected virtual void ProcessUnknownAttribute(object target)
	{
	}

	protected virtual void ProcessUnknownElement(object target)
	{
	}

	private bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList)
	{
		return false;
	}

	private void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList)
	{
	}

	private void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList)
	{
	}

	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList)
	{
		return null;
	}

	private object ReadObjectElement(XmlTypeMapElementInfo elem)
	{
		return null;
	}

	private object ReadPrimitiveValue(XmlTypeMapElementInfo elem)
	{
		return null;
	}

	private object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap)
	{
		return null;
	}

	private object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance)
	{
		return null;
	}

	private object ReadListString(XmlTypeMapping typeMap, string values)
	{
		return null;
	}

	private void AddListValue(TypeData listType, ref object list, int index, object value, bool canCreateInstance)
	{
	}

	private static object CreateInstance(Type type, bool nonPublic)
	{
		return null;
	}

	private object CreateInstance(Type type)
	{
		return null;
	}

	private object CreateList(Type listType)
	{
		return null;
	}

	private object InitializeList(TypeData listType)
	{
		return null;
	}

	private void FillList(object list, object items)
	{
	}

	private void CopyEnumerableList(object source, object dest)
	{
	}

	private object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable)
	{
		return null;
	}

	private object ReadXmlNode(TypeData type, bool wrapped)
	{
		return null;
	}

	private object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable)
	{
		return null;
	}

	private object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable)
	{
		return null;
	}

	private object GetEnumValue(XmlTypeMapping typeMap, string val)
	{
		return null;
	}

	private object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable)
	{
		return null;
	}
}
