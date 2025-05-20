using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting.Proxies;

/// <summary>Indicates that an object type requires a custom proxy.</summary>
[AttributeUsage(AttributeTargets.Class)]
[ComVisible(true)]
public class ProxyAttribute : Attribute, IContextAttribute
{
	/// <summary>Creates either an uninitialized <see cref="T:System.MarshalByRefObject" /> or a transparent proxy, depending on whether the specified type can exist in the current context.</summary>
	/// <param name="serverType">The object type to create an instance of.</param>
	/// <returns>An uninitialized <see cref="T:System.MarshalByRefObject" /> or a transparent proxy.</returns>
	public virtual MarshalByRefObject CreateInstance(Type serverType)
	{
		return null;
	}

	/// <summary>Creates an instance of a remoting proxy for a remote object described by the specified <see cref="T:System.Runtime.Remoting.ObjRef" />, and located on the server.</summary>
	/// <param name="objRef">The object reference to the remote object for which to create a proxy.</param>
	/// <param name="serverType">The type of the server where the remote object is located.</param>
	/// <param name="serverObject">The server object.</param>
	/// <param name="serverContext">The context in which the server object is located.</param>
	/// <returns>The new instance of remoting proxy for the remote object that is described in the specified <see cref="T:System.Runtime.Remoting.ObjRef" />.</returns>
	public virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext)
	{
		return null;
	}

	/// <summary>Gets properties for a new context.</summary>
	/// <param name="msg">The message for which the context is to be retrieved.</param>
	[ComVisible(true)]
	public void GetPropertiesForNewContext(IConstructionCallMessage msg)
	{
	}

	/// <summary>Checks the specified context.</summary>
	/// <param name="ctx">The context to be verified.</param>
	/// <param name="msg">The message for the remote call.</param>
	/// <returns>The specified context.</returns>
	[ComVisible(true)]
	public bool IsContextOK(Context ctx, IConstructionCallMessage msg)
	{
		return false;
	}
}
