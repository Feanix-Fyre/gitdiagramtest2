using System;

namespace UnityEngine;

[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
public sealed class GradientUsageAttribute : PropertyAttribute
{
	public readonly bool hdr;

	public readonly ColorSpace colorSpace;

	public GradientUsageAttribute(bool hdr)
	{
	}

	public GradientUsageAttribute(bool hdr, ColorSpace colorSpace)
	{
	}
}
