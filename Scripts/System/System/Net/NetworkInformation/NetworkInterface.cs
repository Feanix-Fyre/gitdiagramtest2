namespace System.Net.NetworkInformation;

/// <summary>Provides configuration and statistical information for a network interface.</summary>
public abstract class NetworkInterface
{
	/// <summary>Gets the current operational state of the network connection.</summary>
	/// <returns>One of the <see cref="T:System.Net.NetworkInformation.OperationalStatus" /> values.</returns>
	public virtual OperationalStatus OperationalStatus => default(OperationalStatus);

	/// <summary>Gets the interface type.</summary>
	/// <returns>An <see cref="T:System.Net.NetworkInformation.NetworkInterfaceType" /> value that specifies the network interface type.</returns>
	public virtual NetworkInterfaceType NetworkInterfaceType => default(NetworkInterfaceType);

	/// <summary>Returns objects that describe the network interfaces on the local computer.</summary>
	/// <returns>A <see cref="T:System.Net.NetworkInformation.NetworkInterface" /> array that contains objects that describe the available network interfaces, or an empty array if no interfaces are detected.</returns>
	/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">A Windows system function call failed.</exception>
	public static NetworkInterface[] GetAllNetworkInterfaces()
	{
		return null;
	}

	/// <summary>Returns an object that describes the configuration of this network interface.</summary>
	/// <returns>An <see cref="T:System.Net.NetworkInformation.IPInterfaceProperties" /> object that describes this network interface.</returns>
	public virtual IPInterfaceProperties GetIPProperties()
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkInformation.NetworkInterface" /> class.</summary>
	protected NetworkInterface()
	{
	}
}
