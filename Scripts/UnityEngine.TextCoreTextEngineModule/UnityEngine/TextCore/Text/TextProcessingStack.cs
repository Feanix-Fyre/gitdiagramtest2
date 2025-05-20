using System.Diagnostics;

namespace UnityEngine.TextCore.Text;

[DebuggerDisplay("Item count = {m_Count}")]
internal struct TextProcessingStack<T>
{
	public T[] itemStack;

	public int index;

	private T m_DefaultItem;

	private int m_Capacity;

	private int m_RolloverSize;

	private int m_Count;

	public int Count => 0;

	public T current => default(T);

	public TextProcessingStack(T[] stack)
	{
		itemStack = null;
		index = 0;
		m_DefaultItem = default(T);
		m_Capacity = 0;
		m_RolloverSize = 0;
		m_Count = 0;
	}

	public TextProcessingStack(int capacity)
	{
		itemStack = null;
		index = 0;
		m_DefaultItem = default(T);
		m_Capacity = 0;
		m_RolloverSize = 0;
		m_Count = 0;
	}

	public TextProcessingStack(int capacity, int rolloverSize)
	{
		itemStack = null;
		index = 0;
		m_DefaultItem = default(T);
		m_Capacity = 0;
		m_RolloverSize = 0;
		m_Count = 0;
	}

	internal static void SetDefault(TextProcessingStack<T>[] stack, T item)
	{
	}

	public void Clear()
	{
	}

	public void SetDefault(T item)
	{
	}

	public void Add(T item)
	{
	}

	public T Remove()
	{
		return default(T);
	}

	public void Push(T item)
	{
	}

	public T Pop()
	{
		return default(T);
	}

	public T Peek()
	{
		return default(T);
	}

	public T CurrentItem()
	{
		return default(T);
	}
}
