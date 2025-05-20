using UnityEngine;

namespace Unity.Properties.Internal;

internal class Vector2IntPropertyBag : ContainerPropertyBag<Vector2Int>
{
	private class XProperty : Property<Vector2Int, int>
	{
		public override string Name => null;
	}

	private class YProperty : Property<Vector2Int, int>
	{
		public override string Name => null;
	}
}
