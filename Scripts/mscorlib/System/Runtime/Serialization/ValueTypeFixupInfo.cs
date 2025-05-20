using System.Reflection;

namespace System.Runtime.Serialization;

internal sealed class ValueTypeFixupInfo
{
	private readonly long _containerID;

	private readonly FieldInfo _parentField;

	private readonly int[] _parentIndex;

	public long ContainerID => 0L;

	public FieldInfo ParentField => null;

	public int[] ParentIndex => null;

	public ValueTypeFixupInfo(long containerID, FieldInfo member, int[] parentIndex)
	{
	}
}
