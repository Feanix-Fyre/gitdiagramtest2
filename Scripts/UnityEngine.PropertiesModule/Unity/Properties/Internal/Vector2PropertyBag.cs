using UnityEngine;

namespace Unity.Properties.Internal;

internal class Vector2PropertyBag : ContainerPropertyBag<Vector2>
{
	private class XProperty : Property<Vector2, float>
	{
		public override string Name => null;
	}

	private class YProperty : Property<Vector2, float>
	{
		public override string Name => null;
	}
}
