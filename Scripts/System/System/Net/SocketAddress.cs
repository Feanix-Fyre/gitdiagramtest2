using System.Net.Sockets;

namespace System.Net;

/// <summary>Stores serialized information from <see cref="T:System.Net.EndPoint" /> derived classes.</summary>
public class SocketAddress
{
	internal int m_Size;

	internal byte[] m_Buffer;

	private bool m_changed;

	private int m_hash;

	/// <summary>Gets the <see cref="T:System.Net.Sockets.AddressFamily" /> enumerated value of the current <see cref="T:System.Net.SocketAddress" />.</summary>
	/// <returns>One of the <see cref="T:System.Net.Sockets.AddressFamily" /> enumerated values.</returns>
	public AddressFamily Family => default(AddressFamily);

	/// <summary>Gets the underlying buffer size of the <see cref="T:System.Net.SocketAddress" />.</summary>
	/// <returns>The underlying buffer size of the <see cref="T:System.Net.SocketAddress" />.</returns>
	public int Size => 0;

	/// <summary>Gets or sets the specified index element in the underlying buffer.</summary>
	/// <param name="offset">The array index element of the desired information.</param>
	/// <returns>The value of the specified index element in the underlying buffer.</returns>
	/// <exception cref="T:System.IndexOutOfRangeException">The specified index does not exist in the buffer.</exception>
	public byte this[int offset] => 0;

	/// <summary>Creates a new instance of the <see cref="T:System.Net.SocketAddress" /> class using the specified address family and buffer size.</summary>
	/// <param name="family">An <see cref="T:System.Net.Sockets.AddressFamily" /> enumerated value.</param>
	/// <param name="size">The number of bytes to allocate for the underlying buffer.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="size" /> is less than 2. These 2 bytes are needed to store <paramref name="family" />.</exception>
	public SocketAddress(AddressFamily family, int size)
	{
	}

	internal SocketAddress(IPAddress ipAddress)
	{
	}

	internal SocketAddress(IPAddress ipaddress, int port)
	{
	}

	internal IPAddress GetIPAddress()
	{
		return null;
	}

	internal IPEndPoint GetIPEndPoint()
	{
		return null;
	}

	/// <summary>Determines whether the specified <see langword="Object" /> is equal to the current <see langword="Object" />.</summary>
	/// <param name="comparand">The <see cref="T:System.Object" /> to compare with the current <see langword="Object" />.</param>
	/// <returns>
	///   <see langword="true" /> if the specified <see langword="Object" /> is equal to the current <see langword="Object" />; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object comparand)
	{
		return false;
	}

	/// <summary>Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table.</summary>
	/// <returns>A hash code for the current <see cref="T:System.Object" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Returns information about the socket address.</summary>
	/// <returns>A string that contains information about the <see cref="T:System.Net.SocketAddress" />.</returns>
	public override string ToString()
	{
		return null;
	}
}
