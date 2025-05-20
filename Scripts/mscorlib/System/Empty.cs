using System.Runtime.Serialization;

namespace System;

[Serializable]
internal sealed class Empty : ISerializable
{
	public static readonly Empty Value;

	private Empty()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
