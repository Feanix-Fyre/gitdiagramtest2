using System;
using System.Collections.Generic;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization;

public class JsonPrimitiveContract : JsonContract
{
	private static readonly Dictionary<Type, ReadType> ReadTypeMap;

	internal PrimitiveTypeCode TypeCode { get; set; }

	public JsonPrimitiveContract(Type underlyingType)
		: base(null)
	{
	}
}
