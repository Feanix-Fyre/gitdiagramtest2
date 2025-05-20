namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryMethodCall
{
	private string methodName;

	private string typeName;

	private object[] args;

	private object callContext;

	private Type[] argTypes;

	private bool bArgsPrimitive;

	private MessageEnum messageEnum;

	internal void Write(__BinaryWriter sout)
	{
	}

	internal void Dump()
	{
	}
}
