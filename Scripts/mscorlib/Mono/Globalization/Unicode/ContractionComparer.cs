using System.Collections.Generic;

namespace Mono.Globalization.Unicode;

internal class ContractionComparer : IComparer<Contraction>
{
	public static readonly ContractionComparer Instance;

	public int Compare(Contraction c1, Contraction c2)
	{
		return 0;
	}
}
