using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels;

/// <summary>Creates server channel sinks for the server channel through which remoting messages flow.</summary>
[ComVisible(true)]
public interface IServerChannelSinkProvider
{
	/// <summary>Gets or sets the next sink provider in the channel sink provider chain.</summary>
	/// <returns>The next sink provider in the channel sink provider chain.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	IServerChannelSinkProvider Next { set; }
}
