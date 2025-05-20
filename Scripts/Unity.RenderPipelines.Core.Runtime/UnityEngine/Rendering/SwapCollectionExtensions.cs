using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;

namespace UnityEngine.Rendering;

public static class SwapCollectionExtensions
{
	[MustUseReturnValue]
	[CollectionAccess(CollectionAccessType.ModifyExistingContent)]
	public static bool TrySwap<TValue>([DisallowNull] this IList<TValue> list, int from, int to, [NotNullWhen(false)] out Exception error)
	{
		error = null;
		return false;
	}
}
