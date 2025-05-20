using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Input/InputBindings.h")]
public struct Touch
{
	private int m_FingerId;

	private Vector2 m_Position;

	private Vector2 m_RawPosition;

	private Vector2 m_PositionDelta;

	private float m_TimeDelta;

	private int m_TapCount;

	private TouchPhase m_Phase;

	private TouchType m_Type;

	private float m_Pressure;

	private float m_maximumPossiblePressure;

	private float m_Radius;

	private float m_RadiusVariance;

	private float m_AltitudeAngle;

	private float m_AzimuthAngle;

	public int fingerId => 0;

	public Vector2 position
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector2 rawPosition
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector2 deltaPosition
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public float deltaTime => 0f;

	public int tapCount => 0;

	public TouchPhase phase => default(TouchPhase);

	public float pressure => 0f;

	public float maximumPossiblePressure => 0f;

	public TouchType type => default(TouchType);

	public float altitudeAngle => 0f;

	public float azimuthAngle => 0f;

	public float radius => 0f;

	public float radiusVariance => 0f;
}
