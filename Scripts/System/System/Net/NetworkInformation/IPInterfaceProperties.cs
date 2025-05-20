namespace System.Net.NetworkInformation;

/// <summary>Provides information about network interfaces that support Internet Protocol version 4 (IPv4) or Internet Protocol version 6 (IPv6).</summary>
public abstract class IPInterfaceProperties
{
	/// <summary>Gets the unicast addresses assigned to this interface.</summary>
	/// <returns>An <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformationCollection" /> that contains the unicast addresses for this interface.</returns>
	public abstract UnicastIPAddressInformationCollection UnicastAddresses { get; }

	/// <summary>Gets the IPv4 network gateway addresses for this interface.</summary>
	/// <returns>An <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformationCollection" /> that contains the address information for network gateways, or an empty array if no gateways are found.</returns>
	public abstract GatewayIPAddressInformationCollection GatewayAddresses { get; }

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkInformation.IPInterfaceProperties" /> class.</summary>
	protected IPInterfaceProperties()
	{
	}
}
