using System.Numerics;

namespace System.Data;

internal sealed class AutoIncrementInt64 : AutoIncrementValue
{
	private long _current;

	private long _seed;

	private long _step;

	internal override object Current
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal override Type DataType => null;

	internal override long Seed
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	internal override long Step
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	internal override void MoveAfter()
	{
	}

	internal override void SetCurrent(object value, IFormatProvider formatProvider)
	{
	}

	internal override void SetCurrentAndIncrement(object value)
	{
	}

	private bool BoundaryCheck(BigInteger value)
	{
		return false;
	}
}
