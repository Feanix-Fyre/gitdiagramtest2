namespace UnityEngine.InputSystem.Processors;

public class ScaleProcessor : InputProcessor<float>
{
	[Tooltip("Scale factor to multiply incoming float values by.")]
	public float factor;

	public override float Process(float value, InputControl control)
	{
		return 0f;
	}

	public override string ToString()
	{
		return null;
	}
}
