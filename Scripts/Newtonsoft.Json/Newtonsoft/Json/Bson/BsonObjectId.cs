using System;

namespace Newtonsoft.Json.Bson;

[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
public class BsonObjectId
{
	public byte[] Value { get; }

	public BsonObjectId(byte[] value)
	{
	}
}
