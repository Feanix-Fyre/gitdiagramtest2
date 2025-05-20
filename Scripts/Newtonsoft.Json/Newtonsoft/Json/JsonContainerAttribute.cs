using System;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
public abstract class JsonContainerAttribute : Attribute
{
	internal bool? _isReference;

	internal bool? _itemIsReference;

	internal ReferenceLoopHandling? _itemReferenceLoopHandling;

	internal TypeNameHandling? _itemTypeNameHandling;

	private Type? _namingStrategyType;

	private object[]? _namingStrategyParameters;

	public string? Id { get; set; }

	public string? Title { get; set; }

	public string? Description { get; set; }

	public Type? ItemConverterType { get; set; }

	public object[]? ItemConverterParameters { get; set; }

	public Type? NamingStrategyType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public object[]? NamingStrategyParameters
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal NamingStrategy? NamingStrategyInstance { get; set; }

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

	protected JsonContainerAttribute()
	{
	}

	protected JsonContainerAttribute(string id)
	{
	}
}
