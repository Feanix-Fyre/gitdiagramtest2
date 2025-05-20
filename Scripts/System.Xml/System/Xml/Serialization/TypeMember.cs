namespace System.Xml.Serialization;

internal sealed class TypeMember
{
	private Type type;

	private string member;

	internal TypeMember(Type type, string member)
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

	public static bool Equals(TypeMember tm1, TypeMember tm2)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
