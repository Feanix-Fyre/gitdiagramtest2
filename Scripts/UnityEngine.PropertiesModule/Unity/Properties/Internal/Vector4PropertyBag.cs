using UnityEngine;

namespace Unity.Properties.Internal;

internal class Vector4PropertyBag : ContainerPropertyBag<Vector4>
{
	private class XProperty : Property<Vector4, float>
	{
		public override string Name => null;
	}

	private class YProperty : Property<Vector4, float>
	{
		public override string Name => null;
	}

	private class ZProperty : Property<Vector4, float>
	{
		public override string Name => null;
	}

	private class WProperty : Property<Vector4, float>
	{
		public override string Name => null;
	}
}
