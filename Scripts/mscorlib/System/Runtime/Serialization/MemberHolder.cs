namespace System.Runtime.Serialization;

[Serializable]
internal sealed class MemberHolder
{
	internal readonly Type _memberType;

	internal readonly StreamingContext _context;

	internal MemberHolder(Type type, StreamingContext ctx)
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}
}
