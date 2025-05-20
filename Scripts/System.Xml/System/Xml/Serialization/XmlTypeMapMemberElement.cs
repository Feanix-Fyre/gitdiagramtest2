namespace System.Xml.Serialization;

internal class XmlTypeMapMemberElement : XmlTypeMapMember
{
	private XmlTypeMapElementInfoList _elementInfo;

	private string _choiceMember;

	private bool _isTextCollector;

	private TypeData _choiceTypeData;

	public XmlTypeMapElementInfoList ElementInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string ChoiceMember
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public TypeData ChoiceTypeData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsXmlTextCollector
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public XmlTypeMapElementInfo FindElement(object ob, object memberValue)
	{
		return null;
	}

	public void SetChoice(object ob, object choice)
	{
	}
}
