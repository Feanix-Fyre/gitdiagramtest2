using System;

namespace Unity.Burst.Intrinsics;

[BurstRuntime.Preserve]
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
internal sealed class BurstTargetCpuAttribute : Attribute
{
	public readonly BurstTargetCpu TargetCpu;

	public BurstTargetCpuAttribute(BurstTargetCpu TargetCpu)
	{
	}
}
