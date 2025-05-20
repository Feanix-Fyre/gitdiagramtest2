using System;

namespace Newtonsoft.Json;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
public sealed class JsonPropertyAttribute : Attribute
{
	internal NullValueHandling? _nullValueHandling;

	internal DefaultValueHandling? _defaultValueHandling;

	internal ReferenceLoopHandling? _referenceLoopHandling;

	internal ObjectCreationHandling? _objectCreationHandling;

	internal TypeNameHandling? _typeNameHandling;

	internal bool? _isReference;

	internal int? _order;

	internal Required? _required;

	internal bool? _itemIsReference;

	internal ReferenceLoopHandling? _itemReferenceLoopHandling;

	internal TypeNameHandling? _itemTypeNameHandling;

	public Type? ItemConverterType { get; set; }

	public object[]? ItemConverterParameters { get; set; }

	public Type? NamingStrategyType { get; set; }

	public object[]? NamingStrategyParameters { get; set; }

	public NullValueHandling NullValueHandling
	{
		get
		{
			return default(NullValueHandling);
		}
		set
		{
		}
	}

	public DefaultValueHandling DefaultValueHandling
	{
		get
		{
			return default(DefaultValueHandling);
		}
		set
		{
		}
	}

	public ReferenceLoopHandling ReferenceLoopHandling
	{
		get
		{
			return default(ReferenceLoopHandling);
		}
		set
		{
		}
	}

	public ObjectCreationHandling ObjectCreationHandling
	{
		get
		{
			return default(ObjectCreationHandling);
		}
		set
		{
		}
	}

	public TypeNameHandling TypeNameHandling
	{
		get
		{
			return default(TypeNameHandling);
		}
		set
		{
		}
	}

	public bool IsReference
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int Order
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Required Required
	{
		get
		{
			return default(Required);
		}
		set
		{
		}
	}

	public string? PropertyName { get; set; }

	public ReferenceLoopHandling ItemReferenceLoopHandling
	{
		get
		{
			return default(ReferenceLoopHandling);
		}
		set
		{
		}
	}

	public TypeNameHandling ItemTypeNameHandling
	{
		get
		{
			return default(TypeNameHandling);
		}
		set
		{
		}
	}

	public bool ItemIsReference
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public JsonPropertyAttribute()
	{
	}

	public JsonPropertyAttribute(string propertyName)
	{
	}
}
