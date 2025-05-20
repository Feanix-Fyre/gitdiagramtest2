using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnityEngine.InputSystem.Utilities;

[StructLayout((LayoutKind)0, Size = 1)]
public struct Vector3MagnitudeComparer : IComparer<Vector3>
{
	public int Compare(Vector3 x, Vector3 y)
	{
		return 0;
	}
}
