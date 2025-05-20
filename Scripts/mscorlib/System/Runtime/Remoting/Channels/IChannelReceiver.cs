using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels;

/// <summary>Provides required functions and properties for the receiver channels.</summary>
[ComVisible(true)]
public interface IChannelReceiver : IChannel
{
	/// <summary>Gets the channel-specific data.</summary>
	/// <returns>The channel data.</returns>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	object ChannelData { get; }

	/// <summary>Instructs the current channel to start listening for requests.</summary>
	/// <param name="data">Optional initialization information.</param>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	void StartListening(object data);
}
