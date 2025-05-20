using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Creates a Digital Signature Algorithm (<see cref="T:System.Security.Cryptography.DSA" />) signature.</summary>
[ComVisible(true)]
public class DSASignatureFormatter : AsymmetricSignatureFormatter
{
	private string _oid;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSASignatureFormatter" /> class.</summary>
	public DSASignatureFormatter()
	{
	}
}
