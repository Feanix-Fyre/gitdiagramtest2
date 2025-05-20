namespace System.Threading.Tasks;

internal class StackGuard
{
	private int m_inliningDepth;

	private const int MAX_UNCHECKED_INLINING_DEPTH = 20;

	internal bool TryBeginInliningScope()
	{
		return false;
	}

	internal void EndInliningScope()
	{
	}
}
