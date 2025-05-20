using System;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class Vector3Parameter : ParameterOverride<Vector3>
{
	public override void Interp(Vector3 from, Vector3 to, float t)
	{
	}

	public static implicit operator Vector2(Vector3Parameter prop)
	{
		return default(Vector2);
	}

	public static implicit operator Vector4(Vector3Parameter prop)
	{
		return default(Vector4);
	}
}
