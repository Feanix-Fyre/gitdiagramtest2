using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine.UIElements.UIR.Implementation;

namespace UnityEngine.UIElements.UIR;

internal class RenderChain : IDisposable
{
	private struct DepthOrderedDirtyTracking
	{
		public List<VisualElement> heads;

		public List<VisualElement> tails;

		public int[] minDepths;

		public int[] maxDepths;

		public uint dirtyID;

		public void EnsureFits(int maxDepth)
		{
		}

		public void RegisterDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypes, RenderDataDirtyTypeClasses dirtyTypeClass)
		{
		}

		public void ClearDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypesInverse)
		{
		}

		public void Reset()
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	private struct RenderChainStaticIndexAllocator
	{
		private static List<RenderChain> renderChains;

		public static int AllocateIndex(RenderChain renderChain)
		{
			return 0;
		}

		public static void FreeIndex(int index)
		{
		}

		public static RenderChain AccessIndex(int index)
		{
			return null;
		}
	}

	private struct RenderNodeData
	{
		public Material standardMaterial;

		public Material initialMaterial;

		public MaterialPropertyBlock matPropBlock;

		public RenderChainCommand firstCommand;

		public UIRenderDevice device;

		public Texture vectorAtlas;

		public Texture shaderInfoAtlas;

		public float dpiScale;

		public NativeSlice<Transform3x4> transformConstants;

		public NativeSlice<Vector4> clipRectConstants;
	}

	private RenderChainCommand m_FirstCommand;

	private DepthOrderedDirtyTracking m_DirtyTracker;

	private LinkedPool<RenderChainCommand> m_CommandPool;

	private BasicNodePool<TextureEntry> m_TexturePool;

	private List<RenderNodeData> m_RenderNodesData;

	private Shader m_DefaultShader;

	private Shader m_DefaultWorldSpaceShader;

	private Material m_DefaultMat;

	private Material m_DefaultWorldSpaceMat;

	private bool m_BlockDirtyRegistration;

	private int m_StaticIndex;

	private int m_ActiveRenderNodes;

	private int m_CustomMaterialCommands;

	private ChainBuilderStats m_Stats;

	private uint m_StatsElementsAdded;

	private uint m_StatsElementsRemoved;

	private TextureRegistry m_TextureRegistry;

	private static ProfilerMarker s_MarkerProcess;

	private static ProfilerMarker s_MarkerClipProcessing;

	private static ProfilerMarker s_MarkerOpacityProcessing;

	private static ProfilerMarker s_MarkerColorsProcessing;

	private static ProfilerMarker s_MarkerTransformProcessing;

	private static ProfilerMarker s_MarkerVisualsProcessing;

	private static ProfilerMarker s_MarkerTextRegen;

	internal static Action OnPreRender;

	internal UIRVEShaderInfoAllocator shaderInfoAllocator;

	public OpacityIdAccelerator opacityIdAccelerator { get; private set; }

	protected bool disposed { get; private set; }

	internal BaseVisualElementPanel panel { get; private set; }

	internal UIRenderDevice device { get; private set; }

	internal AtlasBase atlas { get; private set; }

	internal VectorImageManager vectorImageManager { get; private set; }

	internal TempAllocator<Vertex> vertsPool { get; private set; }

	internal TempAllocator<ushort> indicesPool { get; private set; }

	internal JobManager jobManager { get; private set; }

	internal UIRStylePainter painter { get; private set; }

	internal bool drawStats { get; set; }

	internal bool drawInCameras { get; private set; }

	internal Shader defaultShader
	{
		set
		{
		}
	}

	internal Shader defaultWorldSpaceShader
	{
		set
		{
		}
	}

	static RenderChain()
	{
	}

	public RenderChain(BaseVisualElementPanel panel)
	{
	}

	private void Constructor(BaseVisualElementPanel panelObj, UIRenderDevice deviceObj, AtlasBase atlas, VectorImageManager vectorImageMan)
	{
	}

	private void Destructor()
	{
	}

	public void Dispose()
	{
	}

	protected void Dispose(bool disposing)
	{
	}

	public void ProcessChanges()
	{
	}

	public void Render()
	{
	}

	public void UIEOnChildAdded(VisualElement ve)
	{
	}

	public void UIEOnChildrenReordered(VisualElement ve)
	{
	}

	public void UIEOnChildRemoving(VisualElement ve)
	{
	}

	public void UIEOnRenderHintsChanged(VisualElement ve)
	{
	}

	public void UIEOnClippingChanged(VisualElement ve, bool hierarchical)
	{
	}

	public void UIEOnOpacityChanged(VisualElement ve, bool hierarchical = false)
	{
	}

	public void UIEOnColorChanged(VisualElement ve)
	{
	}

	public void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged)
	{
	}

	public void UIEOnVisualsChanged(VisualElement ve, bool hierarchical)
	{
	}

	public void UIEOnOpacityIdChanged(VisualElement ve)
	{
	}

	internal Material GetStandardMaterial()
	{
		return null;
	}

	internal Material GetStandardWorldSpaceMaterial()
	{
		return null;
	}

	internal void EnsureFitsDepth(int depth)
	{
	}

	internal void ChildWillBeRemoved(VisualElement ve)
	{
	}

	internal RenderChainCommand AllocCommand()
	{
		return null;
	}

	internal void FreeCommand(RenderChainCommand cmd)
	{
	}

	internal void OnRenderCommandAdded(RenderChainCommand command)
	{
	}

	internal void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand)
	{
	}

	private static RenderNodeData AccessRenderNodeData(IntPtr obj)
	{
		return default(RenderNodeData);
	}

	private static void OnRenderNodeExecute(IntPtr obj)
	{
	}

	private static void OnRegisterIntermediateRenderers(Camera camera)
	{
	}

	private static void OnRegisterIntermediateRendererMat(BaseRuntimePanel rtp, RenderChain renderChain, ref RenderNodeData rnd, Camera camera, int sameDistanceSortPriority)
	{
	}

	internal void RepaintTexturedElements()
	{
	}

	public void AppendTexture(VisualElement ve, Texture src, TextureId id, bool isAtlas)
	{
	}

	public void ResetTextures(VisualElement ve)
	{
	}

	private void DrawStats()
	{
	}

	private static VisualElement GetFirstElementInPanel(VisualElement ve)
	{
		return null;
	}
}
