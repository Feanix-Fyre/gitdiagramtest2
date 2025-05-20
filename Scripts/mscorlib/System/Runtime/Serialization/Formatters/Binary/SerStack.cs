namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class SerStack
{
	internal object[] objects;

	internal string stackId;

	internal int top;

	internal SerStack(string stackId)
	{
	}

	internal void Push(object obj)
	{
	}

	internal object Pop()
	{
		return null;
	}

	internal void IncreaseCapacity()
	{
	}

	internal object Peek()
	{
		return null;
	}

	internal object PeekPeek()
	{
		return null;
	}

	internal bool IsEmpty()
	{
		return false;
	}
}
