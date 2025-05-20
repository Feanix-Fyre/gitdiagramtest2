namespace UnityEngine.InputSystem.XR;

public struct Eyes
{
	public Vector3 m_LeftEyePosition;

	public Quaternion m_LeftEyeRotation;

	public Vector3 m_RightEyePosition;

	public Quaternion m_RightEyeRotation;

	public Vector3 m_FixationPoint;

	public float m_LeftEyeOpenAmount;

	public float m_RightEyeOpenAmount;

	public Vector3 leftEyePosition
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Quaternion leftEyeRotation
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public Vector3 rightEyePosition
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Quaternion rightEyeRotation
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public Vector3 fixationPoint
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public float leftEyeOpenAmount
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float rightEyeOpenAmount
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}
}
