using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Lifetime;

/// <summary>Defines a lifetime lease object that is used by the remoting lifetime service.</summary>
[ComVisible(true)]
public interface ILease
{
	/// <summary>Gets the amount of time remaining on the lease.</summary>
	/// <returns>The amount of time remaining on the lease.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission.</exception>
	TimeSpan CurrentLeaseTime { get; }

	/// <summary>Gets the current <see cref="T:System.Runtime.Remoting.Lifetime.LeaseState" /> of the lease.</summary>
	/// <returns>The current <see cref="T:System.Runtime.Remoting.Lifetime.LeaseState" /> of the lease.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission.</exception>
	LeaseState CurrentState { get; }

	/// <summary>Gets or sets the amount of time by which a call to the remote object renews the <see cref="P:System.Runtime.Remoting.Lifetime.ILease.CurrentLeaseTime" />.</summary>
	/// <returns>The amount of time by which a call to the remote object renews the <see cref="P:System.Runtime.Remoting.Lifetime.ILease.CurrentLeaseTime" />.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission.</exception>
	TimeSpan RenewOnCallTime { get; }

	/// <summary>Renews a lease for the specified time.</summary>
	/// <param name="renewalTime">The length of time to renew the lease by.</param>
	/// <returns>The new expiration time of the lease.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission.</exception>
	TimeSpan Renew(TimeSpan renewalTime);
}
