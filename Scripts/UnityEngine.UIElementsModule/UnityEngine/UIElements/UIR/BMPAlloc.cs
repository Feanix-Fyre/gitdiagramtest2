namespace UnityEngine.UIElements.UIR;

internal struct BMPAlloc
{
	public static readonly BMPAlloc Invalid;

	public int page;

	public ushort pageLine;

	public byte bitIndex;

	public OwnedState ownedState;

	public bool Equals(BMPAlloc other)
	{
		return false;
	}

	public bool IsValid()
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
