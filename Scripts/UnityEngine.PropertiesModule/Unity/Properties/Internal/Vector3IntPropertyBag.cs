using UnityEngine;

namespace Unity.Properties.Internal;

internal class Vector3IntPropertyBag : ContainerPropertyBag<Vector3Int>
{
	private class XProperty : Property<Vector3Int, int>
	{
		public override string Name => null;
	}

	private class YProperty : Property<Vector3Int, int>
	{
		public override string Name => null;
	}

	private class ZProperty : Property<Vector3Int, int>
	{
		public override string Name => null;
	}
}
