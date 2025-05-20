namespace UnityEngine.TextCore.Text;

internal class TextInfo
{
	private static Vector2 s_InfinityVectorPositive;

	private static Vector2 s_InfinityVectorNegative;

	public int characterCount;

	public int spriteCount;

	public int spaceCount;

	public int wordCount;

	public int linkCount;

	public int lineCount;

	public int pageCount;

	public int materialCount;

	public TextElementInfo[] textElementInfo;

	public WordInfo[] wordInfo;

	public LinkInfo[] linkInfo;

	public LineInfo[] lineInfo;

	public PageInfo[] pageInfo;

	public MeshInfo[] meshInfo;

	public bool isDirty;

	public bool hasMultipleColors;

	internal void Clear()
	{
	}

	internal void ClearMeshInfo(bool updateMesh)
	{
	}

	internal void ClearLineInfo()
	{
	}

	internal void ClearPageInfo()
	{
	}

	internal static void Resize<T>(ref T[] array, int size)
	{
	}

	internal static void Resize<T>(ref T[] array, int size, bool isBlockAllocated)
	{
	}
}
