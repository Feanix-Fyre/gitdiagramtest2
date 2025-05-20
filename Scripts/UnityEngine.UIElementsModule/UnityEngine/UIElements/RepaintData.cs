namespace UnityEngine.UIElements;

internal class RepaintData
{
	public Matrix4x4 currentOffset { get; }

	public Rect currentWorldClip { get; }

	public Event repaintEvent { get; set; }
}
