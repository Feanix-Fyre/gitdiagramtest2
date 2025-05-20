namespace UnityEngine.InputSystem.Processors;

public class ScaleVector3Processor : InputProcessor<Vector3>
{
	[Tooltip("Scale factor to multiply the incoming Vector3's X component by.")]
	public float x;

	[Tooltip("Scale factor to multiply the incoming Vector3's Y component by.")]
	public float y;

	[Tooltip("Scale factor to multiply the incoming Vector3's Z component by.")]
	public float z;

	public override Vector3 Process(Vector3 value, InputControl control)
	{
		return default(Vector3);
	}

	public override string ToString()
	{
		return null;
	}
}
