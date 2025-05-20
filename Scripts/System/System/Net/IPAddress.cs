using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace System.Net;

/// <summary>Provides an Internet Protocol (IP) address.</summary>
[Serializable]
public class IPAddress
{
	private sealed class ReadOnlyIPAddress : IPAddress
	{
		public ReadOnlyIPAddress(long newAddress)
			: base(0L)
		{
		}
	}

	/// <summary>Provides an IP address that indicates that the server must listen for client activity on all network interfaces. This field is read-only.</summary>
	public static readonly IPAddress Any;

	/// <summary>Provides the IP loopback address. This field is read-only.</summary>
	public static readonly IPAddress Loopback;

	/// <summary>Provides the IP broadcast address. This field is read-only.</summary>
	public static readonly IPAddress Broadcast;

	/// <summary>Provides an IP address that indicates that no network interface should be used. This field is read-only.</summary>
	public static readonly IPAddress None;

	internal const long LoopbackMask = 255L;

	/// <summary>The <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> method uses the <see cref="F:System.Net.IPAddress.IPv6Any" /> field to indicate that a <see cref="T:System.Net.Sockets.Socket" /> must listen for client activity on all network interfaces.</summary>
	public static readonly IPAddress IPv6Any;

	/// <summary>Provides the IP loopback address. This property is read-only.</summary>
	public static readonly IPAddress IPv6Loopback;

	/// <summary>Provides an IP address that indicates that no network interface should be used. This property is read-only.</summary>
	public static readonly IPAddress IPv6None;

	private uint _addressOrScopeId;

	private readonly ushort[] _numbers;

	private string _toString;

	private int _hashCode;

	internal const int NumberOfLabels = 8;

	private bool IsIPv4 => false;

	private bool IsIPv6 => false;

	private uint PrivateAddress
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	private uint PrivateScopeId
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	/// <summary>Gets the address family of the IP address.</summary>
	/// <returns>Returns <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> for IPv4 or <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> for IPv6.</returns>
	public AddressFamily AddressFamily => default(AddressFamily);

	/// <summary>Gets or sets the IPv6 address scope identifier.</summary>
	/// <returns>A long integer that specifies the scope of the address.</returns>
	/// <exception cref="T:System.Net.Sockets.SocketException">
	///   <see langword="AddressFamily" /> = <see langword="InterNetwork" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="scopeId" /> &lt; 0  
	/// -or-
	///
	/// <paramref name="scopeId" /> &gt; 0x00000000FFFFFFFF</exception>
	public long ScopeId => 0L;

	/// <summary>An Internet Protocol (IP) address.</summary>
	/// <returns>The long value of the IP address.</returns>
	/// <exception cref="T:System.Net.Sockets.SocketException">The address family is <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" />.</exception>
	[Obsolete("This property has been deprecated. It is address family dependent. Please use IPAddress.Equals method to perform comparisons. https://go.microsoft.com/fwlink/?linkid=14202")]
	public long Address => 0L;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.IPAddress" /> class with the address specified as an <see cref="T:System.Int64" />.</summary>
	/// <param name="newAddress">The long value of the IP address. For example, the value 0x2414188f in big-endian format would be the IP address "143.24.20.36".</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="newAddress" /> &lt; 0 or  
	/// <paramref name="newAddress" /> &gt; 0x00000000FFFFFFFF</exception>
	public IPAddress(long newAddress)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.IPAddress" /> class with the address specified as a <see cref="T:System.Byte" /> array and the specified scope identifier.</summary>
	/// <param name="address">The byte array value of the IP address.</param>
	/// <param name="scopeid">The long value of the scope identifier.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="address" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="address" /> contains a bad IP address.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="scopeid" /> &lt; 0 or  
	/// <paramref name="scopeid" /> &gt; 0x00000000FFFFFFFF</exception>
	public IPAddress(byte[] address, long scopeid)
	{
	}

	public IPAddress(ReadOnlySpan<byte> address, long scopeid)
	{
	}

	internal unsafe IPAddress(ushort* numbers, int numbersLength, uint scopeid)
	{
	}

	private IPAddress(ushort[] numbers, uint scopeid)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.IPAddress" /> class with the address specified as a <see cref="T:System.Byte" /> array.</summary>
	/// <param name="address">The byte array value of the IP address.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="address" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="address" /> contains a bad IP address.</exception>
	public IPAddress(byte[] address)
	{
	}

	public IPAddress(ReadOnlySpan<byte> address)
	{
	}

	/// <summary>Determines whether a string is a valid IP address.</summary>
	/// <param name="ipString">The string to validate.</param>
	/// <param name="address">The <see cref="T:System.Net.IPAddress" /> version of the string.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="ipString" /> was able to be parsed as an IP address; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="ipString" /> is null.</exception>
	public static bool TryParse(string ipString, out IPAddress address)
	{
		address = null;
		return false;
	}

	/// <summary>Converts an IP address string to an <see cref="T:System.Net.IPAddress" /> instance.</summary>
	/// <param name="ipString">A string that contains an IP address in dotted-quad notation for IPv4 and in colon-hexadecimal notation for IPv6.</param>
	/// <returns>An <see cref="T:System.Net.IPAddress" /> instance.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="ipString" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="ipString" /> is not a valid IP address.</exception>
	public static IPAddress Parse(string ipString)
	{
		return null;
	}

	public bool TryWriteBytes(Span<byte> destination, out int bytesWritten)
	{
		bytesWritten = default(int);
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void WriteIPv6Bytes(Span<byte> destination)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void WriteIPv4Bytes(Span<byte> destination)
	{
	}

	/// <summary>Provides a copy of the <see cref="T:System.Net.IPAddress" /> as an array of bytes.</summary>
	/// <returns>A <see cref="T:System.Byte" /> array.</returns>
	public byte[] GetAddressBytes()
	{
		return null;
	}

	/// <summary>Converts an Internet address to its standard notation.</summary>
	/// <returns>A string that contains the IP address in either IPv4 dotted-quad or in IPv6 colon-hexadecimal notation.</returns>
	/// <exception cref="T:System.Net.Sockets.SocketException">The address family is <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> and the address is bad.</exception>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Indicates whether the specified IP address is the loopback address.</summary>
	/// <param name="address">An IP address.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="address" /> is the loopback address; otherwise, <see langword="false" />.</returns>
	public static bool IsLoopback(IPAddress address)
	{
		return false;
	}

	internal bool Equals(object comparandObj, bool compareScopeId)
	{
		return false;
	}

	/// <summary>Compares two IP addresses.</summary>
	/// <param name="comparand">An <see cref="T:System.Net.IPAddress" /> instance to compare to the current instance.</param>
	/// <returns>
	///   <see langword="true" /> if the two addresses are equal; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object comparand)
	{
		return false;
	}

	/// <summary>Returns a hash value for an IP address.</summary>
	/// <returns>An integer hash value.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Maps the <see cref="T:System.Net.IPAddress" /> object to an IPv6 address.</summary>
	/// <returns>Returns <see cref="T:System.Net.IPAddress" />.  
	///  An IPv6 address.</returns>
	public IPAddress MapToIPv6()
	{
		return null;
	}

	private static byte[] ThrowAddressNullException()
	{
		return null;
	}
}
