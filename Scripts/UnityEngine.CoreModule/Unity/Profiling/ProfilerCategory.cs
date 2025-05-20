using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace Unity.Profiling;

[StructLayout((LayoutKind)2, Size = 2)]
[UsedByNativeCode]
public readonly struct ProfilerCategory
{
	[FieldOffset(0)]
	private readonly ushort m_CategoryId;

	public string Name => null;

	public static ProfilerCategory Scripts => default(ProfilerCategory);

	internal ProfilerCategory(ushort category)
	{
		m_CategoryId = 0;
	}

	public override string ToString()
	{
		return null;
	}

	public static implicit operator ushort(ProfilerCategory category)
	{
		return 0;
	}
}
