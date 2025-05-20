namespace UnityEngine.InputSystem.Processors;

public class InvertProcessor : InputProcessor<float>
{
	public override float Process(float value, InputControl control)
	{
		return 0f;
	}

	public override string ToString()
	{
		return null;
	}
}
