using UnityEngine;

namespace Unity.Properties.Internal;

internal class RectPropertyBag : ContainerPropertyBag<Rect>
{
	private class XProperty : Property<Rect, float>
	{
		public override string Name => null;
	}

	private class YProperty : Property<Rect, float>
	{
		public override string Name => null;
	}

	private class WidthProperty : Property<Rect, float>
	{
		public override string Name => null;
	}

	private class HeightProperty : Property<Rect, float>
	{
		public override string Name => null;
	}
}
