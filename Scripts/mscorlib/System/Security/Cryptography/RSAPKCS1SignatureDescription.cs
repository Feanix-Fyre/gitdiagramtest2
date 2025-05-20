namespace System.Security.Cryptography;

internal abstract class RSAPKCS1SignatureDescription : SignatureDescription
{
	private string _hashAlgorithm;

	protected RSAPKCS1SignatureDescription(string hashAlgorithm, string digestAlgorithm)
	{
	}
}
