using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel;

[Serializable]
[UsedByNativeCode]
internal struct MarkPositionAdjustment
{
	[NativeName("xCoordinate")]
	[SerializeField]
	private float m_XPositionAdjustment;

	[NativeName("yCoordinate")]
	[SerializeField]
	private float m_YPositionAdjustment;

	public float xPositionAdjustment => 0f;

	public float yPositionAdjustment => 0f;
}
