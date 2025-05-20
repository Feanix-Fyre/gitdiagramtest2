using System;

namespace Newtonsoft.Json.Converters;

public class UnixDateTimeConverter : DateTimeConverterBase
{
	internal static readonly DateTime UnixEpoch;

	public bool AllowPreEpoch { get; set; }

	public UnixDateTimeConverter()
	{
	}

	public UnixDateTimeConverter(bool allowPreEpoch)
	{
	}

	public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
	{
	}

	public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
	{
		return null;
	}
}
