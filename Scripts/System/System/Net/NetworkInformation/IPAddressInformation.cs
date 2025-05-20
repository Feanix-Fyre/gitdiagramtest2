namespace System.Net.NetworkInformation;

/// <summary>Provides information about a network interface address.</summary>
public abstract class IPAddressInformation
{
	/// <summary>Gets the Internet Protocol (IP) address.</summary>
	/// <returns>An <see cref="T:System.Net.IPAddress" /> instance that contains the IP address of an interface.</returns>
	public abstract IPAddress Address { get; }

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkInformation.IPAddressInformation" /> class.</summary>
	protected IPAddressInformation()
	{
	}
}
