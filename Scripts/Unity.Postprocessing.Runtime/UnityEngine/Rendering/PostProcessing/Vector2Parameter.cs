using System;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class Vector2Parameter : ParameterOverride<Vector2>
{
	public override void Interp(Vector2 from, Vector2 to, float t)
	{
	}

	public static implicit operator Vector3(Vector2Parameter prop)
	{
		return default(Vector3);
	}

	public static implicit operator Vector4(Vector2Parameter prop)
	{
		return default(Vector4);
	}
}
