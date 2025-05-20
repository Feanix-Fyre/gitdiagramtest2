using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace System.Net;

internal class TlsStream : NetworkStream
{
	private SslStream _sslStream;

	private string _host;

	private X509CertificateCollection _clientCertificates;

	public TlsStream(NetworkStream stream, Socket socket, string host, X509CertificateCollection clientCertificates)
		: base(null)
	{
	}

	public void AuthenticateAsClient()
	{
	}

	public IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object state)
	{
		return null;
	}

	public void EndAuthenticateAsClient(IAsyncResult asyncResult)
	{
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		return null;
	}

	public override void EndWrite(IAsyncResult result)
	{
	}

	public override void Write(byte[] buffer, int offset, int size)
	{
	}

	public override int Read(byte[] buffer, int offset, int size)
	{
		return 0;
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return null;
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		return 0;
	}

	public override void Close()
	{
	}
}
