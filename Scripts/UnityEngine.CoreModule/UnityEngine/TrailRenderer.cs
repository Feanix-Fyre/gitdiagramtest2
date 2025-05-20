using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/TrailRenderer.h")]
public sealed class TrailRenderer : Renderer
{
	public bool emitting
	{
		set
		{
		}
	}

	public Color startColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public bool generateLightingData
	{
		set
		{
		}
	}

	public LineAlignment alignment
	{
		set
		{
		}
	}

	[SpecialName]
	private void get_startColor_Injected(out Color ret)
	{
		ret = default(Color);
	}

	[SpecialName]
	private void set_startColor_Injected(ref Color value)
	{
	}
}
