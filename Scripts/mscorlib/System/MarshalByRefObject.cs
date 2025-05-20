using System.Runtime.InteropServices;
using System.Runtime.Remoting;

namespace System;

/// <summary>Enables access to objects across application domain boundaries in applications that support remoting.</summary>
[Serializable]
[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public abstract class MarshalByRefObject
{
	[NonSerialized]
	private object _identity;

	internal ServerIdentity ObjectIdentity
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.MarshalByRefObject" /> class.</summary>
	protected MarshalByRefObject()
	{
	}

	/// <summary>Creates an object that contains all the relevant information required to generate a proxy used to communicate with a remote object.</summary>
	/// <param name="requestedType">The <see cref="T:System.Type" /> of the object that the new <see cref="T:System.Runtime.Remoting.ObjRef" /> will reference.</param>
	/// <returns>Information required to generate a proxy.</returns>
	/// <exception cref="T:System.Runtime.Remoting.RemotingException">This instance is not a valid remoting object.</exception>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	public virtual ObjRef CreateObjRef(Type requestedType)
	{
		return null;
	}

	/// <summary>Obtains a lifetime service object to control the lifetime policy for this instance.</summary>
	/// <returns>An object of type <see cref="T:System.Runtime.Remoting.Lifetime.ILease" /> used to control the lifetime policy for this instance. This is the current lifetime service object for this instance if one exists; otherwise, a new lifetime service object initialized to the value of the <see cref="P:System.Runtime.Remoting.Lifetime.LifetimeServices.LeaseManagerPollTime" /> property.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	public virtual object InitializeLifetimeService()
	{
		return null;
	}
}
