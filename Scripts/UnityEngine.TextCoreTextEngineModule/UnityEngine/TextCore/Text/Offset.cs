namespace UnityEngine.TextCore.Text;

internal struct Offset
{
	private float m_Left;

	private float m_Right;

	private float m_Top;

	private float m_Bottom;

	private static readonly Offset k_ZeroOffset;

	public float left => 0f;

	public float right => 0f;

	public float top => 0f;

	public float bottom => 0f;

	public static Offset zero => default(Offset);

	public Offset(float left, float right, float top, float bottom)
	{
		m_Left = 0f;
		m_Right = 0f;
		m_Top = 0f;
		m_Bottom = 0f;
	}

	public static bool operator ==(Offset lhs, Offset rhs)
	{
		return false;
	}

	public static Offset operator *(Offset a, float b)
	{
		return default(Offset);
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
