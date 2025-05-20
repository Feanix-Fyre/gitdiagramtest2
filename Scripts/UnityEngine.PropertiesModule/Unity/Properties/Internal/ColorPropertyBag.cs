using UnityEngine;

namespace Unity.Properties.Internal;

internal class ColorPropertyBag : ContainerPropertyBag<Color>
{
	private class RProperty : Property<Color, float>
	{
		public override string Name => null;
	}

	private class GProperty : Property<Color, float>
	{
		public override string Name => null;
	}

	private class BProperty : Property<Color, float>
	{
		public override string Name => null;
	}

	private class AProperty : Property<Color, float>
	{
		public override string Name => null;
	}
}
