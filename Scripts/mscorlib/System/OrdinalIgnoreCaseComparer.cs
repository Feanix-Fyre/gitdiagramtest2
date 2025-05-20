using System.Runtime.Serialization;

namespace System;

[Serializable]
internal sealed class OrdinalIgnoreCaseComparer : OrdinalComparer, ISerializable
{
	public OrdinalIgnoreCaseComparer()
		: base(ignoreCase: false)
	{
	}

	public override int Compare(string x, string y)
	{
		return 0;
	}

	public override bool Equals(string x, string y)
	{
		return false;
	}

	public override int GetHashCode(string obj)
	{
		return 0;
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
