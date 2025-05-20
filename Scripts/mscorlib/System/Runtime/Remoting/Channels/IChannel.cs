using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels;

/// <summary>Provides conduits for messages that cross remoting boundaries.</summary>
[ComVisible(true)]
public interface IChannel
{
	/// <summary>Gets the name of the channel.</summary>
	/// <returns>The name of the channel.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	string ChannelName { get; }

	/// <summary>Gets the priority of the channel.</summary>
	/// <returns>An integer that indicates the priority of the channel.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	int ChannelPriority { get; }
}
