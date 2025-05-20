namespace System.Reflection;

internal sealed class SignaturePointerType : SignatureHasElementType
{
	public sealed override bool IsSZArray => false;

	public sealed override bool IsVariableBoundArray => false;

	protected sealed override string Suffix => null;

	internal SignaturePointerType(SignatureType elementType)
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
