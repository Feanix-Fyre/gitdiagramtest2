using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging;

/// <summary>Implements the <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" /> interface to create a request message that acts as a method call on a remote object.</summary>
[Serializable]
[CLSCompliant(false)]
[ComVisible(true)]
public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage
{
	private string _uri;

	private string _typeName;

	private string _methodName;

	private object[] _args;

	private Type[] _methodSignature;

	private MethodBase _methodBase;

	private LogicalCallContext _callContext;

	private Identity _targetIdentity;

	private Type[] _genericArguments;

	/// <summary>An <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties.</summary>
	protected IDictionary ExternalProperties;

	/// <summary>An <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties.</summary>
	protected IDictionary InternalProperties;

	/// <summary>Gets the number of arguments passed to a method.</summary>
	/// <returns>A <see cref="T:System.Int32" /> that represents the number of arguments passed to a method.</returns>
	public int ArgCount => 0;

	/// <summary>Gets an array of arguments passed to a method.</summary>
	/// <returns>An array of type <see cref="T:System.Object" /> that represents the arguments passed to a method.</returns>
	public object[] Args => null;

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

	/// <summary>Gets an <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties.</summary>
	/// <returns>An <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties.</returns>
	public virtual IDictionary Properties => null;

	/// <summary>Gets the full type name of the remote object on which the method call is being made.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the full type name of the remote object on which the method call is being made.</returns>
	public string TypeName => null;

	/// <summary>Gets or sets the Uniform Resource Identifier (URI) of the remote object on which the method call is being made.</summary>
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

	private Type[] GenericArguments => null;

	internal MethodCall(SerializationInfo info, StreamingContext context)
	{
	}

	internal MethodCall(CADMethodCallMessage msg)
	{
	}

	internal MethodCall()
	{
	}

	internal void CopyFrom(IMethodMessage call)
	{
	}

	internal virtual void InitMethodProperty(string key, object value)
	{
	}

	/// <summary>The <see cref="M:System.Runtime.Remoting.Messaging.MethodCall.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)" /> method is not implemented.</summary>
	/// <param name="info">The data for serializing or deserializing the remote object.</param>
	/// <param name="context">The context of a certain serialized stream.</param>
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	internal virtual void InitDictionary()
	{
	}

	/// <summary>Gets a method argument, as an object, at a specified index.</summary>
	/// <param name="argNum">The index of the requested argument.</param>
	/// <returns>The method argument as an object.</returns>
	public object GetArg(int argNum)
	{
		return null;
	}

	/// <summary>Initializes a <see cref="T:System.Runtime.Remoting.Messaging.MethodCall" />.</summary>
	public virtual void Init()
	{
	}

	/// <summary>Sets method information from previously initialized remoting message properties.</summary>
	public void ResolveMethod()
	{
	}

	private Type CastTo(string clientType, Type serverType)
	{
		return null;
	}

	private static string GetTypeNameFromAssemblyQualifiedName(string aqname)
	{
		return null;
	}
}
