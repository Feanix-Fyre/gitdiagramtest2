using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

internal struct TextureId
{
	private readonly int m_Index;

	public static readonly TextureId invalid;

	public int index => 0;

	public TextureId(int index)
	{
		m_Index = 0;
	}

	public float ConvertToGpu()
	{
		return 0f;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(TextureId left, TextureId right)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(TextureId left, TextureId right)
	{
		return false;
	}
}
