namespace Newtonsoft.Json.Bson;

internal class BsonEmpty : BsonToken
{
	public static readonly BsonToken Null;

	public static readonly BsonToken Undefined;

	public override BsonType Type { get; }

	private BsonEmpty(BsonType type)
	{
	}
}
