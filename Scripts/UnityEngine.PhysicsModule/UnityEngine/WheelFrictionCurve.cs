namespace UnityEngine;

public struct WheelFrictionCurve
{
	private float m_ExtremumSlip;

	private float m_ExtremumValue;

	private float m_AsymptoteSlip;

	private float m_AsymptoteValue;

	private float m_Stiffness;

	public float stiffness
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
