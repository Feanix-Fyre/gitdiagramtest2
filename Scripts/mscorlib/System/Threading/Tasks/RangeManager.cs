namespace System.Threading.Tasks;

internal class RangeManager
{
	internal readonly IndexRange[] _indexRanges;

	internal readonly bool _use32BitCurrentIndex;

	internal int _nCurrentIndexRangeToAssign;

	internal long _nStep;

	internal RangeManager(long nFromInclusive, long nToExclusive, long nStep, int nNumExpectedWorkers)
	{
	}

	internal RangeWorker RegisterNewWorker()
	{
		return default(RangeWorker);
	}
}
