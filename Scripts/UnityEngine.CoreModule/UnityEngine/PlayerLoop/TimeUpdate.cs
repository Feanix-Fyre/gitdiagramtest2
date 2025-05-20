using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.PlayerLoop;

[StructLayout((LayoutKind)0, Size = 1)]
[RequiredByNativeCode]
public struct TimeUpdate
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[RequiredByNativeCode]
	public struct WaitForLastPresentationAndUpdateTime
	{
	}
}
