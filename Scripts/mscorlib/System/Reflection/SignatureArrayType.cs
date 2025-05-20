namespace System.Reflection;

internal sealed class SignatureArrayType : SignatureHasElementType
{
	private readonly int _rank;

	private readonly bool _isMultiDim;

	public sealed override bool IsSZArray => false;

	public sealed override bool IsVariableBoundArray => false;

	protected sealed override string Suffix => null;

	internal SignatureArrayType(SignatureType elementType, int rank, bool isMultiDim)
		: base(null)
	{
	}

	protected sealed override bool IsArrayImpl()
	{
		return false;
	}

	protected sealed override bool IsByRefImpl()
	{
		return false;
	}

	protected sealed override bool IsPointerImpl()
	{
		return false;
	}

	public sealed override int GetArrayRank()
	{
		return 0;
	}
}
