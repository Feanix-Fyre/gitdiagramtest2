namespace UnityEngine.TextCore.Text;

internal struct HighlightState
{
	public Color32 color;

	public Offset padding;

	public HighlightState(Color32 color, Offset padding)
	{
		this.color = default(Color32);
		this.padding = default(Offset);
	}

	public static bool operator ==(HighlightState lhs, HighlightState rhs)
	{
		return false;
	}

	public static bool operator !=(HighlightState lhs, HighlightState rhs)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}
}
