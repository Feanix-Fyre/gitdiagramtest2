using System.Collections.Generic;
using System.Text;
using Internal.Cryptography.Pal;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.X509Certificates;

internal abstract class X509Certificate2ImplUnix : X509Certificate2Impl
{
	private bool readCertData;

	private CertificateData certData;

	public sealed override string KeyAlgorithm => null;

	public sealed override byte[] KeyAlgorithmParameters => null;

	public sealed override byte[] PublicKeyValue => null;

	public sealed override byte[] SerialNumber => null;

	public sealed override string SignatureAlgorithm => null;

	public sealed override int Version => 0;

	public sealed override X500DistinguishedName SubjectName => null;

	public sealed override X500DistinguishedName IssuerName => null;

	public sealed override string Subject => null;

	public sealed override string Issuer => null;

	public sealed override byte[] RawData => null;

	public sealed override byte[] Thumbprint => null;

	public sealed override IEnumerable<X509Extension> Extensions => null;

	public sealed override DateTime NotAfter => default(DateTime);

	public sealed override DateTime NotBefore => default(DateTime);

	private void EnsureCertData()
	{
	}

	protected abstract byte[] GetRawCertData();

	public sealed override string GetNameInfo(X509NameType nameType, bool forIssuer)
	{
		return null;
	}

	public sealed override void AppendPrivateKeyInfo(StringBuilder sb)
	{
	}

	public sealed override byte[] Export(X509ContentType contentType, SafePasswordHandle password)
	{
		return null;
	}

	private byte[] ExportPkcs12(SafePasswordHandle password)
	{
		return null;
	}

	private byte[] ExportPkcs12(string password)
	{
		return null;
	}
}
