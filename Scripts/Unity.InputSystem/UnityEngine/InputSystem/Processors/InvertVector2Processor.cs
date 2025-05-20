namespace UnityEngine.InputSystem.Processors;

public class InvertVector2Processor : InputProcessor<Vector2>
{
	public bool invertX;

	public bool invertY;

	public override Vector2 Process(Vector2 value, InputControl control)
	{
		return default(Vector2);
	}

	public override string ToString()
	{
		return null;
	}
}
