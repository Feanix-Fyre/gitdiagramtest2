namespace System.Xml.Serialization;

internal class ListMap : ObjectMap
{
	private XmlTypeMapElementInfoList _itemInfo;

	private string _choiceMember;

	public string ChoiceMember
	{
		set
		{
		}
	}

	public XmlTypeMapElementInfoList ItemInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue)
	{
		return null;
	}

	public XmlTypeMapElementInfo FindElement(string elementName, string ns)
	{
		return null;
	}

	public XmlTypeMapElementInfo FindTextElement()
	{
		return null;
	}

	public void GetArrayType(int itemCount, out string localName, out string ns)
	{
		localName = null;
		ns = null;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
