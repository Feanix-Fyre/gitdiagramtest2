using System.Collections.Generic;

namespace UnityEngine.Experimental.Rendering;

public class XRLayout
{
	private readonly List<(Camera, XRPass)> m_ActivePasses;

	public void AddCamera(Camera camera, bool enableXR)
	{
	}

	public void ReconfigurePass(XRPass xrPass, Camera camera)
	{
	}

	public List<(Camera, XRPass)> GetActivePasses()
	{
		return null;
	}

	internal void AddPass(Camera camera, XRPass xrPass)
	{
	}

	internal void Clear()
	{
	}

	internal void LogDebugInfo()
	{
	}
}
