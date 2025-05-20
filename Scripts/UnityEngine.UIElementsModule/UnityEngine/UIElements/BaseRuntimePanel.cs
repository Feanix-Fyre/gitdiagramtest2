using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

internal abstract class BaseRuntimePanel : Panel
{
	private GameObject m_SelectableGameObject;

	private static int s_CurrentRuntimePanelCounter;

	internal readonly int m_RuntimePanelCreationIndex;

	private float m_SortingPriority;

	internal int resolvedSortingIndex;

	private Shader m_StandardWorldSpaceShader;

	private bool m_DrawToCameras;

	internal RenderTexture targetTexture;

	internal Matrix4x4 panelToWorld;

	internal static readonly Func<Vector2, Vector2> DefaultScreenToPanelSpace;

	private Func<Vector2, Vector2> m_ScreenToPanelSpace;

	public GameObject selectableGameObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float sortingPriority
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	internal override Shader standardWorldSpaceShader => null;

	internal bool drawToCameras
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal int targetDisplay { get; set; }

	internal int screenRenderingWidth => 0;

	internal int screenRenderingHeight => 0;

	public Func<Vector2, Vector2> screenToPanelSpace
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public event Action destroyed
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

	protected BaseRuntimePanel(ScriptableObject ownerObject, EventDispatcher dispatcher = null)
		: base(null, default(ContextType), null)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	internal static int getScreenRenderingHeight(int display)
	{
		return 0;
	}

	internal static int getScreenRenderingWidth(int display)
	{
		return 0;
	}

	public override void Repaint(Event e)
	{
	}

	internal Vector2 ScreenToPanel(Vector2 screen)
	{
		return default(Vector2);
	}

	internal bool ScreenToPanel(Vector2 screenPosition, Vector2 screenDelta, out Vector2 panelPosition, out Vector2 panelDelta, bool allowOutside = false)
	{
		panelPosition = default(Vector2);
		panelDelta = default(Vector2);
		return false;
	}

	private void AssignPanelToComponents(BaseRuntimePanel panel)
	{
	}

	internal void PointerLeavesPanel(int pointerId, Vector2 position)
	{
	}

	internal void PointerEntersPanel(int pointerId, Vector2 position)
	{
	}
}
