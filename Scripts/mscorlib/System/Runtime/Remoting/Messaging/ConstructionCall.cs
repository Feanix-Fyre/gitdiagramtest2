using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging;

/// <summary>Implements the <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" /> interface to create a request message that constitutes a constructor call on a remote object.</summary>
[Serializable]
[ComVisible(true)]
[CLSCompliant(false)]
public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage
{
	private IActivator _activator;

	private object[] _activationAttributes;

	private IList _contextProperties;

	private Type _activationType;

	private string _activationTypeName;

	private bool _isContextOk;

	[NonSerialized]
	private RemotingProxy _sourceProxy;

	internal bool IsContextOk
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets the type of the remote object to activate.</summary>
	/// <returns>The <see cref="T:System.Type" /> of the remote object to activate.</returns>
	public Type ActivationType => null;

	/// <summary>Gets the full type name of the remote object to activate.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the full type name of the remote object to activate.</returns>
	public string ActivationTypeName => null;

	/// <summary>Gets or sets the activator that activates the remote object.</summary>
	/// <returns>The <see cref="T:System.Runtime.Remoting.Activation.IActivator" /> that activates the remote object.</returns>
	public IActivator Activator
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the call site activation attributes for the remote object.</summary>
	/// <returns>An array of type <see cref="T:System.Object" /> containing the call site activation attributes for the remote object.</returns>
	public object[] CallSiteActivationAttributes => null;

	/// <summary>Gets a list of properties that define the context in which the remote object is to be created.</summary>
	/// <returns>A <see cref="T:System.Collections.IList" /> that contains a list of properties that define the context in which the remote object is to be created.</returns>
	public IList ContextProperties => null;

	/// <summary>Gets an <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties.</summary>
	/// <returns>An <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties.</returns>
	public override IDictionary Properties => null;

	internal RemotingProxy SourceProxy
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal ConstructionCall(Type type)
		: base(null, default(StreamingContext))
	{
	}

	internal ConstructionCall(SerializationInfo info, StreamingContext context)
		: base(null, default(StreamingContext))
	{
	}

	internal override void InitDictionary()
	{
	}

	internal void SetActivationAttributes(object[] attributes)
	{
	}

	internal override void InitMethodProperty(string key, object value)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
