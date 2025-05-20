using System.Text;

namespace System.Xml.Serialization;

internal class XmlSerializationWriterInterpreter : XmlSerializationWriter
{
	private class CallbackInfo
	{
		private XmlSerializationWriterInterpreter _swi;

		private XmlTypeMapping _typeMap;

		public CallbackInfo(XmlSerializationWriterInterpreter swi, XmlTypeMapping typeMap)
		{
		}

		internal void WriteObject(object ob)
		{
		}

		internal void WriteEnum(object ob)
		{
		}
	}

	private XmlMapping _typeMap;

	private SerializationFormat _format;

	public XmlSerializationWriterInterpreter(XmlMapping typeMap)
	{
	}

	protected override void InitCallbacks()
	{
	}

	public void WriteRoot(object ob)
	{
	}

	protected virtual void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem)
	{
	}

	protected virtual void WriteMessage(XmlMembersMapping membersMap, object[] parameters)
	{
	}

	protected virtual void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp)
	{
	}

	protected virtual void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob)
	{
	}

	protected virtual void WriteObjectElementElements(XmlTypeMapping typeMap, object ob)
	{
	}

	private void WriteMembers(ClassMap map, object ob, bool isValueList)
	{
	}

	private void WriteAttributeMembers(ClassMap map, object ob, bool isValueList)
	{
	}

	private void WriteElementMembers(ClassMap map, object ob, bool isValueList)
	{
	}

	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList)
	{
		return null;
	}

	private bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList)
	{
		return false;
	}

	private void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue)
	{
	}

	internal static object ImplicitConvert(object obj, Type type)
	{
		return null;
	}

	private void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable)
	{
	}

	private void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable)
	{
	}

	protected virtual void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp)
	{
	}

	private void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString)
	{
	}

	private int GetListCount(TypeData listType, object ob)
	{
		return 0;
	}

	private void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue)
	{
	}

	protected virtual void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp)
	{
	}

	protected virtual void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp)
	{
	}

	private string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value)
	{
		return null;
	}

	private string GetEnumXmlValue(XmlTypeMapping typeMap, object ob)
	{
		return null;
	}
}
