using System;

namespace UnityEngine.Timeline;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class TrackClipTypeAttribute : Attribute
{
	public readonly Type inspectedType;

	public readonly bool allowAutoCreate;

	public TrackClipTypeAttribute(Type clipClass)
	{
	}

	public TrackClipTypeAttribute(Type clipClass, bool allowAutoCreate)
	{
	}
}
