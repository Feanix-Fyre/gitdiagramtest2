using Unity.Collections;

namespace UnityEngine.Rendering.Universal.UTess;

internal struct TessLink
{
	internal NativeArray<int> roots;

	internal NativeArray<int> ranks;

	internal static TessLink CreateLink(int count, Allocator allocator)
	{
		return default(TessLink);
	}

	internal static void DestroyLink(TessLink link)
	{
	}

	internal int Find(int x)
	{
		return 0;
	}

	internal void Link(int x, int y)
	{
	}
}
