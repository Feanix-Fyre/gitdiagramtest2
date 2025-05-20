using System.Runtime.InteropServices;

namespace System.Globalization;

/// <summary>Represents the result of mapping a string to its sort key.</summary>
[Serializable]
[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public class SortKey
{
	private readonly string source;

	private readonly byte[] key;

	private readonly CompareOptions options;

	private readonly int lcid;

	/// <summary>Gets the original string used to create the current <see cref="T:System.Globalization.SortKey" /> object.</summary>
	/// <returns>The original string used to create the current <see cref="T:System.Globalization.SortKey" /> object.</returns>
	public virtual string OriginalString => null;

	/// <summary>Gets the byte array representing the current <see cref="T:System.Globalization.SortKey" /> object.</summary>
	/// <returns>A byte array representing the current <see cref="T:System.Globalization.SortKey" /> object.</returns>
	public virtual byte[] KeyData => null;

	/// <summary>Compares two sort keys.</summary>
	/// <param name="sortkey1">The first sort key to compare.</param>
	/// <param name="sortkey2">The second sort key to compare.</param>
	/// <returns>A signed integer that indicates the relationship between <paramref name="sortkey1" /> and <paramref name="sortkey2" />.  
	///   Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///  <paramref name="sortkey1" /> is less than <paramref name="sortkey2" />.  
	///
	///   Zero  
	///
	///  <paramref name="sortkey1" /> is equal to <paramref name="sortkey2" />.  
	///
	///   Greater than zero  
	///
	///  <paramref name="sortkey1" /> is greater than <paramref name="sortkey2" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="sortkey1" /> or <paramref name="sortkey2" /> is <see langword="null" />.</exception>
	public static int Compare(SortKey sortkey1, SortKey sortkey2)
	{
		return 0;
	}

	internal SortKey(int lcid, string source, CompareOptions opt)
	{
	}

	internal SortKey(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength)
	{
	}

	internal SortKey(string localeName, string str, CompareOptions options, byte[] keyData)
	{
	}

	/// <summary>Determines whether the specified object is equal to the current <see cref="T:System.Globalization.SortKey" /> object.</summary>
	/// <param name="value">The object to compare with the current <see cref="T:System.Globalization.SortKey" /> object.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="value" /> parameter is equal to the current <see cref="T:System.Globalization.SortKey" /> object; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Serves as a hash function for the current <see cref="T:System.Globalization.SortKey" /> object that is suitable for hashing algorithms and data structures such as a hash table.</summary>
	/// <returns>A hash code for the current <see cref="T:System.Globalization.SortKey" /> object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Returns a string that represents the current <see cref="T:System.Globalization.SortKey" /> object.</summary>
	/// <returns>A string that represents the current <see cref="T:System.Globalization.SortKey" /> object.</returns>
	public override string ToString()
	{
		return null;
	}

	internal SortKey()
	{
	}
}
