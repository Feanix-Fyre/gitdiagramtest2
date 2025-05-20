using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Represents the base class from which all implementations of asymmetric signature formatters derive.</summary>
[ComVisible(true)]
public abstract class AsymmetricSignatureFormatter
{
	/// <summary>Initializes a new instance of <see cref="T:System.Security.Cryptography.AsymmetricSignatureFormatter" />.</summary>
	protected AsymmetricSignatureFormatter()
	{
	}
}
