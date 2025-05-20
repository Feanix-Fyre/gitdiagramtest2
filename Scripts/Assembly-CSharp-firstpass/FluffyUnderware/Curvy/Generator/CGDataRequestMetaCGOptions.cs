using System;
using JetBrains.Annotations;

namespace FluffyUnderware.Curvy.Generator;

public class CGDataRequestMetaCGOptions : CGDataRequestParameter
{
	[UsedImplicitly]
	[Obsolete("This option is now always assumed to be true")]
	public bool CheckHardEdges;

	[Obsolete("This option is now always assumed to be true")]
	[UsedImplicitly]
	public bool CheckMaterialID;

	public bool IncludeControlPoints;

	[UsedImplicitly]
	[Obsolete("This option is now always assumed to be true")]
	public bool CheckExtendedUV;

	public CGDataRequestMetaCGOptions(bool checkEdges, bool checkMaterials, bool includeCP, bool extendedUV)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}
}
