using System;

namespace Unity.Jobs.LowLevel.Unsafe;

[AttributeUsage(AttributeTargets.Interface)]
public sealed class JobProducerTypeAttribute : Attribute
{
	public JobProducerTypeAttribute(Type producerType)
	{
	}
}
