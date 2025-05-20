using System;

namespace Unity.Properties.Internal;

internal class SystemVersionPropertyBag : ContainerPropertyBag<Version>
{
	private class MajorProperty : Property<Version, int>
	{
		public override string Name => null;
	}

	private class MinorProperty : Property<Version, int>
	{
		public override string Name => null;
	}

	private class BuildProperty : Property<Version, int>
	{
		public override string Name => null;
	}

	private class RevisionProperty : Property<Version, int>
	{
		public override string Name => null;
	}
}
