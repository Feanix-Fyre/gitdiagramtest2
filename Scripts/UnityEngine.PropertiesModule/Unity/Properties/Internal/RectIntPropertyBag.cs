using UnityEngine;

namespace Unity.Properties.Internal;

internal class RectIntPropertyBag : ContainerPropertyBag<RectInt>
{
	private class XProperty : Property<RectInt, int>
	{
		public override string Name => null;
	}

	private class YProperty : Property<RectInt, int>
	{
		public override string Name => null;
	}

	private class WidthProperty : Property<RectInt, int>
	{
		public override string Name => null;
	}

	private class HeightProperty : Property<RectInt, int>
	{
		public override string Name => null;
	}
}
