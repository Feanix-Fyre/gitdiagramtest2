using UnityEngine;

namespace Unity.Properties.Internal;

internal class BoundsPropertyBag : ContainerPropertyBag<Bounds>
{
	private class CenterProperty : Property<Bounds, Vector3>
	{
		public override string Name => null;
	}

	private class ExtentsProperty : Property<Bounds, Vector3>
	{
		public override string Name => null;
	}
}
