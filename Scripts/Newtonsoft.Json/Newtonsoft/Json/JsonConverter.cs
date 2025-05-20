using System;

namespace Newtonsoft.Json;

public abstract class JsonConverter
{
	public virtual bool CanRead => false;

	public virtual bool CanWrite => false;

	public abstract void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer);

	public abstract object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer);

	public abstract bool CanConvert(Type objectType);
}
public abstract class JsonConverter<T> : JsonConverter where T : notnull
{
	public sealed override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
	{
	}

	public abstract void WriteJson(JsonWriter writer, T? value, JsonSerializer serializer);

	public sealed override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
	{
		return null;
	}

	public abstract T ReadJson(JsonReader reader, Type objectType, T? existingValue, bool hasExistingValue, JsonSerializer serializer);

	public sealed override bool CanConvert(Type objectType)
	{
		return false;
	}
}
