namespace System.Net.Sockets;

/// <summary>Presents the packet information from a call to <see cref="M:System.Net.Sockets.Socket.ReceiveMessageFrom(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags@,System.Net.EndPoint@,System.Net.Sockets.IPPacketInformation@)" /> or <see cref="M:System.Net.Sockets.Socket.EndReceiveMessageFrom(System.IAsyncResult,System.Net.Sockets.SocketFlags@,System.Net.EndPoint@,System.Net.Sockets.IPPacketInformation@)" />.</summary>
public struct IPPacketInformation
{
	private IPAddress address;

	private int networkInterface;

	/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
	/// <param name="comparand">The object to compare with this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="comparand" /> is an instance of <see cref="T:System.Net.Sockets.IPPacketInformation" /> and equals the value of the instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object comparand)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>An Int32 hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}
}
