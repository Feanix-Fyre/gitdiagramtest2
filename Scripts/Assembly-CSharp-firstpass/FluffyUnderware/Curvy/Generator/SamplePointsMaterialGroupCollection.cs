using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace FluffyUnderware.Curvy.Generator;

public class SamplePointsMaterialGroupCollection : List<SamplePointsMaterialGroup>
{
	public int MaterialID;

	public float AspectCorrectionU;

	public float AspectCorrectionV;

	public int TriangleCount => 0;

	[UsedImplicitly]
	[Obsolete("Use AspectCorrectionV instead")]
	public float AspectCorrection
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public SamplePointsMaterialGroupCollection()
	{
	}

	public SamplePointsMaterialGroupCollection(int capacity)
	{
	}

	public SamplePointsMaterialGroupCollection(IEnumerable<SamplePointsMaterialGroup> collection)
	{
	}

	public void CalculateAspectCorrection(CGVolume volume, CGMaterialSettingsEx matSettings)
	{
	}
}
