using System.Globalization;
using System.Runtime.Serialization;

namespace System.Collections;

/// <summary>Compares two objects for equivalence, where string comparisons are case-sensitive.</summary>
[Serializable]
public sealed class Comparer : IComparer, ISerializable
{
	private CompareInfo _compareInfo;

	/// <summary>Represents an instance of <see cref="T:System.Collections.Comparer" /> that is associated with the <see cref="P:System.Threading.Thread.CurrentCulture" /> of the current thread. This field is read-only.</summary>
	public static readonly Comparer Default;

	/// <summary>Represents an instance of <see cref="T:System.Collections.Comparer" /> that is associated with <see cref="P:System.Globalization.CultureInfo.InvariantCulture" />. This field is read-only.</summary>
	public static readonly Comparer DefaultInvariant;

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Comparer" /> class using the specified <see cref="T:System.Globalization.CultureInfo" />.</summary>
	/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for the new <see cref="T:System.Collections.Comparer" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="culture" /> is <see langword="null" />.</exception>
	public Comparer(CultureInfo culture)
	{
	}

	private Comparer(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data required for serialization.</summary>
	/// <param name="info">The object to populate with data.</param>
	/// <param name="context">The context information about the source or destination of the serialization.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Performs a case-sensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.</summary>
	/// <param name="a">The first object to compare.</param>
	/// <param name="b">The second object to compare.</param>
	/// <returns>A signed integer that indicates the relative values of <paramref name="a" /> and <paramref name="b" />, as shown in the following table.  
	///   Value  
	///
	///   Meaning  
	///
	///   Less than zero  
	///
	///  <paramref name="a" /> is less than <paramref name="b" />.  
	///
	///   Zero  
	///
	///  <paramref name="a" /> equals <paramref name="b" />.  
	///
	///   Greater than zero  
	///
	///  <paramref name="a" /> is greater than <paramref name="b" />.</returns>
	/// <exception cref="T:System.ArgumentException">Neither <paramref name="a" /> nor <paramref name="b" /> implements the <see cref="T:System.IComparable" /> interface.  
	///  -or-  
	///  <paramref name="a" /> and <paramref name="b" /> are of different types and neither one can handle comparisons with the other.</exception>
	public int Compare(object a, object b)
	{
		return 0;
	}
}
