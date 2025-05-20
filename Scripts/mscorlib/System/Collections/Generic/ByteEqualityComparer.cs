namespace System.Collections.Generic;

[Serializable]
internal class ByteEqualityComparer : EqualityComparer<byte>
{
	public override bool Equals(byte x, byte y)
	{
		return false;
	}

	public override int GetHashCode(byte b)
	{
		return 0;
	}

	internal override int IndexOf(byte[] array, byte value, int startIndex, int count)
	{
		return 0;
	}

	internal override int LastIndexOf(byte[] array, byte value, int startIndex, int count)
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
}
