using UnityEngine;

namespace Unity.Properties.Internal;

internal class BoundsIntPropertyBag : ContainerPropertyBag<BoundsInt>
{
	private class PositionProperty : Property<BoundsInt, Vector3Int>
	{
		public override string Name => null;
	}

	private class SizeProperty : Property<BoundsInt, Vector3Int>
	{
		public override string Name => null;
	}
}
