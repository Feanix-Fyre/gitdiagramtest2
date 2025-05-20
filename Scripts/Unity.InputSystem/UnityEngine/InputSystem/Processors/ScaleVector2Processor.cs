namespace UnityEngine.InputSystem.Processors;

public class ScaleVector2Processor : InputProcessor<Vector2>
{
	[Tooltip("Scale factor to multiply the incoming Vector2's X component by.")]
	public float x;

	[Tooltip("Scale factor to multiply the incoming Vector2's Y component by.")]
	public float y;

	public override Vector2 Process(Vector2 value, InputControl control)
	{
		return default(Vector2);
	}

	public override string ToString()
	{
		return null;
	}
}
