using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

public struct CreationContext : IEquatable<CreationContext>
{
	public static readonly CreationContext Default;

	public VisualElement target { get; private set; }

	public VisualTreeAsset visualTreeAsset { get; private set; }

	public Dictionary<string, VisualElement> slotInsertionPoints { get; private set; }

	internal List<TemplateAsset.AttributeOverride> attributeOverrides { get; private set; }

	internal CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, VisualTreeAsset vta, VisualElement target)
	{
		this.target = null;
		visualTreeAsset = null;
		this.slotInsertionPoints = null;
		attributeOverrides = null;
	}

	internal CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, List<TemplateAsset.AttributeOverride> attributeOverrides, VisualTreeAsset vta, VisualElement target)
	{
		this.target = null;
		visualTreeAsset = null;
		this.slotInsertionPoints = null;
		this.attributeOverrides = null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(CreationContext other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
