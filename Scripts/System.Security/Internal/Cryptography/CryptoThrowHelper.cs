using System.Security.Cryptography;

namespace Internal.Cryptography;

internal static class CryptoThrowHelper
{
	private sealed class WindowsCryptographicException : CryptographicException
	{
		public WindowsCryptographicException(int hr, string message)
		{
		}
	}

	public static CryptographicException ToCryptographicException(this int hr)
	{
		return null;
	}
}
