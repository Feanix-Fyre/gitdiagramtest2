namespace UnityEngine.EventSystems;

public class PinchEventData
{
	public PointerEventData targetPointerData;

	public PointerEventData unchangedPointerData;

	public float distanceDelta;

	public Vector2 midPoint => default(Vector2);

	public PinchEventData(PointerEventData target, PointerEventData unchanged, float distanceDelta = 0f)
	{
	}
}
