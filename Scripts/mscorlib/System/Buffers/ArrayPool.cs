namespace System.Buffers;

public abstract class ArrayPool<T>
{
	public static ArrayPool<T> Shared { get; }

	public abstract T[] Rent(int minimumLength);

	public abstract void Return(T[] array, bool clearArray = false);
}
