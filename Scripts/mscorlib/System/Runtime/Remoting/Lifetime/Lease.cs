using System.Collections;

namespace System.Runtime.Remoting.Lifetime;

internal class Lease : MarshalByRefObject, ILease
{
	private delegate TimeSpan RenewalDelegate(ILease lease);

	private DateTime _leaseExpireTime;

	private LeaseState _currentState;

	private TimeSpan _initialLeaseTime;

	private TimeSpan _renewOnCallTime;

	private TimeSpan _sponsorshipTimeout;

	private ArrayList _sponsors;

	private Queue _renewingSponsors;

	private RenewalDelegate _renewalDelegate;

	public TimeSpan CurrentLeaseTime => default(TimeSpan);

	public LeaseState CurrentState => default(LeaseState);

	public TimeSpan RenewOnCallTime => default(TimeSpan);

	public void Activate()
	{
	}

	public TimeSpan Renew(TimeSpan renewalTime)
	{
		return default(TimeSpan);
	}

	public void Unregister(ISponsor obj)
	{
	}

	internal void UpdateState()
	{
	}

	private void CheckNextSponsor()
	{
	}

	private void ProcessSponsorResponse(object state, bool timedOut)
	{
	}
}
