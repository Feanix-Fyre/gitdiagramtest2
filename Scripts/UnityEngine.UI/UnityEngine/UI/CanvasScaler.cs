using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
[ExecuteAlways]
[AddComponentMenu("Layout/Canvas Scaler", 101)]
[DisallowMultipleComponent]
public class CanvasScaler : UIBehaviour
{
	public enum ScaleMode
	{
		ConstantPixelSize = 0,
		ScaleWithScreenSize = 1,
		ConstantPhysicalSize = 2
	}

	public enum ScreenMatchMode
	{
		MatchWidthOrHeight = 0,
		Expand = 1,
		Shrink = 2
	}

	public enum Unit
	{
		Centimeters = 0,
		Millimeters = 1,
		Inches = 2,
		Points = 3,
		Picas = 4
	}

	[Tooltip("Determines how UI elements in the Canvas are scaled.")]
	[SerializeField]
	private ScaleMode m_UiScaleMode;

	[SerializeField]
	[Tooltip("If a sprite has this 'Pixels Per Unit' setting, then one pixel in the sprite will cover one unit in the UI.")]
	protected float m_ReferencePixelsPerUnit;

	[SerializeField]
	[Tooltip("Scales all UI elements in the Canvas by this factor.")]
	protected float m_ScaleFactor;

	[SerializeField]
	[Tooltip("The resolution the UI layout is designed for. If the screen resolution is larger, the UI will be scaled up, and if it's smaller, the UI will be scaled down. This is done in accordance with the Screen Match Mode.")]
	protected Vector2 m_ReferenceResolution;

	[Tooltip("A mode used to scale the canvas area if the aspect ratio of the current resolution doesn't fit the reference resolution.")]
	[SerializeField]
	protected ScreenMatchMode m_ScreenMatchMode;

	[SerializeField]
	[Tooltip("Determines if the scaling is using the width or height as reference, or a mix in between.")]
	[Range(0f, 1f)]
	protected float m_MatchWidthOrHeight;

	private const float kLogBase = 2f;

	[SerializeField]
	[Tooltip("The physical unit to specify positions and sizes in.")]
	protected Unit m_PhysicalUnit;

	[Tooltip("The DPI to assume if the screen DPI is not known.")]
	[SerializeField]
	protected float m_FallbackScreenDPI;

	[SerializeField]
	[Tooltip("The pixels per inch to use for sprites that have a 'Pixels Per Unit' setting that matches the 'Reference Pixels Per Unit' setting.")]
	protected float m_DefaultSpriteDPI;

	[SerializeField]
	[Tooltip("The amount of pixels per unit to use for dynamically created bitmaps in the UI, such as Text.")]
	protected float m_DynamicPixelsPerUnit;

	private Canvas m_Canvas;

	[NonSerialized]
	private float m_PrevScaleFactor;

	[NonSerialized]
	private float m_PrevReferencePixelsPerUnit;

	[SerializeField]
	protected bool m_PresetInfoIsWorld;

	public ScaleMode uiScaleMode
	{
		get
		{
			return default(ScaleMode);
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

	public Vector2 referenceResolution
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public ScreenMatchMode screenMatchMode
	{
		get
		{
			return default(ScreenMatchMode);
		}
		set
		{
		}
	}

	public float matchWidthOrHeight
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Unit physicalUnit
	{
		get
		{
			return default(Unit);
		}
		set
		{
		}
	}

	public float fallbackScreenDPI
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float defaultSpriteDPI
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float dynamicPixelsPerUnit
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected CanvasScaler()
	{
	}

	protected override void OnEnable()
	{
	}

	private void Canvas_preWillRenderCanvases()
	{
	}

	protected override void OnDisable()
	{
	}

	protected virtual void Handle()
	{
	}

	protected virtual void HandleWorldCanvas()
	{
	}

	protected virtual void HandleConstantPixelSize()
	{
	}

	protected virtual void HandleScaleWithScreenSize()
	{
	}

	protected virtual void HandleConstantPhysicalSize()
	{
	}

	protected void SetScaleFactor(float scaleFactor)
	{
	}

	protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit)
	{
	}
}
