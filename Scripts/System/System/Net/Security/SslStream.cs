using System.IO;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace System.Net.Security;

/// <summary>Provides a stream used for client-server communication that uses the Secure Socket Layer (SSL) security protocol to authenticate the server and optionally the client.</summary>
public class SslStream : AuthenticatedStream
{
	private MobileTlsProvider provider;

	private MonoTlsSettings settings;

	private RemoteCertificateValidationCallback validationCallback;

	private LocalCertificateSelectionCallback selectionCallback;

	private MobileAuthenticatedStream impl;

	private bool explicitSettings;

	internal MobileAuthenticatedStream Impl => null;

	internal string InternalTargetHost => null;

	/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether authentication was successful.</summary>
	/// <returns>
	///   <see langword="true" /> if successful authentication occurred; otherwise, <see langword="false" />.</returns>
	public override bool IsAuthenticated => false;

	/// <summary>Gets the certificate used to authenticate the local endpoint.</summary>
	/// <returns>An X509Certificate object that represents the certificate supplied for authentication or <see langword="null" /> if no certificate was supplied.</returns>
	/// <exception cref="T:System.InvalidOperationException">Authentication failed or has not occurred.</exception>
	public virtual X509Certificate LocalCertificate => null;

	/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the underlying stream is seekable.</summary>
	/// <returns>This property always returns <see langword="false" />.</returns>
	public override bool CanSeek => false;

	/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the underlying stream is readable.</summary>
	/// <returns>
	///   <see langword="true" /> if authentication has occurred and the underlying stream is readable; otherwise <see langword="false" />.</returns>
	public override bool CanRead => false;

	/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the underlying stream supports time-outs.</summary>
	/// <returns>
	///   <see langword="true" /> if the underlying stream supports time-outs; otherwise, <see langword="false" />.</returns>
	public override bool CanTimeout => false;

	/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the underlying stream is writable.</summary>
	/// <returns>
	///   <see langword="true" /> if authentication has occurred and the underlying stream is writable; otherwise <see langword="false" />.</returns>
	public override bool CanWrite => false;

	/// <summary>Gets or sets the amount of time a read operation blocks waiting for data.</summary>
	/// <returns>The amount of time that elapses before a synchronous read operation fails.</returns>
	public override int ReadTimeout
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the amount of time a write operation blocks waiting for data.</summary>
	/// <returns>The amount of time that elapses before a synchronous write operation fails.</returns>
	public override int WriteTimeout
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets the length of the underlying stream.</summary>
	/// <returns>The length of the underlying stream.</returns>
	/// <exception cref="T:System.NotSupportedException">Getting the value of this property is not supported when the underlying stream is a <see cref="T:System.Net.Sockets.NetworkStream" />.</exception>
	public override long Length => 0L;

	/// <summary>Gets or sets the current position in the underlying stream.</summary>
	/// <returns>The current position in the underlying stream.</returns>
	/// <exception cref="T:System.NotSupportedException">Setting this property is not supported.  
	///  -or-  
	///  Getting the value of this property is not supported when the underlying stream is a <see cref="T:System.Net.Sockets.NetworkStream" />.</exception>
	public override long Position
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	private static MobileTlsProvider GetProvider()
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Security.SslStream" /> class using the specified <see cref="T:System.IO.Stream" />, stream closure behavior and certificate validation delegate.</summary>
	/// <param name="innerStream">A <see cref="T:System.IO.Stream" /> object used by the <see cref="T:System.Net.Security.SslStream" /> for sending and receiving data.</param>
	/// <param name="leaveInnerStreamOpen">A Boolean value that indicates the closure behavior of the <see cref="T:System.IO.Stream" /> object used by the <see cref="T:System.Net.Security.SslStream" /> for sending and receiving data. This parameter indicates if the inner stream is left open.</param>
	/// <param name="userCertificateValidationCallback">A <see cref="T:System.Net.Security.RemoteCertificateValidationCallback" /> delegate responsible for validating the certificate supplied by the remote party.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="innerStream" /> is not readable.  
	/// -or-  
	/// <paramref name="innerStream" /> is not writable.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="innerStream" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="innerStream" /> is equal to <see cref="F:System.IO.Stream.Null" />.</exception>
	public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback)
		: base(null, leaveInnerStreamOpen: false)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Security.SslStream" /> class using the specified <see cref="T:System.IO.Stream" />, stream closure behavior, certificate validation delegate and certificate selection delegate.</summary>
	/// <param name="innerStream">A <see cref="T:System.IO.Stream" /> object used by the <see cref="T:System.Net.Security.SslStream" /> for sending and receiving data.</param>
	/// <param name="leaveInnerStreamOpen">A Boolean value that indicates the closure behavior of the <see cref="T:System.IO.Stream" /> object used by the <see cref="T:System.Net.Security.SslStream" /> for sending and receiving data. This parameter indicates if the inner stream is left open.</param>
	/// <param name="userCertificateValidationCallback">A <see cref="T:System.Net.Security.RemoteCertificateValidationCallback" /> delegate responsible for validating the certificate supplied by the remote party.</param>
	/// <param name="userCertificateSelectionCallback">A <see cref="T:System.Net.Security.LocalCertificateSelectionCallback" /> delegate responsible for selecting the certificate used for authentication.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="innerStream" /> is not readable.  
	/// -or-  
	/// <paramref name="innerStream" /> is not writable.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="innerStream" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="innerStream" /> is equal to <see cref="F:System.IO.Stream.Null" />.</exception>
	public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback)
		: base(null, leaveInnerStreamOpen: false)
	{
	}

	internal SslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings)
		: base(null, leaveInnerStreamOpen: false)
	{
	}

	private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback)
	{
	}

	private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback)
	{
	}

	/// <summary>Called by clients to authenticate the server and optionally the client in a client-server connection. The authentication process uses the specified certificate collection and SSL protocol.</summary>
	/// <param name="targetHost">The name of the server that will share this <see cref="T:System.Net.Security.SslStream" />.</param>
	/// <param name="clientCertificates">The <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> that contains client certificates.</param>
	/// <param name="enabledSslProtocols">The <see cref="T:System.Security.Authentication.SslProtocols" /> value that represents the protocol used for authentication.</param>
	/// <param name="checkCertificateRevocation">A <see cref="T:System.Boolean" /> value that specifies whether the certificate revocation list is checked during authentication.</param>
	public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
	{
	}

	/// <summary>Called by clients to begin an asynchronous operation to authenticate the server and optionally the client using the specified certificates and security protocol.</summary>
	/// <param name="targetHost">The name of the server that shares this <see cref="T:System.Net.Security.SslStream" />.</param>
	/// <param name="clientCertificates">The <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> containing client certificates.</param>
	/// <param name="enabledSslProtocols">The <see cref="T:System.Security.Authentication.SslProtocols" /> value that represents the protocol used for authentication.</param>
	/// <param name="checkCertificateRevocation">A <see cref="T:System.Boolean" /> value that specifies whether the certificate revocation list is checked during authentication.</param>
	/// <param name="asyncCallback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the authentication is complete.</param>
	/// <param name="asyncState">A user-defined object that contains information about the operation. This object is passed to the <paramref name="asyncCallback" /> delegate when the operation completes.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> object that indicates the status of the asynchronous operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="targetHost" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="enabledSslProtocols" /> is not a valid <see cref="T:System.Security.Authentication.SslProtocols" /> value.</exception>
	/// <exception cref="T:System.Security.Authentication.AuthenticationException">The authentication failed and left this object in an unusable state.</exception>
	/// <exception cref="T:System.InvalidOperationException">Authentication has already occurred.  
	///  -or-  
	///  Server authentication using this <see cref="T:System.Net.Security.SslStream" /> was tried previously.  
	///  -or-  
	///  Authentication is already in progress.</exception>
	/// <exception cref="T:System.ObjectDisposedException">This object has been closed.</exception>
	public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState)
	{
		return null;
	}

	/// <summary>Ends a pending asynchronous server authentication operation started with a previous call to <see cref="Overload:System.Net.Security.SslStream.BeginAuthenticateAsClient" />.</summary>
	/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> instance returned by a call to <see cref="Overload:System.Net.Security.SslStream.BeginAuthenticateAsClient" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asyncResult" /> was not created by a call to <see cref="Overload:System.Net.Security.SslStream.BeginAuthenticateAsClient" />.</exception>
	/// <exception cref="T:System.Security.Authentication.AuthenticationException">The authentication failed and left this object in an unusable state.</exception>
	/// <exception cref="T:System.InvalidOperationException">There is no pending server authentication to complete.</exception>
	public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult)
	{
	}

	/// <summary>Called by clients to authenticate the server and optionally the client in a client-server connection as an asynchronous operation. The authentication process uses the specified certificate collection and SSL protocol.</summary>
	/// <param name="targetHost">The name of the server that will share this <see cref="T:System.Net.Security.SslStream" />.</param>
	/// <param name="clientCertificates">The <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> that contains client certificates.</param>
	/// <param name="enabledSslProtocols">The <see cref="T:System.Security.Authentication.SslProtocols" /> value that represents the protocol used for authentication.</param>
	/// <param name="checkCertificateRevocation">A <see cref="T:System.Boolean" /> value that specifies whether the certificate revocation list is checked during authentication.</param>
	/// <returns>The task object representing the asynchronous operation.</returns>
	public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
	{
		return null;
	}

	/// <summary>Sets the length of the underlying stream.</summary>
	/// <param name="value">An <see cref="T:System.Int64" /> value that specifies the length of the stream.</param>
	public override void SetLength(long value)
	{
	}

	/// <summary>Throws a <see cref="T:System.NotSupportedException" />.</summary>
	/// <param name="offset">This value is ignored.</param>
	/// <param name="origin">This value is ignored.</param>
	/// <returns>Always throws a <see cref="T:System.NotSupportedException" />.</returns>
	/// <exception cref="T:System.NotSupportedException">Seeking is not supported by <see cref="T:System.Net.Security.SslStream" /> objects.</exception>
	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	/// <summary>Causes any buffered data to be written to the underlying device.</summary>
	public override void Flush()
	{
	}

	private void CheckDisposed()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Security.SslStream" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Reads data from this stream and stores it in the specified array.</summary>
	/// <param name="buffer">A <see cref="T:System.Byte" /> array that receives the bytes read from this stream.</param>
	/// <param name="offset">A <see cref="T:System.Int32" /> that contains the zero-based location in <paramref name="buffer" /> at which to begin storing the data read from this stream.</param>
	/// <param name="count">A <see cref="T:System.Int32" /> that contains the maximum number of bytes to read from this stream.</param>
	/// <returns>A <see cref="T:System.Int32" /> value that specifies the number of bytes read. When there is no more data to be read, returns 0.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="offset" />
	///   <paramref name="&lt;" />
	///   <paramref name="0" />.  
	/// <paramref name="-or-" /><paramref name="offset" /> &gt; the length of <paramref name="buffer" />.  
	/// -or-  
	/// <paramref name="offset" /> + count &gt; the length of <paramref name="buffer" />.</exception>
	/// <exception cref="T:System.IO.IOException">The read operation failed. Check the inner exception, if present to determine the cause of the failure.</exception>
	/// <exception cref="T:System.NotSupportedException">There is already a read operation in progress.</exception>
	/// <exception cref="T:System.ObjectDisposedException">This object has been closed.</exception>
	/// <exception cref="T:System.InvalidOperationException">Authentication has not occurred.</exception>
	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	/// <summary>Write the specified number of <see cref="T:System.Byte" />s to the underlying stream using the specified buffer and offset.</summary>
	/// <param name="buffer">A <see cref="T:System.Byte" /> array that supplies the bytes written to the stream.</param>
	/// <param name="offset">A <see cref="T:System.Int32" /> that contains the zero-based location in <paramref name="buffer" /> at which to begin reading bytes to be written to the stream.</param>
	/// <param name="count">A <see cref="T:System.Int32" /> that contains the number of bytes to read from <paramref name="buffer" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="offset" />
	///   <paramref name="&lt;" />
	///   <paramref name="0" />.  
	/// <paramref name="-or-" /><paramref name="offset" /> &gt; the length of <paramref name="buffer" />.  
	/// -or-  
	/// <paramref name="offset" /> + count &gt; the length of <paramref name="buffer" />.</exception>
	/// <exception cref="T:System.IO.IOException">The write operation failed.</exception>
	/// <exception cref="T:System.NotSupportedException">There is already a write operation in progress.</exception>
	/// <exception cref="T:System.ObjectDisposedException">This object has been closed.</exception>
	/// <exception cref="T:System.InvalidOperationException">Authentication has not occurred.</exception>
	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	/// <summary>Begins an asynchronous read operation that reads data from the stream and stores it in the specified array.</summary>
	/// <param name="buffer">A <see cref="T:System.Byte" /> array that receives the bytes read from the stream.</param>
	/// <param name="offset">The zero-based location in <paramref name="buffer" /> at which to begin storing the data read from this stream.</param>
	/// <param name="count">The maximum number of bytes to read from the stream.</param>
	/// <param name="asyncCallback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the read operation is complete.</param>
	/// <param name="asyncState">A user-defined object that contains information about the read operation. This object is passed to the <paramref name="asyncCallback" /> delegate when the operation completes.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> object that indicates the status of the asynchronous operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="offset" />
	///   <paramref name="&lt;" />
	///   <paramref name="0" />.  
	/// <paramref name="-or-" /><paramref name="offset" /> &gt; the length of <paramref name="buffer" />.  
	/// -or-  
	/// <paramref name="offset" /> + count &gt; the length of <paramref name="buffer" />.</exception>
	/// <exception cref="T:System.IO.IOException">The read operation failed.  
	///  -or-  
	///  Encryption is in use, but the data could not be decrypted.</exception>
	/// <exception cref="T:System.NotSupportedException">There is already a read operation in progress.</exception>
	/// <exception cref="T:System.ObjectDisposedException">This object has been closed.</exception>
	/// <exception cref="T:System.InvalidOperationException">Authentication has not occurred.</exception>
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return null;
	}

	/// <summary>Ends an asynchronous read operation started with a previous call to <see cref="M:System.Net.Security.SslStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</summary>
	/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> instance returned by a call to <see cref="M:System.Net.Security.SslStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /></param>
	/// <returns>A <see cref="T:System.Int32" /> value that specifies the number of bytes read from the underlying stream.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asyncResult" /> was not created by a call to <see cref="M:System.Net.Security.SslStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">There is no pending read operation to complete.
	/// -or-
	/// Authentication has not occurred.</exception>
	/// <exception cref="T:System.IO.IOException">The read operation failed.</exception>
	public override int EndRead(IAsyncResult asyncResult)
	{
		return 0;
	}

	/// <summary>Begins an asynchronous write operation that writes <see cref="T:System.Byte" />s from the specified buffer to the stream.</summary>
	/// <param name="buffer">A <see cref="T:System.Byte" /> array that supplies the bytes to be written to the stream.</param>
	/// <param name="offset">The zero-based location in <paramref name="buffer" /> at which to begin reading bytes to be written to the stream.</param>
	/// <param name="count">An <see cref="T:System.Int32" /> value that specifies the number of bytes to read from <paramref name="buffer" />.</param>
	/// <param name="asyncCallback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the write operation is complete.</param>
	/// <param name="asyncState">A user-defined object that contains information about the write operation. This object is passed to the <paramref name="asyncCallback" /> delegate when the operation completes.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> object indicating the status of the asynchronous operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="offset" />
	///   <paramref name="&lt;" />
	///   <paramref name="0" />.  
	/// <paramref name="-or-" /><paramref name="offset" /> &gt; the length of <paramref name="buffer" />.  
	/// -or-  
	/// <paramref name="offset" /> + count &gt; the length of <paramref name="buffer" />.</exception>
	/// <exception cref="T:System.IO.IOException">The write operation failed.</exception>
	/// <exception cref="T:System.NotSupportedException">There is already a write operation in progress.</exception>
	/// <exception cref="T:System.ObjectDisposedException">This object has been closed.</exception>
	/// <exception cref="T:System.InvalidOperationException">Authentication has not occurred.</exception>
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return null;
	}

	/// <summary>Ends an asynchronous write operation started with a previous call to <see cref="M:System.Net.Security.SslStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</summary>
	/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> instance returned by a call to <see cref="M:System.Net.Security.SslStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /></param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asyncResult" /> was not created by a call to <see cref="M:System.Net.Security.SslStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">There is no pending write operation to complete.
	/// -or-
	/// Authentication has not occurred.</exception>
	/// <exception cref="T:System.IO.IOException">The write operation failed.</exception>
	public override void EndWrite(IAsyncResult asyncResult)
	{
	}
}
