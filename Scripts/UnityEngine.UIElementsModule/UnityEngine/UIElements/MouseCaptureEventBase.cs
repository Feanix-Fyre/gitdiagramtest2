namespace UnityEngine.UIElements;

public abstract class MouseCaptureEventBase<T> : PointerCaptureEventBase<T> where T : MouseCaptureEventBase<T>, new()
{
	protected override void Init()
	{
	}
}
