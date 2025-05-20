using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnityEngine.InputSystem.Utilities;

[StructLayout((LayoutKind)0, Size = 1)]
public struct Vector2MagnitudeComparer : IComparer<Vector2>
{
	public int Compare(Vector2 x, Vector2 y)
	{
		return 0;
	}
}
