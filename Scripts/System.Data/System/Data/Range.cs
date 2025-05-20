namespace System.Data;

internal struct Range
{
	private int _min;

	private int _max;

	private bool _isNotNull;

	public int Count => 0;

	public bool IsNull => false;

	public int Min => 0;

	public Range(int min, int max)
	{
		_min = 0;
		_max = 0;
		_isNotNull = false;
	}

	internal void CheckNull()
	{
	}
}
