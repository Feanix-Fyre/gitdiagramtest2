using System.Runtime.InteropServices;

namespace System.Threading.Tasks;

[StructLayout((LayoutKind)3)]
internal struct RangeWorker
{
	internal readonly IndexRange[] _indexRanges;

	internal int _nCurrentIndexRange;

	internal long _nStep;

	internal long _nIncrementValue;

	internal readonly long _nMaxIncrementValue;

	internal readonly bool _use32BitCurrentIndex;

	internal bool IsInitialized => false;

	internal RangeWorker(IndexRange[] ranges, int nInitialRange, long nStep, bool use32BitCurrentIndex)
	{
		_indexRanges = null;
		_nCurrentIndexRange = 0;
		_nStep = 0L;
		_nIncrementValue = 0L;
		_nMaxIncrementValue = 0L;
		_use32BitCurrentIndex = false;
	}

	internal bool FindNewWork(out long nFromInclusiveLocal, out long nToExclusiveLocal)
	{
		nFromInclusiveLocal = default(long);
		nToExclusiveLocal = default(long);
		return false;
	}

	internal bool FindNewWork32(out int nFromInclusiveLocal32, out int nToExclusiveLocal32)
	{
		nFromInclusiveLocal32 = default(int);
		nToExclusiveLocal32 = default(int);
		return false;
	}
}
