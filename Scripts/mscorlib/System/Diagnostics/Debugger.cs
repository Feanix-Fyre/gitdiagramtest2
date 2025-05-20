using System.Runtime.InteropServices;

namespace System.Diagnostics;

/// <summary>Enables communication with a debugger. This class cannot be inherited.</summary>
[ComVisible(true)]
public sealed class Debugger
{
	/// <summary>Represents the default category of message with a constant.</summary>
	public static readonly string DefaultCategory;

	/// <summary>Checks to see if logging is enabled by an attached debugger.</summary>
	/// <returns>
	///   <see langword="true" /> if a debugger is attached and logging is enabled; otherwise, <see langword="false" />. The attached debugger is the registered managed debugger in the <see langword="DbgManagedDebugger" /> registry key. For more information on this key, see Enabling JIT-Attach Debugging.</returns>
	public static bool IsLogging()
	{
		return false;
	}

	private static void Log_icall(int level, ref string category, ref string message)
	{
	}

	/// <summary>Posts a message for the attached debugger.</summary>
	/// <param name="level">A description of the importance of the message.</param>
	/// <param name="category">The category of the message.</param>
	/// <param name="message">The message to show.</param>
	public static void Log(int level, string category, string message)
	{
	}

	/// <summary>Notifies a debugger that execution is about to enter a path that involves a cross-thread dependency.</summary>
	public static void NotifyOfCrossThreadDependency()
	{
	}
}
