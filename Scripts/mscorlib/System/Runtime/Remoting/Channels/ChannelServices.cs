using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels;

/// <summary>Provides static methods to aid with remoting channel registration, resolution, and URL discovery. This class cannot be inherited.</summary>
[ComVisible(true)]
public sealed class ChannelServices
{
	private static ArrayList registeredChannels;

	private static ArrayList delayedClientChannels;

	private static CrossContextChannel _crossContextSink;

	internal static string CrossContextUrl;

	private static IList oldStartModeTypes;

	internal static CrossContextChannel CrossContextChannel => null;

	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri)
	{
		objectUri = null;
		return null;
	}

	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri)
	{
		objectUri = null;
		return null;
	}

	/// <summary>Registers a channel with the channel services. <see cref="M:System.Runtime.Remoting.Channels.ChannelServices.RegisterChannel(System.Runtime.Remoting.Channels.IChannel)" /> is obsolete. Please use <see cref="M:System.Runtime.Remoting.Channels.ChannelServices.RegisterChannel(System.Runtime.Remoting.Channels.IChannel,System.Boolean)" /> instead.</summary>
	/// <param name="chnl">The channel to register.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="chnl" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Remoting.RemotingException">The channel has already been registered.</exception>
	/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels.</exception>
	[Obsolete("Use RegisterChannel(IChannel,Boolean)")]
	public static void RegisterChannel(IChannel chnl)
	{
	}

	/// <summary>Registers a channel with the channel services.</summary>
	/// <param name="chnl">The channel to register.</param>
	/// <param name="ensureSecurity">
	///   <see langword="true" /> ensures that security is enabled; otherwise <see langword="false" />. Setting the value to <see langword="false" /> does not effect the security setting on the TCP or IPC channel.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="chnl" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Remoting.RemotingException">The channel has already been registered.</exception>
	/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the call stack does not have permission to configure remoting types and channels.</exception>
	/// <exception cref="T:System.NotSupportedException">Not supported in Windows 98 for <see cref="T:System.Runtime.Remoting.Channels.Tcp.TcpServerChannel" /> and on all platforms for <see cref="T:System.Runtime.Remoting.Channels.Http.HttpServerChannel" />. Host the service using Internet Information Services (IIS) if you require a secure HTTP channel.</exception>
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity)
	{
	}

	internal static void RegisterChannelConfig(ChannelData channel)
	{
	}

	private static object CreateProvider(ProviderData prov)
	{
		return null;
	}

	/// <summary>Synchronously dispatches the incoming message to the server-side chain(s) based on the URI embedded in the message.</summary>
	/// <param name="msg">The message to dispatch.</param>
	/// <returns>A reply message is returned by the call to the server-side chain.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="msg" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission.</exception>
	public static IMessage SyncDispatchMessage(IMessage msg)
	{
		return null;
	}

	private static ReturnMessage CheckIncomingMessage(IMessage msg)
	{
		return null;
	}

	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg)
	{
		return null;
	}

	private static bool IsLocalCall(IMessage callMsg)
	{
		return false;
	}

	internal static object[] GetCurrentChannelInfo()
	{
		return null;
	}
}
