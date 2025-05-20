using System.Collections;
using System.Threading;

namespace System.Runtime.Remoting.Lifetime;

internal class LeaseManager
{
	private ArrayList _objects;

	private Timer _timer;

	public void SetPollTime(TimeSpan timeSpan)
	{
	}

	public void TrackLifetime(ServerIdentity identity)
	{
	}

	public void StartManager()
	{
	}

	public void StopManager()
	{
	}

	public void ManageLeases(object state)
	{
	}
}
