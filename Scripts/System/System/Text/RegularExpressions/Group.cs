namespace System.Text.RegularExpressions;

/// <summary>Represents the results from a single capturing group.</summary>
[Serializable]
public class Group : Capture
{
	internal static readonly Group s_emptyGroup;

	internal readonly int[] _caps;

	internal int _capcount;

	internal CaptureCollection _capcoll;

	/// <summary>Gets a value indicating whether the match is successful.</summary>
	/// <returns>
	///   <see langword="true" /> if the match is successful; otherwise, <see langword="false" />.</returns>
	public bool Success => false;

	internal Group(string text, int[] caps, int capcount, string name)
		: base(null, 0, 0)
	{
	}

	internal Group()
		: base(null, 0, 0)
	{
	}
}
