namespace UnityEngine.Experimental.GlobalIllumination;

public struct LinearColor
{
	private float m_red;

	private float m_green;

	private float m_blue;

	private float m_intensity;

	public float red
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float green
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float blue
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static LinearColor Convert(Color color, float intensity)
	{
		return default(LinearColor);
	}

	public static LinearColor Black()
	{
		return default(LinearColor);
	}
}
