namespace UnityEngine.InputSystem.Processors;

public class ClampProcessor : InputProcessor<float>
{
	public float min;

	public float max;

	public override float Process(float value, InputControl control)
	{
		return 0f;
	}

	public override string ToString()
	{
		return null;
	}
}
