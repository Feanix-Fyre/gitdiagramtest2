namespace UnityEngine.Rendering.Universal;

internal struct IntPoint
{
	public long N;

	public long X;

	public long Y;

	public long D;

	public double NX;

	public double NY;

	public IntPoint(long X, long Y)
	{
		N = 0L;
		this.X = 0L;
		this.Y = 0L;
		D = 0L;
		NX = 0.0;
		NY = 0.0;
	}

	public IntPoint(double x, double y)
	{
		N = 0L;
		X = 0L;
		Y = 0L;
		D = 0L;
		NX = 0.0;
		NY = 0.0;
	}

	public IntPoint(IntPoint pt)
	{
		N = 0L;
		X = 0L;
		Y = 0L;
		D = 0L;
		NX = 0.0;
		NY = 0.0;
	}

	public static bool operator ==(IntPoint a, IntPoint b)
	{
		return false;
	}

	public static bool operator !=(IntPoint a, IntPoint b)
	{
		return false;
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
