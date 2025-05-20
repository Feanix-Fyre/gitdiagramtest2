namespace System.Runtime.Serialization.Formatters.Binary;

[Serializable]
internal sealed class SizedArray : ICloneable
{
	internal object[] objects;

	internal object[] negObjects;

	internal object this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal SizedArray()
	{
	}

	internal SizedArray(int length)
	{
	}

	private SizedArray(SizedArray sizedArray)
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
