namespace System.Reflection;

internal sealed class SignatureConstructedGenericType : SignatureType
{
	private readonly Type _genericTypeDefinition;

	private readonly Type[] _genericTypeArguments;

	public sealed override bool IsGenericTypeDefinition => false;

	public sealed override bool IsSZArray => false;

	public sealed override bool IsVariableBoundArray => false;

	public sealed override bool IsConstructedGenericType => false;

	public sealed override bool IsGenericParameter => false;

	public sealed override bool IsGenericMethodParameter => false;

	public sealed override bool ContainsGenericParameters => false;

	internal sealed override SignatureType ElementType => null;

	public sealed override Type[] GenericTypeArguments => null;

	public sealed override int GenericParameterPosition => 0;

	public sealed override string Name => null;

	public sealed override string Namespace => null;

	internal SignatureConstructedGenericType(Type genericTypeDefinition, Type[] typeArguments)
	{
	}

	protected sealed override bool HasElementTypeImpl()
	{
		return false;
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
