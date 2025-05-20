using System.Collections;

namespace System.Security.Cryptography.X509Certificates;

/// <summary>Supports a simple iteration over a <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object. This class cannot be inherited.</summary>
public sealed class X509Certificate2Enumerator : IEnumerator
{
	private IEnumerator enumerator;

	/// <summary>Gets the current element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</summary>
	/// <returns>The current element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</returns>
	/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element.</exception>
	public X509Certificate2 Current => null;

	/// <summary>For a description of this member, see <see cref="P:System.Collections.IEnumerator.Current" />.</summary>
	/// <returns>The current element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</returns>
	/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element.</exception>
	object IEnumerator.Current => null;

	internal X509Certificate2Enumerator(X509Certificate2Collection collection)
	{
	}

	/// <summary>Advances the enumerator to the next element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</summary>
	/// <returns>
	///   <see langword="true" /> if the enumerator was successfully advanced to the next element; <see langword="false" /> if the enumerator has passed the end of the collection.</returns>
	/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created.</exception>
	public bool MoveNext()
	{
		return false;
	}

	/// <summary>For a description of this member, see <see cref="M:System.Collections.IEnumerator.MoveNext" />.</summary>
	/// <returns>
	///   <see langword="true" /> if the enumerator was successfully advanced to the next element; <see langword="false" /> if the enumerator has passed the end of the collection.</returns>
	/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created.</exception>
	bool IEnumerator.MoveNext()
	{
		return false;
	}

	/// <summary>For a description of this member, see <see cref="M:System.Collections.IEnumerator.Reset" />.</summary>
	/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created.</exception>
	void IEnumerator.Reset()
	{
	}
}
