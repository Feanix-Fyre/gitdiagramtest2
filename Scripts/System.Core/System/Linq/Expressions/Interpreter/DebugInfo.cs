using System.Collections.Generic;

namespace System.Linq.Expressions.Interpreter;

internal sealed class DebugInfo
{
	private class DebugInfoComparer : IComparer<DebugInfo>
	{
		int IComparer<DebugInfo>.Compare(DebugInfo d1, DebugInfo d2)
		{
			return 0;
		}
	}

	public int StartLine;

	public int EndLine;

	public int Index;

	public string FileName;

	public bool IsClear;

	private static readonly DebugInfoComparer s_debugComparer;

	public static DebugInfo GetMatchingDebugInfo(DebugInfo[] debugInfos, int index)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
