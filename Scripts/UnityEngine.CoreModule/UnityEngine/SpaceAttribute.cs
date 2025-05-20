using System;

namespace UnityEngine;

[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class SpaceAttribute : PropertyAttribute
{
	public readonly float height;

	public SpaceAttribute()
	{
	}

	public SpaceAttribute(float height)
	{
	}
}
