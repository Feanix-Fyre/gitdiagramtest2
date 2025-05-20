namespace Newtonsoft.Json.Bson;

internal class BsonBoolean : BsonValue
{
	public static readonly BsonBoolean False;

	public static readonly BsonBoolean True;

	private BsonBoolean(bool value)
		: base(null, default(BsonType))
	{
	}
}
