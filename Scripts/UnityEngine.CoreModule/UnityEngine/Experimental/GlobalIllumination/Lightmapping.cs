using System;
using Unity.Collections;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.GlobalIllumination;

public static class Lightmapping
{
	public delegate void RequestLightsDelegate(Light[] requests, NativeArray<LightDataGI> lightsOutput);

	[RequiredByNativeCode]
	private static readonly RequestLightsDelegate s_DefaultDelegate;

	[RequiredByNativeCode]
	private static RequestLightsDelegate s_RequestLightsDelegate;

	[RequiredByNativeCode]
	public static void SetDelegate(RequestLightsDelegate del)
	{
	}

	[RequiredByNativeCode]
	public static RequestLightsDelegate GetDelegate()
	{
		return null;
	}

	[RequiredByNativeCode]
	public static void ResetDelegate()
	{
	}

	[RequiredByNativeCode]
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount)
	{
	}
}
