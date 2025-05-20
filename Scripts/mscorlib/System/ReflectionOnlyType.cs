namespace System;

[Serializable]
internal class ReflectionOnlyType : RuntimeType
{
	public override RuntimeTypeHandle TypeHandle => default(RuntimeTypeHandle);

	private ReflectionOnlyType()
	{
	}
}
