using System;
using System.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR;

internal class VectorImageManager : IDisposable
{
	public static List<VectorImageManager> instances;

	private static ProfilerMarker s_MarkerRegister;

	private static ProfilerMarker s_MarkerUnregister;

	private readonly AtlasBase m_Atlas;

	private Dictionary<VectorImage, VectorImageRenderInfo> m_Registered;

	private VectorImageRenderInfoPool m_RenderInfoPool;

	private GradientRemapPool m_GradientRemapPool;

	private GradientSettingsAtlas m_GradientSettingsAtlas;

	private bool m_LoggedExhaustedSettingsAtlas;

	public Texture2D atlas => null;

	protected bool disposed { get; private set; }

	public VectorImageManager(AtlasBase atlas)
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public void Commit()
	{
	}

	public GradientRemap AddUser(VectorImage vi, VisualElement context)
	{
		return null;
	}

	private VectorImageRenderInfo Register(VectorImage vi, VisualElement context)
	{
		return null;
	}
}
