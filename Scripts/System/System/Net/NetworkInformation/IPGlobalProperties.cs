namespace System.Net.NetworkInformation;

/// <summary>Provides information about the network connectivity of the local computer.</summary>
public abstract class IPGlobalProperties
{
	/// <summary>Gets the domain in which the local computer is registered.</summary>
	/// <returns>A <see cref="T:System.String" /> instance that contains the computer's domain name. If the computer does not belong to a domain, returns <see cref="F:System.String.Empty" />.</returns>
	/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">A Win32 function call failed.</exception>
	public abstract string DomainName { get; }

	/// <summary>Gets an object that provides information about the local computer's network connectivity and traffic statistics.</summary>
	/// <returns>A <see cref="T:System.Net.NetworkInformation.IPGlobalProperties" /> object that contains information about the local computer.</returns>
	public static IPGlobalProperties GetIPGlobalProperties()
	{
		return null;
	}

	internal static IPGlobalProperties InternalGetIPGlobalProperties()
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkInformation.IPGlobalProperties" /> class.</summary>
	protected IPGlobalProperties()
	{
	}
}
