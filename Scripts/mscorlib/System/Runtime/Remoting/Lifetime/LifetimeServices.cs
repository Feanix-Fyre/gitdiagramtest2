using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Lifetime;

/// <summary>Controls the.NET remoting lifetime services.</summary>
[ComVisible(true)]
public sealed class LifetimeServices
{
	private static TimeSpan _leaseManagerPollTime;

	private static TimeSpan _leaseTime;

	private static TimeSpan _renewOnCallTime;

	private static TimeSpan _sponsorshipTimeout;

	private static LeaseManager _leaseManager;

	/// <summary>Gets or sets the time interval between each activation of the lease manager to clean up expired leases.</summary>
	/// <returns>The default amount of time the lease manager sleeps after checking for expired leases.</returns>
	/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. This exception is thrown only when setting the property value.</exception>
	public static TimeSpan LeaseManagerPollTime
	{
		get
		{
			return default(TimeSpan);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the initial lease time span for an <see cref="T:System.AppDomain" />.</summary>
	/// <returns>The initial lease <see cref="T:System.TimeSpan" /> for objects that can have leases in the <see cref="T:System.AppDomain" />.</returns>
	/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. This exception is thrown only when setting the property value.</exception>
	public static TimeSpan LeaseTime
	{
		get
		{
			return default(TimeSpan);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the amount of time by which the lease is extended every time a call comes in on the server object.</summary>
	/// <returns>The <see cref="T:System.TimeSpan" /> by which a lifetime lease in the current <see cref="T:System.AppDomain" /> is extended after each call.</returns>
	/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. This exception is thrown only when setting the property value.</exception>
	public static TimeSpan RenewOnCallTime
	{
		get
		{
			return default(TimeSpan);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the amount of time the lease manager waits for a sponsor to return with a lease renewal time.</summary>
	/// <returns>The initial sponsorship time-out.</returns>
	/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. This exception is thrown only when setting the property value.</exception>
	public static TimeSpan SponsorshipTimeout
	{
		get
		{
			return default(TimeSpan);
		}
		set
		{
		}
	}

	static LifetimeServices()
	{
	}

	internal static void TrackLifetime(ServerIdentity identity)
	{
	}
}
