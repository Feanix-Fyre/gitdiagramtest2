using UnityEngine.Scripting;

namespace UnityEngine.Experimental.GlobalIllumination;

[UsedByNativeCode]
public struct LightDataGI
{
	public int instanceID;

	public int cookieID;

	public float cookieScale;

	public LinearColor color;

	public LinearColor indirectColor;

	public Quaternion orientation;

	public Vector3 position;

	public float range;

	public float coneAngle;

	public float innerConeAngle;

	public float shape0;

	public float shape1;

	public LightType type;

	public LightMode mode;

	public byte shadow;

	public FalloffType falloff;

	public void Init(ref DirectionalLight light, ref Cookie cookie)
	{
	}

	public void Init(ref PointLight light, ref Cookie cookie)
	{
	}

	public void Init(ref SpotLight light, ref Cookie cookie)
	{
	}

	public void Init(ref RectangleLight light, ref Cookie cookie)
	{
	}

	public void Init(ref DiscLight light, ref Cookie cookie)
	{
	}

	public void Init(ref DirectionalLight light)
	{
	}

	public void Init(ref PointLight light)
	{
	}

	public void Init(ref SpotLight light)
	{
	}

	public void InitNoBake(int lightInstanceID)
	{
	}
}
