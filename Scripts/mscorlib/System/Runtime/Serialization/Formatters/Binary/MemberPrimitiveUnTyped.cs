namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class MemberPrimitiveUnTyped
{
	internal InternalPrimitiveTypeE typeInformation;

	internal object value;

	internal MemberPrimitiveUnTyped()
	{
	}

	internal void Set(InternalPrimitiveTypeE typeInformation, object value)
	{
	}

	internal void Set(InternalPrimitiveTypeE typeInformation)
	{
	}

	public void Write(__BinaryWriter sout)
	{
	}

	public void Read(__BinaryParser input)
	{
	}

	public void Dump()
	{
	}
}
