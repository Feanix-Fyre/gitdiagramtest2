using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Computes the <see cref="T:System.Security.Cryptography.SHA256" /> hash for the input data.</summary>
[ComVisible(true)]
public abstract class SHA256 : HashAlgorithm
{
	/// <summary>Initializes a new instance of <see cref="T:System.Security.Cryptography.SHA256" />.</summary>
	protected SHA256()
	{
	}

	/// <summary>Creates an instance of the default implementation of <see cref="T:System.Security.Cryptography.SHA256" />.</summary>
	/// <returns>A new instance of <see cref="T:System.Security.Cryptography.SHA256" />. On the .NET Framework, this method creates an instance of the <see cref="T:System.Security.Cryptography.SHA256Managed" /> class if FIPS mode is not active; if FIPS mode is active, it creates an instance of the <see cref="T:System.Security.Cryptography.SHA256Cng" /> class. On .NET Core, it returns an instance of a private class derived from <see cref="T:System.Security.Cryptography.SHA256" />.</returns>
	/// <exception cref="T:System.Reflection.TargetInvocationException">On the .NET Framework 4.6.1 and earlier versions only: The algorithm was used with Federal Information Processing Standards (FIPS) mode enabled, but is not FIPS compatible.</exception>
	public static SHA256 Create()
	{
		return null;
	}
}
