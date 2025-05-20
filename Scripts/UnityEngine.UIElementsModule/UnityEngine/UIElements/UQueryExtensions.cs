namespace UnityEngine.UIElements;

public static class UQueryExtensions
{
	private static UQueryState<VisualElement> SingleElementEmptyQuery;

	private static UQueryState<VisualElement> SingleElementNameQuery;

	private static UQueryState<VisualElement> SingleElementClassQuery;

	private static UQueryState<VisualElement> SingleElementNameAndClassQuery;

	private static UQueryState<VisualElement> SingleElementTypeQuery;

	private static UQueryState<VisualElement> SingleElementTypeAndNameQuery;

	private static UQueryState<VisualElement> SingleElementTypeAndClassQuery;

	private static UQueryState<VisualElement> SingleElementTypeAndNameAndClassQuery;

	public static T Q<T>(this VisualElement e, string name = null, string className = null) where T : VisualElement
	{
		return null;
	}

	public static VisualElement Q(this VisualElement e, string name = null, string className = null)
	{
		return null;
	}
}
