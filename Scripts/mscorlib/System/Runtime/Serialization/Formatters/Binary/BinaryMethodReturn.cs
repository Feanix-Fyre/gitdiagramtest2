namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryMethodReturn
{
	private object returnValue;

	private object[] args;

	private object callContext;

	private Type[] argTypes;

	private bool bArgsPrimitive;

	private MessageEnum messageEnum;

	private Type returnType;

	private static object instanceOfVoid;

	static BinaryMethodReturn()
	{
	}

	internal BinaryMethodReturn()
	{
	}

	public void Write(__BinaryWriter sout)
	{
	}

	public void Dump()
	{
	}
}
