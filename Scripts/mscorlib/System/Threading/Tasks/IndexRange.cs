using System.Runtime.InteropServices;

namespace System.Threading.Tasks;

[StructLayout((LayoutKind)3)]
internal struct IndexRange
{
	internal long _nFromInclusive;

	internal long _nToExclusive;

	internal Box<long> _nSharedCurrentIndexOffset;

	internal int _bRangeFinished;
}
