using System.ComponentModel;

namespace UnityEngine.InputSystem.Processors;

[DesignTimeVisible(false)]
internal class CompensateRotationProcessor : InputProcessor<Quaternion>
{
	public override CachingPolicy cachingPolicy => default(CachingPolicy);

	public override Quaternion Process(Quaternion value, InputControl control)
	{
		return default(Quaternion);
	}

	public override string ToString()
	{
		return null;
	}
}
