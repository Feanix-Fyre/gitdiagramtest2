using System.ComponentModel;

namespace UnityEngine.InputSystem.Processors;

[DesignTimeVisible(false)]
internal class CompensateDirectionProcessor : InputProcessor<Vector3>
{
	public override CachingPolicy cachingPolicy => default(CachingPolicy);

	public override Vector3 Process(Vector3 value, InputControl control)
	{
		return default(Vector3);
	}

	public override string ToString()
	{
		return null;
	}
}
