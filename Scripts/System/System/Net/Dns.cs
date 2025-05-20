using System.Threading.Tasks;

namespace System.Net;

/// <summary>Provides simple domain name resolution functionality.</summary>
public static class Dns
{
	private delegate IPAddress[] GetHostAddressesCallback(string hostName);

	/// <summary>Asynchronously returns the Internet Protocol (IP) addresses for the specified host.</summary>
	/// <param name="hostNameOrAddress">The host name or IP address to resolve.</param>
	/// <param name="requestCallback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the operation is complete.</param>
	/// <param name="state">A user-defined object that contains information about the operation. This object is passed to the <paramref name="requestCallback" /> delegate when the operation is complete.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> instance that references the asynchronous request.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="hostNameOrAddress" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The length of <paramref name="hostNameOrAddress" /> is greater than 255 characters.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error is encountered when resolving <paramref name="hostNameOrAddress" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="hostNameOrAddress" /> is an invalid IP address.</exception>
	public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state)
	{
		return null;
	}

	/// <summary>Ends an asynchronous request for DNS information.</summary>
	/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> instance returned by a call to the <see cref="M:System.Net.Dns.BeginGetHostAddresses(System.String,System.AsyncCallback,System.Object)" /> method.</param>
	/// <returns>An array of type <see cref="T:System.Net.IPAddress" /> that holds the IP addresses for the host specified by the <paramref name="hostNameOrAddress" /> parameter of <see cref="M:System.Net.Dns.BeginGetHostAddresses(System.String,System.AsyncCallback,System.Object)" />.</returns>
	public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult)
	{
		return null;
	}

	private static bool GetHostByName_icall(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint)
	{
		h_name = null;
		h_aliases = null;
		h_addr_list = null;
		return false;
	}

	private static bool GetHostByAddr_icall(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint)
	{
		h_name = null;
		h_aliases = null;
		h_addr_list = null;
		return false;
	}

	private static bool GetHostName_icall(out string h_name)
	{
		h_name = null;
		return false;
	}

	private static void Error_11001(string hostName)
	{
	}

	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist)
	{
		return null;
	}

	private static IPHostEntry GetHostByAddressFromString(string address, bool parse)
	{
		return null;
	}

	/// <summary>Resolves a host name or IP address to an <see cref="T:System.Net.IPHostEntry" /> instance.</summary>
	/// <param name="hostNameOrAddress">The host name or IP address to resolve.</param>
	/// <returns>An <see cref="T:System.Net.IPHostEntry" /> instance that contains address information about the host specified in <paramref name="hostNameOrAddress" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="hostNameOrAddress" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The length of <paramref name="hostNameOrAddress" /> parameter is greater than 255 characters.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error was encountered when resolving the <paramref name="hostNameOrAddress" /> parameter.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="hostNameOrAddress" /> parameter is an invalid IP address.</exception>
	public static IPHostEntry GetHostEntry(string hostNameOrAddress)
	{
		return null;
	}

	/// <summary>Resolves an IP address to an <see cref="T:System.Net.IPHostEntry" /> instance.</summary>
	/// <param name="address">An IP address.</param>
	/// <returns>An <see cref="T:System.Net.IPHostEntry" /> instance that contains address information about the host specified in <paramref name="address" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="address" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error is encountered when resolving <paramref name="address" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="address" /> is an invalid IP address.</exception>
	public static IPHostEntry GetHostEntry(IPAddress address)
	{
		return null;
	}

	/// <summary>Returns the Internet Protocol (IP) addresses for the specified host.</summary>
	/// <param name="hostNameOrAddress">The host name or IP address to resolve.</param>
	/// <returns>An array of type <see cref="T:System.Net.IPAddress" /> that holds the IP addresses for the host that is specified by the <paramref name="hostNameOrAddress" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="hostNameOrAddress" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The length of <paramref name="hostNameOrAddress" /> is greater than 255 characters.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error is encountered when resolving <paramref name="hostNameOrAddress" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="hostNameOrAddress" /> is an invalid IP address.</exception>
	public static IPAddress[] GetHostAddresses(string hostNameOrAddress)
	{
		return null;
	}

	/// <summary>Gets the DNS information for the specified DNS host name.</summary>
	/// <param name="hostName">The DNS name of the host.</param>
	/// <returns>An <see cref="T:System.Net.IPHostEntry" /> object that contains host information for the address specified in <paramref name="hostName" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="hostName" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The length of <paramref name="hostName" /> is greater than 255 characters.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error is encountered when resolving <paramref name="hostName" />.</exception>
	[Obsolete("Use GetHostEntry instead")]
	public static IPHostEntry GetHostByName(string hostName)
	{
		return null;
	}

	/// <summary>Gets the host name of the local computer.</summary>
	/// <returns>A string that contains the DNS host name of the local computer.</returns>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error is encountered when resolving the local host name.</exception>
	public static string GetHostName()
	{
		return null;
	}

	/// <summary>Returns the Internet Protocol (IP) addresses for the specified host as an asynchronous operation.</summary>
	/// <param name="hostNameOrAddress">The host name or IP address to resolve.</param>
	/// <returns>The task object representing the asynchronous operation. The <see cref="P:System.Threading.Tasks.Task`1.Result" /> property on the task object returns an array of type <see cref="T:System.Net.IPAddress" /> that holds the IP addresses for the host that is specified by the <paramref name="hostNameOrAddress" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="hostNameOrAddress" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The length of <paramref name="hostNameOrAddress" /> is greater than 255 characters.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error is encountered when resolving <paramref name="hostNameOrAddress" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="hostNameOrAddress" /> is an invalid IP address.</exception>
	public static Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress)
	{
		return null;
	}
}
