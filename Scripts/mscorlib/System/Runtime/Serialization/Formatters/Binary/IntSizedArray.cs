namespace System.Runtime.Serialization.Formatters.Binary;

[Serializable]
internal sealed class IntSizedArray : ICloneable
{
	internal int[] objects;

	internal int[] negObjects;

	internal int this[int index]
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public IntSizedArray()
	{
	}

	private IntSizedArray(IntSizedArray sizedArray)
	{
	}

	public object Clone()
	{
		return null;
	}

	internal void IncreaseCapacity(int index)
	{
	}
}
