using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging;

/// <summary>Holds a message returned in response to a method call on a remote object.</summary>
[ComVisible(true)]
public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage
{
	private object[] _outArgs;

	private object[] _args;

	private LogicalCallContext _callCtx;

	private object _returnValue;

	private string _uri;

	private Exception _exception;

	private MethodBase _methodBase;

	private string _methodName;

	private Type[] _methodSignature;

	private string _typeName;

	private MethodReturnDictionary _properties;

	private Identity _targetIdentity;

	private ArgInfo _inArgInfo;

	/// <summary>Gets the number of arguments of the called method.</summary>
	/// <returns>The number of arguments of the called method.</returns>
	public int ArgCount => 0;

	/// <summary>Gets a specified argument passed to the method called on the remote object.</summary>
	/// <returns>An argument passed to the method called on the remote object.</returns>
	public object[] Args => null;

	/// <summary>Gets the <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> of the called method.</summary>
	/// <returns>The <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> of the called method.</returns>
	public LogicalCallContext LogicalCallContext => null;

	/// <summary>Gets the <see cref="T:System.Reflection.MethodBase" /> of the called method.</summary>
	/// <returns>The <see cref="T:System.Reflection.MethodBase" /> of the called method.</returns>
	public MethodBase MethodBase => null;

	/// <summary>Gets the name of the called method.</summary>
	/// <returns>The name of the method that the current <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" /> originated from.</returns>
	public string MethodName => null;

	/// <summary>Gets an array of <see cref="T:System.Type" /> objects containing the method signature.</summary>
	/// <returns>An array of <see cref="T:System.Type" /> objects containing the method signature.</returns>
	public object MethodSignature => null;

	/// <summary>Gets an <see cref="T:System.Collections.IDictionary" /> of properties contained in the current <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" />.</summary>
	/// <returns>An <see cref="T:System.Collections.IDictionary" /> of properties contained in the current <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" />.</returns>
	public virtual IDictionary Properties => null;

	/// <summary>Gets the name of the type on which the remote method was called.</summary>
	/// <returns>The type name of the remote object on which the remote method was called.</returns>
	public string TypeName => null;

	/// <summary>Gets or sets the URI of the remote object on which the remote method was called.</summary>
	/// <returns>The URI of the remote object on which the remote method was called.</returns>
	public string Uri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	string IInternalMessage.Uri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the exception that was thrown during the remote method call.</summary>
	/// <returns>The exception thrown during the method call, or <see langword="null" /> if an exception did not occur during the call.</returns>
	public Exception Exception => null;

	/// <summary>Gets a specified object passed as an <see langword="out" /> or <see langword="ref" /> parameter to the called method.</summary>
	/// <returns>An object passed as an <see langword="out" /> or <see langword="ref" /> parameter to the called method.</returns>
	public object[] OutArgs => null;

	/// <summary>Gets the object returned by the called method.</summary>
	/// <returns>The object returned by the called method.</returns>
	public virtual object ReturnValue => null;

	Identity IInternalMessage.TargetIdentity
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" /> class with all the information returning to the caller after the method call.</summary>
	/// <param name="ret">The object returned by the invoked method from which the current <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" /> instance originated.</param>
	/// <param name="outArgs">The objects returned from the invoked method as <see langword="out" /> parameters.</param>
	/// <param name="outArgsCount">The number of <see langword="out" /> parameters returned from the invoked method.</param>
	/// <param name="callCtx">The <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> of the method call.</param>
	/// <param name="mcm">The original method call to the invoked method.</param>
	public ReturnMessage(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" /> class.</summary>
	/// <param name="e">The exception that was thrown during execution of the remotely called method.</param>
	/// <param name="mcm">An <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" /> with which to create an instance of the <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" /> class.</param>
	public ReturnMessage(Exception e, IMethodCallMessage mcm)
	{
	}

	/// <summary>Returns a specified argument passed to the remote method during the method call.</summary>
	/// <param name="argNum">The zero-based index of the requested argument.</param>
	/// <returns>An argument passed to the remote method during the method call.</returns>
	public object GetArg(int argNum)
	{
		return null;
	}
}
