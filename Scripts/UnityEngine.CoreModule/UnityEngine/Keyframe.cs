using UnityEngine.Scripting;

namespace UnityEngine;

[RequiredByNativeCode]
public struct Keyframe
{
	private float m_Time;

	private float m_Value;

	private float m_InTangent;

	private float m_OutTangent;

	private int m_WeightedMode;

	private float m_InWeight;

	private float m_OutWeight;

	public float time
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float inTangent
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float outTangent
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float inWeight
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float outWeight
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public WeightedMode weightedMode
	{
		get
		{
			return default(WeightedMode);
		}
		set
		{
		}
	}

	public Keyframe(float time, float value)
	{
		m_Time = 0f;
		m_Value = 0f;
		m_InTangent = 0f;
		m_OutTangent = 0f;
		m_WeightedMode = 0;
		m_InWeight = 0f;
		m_OutWeight = 0f;
	}

	public Keyframe(float time, float value, float inTangent, float outTangent)
	{
		m_Time = 0f;
		m_Value = 0f;
		m_InTangent = 0f;
		m_OutTangent = 0f;
		m_WeightedMode = 0;
		m_InWeight = 0f;
		m_OutWeight = 0f;
	}

	public Keyframe(float time, float value, float inTangent, float outTangent, float inWeight, float outWeight)
	{
		m_Time = 0f;
		m_Value = 0f;
		m_InTangent = 0f;
		m_OutTangent = 0f;
		m_WeightedMode = 0;
		m_InWeight = 0f;
		m_OutWeight = 0f;
	}
}
