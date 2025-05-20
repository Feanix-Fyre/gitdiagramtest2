namespace UnityEngine.InputSystem.Processors;

public class AxisDeadzoneProcessor : InputProcessor<float>
{
	public float min;

	public float max;

	private float minOrDefault => 0f;

	private float maxOrDefault => 0f;

	public override float Process(float value, InputControl control = null)
	{
		return 0f;
	}

	public override string ToString()
	{
		return null;
	}
}
