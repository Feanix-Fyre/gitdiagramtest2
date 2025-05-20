using System.Collections;

namespace System.Windows.Forms;

/// <summary>Stores <see cref="T:System.Windows.Forms.InputLanguage" /> objects.</summary>
public class InputLanguageCollection : ReadOnlyCollectionBase
{
	/// <summary>Gets the entry at the specified index of the <see cref="T:System.Windows.Forms.InputLanguageCollection" />.</summary>
	/// <param name="index">The zero-based index of the entry to locate in the collection.</param>
	/// <returns>The <see cref="T:System.Windows.Forms.InputLanguage" /> at the specified index of the collection.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is outside the valid range of indexes for the collection.</exception>
	public InputLanguage this[int index] => null;

	internal InputLanguageCollection(InputLanguage[] data)
	{
	}
}
