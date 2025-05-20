using System.IO;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels;

internal class CADSerializer
{
	internal static IMessage DeserializeMessage(MemoryStream mem, IMethodCallMessage msg)
	{
		return null;
	}

	internal static MemoryStream SerializeMessage(IMessage msg)
	{
		return null;
	}

	internal static object DeserializeObjectSafe(byte[] mem)
	{
		return null;
	}

	internal static MemoryStream SerializeObject(object obj)
	{
		return null;
	}

	internal static object DeserializeObject(MemoryStream mem)
	{
		return null;
	}
}
