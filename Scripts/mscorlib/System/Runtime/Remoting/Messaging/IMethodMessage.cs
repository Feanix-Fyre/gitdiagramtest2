using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging;

/// <summary>Defines the method message interface.</summary>
[ComVisible(true)]
public interface IMethodMessage : IMessage
{
	/// <summary>Gets the number of arguments passed to the method.</summary>
	/// <returns>The number of arguments passed to the method.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission.</exception>
	int ArgCount { get; }

	/// <summary>Gets an array of arguments passed to the method.</summary>
	/// <returns>An <see cref="T:System.Object" /> array containing the arguments passed to the method.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission.</exception>
	object[] Args { get; }

	/// <summary>Gets the <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> for the current method call.</summary>
	/// <returns>Gets the <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> for the current method call.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission.</exception>
	LogicalCallContext LogicalCallContext { get; }

	/// <summary>Gets the <see cref="T:System.Reflection.MethodBase" /> of the called method.</summary>
	/// <returns>The <see cref="T:System.Reflection.MethodBase" /> of the called method.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission.</exception>
	MethodBase MethodBase { get; }

	/// <summary>Gets the name of the invoked method.</summary>
	/// <returns>The name of the invoked method.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission.</exception>
	string MethodName { get; }

	/// <summary>Gets an object containing the method signature.</summary>
	/// <returns>An object containing the method signature.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission.</exception>
	object MethodSignature { get; }

	/// <summary>Gets the full <see cref="T:System.Type" /> name of the specific object that the call is destined for.</summary>
	/// <returns>The full <see cref="T:System.Type" /> name of the specific object that the call is destined for.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission.</exception>
	string TypeName { get; }

	/// <summary>Gets the URI of the specific object that the call is destined for.</summary>
	/// <returns>The URI of the remote object that contains the invoked method.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission.</exception>
	string Uri { get; }

	/// <summary>Gets a specific argument as an <see cref="T:System.Object" />.</summary>
	/// <param name="argNum">The number of the requested argument.</param>
	/// <returns>The argument passed to the method.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission.</exception>
	object GetArg(int argNum);
}
