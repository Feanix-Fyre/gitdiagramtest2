namespace UnityEngine.UIElements.UIR;

internal class GradientRemap : LinkedPoolItem<GradientRemap>
{
	public int origIndex;

	public int destIndex;

	public RectInt location;

	public GradientRemap next;

	public TextureId atlas;

	public void Reset()
	{
	}
}
