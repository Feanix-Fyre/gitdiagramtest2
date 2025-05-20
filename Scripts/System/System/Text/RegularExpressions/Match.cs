namespace System.Text.RegularExpressions;

/// <summary>Represents the results from a single regular expression match.</summary>
[Serializable]
public class Match : Group
{
	internal GroupCollection _groupcoll;

	internal Regex _regex;

	internal int _textbeg;

	internal int _textpos;

	internal int _textend;

	internal int _textstart;

	internal int[][] _matches;

	internal int[] _matchcount;

	internal bool _balancing;

	/// <summary>Gets the empty group. All failed matches return this empty match.</summary>
	/// <returns>An empty match.</returns>
	public static Match Empty { get; }

	/// <summary>Gets a collection of groups matched by the regular expression.</summary>
	/// <returns>The character groups matched by the pattern.</returns>
	public virtual GroupCollection Groups => null;

	internal Match(Regex regex, int capcount, string text, int begpos, int len, int startpos)
		: base(null, null, 0, null)
	{
	}

	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart)
	{
	}

	/// <summary>Returns a new <see cref="T:System.Text.RegularExpressions.Match" /> object with the results for the next match, starting at the position at which the last match ended (at the character after the last matched character).</summary>
	/// <returns>The next regular expression match.</returns>
	/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred.</exception>
	public Match NextMatch()
	{
		return null;
	}

	internal virtual ReadOnlySpan<char> GroupToStringImpl(int groupnum)
	{
		return default(ReadOnlySpan<char>);
	}

	internal ReadOnlySpan<char> LastGroupToStringImpl()
	{
		return default(ReadOnlySpan<char>);
	}

	internal virtual void AddMatch(int cap, int start, int len)
	{
	}

	internal virtual void BalanceMatch(int cap)
	{
	}

	internal virtual void RemoveMatch(int cap)
	{
	}

	internal virtual bool IsMatched(int cap)
	{
		return false;
	}

	internal virtual int MatchIndex(int cap)
	{
		return 0;
	}

	internal virtual int MatchLength(int cap)
	{
		return 0;
	}

	internal virtual void Tidy(int textpos)
	{
	}

	internal Match()
		: base(null, null, 0, null)
	{
	}
}
