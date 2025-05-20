namespace System.Xml;

internal class HWStack : ICloneable
{
	private object[] stack;

	private int growthRate;

	private int used;

	private int size;

	private int limit;

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

	internal int Length => 0;

	internal HWStack(int GrowthRate)
	{
	}

	internal HWStack(int GrowthRate, int limit)
	{
	}

	internal object Push()
	{
		return null;
	}

	internal object Pop()
	{
		return null;
	}

	internal object Peek()
	{
		return null;
	}

	internal void AddToTop(object o)
	{
	}

	private HWStack(object[] stack, int growthRate, int used, int size)
	{
	}

	public object Clone()
	{
		return null;
	}
}
