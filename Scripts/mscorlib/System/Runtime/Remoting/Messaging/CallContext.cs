using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging;

/// <summary>Provides a set of properties that are carried with the execution code path. This class cannot be inherited.</summary>
[Serializable]
[ComVisible(true)]
public sealed class CallContext
{
	private CallContext()
	{
	}

	internal static object SetCurrentCallContext(LogicalCallContext ctx)
	{
		return null;
	}

	internal static LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx)
	{
		return null;
	}

	/// <summary>Retrieves an object with the specified name from the logical call context.</summary>
	/// <param name="name">The name of the item in the logical call context.</param>
	/// <returns>The object in the logical call context associated with the specified name.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	public static object LogicalGetData(string name)
	{
		return null;
	}

	/// <summary>Stores a given object in the logical call context and associates it with the specified name.</summary>
	/// <param name="name">The name with which to associate the new item in the logical call context.</param>
	/// <param name="data">The object to store in the logical call context, this object must be serializable.</param>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	public static void LogicalSetData(string name, object data)
	{
	}
}
