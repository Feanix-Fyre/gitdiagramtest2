using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace System.Net;

internal class ServerCertValidationCallback
{
	private class CallbackContext
	{
		internal readonly object request;

		internal readonly X509Certificate certificate;

		internal readonly X509Chain chain;

		internal readonly SslPolicyErrors sslPolicyErrors;

		internal bool result;

		internal CallbackContext(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
		}
	}

	private readonly RemoteCertificateValidationCallback m_ValidationCallback;

	private readonly ExecutionContext m_Context;

	internal RemoteCertificateValidationCallback ValidationCallback => null;

	internal ServerCertValidationCallback(RemoteCertificateValidationCallback validationCallback)
	{
	}

	internal void Callback(object state)
	{
	}

	internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return false;
	}
}
