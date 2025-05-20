using System.Runtime.Serialization;

namespace System.Collections.Generic;

[Serializable]
internal sealed class LongEnumEqualityComparer<T> : EqualityComparer<T>, ISerializable where T : struct
{
	public override bool Equals(T x, T y)
	{
		return false;
	}

	public override int GetHashCode(T obj)
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public LongEnumEqualityComparer()
	{
	}

	public LongEnumEqualityComparer(SerializationInfo information, StreamingContext context)
	{
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
