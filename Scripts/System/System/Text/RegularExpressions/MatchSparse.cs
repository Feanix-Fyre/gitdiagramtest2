using System.Collections;

namespace System.Text.RegularExpressions;

internal class MatchSparse : Match
{
	internal new readonly Hashtable _caps;

	public override GroupCollection Groups => null;

	internal MatchSparse(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos)
		: base(null, 0, null, 0, 0, 0)
	{
	}
}
