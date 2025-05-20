using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Windows.WebCam;

[StructLayout((LayoutKind)0)]
[MovedFrom("UnityEngine.XR.WSA.WebCam")]
[StaticAccessor("VideoCaptureBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("PlatformDependent/Win/Webcam/VideoCaptureBindings.h")]
public class VideoCapture : IDisposable
{
	public enum CaptureResultType
	{
		Success = 0,
		UnknownError = 1
	}

	public struct VideoCaptureResult
	{
		public CaptureResultType resultType;

		public long hResult;
	}

	public delegate void OnVideoCaptureResourceCreatedCallback(VideoCapture captureObject);

	public delegate void OnVideoModeStartedCallback(VideoCaptureResult result);

	public delegate void OnVideoModeStoppedCallback(VideoCaptureResult result);

	public delegate void OnStartedRecordingVideoCallback(VideoCaptureResult result);

	public delegate void OnStoppedRecordingVideoCallback(VideoCaptureResult result);

	internal IntPtr m_NativePtr;

	private static readonly long HR_SUCCESS;

	private static VideoCaptureResult MakeCaptureResult(long hResult)
	{
		return default(VideoCaptureResult);
	}

	[RequiredByNativeCode]
	private static void InvokeOnCreatedVideoCaptureResourceDelegate(OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr)
	{
	}

	private VideoCapture(IntPtr nativeCaptureObject)
	{
	}

	[RequiredByNativeCode]
	private static void InvokeOnVideoModeStartedDelegate(OnVideoModeStartedCallback callback, long hResult)
	{
	}

	[RequiredByNativeCode]
	private static void InvokeOnVideoModeStoppedDelegate(OnVideoModeStoppedCallback callback, long hResult)
	{
	}

	[RequiredByNativeCode]
	private static void InvokeOnStartedRecordingVideoToDiskDelegate(OnStartedRecordingVideoCallback callback, long hResult)
	{
	}

	[RequiredByNativeCode]
	private static void InvokeOnStoppedRecordingVideoToDiskDelegate(OnStoppedRecordingVideoCallback callback, long hResult)
	{
	}

	public void Dispose()
	{
	}

	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeMethod("VideoCaptureBindings::Dispose", HasExplicitThis = true)]
	private void Dispose_Internal()
	{
	}

	~VideoCapture()
	{
	}

	[ThreadAndSerializationSafe]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeMethod("VideoCaptureBindings::DisposeThreaded", HasExplicitThis = true)]
	private void DisposeThreaded_Internal()
	{
	}
}
