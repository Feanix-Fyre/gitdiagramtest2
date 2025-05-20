using System.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing;

internal class TargetPool
{
	private readonly List<int> m_Pool;

	private int m_Current;

	internal TargetPool()
	{
	}

	internal int Get()
	{
		return 0;
	}

	private int Get(int i)
	{
		return 0;
	}

	internal void Reset()
	{
	}
}
