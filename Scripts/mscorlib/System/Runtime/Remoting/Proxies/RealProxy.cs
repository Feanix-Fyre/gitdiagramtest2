using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Proxies;

/// <summary>Provides base functionality for proxies.</summary>
[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public abstract class RealProxy
{
	private Type class_to_proxy;

	internal Context _targetContext;

	internal MarshalByRefObject _server;

	private int _targetDomainId;

	internal string _targetUri;

	internal Identity _objectIdentity;

	private object _objTP;

	private object _stubData;

	internal Identity ObjectIdentity
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" /> class with default values.</summary>
	protected RealProxy()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" /> class that represents a remote object of the specified <see cref="T:System.Type" />.</summary>
	/// <param name="classToProxy">The <see cref="T:System.Type" /> of the remote object for which to create a proxy.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="classToProxy" /> is not an interface, and is not derived from <see cref="T:System.MarshalByRefObject" />.</exception>
	protected RealProxy(Type classToProxy)
	{
	}

	internal RealProxy(Type classToProxy, ClientIdentity identity)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" /> class.</summary>
	/// <param name="classToProxy">The <see cref="T:System.Type" /> of the remote object for which to create a proxy.</param>
	/// <param name="stub">A stub to associate with the new proxy instance.</param>
	/// <param name="stubData">The stub data to set for the specified stub and the new proxy instance.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="classToProxy" /> is not an interface, and is not derived from <see cref="T:System.MarshalByRefObject" />.</exception>
	protected RealProxy(Type classToProxy, IntPtr stub, object stubData)
	{
	}

	private static Type InternalGetProxyType(object transparentProxy)
	{
		return null;
	}

	/// <summary>Returns the <see cref="T:System.Type" /> of the object that the current instance of <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" /> represents.</summary>
	/// <returns>The <see cref="T:System.Type" /> of the object that the current instance of <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" /> represents.</returns>
	public Type GetProxiedType()
	{
		return null;
	}

	/// <summary>Adds the transparent proxy of the object represented by the current instance of <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" /> to the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> into which the transparent proxy is serialized.</param>
	/// <param name="context">The source and destination of the serialization.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> or <paramref name="context" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have SerializationFormatter permission.</exception>
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>When overridden in a derived class, invokes the method that is specified in the provided <see cref="T:System.Runtime.Remoting.Messaging.IMessage" /> on the remote object that is represented by the current instance.</summary>
	/// <param name="msg">A <see cref="T:System.Runtime.Remoting.Messaging.IMessage" /> that contains a <see cref="T:System.Collections.IDictionary" /> of information about the method call.</param>
	/// <returns>The message returned by the invoked method, containing the return value and any <see langword="out" /> or <see langword="ref" /> parameters.</returns>
	public abstract IMessage Invoke(IMessage msg);

	internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out object[] out_args)
	{
		exc = null;
		out_args = null;
		return null;
	}

	internal virtual object InternalGetTransparentProxy(string className)
	{
		return null;
	}

	/// <summary>Returns the transparent proxy for the current instance of <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" />.</summary>
	/// <returns>The transparent proxy for the current proxy instance.</returns>
	public virtual object GetTransparentProxy()
	{
		return null;
	}

	/// <summary>Attaches the current proxy instance to the specified remote <see cref="T:System.MarshalByRefObject" />.</summary>
	/// <param name="s">The <see cref="T:System.MarshalByRefObject" /> that the current proxy instance represents.</param>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have UnmanagedCode permission.</exception>
	protected void AttachServer(MarshalByRefObject s)
	{
	}

	internal void SetTargetDomain(int domainId)
	{
	}

	internal object GetAppDomainTarget()
	{
		return null;
	}

	private static object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call)
	{
		return null;
	}
}
