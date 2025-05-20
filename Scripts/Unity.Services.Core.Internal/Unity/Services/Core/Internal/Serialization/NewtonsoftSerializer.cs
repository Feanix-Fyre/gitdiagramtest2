using Newtonsoft.Json;

namespace Unity.Services.Core.Internal.Serialization;

internal class NewtonsoftSerializer : IJsonSerializer
{
	private readonly JsonSerializer m_Serializer;

	public NewtonsoftSerializer(JsonSerializerSettings settings = null)
	{
	}

	internal NewtonsoftSerializer(JsonSerializer serializer)
	{
	}

	public string SerializeObject<T>(T value)
	{
		return null;
	}

	public T DeserializeObject<T>(string value)
	{
		return default(T);
	}
}
