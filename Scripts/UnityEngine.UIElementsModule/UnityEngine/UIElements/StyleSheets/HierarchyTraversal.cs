namespace UnityEngine.UIElements.StyleSheets;

internal abstract class HierarchyTraversal
{
	public virtual void Traverse(VisualElement element)
	{
	}

	public abstract void TraverseRecursive(VisualElement element, int depth);

	protected void Recurse(VisualElement element, int depth)
	{
	}
}
