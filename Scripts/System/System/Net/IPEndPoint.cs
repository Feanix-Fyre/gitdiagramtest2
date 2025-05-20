using System.Net.Sockets;

namespace System.Net;

/// <summary>Represents a network endpoint as an IP address and a port number.</summary>
[Serializable]
public class IPEndPoint : EndPoint
{
	/// <summary>Specifies the minimum value that can be assigned to the <see cref="P:System.Net.IPEndPoint.Port" /> property. This field is read-only.</summary>
	public const int MinPort = 0;

	/// <summary>Specifies the maximum value that can be assigned to the <see cref="P:System.Net.IPEndPoint.Port" /> property. The MaxPort value is set to 0x0000FFFF. This field is read-only.</summary>
	public const int MaxPort = 65535;

	private IPAddress _address;

	private int _port;

	internal const int AnyPort = 0;

	internal static IPEndPoint Any;

	internal static IPEndPoint IPv6Any;

	/// <summary>Gets the Internet Protocol (IP) address family.</summary>
	/// <returns>Returns <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" />.</returns>
	public override AddressFamily AddressFamily => default(AddressFamily);

	/// <summary>Gets or sets the IP address of the endpoint.</summary>
	/// <returns>An <see cref="T:System.Net.IPAddress" /> instance containing the IP address of the endpoint.</returns>
	public IPAddress Address
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the port number of the endpoint.</summary>
	/// <returns>An integer value in the range <see cref="F:System.Net.IPEndPoint.MinPort" /> to <see cref="F:System.Net.IPEndPoint.MaxPort" /> indicating the port number of the endpoint.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value that was specified for a set operation is less than <see cref="F:System.Net.IPEndPoint.MinPort" /> or greater than <see cref="F:System.Net.IPEndPoint.MaxPort" />.</exception>
	public int Port
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.IPEndPoint" /> class with the specified address and port number.</summary>
	/// <param name="address">An <see cref="T:System.Net.IPAddress" />.</param>
	/// <param name="port">The port number associated with the <paramref name="address" />, or 0 to specify any available port. <paramref name="port" /> is in host order.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="address" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="port" /> is less than <see cref="F:System.Net.IPEndPoint.MinPort" />.  
	/// -or-  
	/// <paramref name="port" /> is greater than <see cref="F:System.Net.IPEndPoint.MaxPort" />.  
	/// -or-  
	/// <paramref name="address" /> is less than 0 or greater than 0x00000000FFFFFFFF.</exception>
	public IPEndPoint(IPAddress address, int port)
	{
	}

	/// <summary>Returns the IP address and port number of the specified endpoint.</summary>
	/// <returns>A string containing the IP address and the port number of the specified endpoint (for example, 192.168.1.2:80).</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Serializes endpoint information into a <see cref="T:System.Net.SocketAddress" /> instance.</summary>
	/// <returns>A <see cref="T:System.Net.SocketAddress" /> instance containing the socket address for the endpoint.</returns>
	public override SocketAddress Serialize()
	{
		return null;
	}

	/// <summary>Creates an endpoint from a socket address.</summary>
	/// <param name="socketAddress">The <see cref="T:System.Net.SocketAddress" /> to use for the endpoint.</param>
	/// <returns>An <see cref="T:System.Net.EndPoint" /> instance using the specified socket address.</returns>
	/// <exception cref="T:System.ArgumentException">The AddressFamily of <paramref name="socketAddress" /> is not equal to the AddressFamily of the current instance.  
	///  -or-  
	///  <paramref name="socketAddress" />.Size &lt; 8.</exception>
	public override EndPoint Create(SocketAddress socketAddress)
	{
		return null;
	}

	/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />.</summary>
	/// <param name="comparand">The <see cref="T:System.Object" /> to compare with the current <see cref="T:System.Object" />.</param>
	/// <returns>
	///   <see langword="true" /> if the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object comparand)
	{
		return false;
	}

	/// <summary>Returns a hash value for a <see cref="T:System.Net.IPEndPoint" /> instance.</summary>
	/// <returns>An integer hash value.</returns>
	public override int GetHashCode()
	{
		return 0;
	}
}
