using System;
using UnityEngine;

namespace TMPro;

[Serializable]
public struct MarkPositionAdjustment
{
	[SerializeField]
	private float m_XPositionAdjustment;

	[SerializeField]
	private float m_YPositionAdjustment;

	public float xPositionAdjustment
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float yPositionAdjustment
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public MarkPositionAdjustment(float x, float y)
	{
		m_XPositionAdjustment = 0f;
		m_YPositionAdjustment = 0f;
	}
}
