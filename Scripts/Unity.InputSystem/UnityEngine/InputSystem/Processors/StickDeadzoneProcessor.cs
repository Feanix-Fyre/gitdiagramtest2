namespace UnityEngine.InputSystem.Processors;

public class StickDeadzoneProcessor : InputProcessor<Vector2>
{
	public float min;

	public float max;

	private float minOrDefault => 0f;

	private float maxOrDefault => 0f;

	public override Vector2 Process(Vector2 value, InputControl control = null)
	{
		return default(Vector2);
	}

	private float GetDeadZoneAdjustedValue(float value)
	{
		return 0f;
	}

	public override string ToString()
	{
		return null;
	}
}
