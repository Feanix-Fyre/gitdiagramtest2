using System.Collections;

namespace System.Security.Cryptography;

/// <summary>Provides the ability to navigate through an <see cref="T:System.Security.Cryptography.OidCollection" /> object. This class cannot be inherited.</summary>
public sealed class OidEnumerator : IEnumerator
{
	private readonly OidCollection _oids;

	private int _current;

	/// <summary>Gets the current <see cref="T:System.Security.Cryptography.Oid" /> object in an <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
	/// <returns>The current <see cref="T:System.Security.Cryptography.Oid" /> object in the collection.</returns>
	public Oid Current => null;

	/// <summary>Gets the current <see cref="T:System.Security.Cryptography.Oid" /> object in an <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
	/// <returns>The current <see cref="T:System.Security.Cryptography.Oid" /> object.</returns>
	object IEnumerator.Current => null;

	internal OidEnumerator(OidCollection oids)
	{
	}

	/// <summary>Advances to the next <see cref="T:System.Security.Cryptography.Oid" /> object in an <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
	/// <returns>
	///   <see langword="true" />, if the enumerator was successfully advanced to the next element; <see langword="false" />, if the enumerator has passed the end of the collection.</returns>
	/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created.</exception>
	public bool MoveNext()
	{
		return false;
	}

	/// <summary>Sets an enumerator to its initial position.</summary>
	/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created.</exception>
	public void Reset()
	{
	}
}
