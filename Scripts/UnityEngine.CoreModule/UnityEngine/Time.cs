using UnityEngine.Bindings;

namespace UnityEngine;

[StaticAccessor("GetTimeManager()", StaticAccessorType.Dot)]
[NativeHeader("Runtime/Input/TimeManager.h")]
public class Time
{
	[NativeProperty("CurTime")]
	public static float time => 0f;

	[NativeProperty("TimeSinceSceneLoad")]
	public static float timeSinceLevelLoad => 0f;

	public static float deltaTime => 0f;

	public static float unscaledTime => 0f;

	public static float fixedUnscaledTime => 0f;

	public static float unscaledDeltaTime => 0f;

	public static float fixedDeltaTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static float maximumDeltaTime => 0f;

	public static float smoothDeltaTime => 0f;

	public static float timeScale
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static int frameCount => 0;

	[NativeProperty("RenderFrameCount")]
	public static int renderedFrameCount => 0;

	[NativeProperty("Realtime")]
	public static float realtimeSinceStartup => 0f;

	[NativeProperty("Realtime")]
	public static double realtimeSinceStartupAsDouble => 0.0;
}
