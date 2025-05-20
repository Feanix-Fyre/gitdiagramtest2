namespace System.Reflection;

internal abstract class SignatureHasElementType : SignatureType
{
	private readonly SignatureType _elementType;

	public sealed override bool IsGenericTypeDefinition => false;

	public abstract override bool IsSZArray { get; }

	public abstract override bool IsVariableBoundArray { get; }

	public sealed override bool IsConstructedGenericType => false;

	public sealed override bool IsGenericParameter => false;

	public sealed override bool IsGenericMethodParameter => false;

	public sealed override bool ContainsGenericParameters => false;

	internal sealed override SignatureType ElementType => null;

	public sealed override Type[] GenericTypeArguments => null;

	public sealed override int GenericParameterPosition => 0;

	public sealed override string Name => null;

	public sealed override string Namespace => null;

	protected abstract string Suffix { get; }

	protected SignatureHasElementType(SignatureType elementType)
	{
	}

	protected sealed override bool HasElementTypeImpl()
	{
		return false;
	}

	protected abstract override bool IsArrayImpl();

	protected abstract override bool IsByRefImpl();

	protected abstract override bool IsPointerImpl();

	public abstract override int GetArrayRank();

	public sealed override Type GetGenericTypeDefinition()
	{
		return null;
	}

	public sealed override Type[] GetGenericArguments()
	{
		return null;
	}

	public sealed override string ToString()
	{
		return null;
	}
}
