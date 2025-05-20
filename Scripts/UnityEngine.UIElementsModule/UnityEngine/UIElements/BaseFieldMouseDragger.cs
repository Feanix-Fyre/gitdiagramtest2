using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public abstract class BaseFieldMouseDragger
{
	public void SetDragZone(VisualElement dragElement)
	{
	}

	public abstract void SetDragZone(VisualElement dragElement, Rect hotZone);
}
