namespace UnityEngine.Rendering;

internal class AtlasAllocator
{
	private class AtlasNode
	{
		public AtlasNode m_RightChild;

		public AtlasNode m_BottomChild;

		public Vector4 m_Rect;

		public AtlasNode Allocate(ref ObjectPool<AtlasNode> pool, int width, int height, bool powerOfTwoPadding)
		{
			return null;
		}

		public void Release(ref ObjectPool<AtlasNode> pool)
		{
		}
	}

	private AtlasNode m_Root;

	private int m_Width;

	private int m_Height;

	private bool powerOfTwoPadding;

	private ObjectPool<AtlasNode> m_NodePool;

	public AtlasAllocator(int width, int height, bool potPadding)
	{
	}

	public bool Allocate(ref Vector4 result, int width, int height)
	{
		return false;
	}

	public void Reset()
	{
	}
}
