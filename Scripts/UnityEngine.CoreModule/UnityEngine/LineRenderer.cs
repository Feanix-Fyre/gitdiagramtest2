using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/LineRenderer.h")]
public sealed class LineRenderer : Renderer
{
	public float startWidth
	{
		set
		{
		}
	}

	public float endWidth
	{
		set
		{
		}
	}

	public bool useWorldSpace
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[NativeProperty("PositionsCount")]
	public int positionCount
	{
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

	public LineTextureMode textureMode
	{
		set
		{
		}
	}

	public void SetPosition(int index, Vector3 position)
	{
	}

	[FreeFunction(Name = "LineRendererScripting::SetPositions", HasExplicitThis = true)]
	public void SetPositions([NotNull("ArgumentNullException")] Vector3[] positions)
	{
	}

	private void SetPosition_Injected(int index, ref Vector3 position)
	{
	}
}
