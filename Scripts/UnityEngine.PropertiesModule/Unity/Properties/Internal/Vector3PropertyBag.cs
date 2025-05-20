using UnityEngine;

namespace Unity.Properties.Internal;

internal class Vector3PropertyBag : ContainerPropertyBag<Vector3>
{
	private class XProperty : Property<Vector3, float>
	{
		public override string Name => null;
	}

	private class YProperty : Property<Vector3, float>
	{
		public override string Name => null;
	}

	private class ZProperty : Property<Vector3, float>
	{
		public override string Name => null;
	}
}
