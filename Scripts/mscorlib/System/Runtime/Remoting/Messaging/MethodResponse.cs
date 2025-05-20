using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging;

/// <summary>Implements the <see cref="T:System.Runtime.Remoting.Messaging.IMethodReturnMessage" /> interface to create a message that acts as a method response on a remote object.</summary>
[Serializable]
[ComVisible(true)]
[CLSCompliant(false)]
public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage
{
	private string _methodName;

	private string _uri;

	private string _typeName;

	private MethodBase _methodBase;

	private object _returnValue;

	private Exception _exception;

	private Type[] _methodSignature;

	private ArgInfo _inArgInfo;

	private object[] _args;

	private object[] _outArgs;

	private IMethodCallMessage _callMsg;

	private LogicalCallContext _callContext;

	private Identity _targetIdentity;

	/// <summary>Specifies an <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties.</summary>
	protected IDictionary ExternalProperties;

	/// <summary>Specifies an <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties.</summary>
	protected IDictionary InternalProperties;

	/// <summary>Gets the number of arguments passed to the method.</summary>
	/// <returns>A <see cref="T:System.Int32" /> that represents the number of arguments passed to a method.</returns>
	public int ArgCount => 0;

	/// <summary>Gets an array of arguments passed to the method.</summary>
	/// <returns>An array of type <see cref="T:System.Object" /> that represents the arguments passed to a method.</returns>
	public object[] Args => null;

	/// <summary>Gets the exception thrown during the method call, or <see langword="null" /> if the method did not throw an exception.</summary>
	/// <returns>The <see cref="T:System.Exception" /> thrown during the method call, or <see langword="null" /> if the method did not throw an exception.</returns>
	public Exception Exception => null;

	/// <summary>Gets the <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> for the current method call.</summary>
	/// <returns>The <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> for the current method call.</returns>
	public LogicalCallContext LogicalCallContext => null;

	/// <summary>Gets the <see cref="T:System.Reflection.MethodBase" /> of the called method.</summary>
	/// <returns>The <see cref="T:System.Reflection.MethodBase" /> of the called method.</returns>
	public MethodBase MethodBase => null;

	/// <summary>Gets the name of the invoked method.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the name of the invoked method.</returns>
	public string MethodName => null;

	/// <summary>Gets an object that contains the method signature.</summary>
	/// <returns>A <see cref="T:System.Object" /> that contains the method signature.</returns>
	public object MethodSignature => null;

	/// <summary>Gets an array of arguments in the method call that are marked as <see langword="ref" /> or <see langword="out" /> parameters.</summary>
	/// <returns>An array of type <see cref="T:System.Object" /> that represents the arguments in the method call that are marked as <see langword="ref" /> or <see langword="out" /> parameters.</returns>
	public object[] OutArgs => null;

	/// <summary>Gets an <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties.</summary>
	/// <returns>An <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties.</returns>
	public virtual IDictionary Properties => null;

	/// <summary>Gets the return value of the method call.</summary>
	/// <returns>A <see cref="T:System.Object" /> that represents the return value of the method call.</returns>
	public object ReturnValue => null;

	/// <summary>Gets the full type name of the remote object on which the method call is being made.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the full type name of the remote object on which the method call is being made.</returns>
	public string TypeName => null;

	/// <summary>Gets the Uniform Resource Identifier (URI) of the remote object on which the method call is being made.</summary>
	/// <returns>The URI of a remote object.</returns>
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

	internal MethodResponse(Exception e, IMethodCallMessage msg)
	{
	}

	internal MethodResponse(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg)
	{
	}

	internal MethodResponse(IMethodCallMessage msg, CADMethodReturnMessage retmsg)
	{
	}

	internal MethodResponse(SerializationInfo info, StreamingContext context)
	{
	}

	internal void InitMethodProperty(string key, object value)
	{
	}

	/// <summary>Gets a method argument, as an object, at a specified index.</summary>
	/// <param name="argNum">The index of the requested argument.</param>
	/// <returns>The method argument as an object.</returns>
	public object GetArg(int argNum)
	{
		return null;
	}

	/// <summary>The <see cref="M:System.Runtime.Remoting.Messaging.MethodResponse.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)" /> method is not implemented.</summary>
	/// <param name="info">Data for serializing or deserializing the remote object.</param>
	/// <param name="context">Context of a certain serialized stream.</param>
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
