using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Modules/UI/Canvas.h")]
[NativeHeader("Modules/UI/CanvasManager.h")]
[RequireComponent(typeof(RectTransform))]
[NativeHeader("Modules/UI/UIStructs.h")]
[NativeClass("UI::Canvas")]
public sealed class Canvas : Behaviour
{
	public delegate void WillRenderCanvases();

	public RenderMode renderMode
	{
		get
		{
			return default(RenderMode);
		}
		set
		{
		}
	}

	public bool isRootCanvas => false;

	public Rect pixelRect => default(Rect);

	public float scaleFactor
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float referencePixelsPerUnit
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool pixelPerfect => false;

	public float planeDistance
	{
		set
		{
		}
	}

	public int renderOrder => 0;

	public bool overrideSorting
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int sortingOrder
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int targetDisplay => 0;

	public int sortingLayerID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public AdditionalCanvasShaderChannels additionalShaderChannels
	{
		get
		{
			return default(AdditionalCanvasShaderChannels);
		}
		set
		{
		}
	}

	public Canvas rootCanvas => null;

	public Vector2 renderingDisplaySize => default(Vector2);

	internal static Action<int> externBeginRenderOverlays { get; set; }

	internal static Action<int, int> externRenderOverlaysBefore { get; set; }

	internal static Action<int> externEndRenderOverlays { get; set; }

	[NativeProperty("Camera", false, TargetType.Function)]
	public Camera worldCamera
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static event WillRenderCanvases preWillRenderCanvases
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event WillRenderCanvases willRenderCanvases
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[FreeFunction("UI::CanvasManager::SetExternalCanvasEnabled")]
	internal static void SetExternalCanvasEnabled(bool enabled)
	{
	}

	[FreeFunction("UI::GetDefaultUIMaterial")]
	public static Material GetDefaultCanvasMaterial()
	{
		return null;
	}

	[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
	public static Material GetETC1SupportedCanvasMaterial()
	{
		return null;
	}

	public static void ForceUpdateCanvases()
	{
	}

	[RequiredByNativeCode]
	private static void SendPreWillRenderCanvases()
	{
	}

	[RequiredByNativeCode]
	private static void SendWillRenderCanvases()
	{
	}

	[RequiredByNativeCode]
	private static void BeginRenderExtraOverlays(int displayIndex)
	{
	}

	[RequiredByNativeCode]
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder)
	{
	}

	[RequiredByNativeCode]
	private static void EndRenderExtraOverlays(int displayIndex)
	{
	}

	[SpecialName]
	private void get_pixelRect_Injected(out Rect ret)
	{
		ret = default(Rect);
	}

	[SpecialName]
	private void get_renderingDisplaySize_Injected(out Vector2 ret)
	{
		ret = default(Vector2);
	}
}
