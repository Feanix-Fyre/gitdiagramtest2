using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
public sealed class ReflectionProbe : Behaviour
{
	public enum ReflectionProbeEvent
	{
		ReflectionProbeAdded = 0,
		ReflectionProbeRemoved = 1
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Action<ReflectionProbe, ReflectionProbeEvent> reflectionProbeChanged;

	private static Dictionary<int, Action<Texture>> registeredDefaultReflectionSetActions;

	private static List<Action<Texture>> registeredDefaultReflectionTextureActions;

	[NativeName("GlobalAABB")]
	public Bounds bounds => default(Bounds);

	public float blendDistance => 0f;

	public int importance => 0;

	public ReflectionProbeRefreshMode refreshMode => default(ReflectionProbeRefreshMode);

	public ReflectionProbeTimeSlicingMode timeSlicingMode => default(ReflectionProbeTimeSlicingMode);

	public Texture texture => null;

	public Vector4 textureHDRDecodeValues
	{
		[NativeName("CalculateHDRDecodeValues")]
		get
		{
			return default(Vector4);
		}
	}

	[StaticAccessor("GetReflectionProbes()")]
	public static Vector4 defaultTextureHDRDecodeValues => default(Vector4);

	[StaticAccessor("GetReflectionProbes()")]
	public static Texture defaultTexture => null;

	public int RenderProbe()
	{
		return 0;
	}

	public int RenderProbe([DefaultValue("null")] RenderTexture targetTexture)
	{
		return 0;
	}

	private int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture)
	{
		return 0;
	}

	[RequiredByNativeCode]
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbeEvent probeEvent)
	{
	}

	[RequiredByNativeCode]
	private static void CallSetDefaultReflection(Texture defaultReflectionCubemap)
	{
	}

	[SpecialName]
	private void get_bounds_Injected(out Bounds ret)
	{
		ret = default(Bounds);
	}

	[SpecialName]
	private void get_textureHDRDecodeValues_Injected(out Vector4 ret)
	{
		ret = default(Vector4);
	}

	[SpecialName]
	private static void get_defaultTextureHDRDecodeValues_Injected(out Vector4 ret)
	{
		ret = default(Vector4);
	}
}
