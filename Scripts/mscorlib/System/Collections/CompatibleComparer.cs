namespace System.Collections;

[Serializable]
internal sealed class CompatibleComparer : IEqualityComparer
{
	private readonly IHashCodeProvider _hcp;

	private readonly IComparer _comparer;

	internal IHashCodeProvider HashCodeProvider => null;

	internal IComparer Comparer => null;

	internal CompatibleComparer(IHashCodeProvider hashCodeProvider, IComparer comparer)
	{
	}

	public new bool Equals(object a, object b)
	{
		return false;
	}

	public int Compare(object a, object b)
	{
		return 0;
	}

	public int GetHashCode(object obj)
	{
		return 0;
	}
}
