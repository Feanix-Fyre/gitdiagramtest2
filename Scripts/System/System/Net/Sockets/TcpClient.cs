using System.Threading.Tasks;

namespace System.Net.Sockets;

/// <summary>Provides client connections for TCP network services.</summary>
public class TcpClient : IDisposable
{
	private Socket m_ClientSocket;

	private bool m_Active;

	private NetworkStream m_DataStream;

	private AddressFamily m_Family;

	private bool m_CleanedUp;

	/// <summary>Gets or sets the underlying <see cref="T:System.Net.Sockets.Socket" />.</summary>
	/// <returns>The underlying network <see cref="T:System.Net.Sockets.Socket" />.</returns>
	public Socket Client
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.TcpClient" /> class.</summary>
	public TcpClient()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.TcpClient" /> class with the specified family.</summary>
	/// <param name="family">The <see cref="P:System.Net.IPAddress.AddressFamily" /> of the IP protocol.</param>
	/// <exception cref="T:System.ArgumentException">The <paramref name="family" /> parameter is not equal to AddressFamily.InterNetwork  
	///  -or-  
	///  The <paramref name="family" /> parameter is not equal to AddressFamily.InterNetworkV6</exception>
	public TcpClient(AddressFamily family)
	{
	}

	/// <summary>Connects the client to the specified port on the specified host.</summary>
	/// <param name="hostname">The DNS name of the remote host to which you intend to connect.</param>
	/// <param name="port">The port number of the remote host to which you intend to connect.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="hostname" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="port" /> parameter is not between <see cref="F:System.Net.IPEndPoint.MinPort" /> and <see cref="F:System.Net.IPEndPoint.MaxPort" />.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">
	///   <see cref="T:System.Net.Sockets.TcpClient" /> is closed.</exception>
	public void Connect(string hostname, int port)
	{
	}

	/// <summary>Connects the client to a remote TCP host using the specified remote network endpoint.</summary>
	/// <param name="remoteEP">The <see cref="T:System.Net.IPEndPoint" /> to which you intend to connect.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="remoteEp" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.TcpClient" /> is closed.</exception>
	public void Connect(IPEndPoint remoteEP)
	{
	}

	/// <summary>Begins an asynchronous request for a remote host connection. The remote host is specified by a host name (<see cref="T:System.String" />) and a port number (<see cref="T:System.Int32" />).</summary>
	/// <param name="host">The name of the remote host.</param>
	/// <param name="port">The port number of the remote host.</param>
	/// <param name="requestCallback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the operation is complete.</param>
	/// <param name="state">A user-defined object that contains information about the connect operation. This object is passed to the <paramref name="requestCallback" /> delegate when the operation is complete.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> object that references the asynchronous connection.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="host" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.Security.SecurityException">A caller higher in the call stack does not have permission for the requested operation.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The port number is not valid.</exception>
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state)
	{
		return null;
	}

	/// <summary>Ends a pending asynchronous connection attempt.</summary>
	/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> object returned by a call to <see cref="Overload:System.Net.Sockets.TcpClient.BeginConnect" />.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="asyncResult" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="asyncResult" /> parameter was not returned by a call to a <see cref="Overload:System.Net.Sockets.TcpClient.BeginConnect" /> method.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="M:System.Net.Sockets.TcpClient.EndConnect(System.IAsyncResult)" /> method was previously called for the asynchronous connection.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the <see cref="T:System.Net.Sockets.Socket" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The underlying <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public void EndConnect(IAsyncResult asyncResult)
	{
	}

	/// <summary>Connects the client to the specified TCP port on the specified host as an asynchronous operation.</summary>
	/// <param name="host">The DNS name of the remote host to which you intend to connect.</param>
	/// <param name="port">The port number of the remote host to which you intend to connect.</param>
	/// <returns>The task object representing the asynchronous operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="hostname" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="port" /> parameter is not between <see cref="F:System.Net.IPEndPoint.MinPort" /> and <see cref="F:System.Net.IPEndPoint.MaxPort" />.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">
	///   <see cref="T:System.Net.Sockets.TcpClient" /> is closed.</exception>
	public Task ConnectAsync(string host, int port)
	{
		return null;
	}

	/// <summary>Returns the <see cref="T:System.Net.Sockets.NetworkStream" /> used to send and receive data.</summary>
	/// <returns>The underlying <see cref="T:System.Net.Sockets.NetworkStream" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Net.Sockets.TcpClient" /> is not connected to a remote host.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.TcpClient" /> has been closed.</exception>
	public NetworkStream GetStream()
	{
		return null;
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Sockets.TcpClient" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">Set to <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>Releases the managed and unmanaged resources used by the <see cref="T:System.Net.Sockets.TcpClient" />.</summary>
	public void Dispose()
	{
	}

	/// <summary>Frees resources used by the <see cref="T:System.Net.Sockets.TcpClient" /> class.</summary>
	~TcpClient()
	{
	}

	private void initialize()
	{
	}
}
