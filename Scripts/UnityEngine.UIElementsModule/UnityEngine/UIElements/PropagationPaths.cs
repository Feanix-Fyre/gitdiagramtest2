using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal class PropagationPaths
{
	private static readonly ObjectPool<PropagationPaths> s_Pool;

	public readonly List<VisualElement> trickleDownPath;

	public readonly List<VisualElement> targetElements;

	public readonly List<VisualElement> bubbleUpPath;

	private const int k_DefaultPropagationDepth = 16;

	private const int k_DefaultTargetCount = 4;

	public static PropagationPaths Build(VisualElement elem, EventBase evt)
	{
		return null;
	}

	public void Release()
	{
	}
}
