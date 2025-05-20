using System;

namespace UnityEngine;

[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
public sealed class ColorUsageAttribute : PropertyAttribute
{
	public readonly bool showAlpha;

	public readonly bool hdr;

	[Obsolete("This field is no longer used for anything.")]
	public readonly float minBrightness;

	[Obsolete("This field is no longer used for anything.")]
	public readonly float maxBrightness;

	[Obsolete("This field is no longer used for anything.")]
	public readonly float minExposureValue;

	[Obsolete("This field is no longer used for anything.")]
	public readonly float maxExposureValue;

	public ColorUsageAttribute(bool showAlpha)
	{
	}

	public ColorUsageAttribute(bool showAlpha, bool hdr)
	{
	}
}
