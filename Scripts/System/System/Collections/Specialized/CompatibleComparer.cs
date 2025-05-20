namespace System.Collections.Specialized;

[Serializable]
internal class CompatibleComparer : IEqualityComparer
{
	private IComparer _comparer;

	private static IComparer defaultComparer;

	private IHashCodeProvider _hcp;

	private static IHashCodeProvider defaultHashProvider;

	public IComparer Comparer => null;

	public IHashCodeProvider HashCodeProvider => null;

	public static IComparer DefaultComparer => null;

	public static IHashCodeProvider DefaultHashCodeProvider => null;

	internal CompatibleComparer(IComparer comparer, IHashCodeProvider hashCodeProvider)
	{
	}

	public new bool Equals(object a, object b)
	{
		return false;
	}

	public int GetHashCode(object obj)
	{
		return 0;
	}
}
