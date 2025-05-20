using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
public struct LOD
{
	public float screenRelativeTransitionHeight;

	public float fadeTransitionWidth;

	public Renderer[] renderers;

	public LOD(float screenRelativeTransitionHeight, Renderer[] renderers)
	{
		this.screenRelativeTransitionHeight = 0f;
		fadeTransitionWidth = 0f;
		this.renderers = null;
	}
}
