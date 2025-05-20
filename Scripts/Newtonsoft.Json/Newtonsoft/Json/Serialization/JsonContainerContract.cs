using System;

namespace Newtonsoft.Json.Serialization;

public class JsonContainerContract : JsonContract
{
	private JsonContract? _itemContract;

	private JsonContract? _finalItemContract;

	internal JsonContract? ItemContract
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal JsonContract? FinalItemContract => null;

	public JsonConverter? ItemConverter { get; set; }

	public bool? ItemIsReference { get; set; }

	public ReferenceLoopHandling? ItemReferenceLoopHandling { get; set; }

	public TypeNameHandling? ItemTypeNameHandling { get; set; }

	internal JsonContainerContract(Type underlyingType)
		: base(null)
	{
	}
}
