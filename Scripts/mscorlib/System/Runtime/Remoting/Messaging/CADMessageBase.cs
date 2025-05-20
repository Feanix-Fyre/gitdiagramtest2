using System.Collections;
using System.Reflection;

namespace System.Runtime.Remoting.Messaging;

internal class CADMessageBase
{
	protected object[] _args;

	protected byte[] _serializedArgs;

	protected int _propertyCount;

	protected CADArgHolder _callContext;

	internal byte[] serializedMethod;

	public CADMessageBase(IMethodMessage msg)
	{
	}

	internal MethodBase GetMethod()
	{
		return null;
	}

	protected static Type[] GetSignature(MethodBase methodBase, bool load)
	{
		return null;
	}

	internal static int MarshalProperties(IDictionary dict, ref ArrayList args)
	{
		return 0;
	}

	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args)
	{
	}

	private static bool IsPossibleToIgnoreMarshal(object obj)
	{
		return false;
	}

	protected object MarshalArgument(object arg, ref ArrayList args)
	{
		return null;
	}

	protected object UnmarshalArgument(object arg, ArrayList args)
	{
		return null;
	}

	internal object[] MarshalArguments(object[] arguments, ref ArrayList args)
	{
		return null;
	}

	internal object[] UnmarshalArguments(object[] arguments, ArrayList args)
	{
		return null;
	}

	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList)
	{
	}

	internal LogicalCallContext GetLogicalCallContext(ArrayList args)
	{
		return null;
	}
}
