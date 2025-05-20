using System.Globalization;

namespace System.Collections;

/// <summary>Supplies a hash code for an object, using a hashing algorithm that ignores the case of strings.</summary>
[Serializable]
[Obsolete("Please use StringComparer instead.")]
public class CaseInsensitiveHashCodeProvider : IHashCodeProvider
{
	private readonly CompareInfo _compareInfo;

	/// <summary>Gets an instance of <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" /> that is associated with the <see cref="P:System.Threading.Thread.CurrentCulture" /> of the current thread and that is always available.</summary>
	/// <returns>An instance of <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" /> that is associated with the <see cref="P:System.Threading.Thread.CurrentCulture" /> of the current thread.</returns>
	public static CaseInsensitiveHashCodeProvider Default => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" /> class using the <see cref="P:System.Threading.Thread.CurrentCulture" /> of the current thread.</summary>
	public CaseInsensitiveHashCodeProvider()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" /> class using the specified <see cref="T:System.Globalization.CultureInfo" />.</summary>
	/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for the new <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="culture" /> is <see langword="null" />.</exception>
	public CaseInsensitiveHashCodeProvider(CultureInfo culture)
	{
	}

	/// <summary>Returns a hash code for the given object, using a hashing algorithm that ignores the case of strings.</summary>
	/// <param name="obj">The <see cref="T:System.Object" /> for which a hash code is to be returned.</param>
	/// <returns>A hash code for the given object, using a hashing algorithm that ignores the case of strings.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="obj" /> is <see langword="null" />.</exception>
	public int GetHashCode(object obj)
	{
		return 0;
	}
}
