using System.Globalization;

namespace System.Collections;

/// <summary>Compares two objects for equivalence, ignoring the case of strings.</summary>
[Serializable]
public class CaseInsensitiveComparer : IComparer
{
	private CompareInfo _compareInfo;

	/// <summary>Gets an instance of <see cref="T:System.Collections.CaseInsensitiveComparer" /> that is associated with the <see cref="P:System.Threading.Thread.CurrentCulture" /> of the current thread and that is always available.</summary>
	/// <returns>An instance of <see cref="T:System.Collections.CaseInsensitiveComparer" /> that is associated with the <see cref="P:System.Threading.Thread.CurrentCulture" /> of the current thread.</returns>
	public static CaseInsensitiveComparer Default => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.CaseInsensitiveComparer" /> class using the <see cref="P:System.Threading.Thread.CurrentCulture" /> of the current thread.</summary>
	public CaseInsensitiveComparer()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.CaseInsensitiveComparer" /> class using the specified <see cref="T:System.Globalization.CultureInfo" />.</summary>
	/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for the new <see cref="T:System.Collections.CaseInsensitiveComparer" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="culture" /> is <see langword="null" />.</exception>
	public CaseInsensitiveComparer(CultureInfo culture)
	{
	}

	/// <summary>Performs a case-insensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.</summary>
	/// <param name="a">The first object to compare.</param>
	/// <param name="b">The second object to compare.</param>
	/// <returns>A signed integer that indicates the relative values of <paramref name="a" /> and <paramref name="b" />, as shown in the following table.  
	///   Value  
	///
	///   Meaning  
	///
	///   Less than zero  
	///
	///  <paramref name="a" /> is less than <paramref name="b" />, with casing ignored.  
	///
	///   Zero  
	///
	///  <paramref name="a" /> equals <paramref name="b" />, with casing ignored.  
	///
	///   Greater than zero  
	///
	///  <paramref name="a" /> is greater than <paramref name="b" />, with casing ignored.</returns>
	/// <exception cref="T:System.ArgumentException">Neither <paramref name="a" /> nor <paramref name="b" /> implements the <see cref="T:System.IComparable" /> interface.  
	///  -or-  
	///  <paramref name="a" /> and <paramref name="b" /> are of different types.</exception>
	public int Compare(object a, object b)
	{
		return 0;
	}
}
