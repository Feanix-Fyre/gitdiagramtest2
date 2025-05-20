namespace UnityEngine.UIElements;

internal abstract class DragAndDropData
{
	public abstract object source { get; }

	public abstract object GetGenericData(string key);
}
