using System.Collections;

namespace System.Runtime.Remoting.Messaging;

internal class CADMethodReturnMessage : CADMessageBase
{
	private object _returnValue;

	private CADArgHolder _exception;

	private Type[] _sig;

	internal int PropertiesCount => 0;

	internal static CADMethodReturnMessage Create(IMessage callMsg)
	{
		return null;
	}

	internal CADMethodReturnMessage(IMethodReturnMessage retMsg)
		: base(null)
	{
	}

	internal ArrayList GetArguments()
	{
		return null;
	}

	internal object[] GetArgs(ArrayList args)
	{
		return null;
	}

	internal object GetReturnValue(ArrayList args)
	{
		return null;
	}

	internal Exception GetException(ArrayList args)
	{
		return null;
	}
}
