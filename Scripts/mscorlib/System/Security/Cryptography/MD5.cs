using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Represents the abstract class from which all implementations of the <see cref="T:System.Security.Cryptography.MD5" /> hash algorithm inherit.</summary>
[ComVisible(true)]
public abstract class MD5 : HashAlgorithm
{
	/// <summary>Initializes a new instance of <see cref="T:System.Security.Cryptography.MD5" />.</summary>
	protected MD5()
	{
	}

	/// <summary>Creates an instance of the default implementation of the <see cref="T:System.Security.Cryptography.MD5" /> hash algorithm.</summary>
	/// <returns>A new instance of the <see cref="T:System.Security.Cryptography.MD5" /> hash algorithm.</returns>
	/// <exception cref="T:System.Reflection.TargetInvocationException">The algorithm was used with Federal Information Processing Standards (FIPS) mode enabled, but is not FIPS compatible.</exception>
	public static MD5 Create()
	{
		return null;
	}
}
