using System.Reflection;

namespace System.Xml.Serialization;

internal class XmlTypeMapMember
{
	private string _name;

	private int _index;

	private int _globalIndex;

	private int _specifiedGlobalIndex;

	private TypeData _typeData;

	private MemberInfo _member;

	private MemberInfo _specifiedMember;

	private MethodInfo _shouldSerialize;

	private object _defaultValue;

	private int _flags;

	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public object DefaultValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public TypeData TypeData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int Index
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int GlobalIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsOptionalValueType
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsReturnValue
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsReadOnly(Type type)
	{
		return false;
	}

	public static object GetValue(object ob, string name)
	{
		return null;
	}

	public object GetValue(object ob)
	{
		return null;
	}

	public void SetValue(object ob, object value)
	{
	}

	public static void SetValue(object ob, string name, object value)
	{
	}

	private void InitMember(Type type)
	{
	}

	public void CheckOptionalValueType(Type type)
	{
	}

	public bool GetValueSpecified(object ob)
	{
		return false;
	}

	public void SetValueSpecified(object ob, bool value)
	{
	}
}
