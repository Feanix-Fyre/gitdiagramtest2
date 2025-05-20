using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/GfxDevice/ScalableBufferManager.h")]
[StaticAccessor("ScalableBufferManager::GetInstance()", StaticAccessorType.Dot)]
public static class ScalableBufferManager
{
	public static float widthScaleFactor => 0f;

	public static float heightScaleFactor => 0f;

	public static void ResizeBuffers(float widthScale, float heightScale)
	{
	}
}
