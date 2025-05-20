using System;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class SplineParameter : ParameterOverride<Spline>
{
	protected internal override void OnEnable()
	{
	}

	internal override void SetValue(ParameterOverride parameter)
	{
	}

	public override void Interp(Spline from, Spline to, float t)
	{
	}
}
