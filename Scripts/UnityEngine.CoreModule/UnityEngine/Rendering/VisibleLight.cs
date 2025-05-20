using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

[UsedByNativeCode]
public struct VisibleLight : IEquatable<VisibleLight>
{
	private LightType m_LightType;

	private Color m_FinalColor;

	private Rect m_ScreenRect;

	private Matrix4x4 m_LocalToWorldMatrix;

	private float m_Range;

	private float m_SpotAngle;

	private int m_InstanceId;

	private VisibleLightFlags m_Flags;

	public Light light => null;

	public LightType lightType => default(LightType);

	public Color finalColor => default(Color);

	public Matrix4x4 localToWorldMatrix => default(Matrix4x4);

	public float range => 0f;

	public float spotAngle => 0f;

	public bool Equals(VisibleLight other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
