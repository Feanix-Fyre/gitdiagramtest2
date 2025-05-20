using System.Collections;

namespace System.Runtime.Remoting.Messaging;

internal class CADMethodCallMessage : CADMessageBase
{
	private string _uri;

	internal string Uri => null;

	internal int PropertiesCount => 0;

	internal static CADMethodCallMessage Create(IMessage callMsg)
	{
		return null;
	}

	internal CADMethodCallMessage(IMethodCallMessage callMsg)
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
}
