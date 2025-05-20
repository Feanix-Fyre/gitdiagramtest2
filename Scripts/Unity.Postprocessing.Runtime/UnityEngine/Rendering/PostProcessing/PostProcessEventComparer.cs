using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnityEngine.Rendering.PostProcessing;

[StructLayout((LayoutKind)0, Size = 1)]
internal struct PostProcessEventComparer : IEqualityComparer<PostProcessEvent>
{
	public bool Equals(PostProcessEvent x, PostProcessEvent y)
	{
		return false;
	}

	public int GetHashCode(PostProcessEvent obj)
	{
		return 0;
	}
}
