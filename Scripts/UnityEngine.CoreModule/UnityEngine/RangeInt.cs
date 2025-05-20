namespace UnityEngine;

public struct RangeInt
{
	public int start;

	public int length;

	public int end => 0;

	public RangeInt(int start, int length)
	{
		this.start = 0;
		this.length = 0;
	}
}
