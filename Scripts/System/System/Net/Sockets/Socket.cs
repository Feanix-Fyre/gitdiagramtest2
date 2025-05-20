using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace System.Net.Sockets;

/// <summary>Implements the Berkeley sockets interface.</summary>
public class Socket : IDisposable
{
	private sealed class CachedEventArgs
	{
		public TaskSocketAsyncEventArgs<Socket> TaskAccept;

		public Int32TaskSocketAsyncEventArgs TaskReceive;

		public Int32TaskSocketAsyncEventArgs TaskSend;

		public AwaitableSocketAsyncEventArgs ValueTaskReceive;

		public AwaitableSocketAsyncEventArgs ValueTaskSend;
	}

	private class TaskSocketAsyncEventArgs<TResult> : SocketAsyncEventArgs
	{
		internal AsyncTaskMethodBuilder<TResult> _builder;

		internal bool _accessed;

		internal TaskSocketAsyncEventArgs()
			: base(flowExecutionContext: false)
		{
		}

		internal AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(out bool responsibleForReturningToPool)
		{
			responsibleForReturningToPool = default(bool);
			return default(AsyncTaskMethodBuilder<TResult>);
		}
	}

	private sealed class Int32TaskSocketAsyncEventArgs : TaskSocketAsyncEventArgs<int>
	{
		internal bool _wrapExceptionsInIOExceptions;
	}

	internal sealed class AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs, IValueTaskSource, IValueTaskSource<int>
	{
		internal static readonly AwaitableSocketAsyncEventArgs Reserved;

		private static readonly Action<object> s_completedSentinel;

		private static readonly Action<object> s_availableSentinel;

		private Action<object> _continuation;

		private ExecutionContext _executionContext;

		private object _scheduler;

		private short _token;

		public bool WrapExceptionsInIOExceptions { get; set; }

		public AwaitableSocketAsyncEventArgs()
			: base(flowExecutionContext: false)
		{
		}

		public bool Reserve()
		{
			return false;
		}

		private void Release()
		{
		}

		protected override void OnCompleted(SocketAsyncEventArgs _)
		{
		}

		public ValueTask<int> ReceiveAsync(Socket socket)
		{
			return default(ValueTask<int>);
		}

		public ValueTask SendAsyncForNetworkStream(Socket socket)
		{
			return default(ValueTask);
		}

		public ValueTaskSourceStatus GetStatus(short token)
		{
			return default(ValueTaskSourceStatus);
		}

		public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
		{
		}

		private void InvokeContinuation(Action<object> continuation, object state, bool forceAsync)
		{
		}

		public int GetResult(short token)
		{
			return 0;
		}

		void IValueTaskSource.GetResult(short token)
		{
		}

		private void ThrowIncorrectTokenException()
		{
		}

		private void ThrowMultipleContinuationsException()
		{
		}

		private void ThrowException(SocketError error)
		{
		}

		private Exception CreateException(SocketError error)
		{
			return null;
		}
	}

	private struct WSABUF
	{
		public int len;

		public IntPtr buf;
	}

	private static readonly EventHandler<SocketAsyncEventArgs> AcceptCompletedHandler;

	private static readonly EventHandler<SocketAsyncEventArgs> ReceiveCompletedHandler;

	private static readonly EventHandler<SocketAsyncEventArgs> SendCompletedHandler;

	private static readonly TaskSocketAsyncEventArgs<Socket> s_rentedSocketSentinel;

	private static readonly Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel;

	private static readonly Task<int> s_zeroTask;

	private CachedEventArgs _cachedTaskEventArgs;

	private static object s_InternalSyncObject;

	internal static bool s_SupportsIPv4;

	internal static bool s_SupportsIPv6;

	internal static bool s_OSSupportsIPv6;

	internal static bool s_Initialized;

	private static bool s_LoggingEnabled;

	internal static bool s_PerfCountersEnabled;

	internal const int DefaultCloseTimeout = -1;

	private const int SOCKET_CLOSED_CODE = 10004;

	private const string TIMEOUT_EXCEPTION_MSG = "A connection attempt failed because the connected party did not properly respondafter a period of time, or established connection failed because connected host has failed to respond";

	private bool is_closed;

	private bool is_listening;

	private bool useOverlappedIO;

	private int linger_timeout;

	private AddressFamily addressFamily;

	private SocketType socketType;

	private ProtocolType protocolType;

	internal SafeSocketHandle m_Handle;

	internal EndPoint seed_endpoint;

	internal SemaphoreSlim ReadSem;

	internal SemaphoreSlim WriteSem;

	internal bool is_blocking;

	internal bool is_bound;

	internal bool is_connected;

	private int m_IntCleanedUp;

	internal bool connect_in_progress;

	internal readonly int ID;

	private static AsyncCallback AcceptAsyncCallback;

	private static IOAsyncCallback BeginAcceptCallback;

	private static IOAsyncCallback BeginAcceptReceiveCallback;

	private static AsyncCallback ConnectAsyncCallback;

	private static IOAsyncCallback BeginConnectCallback;

	private static AsyncCallback DisconnectAsyncCallback;

	private static IOAsyncCallback BeginDisconnectCallback;

	private static AsyncCallback ReceiveAsyncCallback;

	private static IOAsyncCallback BeginReceiveCallback;

	private static IOAsyncCallback BeginReceiveGenericCallback;

	private static AsyncCallback ReceiveFromAsyncCallback;

	private static IOAsyncCallback BeginReceiveFromCallback;

	private static AsyncCallback SendAsyncCallback;

	private static IOAsyncCallback BeginSendGenericCallback;

	private static AsyncCallback SendToAsyncCallback;

	/// <summary>Indicates whether the underlying operating system and network adaptors support Internet Protocol version 4 (IPv4).</summary>
	/// <returns>
	///   <see langword="true" /> if the operating system and network adaptors support the IPv4 protocol; otherwise, <see langword="false" />.</returns>
	public static bool OSSupportsIPv4 => false;

	/// <summary>Indicates whether the underlying operating system and network adaptors support Internet Protocol version 6 (IPv6).</summary>
	/// <returns>
	///   <see langword="true" /> if the operating system and network adaptors support the IPv6 protocol; otherwise, <see langword="false" />.</returns>
	public static bool OSSupportsIPv6 => false;

	/// <summary>Gets the operating system handle for the <see cref="T:System.Net.Sockets.Socket" />.</summary>
	/// <returns>An <see cref="T:System.IntPtr" /> that represents the operating system handle for the <see cref="T:System.Net.Sockets.Socket" />.</returns>
	public IntPtr Handle => (IntPtr)0;

	/// <summary>Gets the address family of the <see cref="T:System.Net.Sockets.Socket" />.</summary>
	/// <returns>One of the <see cref="T:System.Net.Sockets.AddressFamily" /> values.</returns>
	public AddressFamily AddressFamily => default(AddressFamily);

	/// <summary>Gets the type of the <see cref="T:System.Net.Sockets.Socket" />.</summary>
	/// <returns>One of the <see cref="T:System.Net.Sockets.SocketType" /> values.</returns>
	public SocketType SocketType => default(SocketType);

	/// <summary>Gets the protocol type of the <see cref="T:System.Net.Sockets.Socket" />.</summary>
	/// <returns>One of the <see cref="T:System.Net.Sockets.ProtocolType" /> values.</returns>
	public ProtocolType ProtocolType => default(ProtocolType);

	/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that specifies whether the <see cref="T:System.Net.Sockets.Socket" /> allows only one process to bind to a port.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Net.Sockets.Socket" /> allows only one socket to bind to a specific port; otherwise, <see langword="false" />. The default is <see langword="true" /> for Windows Server 2003 and Windows XP Service Pack 2, and <see langword="false" /> for all other versions.</returns>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> has been called for this <see cref="T:System.Net.Sockets.Socket" />.</exception>
	public bool ExclusiveAddressUse
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a value that specifies the size of the receive buffer of the <see cref="T:System.Net.Sockets.Socket" />.</summary>
	/// <returns>An <see cref="T:System.Int32" /> that contains the size, in bytes, of the receive buffer. The default is 8192.</returns>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is less than 0.</exception>
	public int ReceiveBufferSize
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a value that specifies the size of the send buffer of the <see cref="T:System.Net.Sockets.Socket" />.</summary>
	/// <returns>An <see cref="T:System.Int32" /> that contains the size, in bytes, of the send buffer. The default is 8192.</returns>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is less than 0.</exception>
	public int SendBufferSize
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a value that specifies the amount of time after which a synchronous <see cref="Overload:System.Net.Sockets.Socket.Receive" /> call will time out.</summary>
	/// <returns>The time-out value, in milliseconds. The default value is 0, which indicates an infinite time-out period. Specifying -1 also indicates an infinite time-out period.</returns>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is less than -1.</exception>
	public int ReceiveTimeout
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a value that specifies the amount of time after which a synchronous <see cref="Overload:System.Net.Sockets.Socket.Send" /> call will time out.</summary>
	/// <returns>The time-out value, in milliseconds. If you set the property with a value between 1 and 499, the value will be changed to 500. The default value is 0, which indicates an infinite time-out period. Specifying -1 also indicates an infinite time-out period.</returns>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is less than -1.</exception>
	public int SendTimeout
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a value that specifies the Time To Live (TTL) value of Internet Protocol (IP) packets sent by the <see cref="T:System.Net.Sockets.Socket" />.</summary>
	/// <returns>The TTL value.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The TTL value can't be set to a negative number.</exception>
	/// <exception cref="T:System.NotSupportedException">This property can be set only for sockets in the <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> or <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> families.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. This error is also returned when an attempt was made to set TTL to a value higher than 255.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public short Ttl
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that specifies whether the <see cref="T:System.Net.Sockets.Socket" /> allows Internet Protocol (IP) datagrams to be fragmented.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Net.Sockets.Socket" /> allows datagram fragmentation; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	/// <exception cref="T:System.NotSupportedException">This property can be set only for sockets in the <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> or <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> families.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public bool DontFragment
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that specifies whether the <see cref="T:System.Net.Sockets.Socket" /> is a dual-mode socket used for both IPv4 and IPv6.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Net.Sockets.Socket" /> is a  dual-mode socket; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public bool DualMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool IsDualMode => false;

	private static object InternalSyncObject => null;

	internal bool CleanedUp => false;

	/// <summary>Gets the amount of data that has been received from the network and is available to be read.</summary>
	/// <returns>The number of bytes of data received from the network and available to be read.</returns>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public int Available => 0;

	/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that specifies whether the <see cref="T:System.Net.Sockets.Socket" /> can send or receive broadcast packets.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Net.Sockets.Socket" /> allows broadcast packets; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	/// <exception cref="T:System.Net.Sockets.SocketException">This option is valid for a datagram socket only.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public bool EnableBroadcast
	{
		set
		{
		}
	}

	/// <summary>Gets a value that indicates whether the <see cref="T:System.Net.Sockets.Socket" /> is bound to a specific local port.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Net.Sockets.Socket" /> is bound to a local port; otherwise, <see langword="false" />.</returns>
	public bool IsBound => false;

	/// <summary>Gets the local endpoint.</summary>
	/// <returns>The <see cref="T:System.Net.EndPoint" /> that the <see cref="T:System.Net.Sockets.Socket" /> is using for communications.</returns>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public EndPoint LocalEndPoint => null;

	/// <summary>Gets or sets a value that indicates whether the <see cref="T:System.Net.Sockets.Socket" /> is in blocking mode.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Net.Sockets.Socket" /> will block; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public bool Blocking
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets a value that indicates whether a <see cref="T:System.Net.Sockets.Socket" /> is connected to a remote host as of the last <see cref="Overload:System.Net.Sockets.Socket.Send" /> or <see cref="Overload:System.Net.Sockets.Socket.Receive" /> operation.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Net.Sockets.Socket" /> was connected to a remote resource as of the most recent operation; otherwise, <see langword="false" />.</returns>
	public bool Connected => false;

	/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that specifies whether the stream <see cref="T:System.Net.Sockets.Socket" /> is using the Nagle algorithm.</summary>
	/// <returns>
	///   <see langword="false" /> if the <see cref="T:System.Net.Sockets.Socket" /> uses the Nagle algorithm; otherwise, <see langword="true" />. The default is <see langword="false" />.</returns>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the <see cref="T:System.Net.Sockets.Socket" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public bool NoDelay
	{
		set
		{
		}
	}

	/// <summary>Gets the remote endpoint.</summary>
	/// <returns>The <see cref="T:System.Net.EndPoint" /> with which the <see cref="T:System.Net.Sockets.Socket" /> is communicating.</returns>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public EndPoint RemoteEndPoint => null;

	internal static int FamilyHint => 0;

	internal ValueTask<int> ReceiveAsync(Memory<byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken)
	{
		return default(ValueTask<int>);
	}

	private Task<int> ReceiveAsyncApm(Memory<byte> buffer, SocketFlags socketFlags)
	{
		return null;
	}

	internal ValueTask SendAsyncForNetworkStream(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken)
	{
		return default(ValueTask);
	}

	private Task<int> SendAsyncApm(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags)
	{
		return null;
	}

	private static void CompleteAccept(Socket s, TaskSocketAsyncEventArgs<Socket> saea)
	{
	}

	private static void CompleteSendReceive(Socket s, Int32TaskSocketAsyncEventArgs saea, bool isReceive)
	{
	}

	private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions = false)
	{
		return null;
	}

	private void ReturnSocketAsyncEventArgs(Int32TaskSocketAsyncEventArgs saea, bool isReceive)
	{
	}

	private void ReturnSocketAsyncEventArgs(TaskSocketAsyncEventArgs<Socket> saea)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.Socket" /> class using the specified address family, socket type and protocol.</summary>
	/// <param name="addressFamily">One of the <see cref="T:System.Net.Sockets.AddressFamily" /> values.</param>
	/// <param name="socketType">One of the <see cref="T:System.Net.Sockets.SocketType" /> values.</param>
	/// <param name="protocolType">One of the <see cref="T:System.Net.Sockets.ProtocolType" /> values.</param>
	/// <exception cref="T:System.Net.Sockets.SocketException">The combination of <paramref name="addressFamily" />, <paramref name="socketType" />, and <paramref name="protocolType" /> results in an invalid socket.</exception>
	public Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
	{
	}

	internal bool CanTryAddressFamily(AddressFamily family)
	{
		return false;
	}

	/// <summary>Sends data to a connected <see cref="T:System.Net.Sockets.Socket" />.</summary>
	/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that contains the data to be sent.</param>
	/// <returns>The number of bytes sent to the <see cref="T:System.Net.Sockets.Socket" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public int Send(byte[] buffer)
	{
		return 0;
	}

	/// <summary>Sends the set of buffers in the list to a connected <see cref="T:System.Net.Sockets.Socket" />, using the specified <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
	/// <param name="buffers">A list of <see cref="T:System.ArraySegment`1" />s of type <see cref="T:System.Byte" /> that contains the data to be sent.</param>
	/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
	/// <returns>The number of bytes sent to the <see cref="T:System.Net.Sockets.Socket" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffers" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="buffers" /> is empty.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
	{
		return 0;
	}

	/// <summary>Sends the specified number of bytes of data to a connected <see cref="T:System.Net.Sockets.Socket" />, starting at the specified offset, and using the specified <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
	/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that contains the data to be sent.</param>
	/// <param name="offset">The position in the data buffer at which to begin sending data.</param>
	/// <param name="size">The number of bytes to send.</param>
	/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
	/// <returns>The number of bytes sent to the <see cref="T:System.Net.Sockets.Socket" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> is less than 0.  
	/// -or-  
	/// <paramref name="offset" /> is greater than the length of <paramref name="buffer" />.  
	/// -or-  
	/// <paramref name="size" /> is less than 0.  
	/// -or-  
	/// <paramref name="size" /> is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">
	///   <paramref name="socketFlags" /> is not a valid combination of values.  
	/// -or-  
	/// An operating system error occurs while accessing the <see cref="T:System.Net.Sockets.Socket" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags)
	{
		return 0;
	}

	/// <summary>Receives the specified number of bytes from a bound <see cref="T:System.Net.Sockets.Socket" /> into the specified offset position of the receive buffer, using the specified <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
	/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that is the storage location for received data.</param>
	/// <param name="offset">The location in <paramref name="buffer" /> to store the received data.</param>
	/// <param name="size">The number of bytes to receive.</param>
	/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
	/// <returns>The number of bytes received.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> is less than 0.  
	/// -or-  
	/// <paramref name="offset" /> is greater than the length of <paramref name="buffer" />.  
	/// -or-  
	/// <paramref name="size" /> is less than 0.  
	/// -or-  
	/// <paramref name="size" /> is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">
	///   <paramref name="socketFlags" /> is not a valid combination of values.  
	/// -or-  
	/// The <see cref="P:System.Net.Sockets.Socket.LocalEndPoint" /> property was not set.  
	/// -or-  
	/// An operating system error occurs while accessing the <see cref="T:System.Net.Sockets.Socket" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.Security.SecurityException">A caller in the call stack does not have the required permissions.</exception>
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags)
	{
		return 0;
	}

	/// <summary>Receives data from a bound <see cref="T:System.Net.Sockets.Socket" /> into the list of receive buffers, using the specified <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
	/// <param name="buffers">A list of <see cref="T:System.ArraySegment`1" />s of type <see cref="T:System.Byte" /> that contains the received data.</param>
	/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
	/// <returns>The number of bytes received.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffers" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="buffers" />.Count is zero.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred while attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
	{
		return 0;
	}

	/// <summary>Sets low-level operating modes for the <see cref="T:System.Net.Sockets.Socket" /> using the <see cref="T:System.Net.Sockets.IOControlCode" /> enumeration to specify control codes.</summary>
	/// <param name="ioControlCode">A <see cref="T:System.Net.Sockets.IOControlCode" /> value that specifies the control code of the operation to perform.</param>
	/// <param name="optionInValue">An array of type <see cref="T:System.Byte" /> that contains the input data required by the operation.</param>
	/// <param name="optionOutValue">An array of type <see cref="T:System.Byte" /> that contains the output data returned by the operation.</param>
	/// <returns>The number of bytes in the <paramref name="optionOutValue" /> parameter.</returns>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.InvalidOperationException">An attempt was made to change the blocking mode without using the <see cref="P:System.Net.Sockets.Socket.Blocking" /> property.</exception>
	public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue)
	{
		return 0;
	}

	/// <summary>Set the IP protection level on a socket.</summary>
	/// <param name="level">The IP protection level to set on this socket.</param>
	/// <exception cref="T:System.ArgumentException">The <paramref name="level" /> parameter cannot be <see cref="F:System.Net.Sockets.IPProtectionLevel.Unspecified" />. The IP protection level cannot be set to unspecified.</exception>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Net.Sockets.AddressFamily" /> of the socket must be either <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> or <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" />.</exception>
	public void SetIPProtectionLevel(IPProtectionLevel level)
	{
	}

	/// <summary>Sends data asynchronously to a connected <see cref="T:System.Net.Sockets.Socket" />.</summary>
	/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that contains the data to send.</param>
	/// <param name="offset">The zero-based position in the <paramref name="buffer" /> parameter at which to begin sending data.</param>
	/// <param name="size">The number of bytes to send.</param>
	/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
	/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate.</param>
	/// <param name="state">An object that contains state information for this request.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous send.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See remarks section below.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> is less than 0.  
	/// -or-  
	/// <paramref name="offset" /> is less than the length of <paramref name="buffer" />.  
	/// -or-  
	/// <paramref name="size" /> is less than 0.  
	/// -or-  
	/// <paramref name="size" /> is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
	{
		return null;
	}

	/// <summary>Ends a pending asynchronous send.</summary>
	/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that stores state information for this asynchronous operation.</param>
	/// <returns>If successful, the number of bytes sent to the <see cref="T:System.Net.Sockets.Socket" />; otherwise, an invalid <see cref="T:System.Net.Sockets.Socket" /> error.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asyncResult" /> was not returned by a call to the <see cref="M:System.Net.Sockets.Socket.BeginSend(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" /> method.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="M:System.Net.Sockets.Socket.EndSend(System.IAsyncResult)" /> was previously called for the asynchronous send.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public int EndSend(IAsyncResult asyncResult)
	{
		return 0;
	}

	/// <summary>Begins to asynchronously receive data from a connected <see cref="T:System.Net.Sockets.Socket" />.</summary>
	/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that is the storage location for the received data.</param>
	/// <param name="offset">The zero-based position in the <paramref name="buffer" /> parameter at which to store the received data.</param>
	/// <param name="size">The number of bytes to receive.</param>
	/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
	/// <param name="callback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the operation is complete.</param>
	/// <param name="state">A user-defined object that contains information about the receive operation. This object is passed to the <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> delegate when the operation is complete.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous read.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">
	///   <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> is less than 0.  
	/// -or-  
	/// <paramref name="offset" /> is greater than the length of <paramref name="buffer" />.  
	/// -or-  
	/// <paramref name="size" /> is less than 0.  
	/// -or-  
	/// <paramref name="size" /> is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter.</exception>
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
	{
		return null;
	}

	/// <summary>Ends a pending asynchronous read.</summary>
	/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that stores state information and any user defined data for this asynchronous operation.</param>
	/// <returns>The number of bytes received.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asyncResult" /> was not returned by a call to the <see cref="M:System.Net.Sockets.Socket.BeginReceive(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" /> method.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> was previously called for the asynchronous read.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public int EndReceive(IAsyncResult asyncResult)
	{
		return 0;
	}

	internal static void InitializeSockets()
	{
	}

	/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Net.Sockets.Socket" /> class.</summary>
	public void Dispose()
	{
	}

	/// <summary>Frees resources used by the <see cref="T:System.Net.Sockets.Socket" /> class.</summary>
	~Socket()
	{
	}

	internal void InternalShutdown(SocketShutdown how)
	{
	}

	internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent)
	{
	}

	internal Socket(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle)
	{
	}

	private void SocketDefaults()
	{
	}

	private static IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, out int error)
	{
		error = default(int);
		return (IntPtr)0;
	}

	private static int Available_internal(SafeSocketHandle safeHandle, out int error)
	{
		error = default(int);
		return 0;
	}

	private static int Available_icall(IntPtr socket, out int error)
	{
		error = default(int);
		return 0;
	}

	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error)
	{
		error = default(int);
		return null;
	}

	private static SocketAddress LocalEndPoint_icall(IntPtr socket, int family, out int error)
	{
		error = default(int);
		return null;
	}

	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error)
	{
		error = default(int);
	}

	internal static void Blocking_icall(IntPtr socket, bool block, out int error)
	{
		error = default(int);
	}

	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error)
	{
		error = default(int);
		return null;
	}

	private static SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, out int error)
	{
		error = default(int);
		return null;
	}

	/// <summary>Determines the status of the <see cref="T:System.Net.Sockets.Socket" />.</summary>
	/// <param name="microSeconds">The time to wait for a response, in microseconds.</param>
	/// <param name="mode">One of the <see cref="T:System.Net.Sockets.SelectMode" /> values.</param>
	/// <returns>The status of the <see cref="T:System.Net.Sockets.Socket" /> based on the polling mode value passed in the <paramref name="mode" /> parameter.  
	///   Mode  
	///
	///   Return Value  
	///
	///  <see cref="F:System.Net.Sockets.SelectMode.SelectRead" /><see langword="true" /> if <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> has been called and a connection is pending;  
	///
	///  -or-  
	///
	///  <see langword="true" /> if data is available for reading;  
	///
	///  -or-  
	///
	///  <see langword="true" /> if the connection has been closed, reset, or terminated;  
	///
	///  otherwise, returns <see langword="false" />.  
	///
	///  <see cref="F:System.Net.Sockets.SelectMode.SelectWrite" /><see langword="true" />, if processing a <see cref="M:System.Net.Sockets.Socket.Connect(System.Net.EndPoint)" />, and the connection has succeeded;  
	///
	///  -or-  
	///
	///  <see langword="true" /> if data can be sent;  
	///
	///  otherwise, returns <see langword="false" />.  
	///
	///  <see cref="F:System.Net.Sockets.SelectMode.SelectError" /><see langword="true" /> if processing a <see cref="M:System.Net.Sockets.Socket.Connect(System.Net.EndPoint)" /> that does not block, and the connection has failed;  
	///
	///  -or-  
	///
	///  <see langword="true" /> if <see cref="F:System.Net.Sockets.SocketOptionName.OutOfBandInline" /> is not set and out-of-band data is available;  
	///
	///  otherwise, returns <see langword="false" />.</returns>
	/// <exception cref="T:System.NotSupportedException">The <paramref name="mode" /> parameter is not one of the <see cref="T:System.Net.Sockets.SelectMode" /> values.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See remarks below.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public bool Poll(int microSeconds, SelectMode mode)
	{
		return false;
	}

	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error)
	{
		error = default(int);
		return false;
	}

	private static bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, out int error)
	{
		error = default(int);
		return false;
	}

	/// <summary>Creates a new <see cref="T:System.Net.Sockets.Socket" /> for a newly created connection.</summary>
	/// <returns>A <see cref="T:System.Net.Sockets.Socket" /> for a newly created connection.</returns>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.InvalidOperationException">The accepting socket is not listening for connections. You must call <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> and <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> before calling <see cref="M:System.Net.Sockets.Socket.Accept" />.</exception>
	public Socket Accept()
	{
		return null;
	}

	internal void Accept(Socket acceptSocket)
	{
	}

	/// <summary>Begins an asynchronous operation to accept an incoming connection attempt.</summary>
	/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate.</param>
	/// <param name="state">An object that contains state information for this request.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous <see cref="T:System.Net.Sockets.Socket" /> creation.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> object has been closed.</exception>
	/// <exception cref="T:System.NotSupportedException">Windows NT is required for this method.</exception>
	/// <exception cref="T:System.InvalidOperationException">The accepting socket is not listening for connections. You must call <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> and <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> before calling <see cref="M:System.Net.Sockets.Socket.BeginAccept(System.AsyncCallback,System.Object)" />.  
	///  -or-  
	///  The accepted socket is bound.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="receiveSize" /> is less than 0.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	public IAsyncResult BeginAccept(AsyncCallback callback, object state)
	{
		return null;
	}

	/// <summary>Asynchronously accepts an incoming connection attempt and creates a new <see cref="T:System.Net.Sockets.Socket" /> to handle remote host communication.</summary>
	/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that stores state information for this asynchronous operation as well as any user defined data.</param>
	/// <returns>A <see cref="T:System.Net.Sockets.Socket" /> to handle communication with the remote host.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asyncResult" /> was not created by a call to <see cref="M:System.Net.Sockets.Socket.BeginAccept(System.AsyncCallback,System.Object)" />.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="M:System.Net.Sockets.Socket.EndAccept(System.IAsyncResult)" /> method was previously called.</exception>
	/// <exception cref="T:System.NotSupportedException">Windows NT is required for this method.</exception>
	public Socket EndAccept(IAsyncResult asyncResult)
	{
		return null;
	}

	/// <summary>Asynchronously accepts an incoming connection attempt and creates a new <see cref="T:System.Net.Sockets.Socket" /> object to handle remote host communication. This method returns a buffer that contains the initial data and the number of bytes transferred.</summary>
	/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that contains the bytes transferred.</param>
	/// <param name="bytesTransferred">The number of bytes transferred.</param>
	/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> object that stores state information for this asynchronous operation as well as any user defined data.</param>
	/// <returns>A <see cref="T:System.Net.Sockets.Socket" /> object to handle communication with the remote host.</returns>
	/// <exception cref="T:System.NotSupportedException">Windows NT is required for this method.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> object has been closed.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is empty.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asyncResult" /> was not created by a call to <see cref="M:System.Net.Sockets.Socket.BeginAccept(System.AsyncCallback,System.Object)" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="M:System.Net.Sockets.Socket.EndAccept(System.IAsyncResult)" /> method was previously called.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the <see cref="T:System.Net.Sockets.Socket" />.</exception>
	public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult)
	{
		buffer = null;
		bytesTransferred = default(int);
		return null;
	}

	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking)
	{
		error = default(int);
		return null;
	}

	private static IntPtr Accept_icall(IntPtr sock, out int error, bool blocking)
	{
		error = default(int);
		return (IntPtr)0;
	}

	/// <summary>Associates a <see cref="T:System.Net.Sockets.Socket" /> with a local endpoint.</summary>
	/// <param name="localEP">The local <see cref="T:System.Net.EndPoint" /> to associate with the <see cref="T:System.Net.Sockets.Socket" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="localEP" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.Security.SecurityException">A caller higher in the call stack does not have permission for the requested operation.</exception>
	public void Bind(EndPoint localEP)
	{
	}

	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error)
	{
		error = default(int);
	}

	private static void Bind_icall(IntPtr sock, SocketAddress sa, out int error)
	{
		error = default(int);
	}

	/// <summary>Places a <see cref="T:System.Net.Sockets.Socket" /> in a listening state.</summary>
	/// <param name="backlog">The maximum length of the pending connections queue.</param>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public void Listen(int backlog)
	{
	}

	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error)
	{
		error = default(int);
	}

	private static void Listen_icall(IntPtr sock, int backlog, out int error)
	{
		error = default(int);
	}

	/// <summary>Establishes a connection to a remote host. The host is specified by an IP address and a port number.</summary>
	/// <param name="address">The IP address of the remote host.</param>
	/// <param name="port">The port number of the remote host.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="address" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The port number is not valid.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.NotSupportedException">This method is valid for sockets in the <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> or <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> families.</exception>
	/// <exception cref="T:System.ArgumentException">The length of <paramref name="address" /> is zero.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Net.Sockets.Socket" /> has been placed in a listening state by calling <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />.</exception>
	public void Connect(IPAddress address, int port)
	{
	}

	/// <summary>Establishes a connection to a remote host.</summary>
	/// <param name="remoteEP">An <see cref="T:System.Net.EndPoint" /> that represents the remote device.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="remoteEP" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.Security.SecurityException">A caller higher in the call stack does not have permission for the requested operation.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Net.Sockets.Socket" /> has been placed in a listening state by calling <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />.</exception>
	public void Connect(EndPoint remoteEP)
	{
	}

	/// <summary>Begins an asynchronous request for a remote host connection. The host is specified by a host name and a port number.</summary>
	/// <param name="host">The name of the remote host.</param>
	/// <param name="port">The port number of the remote host.</param>
	/// <param name="requestCallback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the connect operation is complete.</param>
	/// <param name="state">A user-defined object that contains information about the connect operation. This object is passed to the <paramref name="requestCallback" /> delegate when the operation is complete.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous connection.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="host" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.NotSupportedException">This method is valid for sockets in the <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> or <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> families.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The port number is not valid.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Net.Sockets.Socket" /> has been placed in a listening state by calling <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />, or an asynchronous operation is already in progress.</exception>
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state)
	{
		return null;
	}

	/// <summary>Begins an asynchronous request for a remote host connection.</summary>
	/// <param name="remoteEP">An <see cref="T:System.Net.EndPoint" /> that represents the remote host.</param>
	/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate.</param>
	/// <param name="state">An object that contains state information for this request.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous connection.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="remoteEP" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.Security.SecurityException">A caller higher in the call stack does not have permission for the requested operation.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Net.Sockets.Socket" /> has been placed in a listening state by calling <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />, or an asynchronous operation is already in progress.</exception>
	public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state)
	{
		return null;
	}

	private static bool BeginMConnect(SocketAsyncResult sockares)
	{
		return false;
	}

	private static bool BeginSConnect(SocketAsyncResult sockares)
	{
		return false;
	}

	/// <summary>Ends a pending asynchronous connection request.</summary>
	/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that stores state information and any user defined data for this asynchronous operation.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asyncResult" /> was not returned by a call to the <see cref="M:System.Net.Sockets.Socket.BeginConnect(System.Net.EndPoint,System.AsyncCallback,System.Object)" /> method.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="M:System.Net.Sockets.Socket.EndConnect(System.IAsyncResult)" /> was previously called for the asynchronous connection.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public void EndConnect(IAsyncResult asyncResult)
	{
	}

	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking)
	{
		error = default(int);
	}

	private static void Connect_icall(IntPtr sock, SocketAddress sa, out int error, bool blocking)
	{
		error = default(int);
	}

	/// <summary>Closes the socket connection and allows reuse of the socket.</summary>
	/// <param name="reuseSocket">
	///   <see langword="true" /> if this socket can be reused after the current connection is closed; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.PlatformNotSupportedException">This method requires Windows 2000 or earlier, or the exception will be thrown.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> object has been closed.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	public void Disconnect(bool reuseSocket)
	{
	}

	/// <summary>Ends a pending asynchronous disconnect request.</summary>
	/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> object that stores state information and any user-defined data for this asynchronous operation.</param>
	/// <exception cref="T:System.NotSupportedException">The operating system is Windows 2000 or earlier, and this method requires Windows XP.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> object has been closed.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asyncResult" /> was not returned by a call to the <see cref="M:System.Net.Sockets.Socket.BeginDisconnect(System.Boolean,System.AsyncCallback,System.Object)" /> method.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="M:System.Net.Sockets.Socket.EndDisconnect(System.IAsyncResult)" /> was previously called for the asynchronous connection.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.Net.WebException">The disconnect request has timed out.</exception>
	public void EndDisconnect(IAsyncResult asyncResult)
	{
	}

	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error)
	{
		error = default(int);
	}

	private static void Disconnect_icall(IntPtr sock, bool reuse, out int error)
	{
		error = default(int);
	}

	/// <summary>Receives data from a bound <see cref="T:System.Net.Sockets.Socket" /> into a receive buffer, using the specified <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
	/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that is the storage location for the received data.</param>
	/// <param name="offset">The position in the <paramref name="buffer" /> parameter to store the received data.</param>
	/// <param name="size">The number of bytes to receive.</param>
	/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
	/// <param name="errorCode">A <see cref="T:System.Net.Sockets.SocketError" /> object that stores the socket error.</param>
	/// <returns>The number of bytes received.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> is less than 0.  
	/// -or-  
	/// <paramref name="offset" /> is greater than the length of <paramref name="buffer" />.  
	/// -or-  
	/// <paramref name="size" /> is less than 0.  
	/// -or-  
	/// <paramref name="size" /> is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">
	///   <paramref name="socketFlags" /> is not a valid combination of values.  
	/// -or-  
	/// The <see cref="P:System.Net.Sockets.Socket.LocalEndPoint" /> property is not set.  
	/// -or-  
	/// An operating system error occurs while accessing the <see cref="T:System.Net.Sockets.Socket" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.Security.SecurityException">A caller in the call stack does not have the required permissions.</exception>
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
	{
		errorCode = default(SocketError);
		return 0;
	}

	private int Receive(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
	{
		errorCode = default(SocketError);
		return 0;
	}

	/// <summary>Receives data from a bound <see cref="T:System.Net.Sockets.Socket" /> into the list of receive buffers, using the specified <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
	/// <param name="buffers">A list of <see cref="T:System.ArraySegment`1" />s of type <see cref="T:System.Byte" /> that contains the received data.</param>
	/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
	/// <param name="errorCode">A <see cref="T:System.Net.Sockets.SocketError" /> object that stores the socket error.</param>
	/// <returns>The number of bytes received.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffers" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="buffers" />.Count is zero.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred while attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	[CLSCompliant(false)]
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
	{
		errorCode = default(SocketError);
		return 0;
	}

	public int Receive(Span<byte> buffer, SocketFlags socketFlags, out SocketError errorCode)
	{
		errorCode = default(SocketError);
		return 0;
	}

	public int Send(ReadOnlySpan<byte> buffer, SocketFlags socketFlags, out SocketError errorCode)
	{
		errorCode = default(SocketError);
		return 0;
	}

	/// <summary>Begins an asynchronous request to receive data from a connected <see cref="T:System.Net.Sockets.Socket" /> object.</summary>
	/// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
	/// <returns>
	///   <see langword="true" /> if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation.  
	/// <see langword="false" /> if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
	/// <exception cref="T:System.ArgumentException">An argument was invalid. The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> or <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> properties on the <paramref name="e" /> parameter must reference valid buffers. One or the other of these properties may be set, but not both at the same time.</exception>
	/// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
	/// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	public bool ReceiveAsync(SocketAsyncEventArgs e)
	{
		return false;
	}

	/// <summary>Begins to asynchronously receive data from a connected <see cref="T:System.Net.Sockets.Socket" />.</summary>
	/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that is the storage location for the received data.</param>
	/// <param name="offset">The location in <paramref name="buffer" /> to store the received data.</param>
	/// <param name="size">The number of bytes to receive.</param>
	/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
	/// <param name="errorCode">A <see cref="T:System.Net.Sockets.SocketError" /> object that stores the socket error.</param>
	/// <param name="callback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the operation is complete.</param>
	/// <param name="state">A user-defined object that contains information about the receive operation. This object is passed to the <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> delegate when the operation is complete.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous read.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">
	///   <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> is less than 0.  
	/// -or-  
	/// <paramref name="offset" /> is greater than the length of <paramref name="buffer" />.  
	/// -or-  
	/// <paramref name="size" /> is less than 0.  
	/// -or-  
	/// <paramref name="size" /> is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter.</exception>
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)
	{
		errorCode = default(SocketError);
		return null;
	}

	/// <summary>Ends a pending asynchronous read.</summary>
	/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that stores state information and any user defined data for this asynchronous operation.</param>
	/// <param name="errorCode">A <see cref="T:System.Net.Sockets.SocketError" /> object that stores the socket error.</param>
	/// <returns>The number of bytes received.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asyncResult" /> was not returned by a call to the <see cref="M:System.Net.Sockets.Socket.BeginReceive(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" /> method.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> was previously called for the asynchronous read.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode)
	{
		errorCode = default(SocketError);
		return 0;
	}

	private unsafe static int Receive_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
	{
		error = default(int);
		return 0;
	}

	private unsafe static int Receive_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
	{
		error = default(int);
		return 0;
	}

	private unsafe static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
	{
		error = default(int);
		return 0;
	}

	private unsafe static int Receive_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
	{
		error = default(int);
		return 0;
	}

	/// <summary>Receives the specified number of bytes of data into the specified location of the data buffer, using the specified <see cref="T:System.Net.Sockets.SocketFlags" />, and stores the endpoint.</summary>
	/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that is the storage location for received data.</param>
	/// <param name="offset">The position in the <paramref name="buffer" /> parameter to store the received data.</param>
	/// <param name="size">The number of bytes to receive.</param>
	/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
	/// <param name="remoteEP">An <see cref="T:System.Net.EndPoint" />, passed by reference, that represents the remote server.</param>
	/// <returns>The number of bytes received.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="remoteEP" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> is less than 0.  
	/// -or-  
	/// <paramref name="offset" /> is greater than the length of <paramref name="buffer" />.  
	/// -or-  
	/// <paramref name="size" /> is less than 0.  
	/// -or-  
	/// <paramref name="size" /> is greater than the length of the <paramref name="buffer" /> minus the value of the offset parameter.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">
	///   <paramref name="socketFlags" /> is not a valid combination of values.  
	/// -or-  
	/// The <see cref="P:System.Net.Sockets.Socket.LocalEndPoint" /> property was not set.  
	/// -or-  
	/// An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP)
	{
		return 0;
	}

	internal int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode)
	{
		errorCode = default(SocketError);
		return 0;
	}

	private int ReceiveFrom(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode)
	{
		errorCode = default(SocketError);
		return 0;
	}

	private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares)
	{
		return 0;
	}

	private unsafe static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking)
	{
		error = default(int);
		return 0;
	}

	private unsafe static int ReceiveFrom_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking)
	{
		error = default(int);
		return 0;
	}

	/// <summary>Sends the specified number of bytes of data to a connected <see cref="T:System.Net.Sockets.Socket" />, starting at the specified offset, and using the specified <see cref="T:System.Net.Sockets.SocketFlags" /></summary>
	/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that contains the data to be sent.</param>
	/// <param name="offset">The position in the data buffer at which to begin sending data.</param>
	/// <param name="size">The number of bytes to send.</param>
	/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
	/// <param name="errorCode">A <see cref="T:System.Net.Sockets.SocketError" /> object that stores the socket error.</param>
	/// <returns>The number of bytes sent to the <see cref="T:System.Net.Sockets.Socket" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> is less than 0.  
	/// -or-  
	/// <paramref name="offset" /> is greater than the length of <paramref name="buffer" />.  
	/// -or-  
	/// <paramref name="size" /> is less than 0.  
	/// -or-  
	/// <paramref name="size" /> is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">
	///   <paramref name="socketFlags" /> is not a valid combination of values.  
	/// -or-  
	/// An operating system error occurs while accessing the <see cref="T:System.Net.Sockets.Socket" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
	{
		errorCode = default(SocketError);
		return 0;
	}

	/// <summary>Sends the set of buffers in the list to a connected <see cref="T:System.Net.Sockets.Socket" />, using the specified <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
	/// <param name="buffers">A list of <see cref="T:System.ArraySegment`1" />s of type <see cref="T:System.Byte" /> that contains the data to be sent.</param>
	/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
	/// <param name="errorCode">A <see cref="T:System.Net.Sockets.SocketError" /> object that stores the socket error.</param>
	/// <returns>The number of bytes sent to the <see cref="T:System.Net.Sockets.Socket" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffers" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="buffers" /> is empty.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	[CLSCompliant(false)]
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
	{
		errorCode = default(SocketError);
		return 0;
	}

	/// <summary>Sends data asynchronously to a connected <see cref="T:System.Net.Sockets.Socket" /> object.</summary>
	/// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
	/// <returns>
	///   <see langword="true" /> if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation.  
	/// <see langword="false" /> if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
	/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> or <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> properties on the <paramref name="e" /> parameter must reference valid buffers. One or the other of these properties may be set, but not both at the same time.</exception>
	/// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
	/// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">The <see cref="T:System.Net.Sockets.Socket" /> is not yet connected or was not obtained via an <see cref="M:System.Net.Sockets.Socket.Accept" />, <see cref="M:System.Net.Sockets.Socket.AcceptAsync(System.Net.Sockets.SocketAsyncEventArgs)" />,or <see cref="Overload:System.Net.Sockets.Socket.BeginAccept" />, method.</exception>
	public bool SendAsync(SocketAsyncEventArgs e)
	{
		return false;
	}

	/// <summary>Sends data asynchronously to a connected <see cref="T:System.Net.Sockets.Socket" />.</summary>
	/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that contains the data to send.</param>
	/// <param name="offset">The zero-based position in the <paramref name="buffer" /> parameter at which to begin sending data.</param>
	/// <param name="size">The number of bytes to send.</param>
	/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
	/// <param name="errorCode">A <see cref="T:System.Net.Sockets.SocketError" /> object that stores the socket error.</param>
	/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate.</param>
	/// <param name="state">An object that contains state information for this request.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous send.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See remarks section below.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> is less than 0.  
	/// -or-  
	/// <paramref name="offset" /> is less than the length of <paramref name="buffer" />.  
	/// -or-  
	/// <paramref name="size" /> is less than 0.  
	/// -or-  
	/// <paramref name="size" /> is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)
	{
		errorCode = default(SocketError);
		return null;
	}

	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far)
	{
	}

	/// <summary>Ends a pending asynchronous send.</summary>
	/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that stores state information for this asynchronous operation.</param>
	/// <param name="errorCode">A <see cref="T:System.Net.Sockets.SocketError" /> object that stores the socket error.</param>
	/// <returns>If successful, the number of bytes sent to the <see cref="T:System.Net.Sockets.Socket" />; otherwise, an invalid <see cref="T:System.Net.Sockets.Socket" /> error.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asyncResult" /> was not returned by a call to the <see cref="M:System.Net.Sockets.Socket.BeginSend(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" /> method.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="M:System.Net.Sockets.Socket.EndSend(System.IAsyncResult)" /> was previously called for the asynchronous send.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public int EndSend(IAsyncResult asyncResult, out SocketError errorCode)
	{
		errorCode = default(SocketError);
		return 0;
	}

	private unsafe static int Send_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
	{
		error = default(int);
		return 0;
	}

	private unsafe static int Send_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
	{
		error = default(int);
		return 0;
	}

	private unsafe static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
	{
		error = default(int);
		return 0;
	}

	private unsafe static int Send_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
	{
		error = default(int);
		return 0;
	}

	/// <summary>Sends the specified number of bytes of data to the specified endpoint, starting at the specified location in the buffer, and using the specified <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
	/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that contains the data to be sent.</param>
	/// <param name="offset">The position in the data buffer at which to begin sending data.</param>
	/// <param name="size">The number of bytes to send.</param>
	/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
	/// <param name="remoteEP">The <see cref="T:System.Net.EndPoint" /> that represents the destination location for the data.</param>
	/// <returns>The number of bytes sent.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="remoteEP" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> is less than 0.  
	/// -or-  
	/// <paramref name="offset" /> is greater than the length of <paramref name="buffer" />.  
	/// -or-  
	/// <paramref name="size" /> is less than 0.  
	/// -or-  
	/// <paramref name="size" /> is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">
	///   <paramref name="socketFlags" /> is not a valid combination of values.  
	/// -or-  
	/// An operating system error occurs while accessing the <see cref="T:System.Net.Sockets.Socket" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.Security.SecurityException">A caller in the call stack does not have the required permissions.</exception>
	public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP)
	{
		return 0;
	}

	/// <summary>Ends a pending asynchronous send to a specific location.</summary>
	/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that stores state information and any user defined data for this asynchronous operation.</param>
	/// <returns>If successful, the number of bytes sent; otherwise, an invalid <see cref="T:System.Net.Sockets.Socket" /> error.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asyncResult" /> was not returned by a call to the <see cref="M:System.Net.Sockets.Socket.BeginSendTo(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.Net.EndPoint,System.AsyncCallback,System.Object)" /> method.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="M:System.Net.Sockets.Socket.EndSendTo(System.IAsyncResult)" /> was previously called for the asynchronous send.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public int EndSendTo(IAsyncResult asyncResult)
	{
		return 0;
	}

	private unsafe static int SendTo_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking)
	{
		error = default(int);
		return 0;
	}

	private unsafe static int SendTo_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking)
	{
		error = default(int);
		return 0;
	}

	/// <summary>Returns the value of a specified <see cref="T:System.Net.Sockets.Socket" /> option, represented as an object.</summary>
	/// <param name="optionLevel">One of the <see cref="T:System.Net.Sockets.SocketOptionLevel" /> values.</param>
	/// <param name="optionName">One of the <see cref="T:System.Net.Sockets.SocketOptionName" /> values.</param>
	/// <returns>An object that represents the value of the option. When the <paramref name="optionName" /> parameter is set to <see cref="F:System.Net.Sockets.SocketOptionName.Linger" /> the return value is an instance of the <see cref="T:System.Net.Sockets.LingerOption" /> class. When <paramref name="optionName" /> is set to <see cref="F:System.Net.Sockets.SocketOptionName.AddMembership" /> or <see cref="F:System.Net.Sockets.SocketOptionName.DropMembership" />, the return value is an instance of the <see cref="T:System.Net.Sockets.MulticastOption" /> class. When <paramref name="optionName" /> is any other value, the return value is an integer.</returns>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.  
	///  -or-  
	///  <paramref name="optionName" /> was set to the unsupported value <see cref="F:System.Net.Sockets.SocketOptionName.MaxConnections" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
	{
		return null;
	}

	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error)
	{
		obj_val = null;
		error = default(int);
	}

	private static void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error)
	{
		obj_val = null;
		error = default(int);
	}

	/// <summary>Sets the specified <see cref="T:System.Net.Sockets.Socket" /> option to the specified <see cref="T:System.Boolean" /> value.</summary>
	/// <param name="optionLevel">One of the <see cref="T:System.Net.Sockets.SocketOptionLevel" /> values.</param>
	/// <param name="optionName">One of the <see cref="T:System.Net.Sockets.SocketOptionName" /> values.</param>
	/// <param name="optionValue">The value of the option, represented as a <see cref="T:System.Boolean" />.</param>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> object has been closed.</exception>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue)
	{
	}

	/// <summary>Sets the specified <see cref="T:System.Net.Sockets.Socket" /> option to the specified integer value.</summary>
	/// <param name="optionLevel">One of the <see cref="T:System.Net.Sockets.SocketOptionLevel" /> values.</param>
	/// <param name="optionName">One of the <see cref="T:System.Net.Sockets.SocketOptionName" /> values.</param>
	/// <param name="optionValue">A value of the option.</param>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue)
	{
	}

	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error)
	{
		error = default(int);
	}

	private static void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error)
	{
		error = default(int);
	}

	/// <summary>Sets low-level operating modes for the <see cref="T:System.Net.Sockets.Socket" /> using numerical control codes.</summary>
	/// <param name="ioControlCode">An <see cref="T:System.Int32" /> value that specifies the control code of the operation to perform.</param>
	/// <param name="optionInValue">A <see cref="T:System.Byte" /> array that contains the input data required by the operation.</param>
	/// <param name="optionOutValue">A <see cref="T:System.Byte" /> array that contains the output data returned by the operation.</param>
	/// <returns>The number of bytes in the <paramref name="optionOutValue" /> parameter.</returns>
	/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed.</exception>
	/// <exception cref="T:System.InvalidOperationException">An attempt was made to change the blocking mode without using the <see cref="P:System.Net.Sockets.Socket.Blocking" /> property.</exception>
	/// <exception cref="T:System.Security.SecurityException">A caller in the call stack does not have the required permissions.</exception>
	public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue)
	{
		return 0;
	}

	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error)
	{
		error = default(int);
		return 0;
	}

	private static int IOControl_icall(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error)
	{
		error = default(int);
		return 0;
	}

	/// <summary>Closes the <see cref="T:System.Net.Sockets.Socket" /> connection and releases all associated resources.</summary>
	public void Close()
	{
	}

	/// <summary>Closes the <see cref="T:System.Net.Sockets.Socket" /> connection and releases all associated resources with a specified timeout to allow queued data to be sent.</summary>
	/// <param name="timeout">Wait up to <paramref name="timeout" /> seconds to send any remaining data, then close the socket.</param>
	public void Close(int timeout)
	{
	}

	internal static void Close_icall(IntPtr socket, out int error)
	{
		error = default(int);
	}

	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error)
	{
		error = default(int);
	}

	internal static void Shutdown_icall(IntPtr socket, SocketShutdown how, out int error)
	{
		error = default(int);
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Sockets.Socket" />, and optionally disposes of the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to releases only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	private void Linger(IntPtr handle)
	{
	}

	private void ThrowIfDisposedAndClosed()
	{
	}

	private void ThrowIfBufferNull(byte[] buffer)
	{
	}

	private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size)
	{
	}

	private void ThrowIfUdp()
	{
	}

	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName)
	{
		return null;
	}

	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job)
	{
	}

	private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation)
	{
	}

	private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op)
	{
		return default(SocketAsyncOperation);
	}

	private IPEndPoint RemapIPEndPoint(IPEndPoint input)
	{
		return null;
	}

	internal static void cancel_blocking_socket_operation(Thread thread)
	{
	}

	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface)
	{
		return false;
	}

	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface)
	{
		return false;
	}
}
