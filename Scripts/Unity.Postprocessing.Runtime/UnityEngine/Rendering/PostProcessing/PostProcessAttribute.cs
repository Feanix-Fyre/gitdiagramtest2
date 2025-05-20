using System;

namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public sealed class PostProcessAttribute : Attribute
{
	public readonly Type renderer;

	public readonly PostProcessEvent eventType;

	public readonly string menuItem;

	public readonly bool allowInSceneView;

	internal readonly bool builtinEffect;

	public PostProcessAttribute(Type renderer, PostProcessEvent eventType, string menuItem, bool allowInSceneView = true)
	{
	}

	internal PostProcessAttribute(Type renderer, string menuItem, bool allowInSceneView = true)
	{
	}
}
