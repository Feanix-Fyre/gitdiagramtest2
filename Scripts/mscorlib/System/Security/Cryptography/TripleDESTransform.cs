using Mono.Security.Cryptography;

namespace System.Security.Cryptography;

internal class TripleDESTransform : SymmetricTransform
{
	private DESTransform E1;

	private DESTransform D2;

	private DESTransform E3;

	private DESTransform D1;

	private DESTransform E2;

	private DESTransform D3;

	public TripleDESTransform(TripleDES algo, bool encryption, byte[] key, byte[] iv)
		: base(null, encryption: false, null)
	{
	}

	protected override void ECB(byte[] input, byte[] output)
	{
	}

	internal static byte[] GetStrongKey()
	{
		return null;
	}
}
