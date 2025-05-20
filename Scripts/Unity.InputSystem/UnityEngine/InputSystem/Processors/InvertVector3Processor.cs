namespace UnityEngine.InputSystem.Processors;

public class InvertVector3Processor : InputProcessor<Vector3>
{
	public bool invertX;

	public bool invertY;

	public bool invertZ;

	public override Vector3 Process(Vector3 value, InputControl control)
	{
		return default(Vector3);
	}

	public override string ToString()
	{
		return null;
	}
}
