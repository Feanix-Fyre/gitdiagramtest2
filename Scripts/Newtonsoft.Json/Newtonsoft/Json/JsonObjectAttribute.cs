using System;

namespace Newtonsoft.Json;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false)]
public sealed class JsonObjectAttribute : JsonContainerAttribute
{
	private MemberSerialization _memberSerialization;

	internal MissingMemberHandling? _missingMemberHandling;

	internal Required? _itemRequired;

	internal NullValueHandling? _itemNullValueHandling;

	public MemberSerialization MemberSerialization
	{
		get
		{
			return default(MemberSerialization);
		}
		set
		{
		}
	}

	public MissingMemberHandling MissingMemberHandling
	{
		get
		{
			return default(MissingMemberHandling);
		}
		set
		{
		}
	}

	public NullValueHandling ItemNullValueHandling
	{
		get
		{
			return default(NullValueHandling);
		}
		set
		{
		}
	}

	public Required ItemRequired
	{
		get
		{
			return default(Required);
		}
		set
		{
		}
	}

	public JsonObjectAttribute()
	{
	}

	public JsonObjectAttribute(MemberSerialization memberSerialization)
	{
	}

	public JsonObjectAttribute(string id)
	{
	}
}
