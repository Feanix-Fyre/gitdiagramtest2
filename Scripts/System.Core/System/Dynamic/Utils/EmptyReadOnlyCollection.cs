using System.Collections.ObjectModel;

namespace System.Dynamic.Utils;

internal static class EmptyReadOnlyCollection<T>
{
	public static readonly ReadOnlyCollection<T> Instance;
}
