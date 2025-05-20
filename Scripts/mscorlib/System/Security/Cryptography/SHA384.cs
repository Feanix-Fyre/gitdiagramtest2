using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Computes the <see cref="T:System.Security.Cryptography.SHA384" /> hash for the input data.</summary>
[ComVisible(true)]
public abstract class SHA384 : HashAlgorithm
{
	/// <summary>Initializes a new instance of <see cref="T:System.Security.Cryptography.SHA384" />.</summary>
	protected SHA384()
	{
	}

	/// <summary>Creates an instance of the default implementation of <see cref="T:System.Security.Cryptography.SHA384" />.</summary>
	/// <returns>A new instance of <see cref="T:System.Security.Cryptography.SHA384" />.</returns>
	/// <exception cref="T:System.Reflection.TargetInvocationException">The algorithm was used with Federal Information Processing Standards (FIPS) mode enabled, but is not FIPS compatible.</exception>
	public static SHA384 Create()
	{
		return null;
	}
}
