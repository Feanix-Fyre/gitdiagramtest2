using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Windows.WebCam;

[StructLayout((LayoutKind)0)]
[StaticAccessor("PhotoCapture", StaticAccessorType.DoubleColon)]
[MovedFrom("UnityEngine.XR.WSA.WebCam")]
[NativeHeader("PlatformDependent/Win/Webcam/PhotoCapture.h")]
public class PhotoCapture : IDisposable
{
	public enum CaptureResultType
	{
		Success = 0,
		UnknownError = 1
	}

	public struct PhotoCaptureResult
	{
		public CaptureResultType resultType;

		public long hResult;
	}

	public delegate void OnCaptureResourceCreatedCallback(PhotoCapture captureObject);

	public delegate void OnPhotoModeStartedCallback(PhotoCaptureResult result);

	public delegate void OnPhotoModeStoppedCallback(PhotoCaptureResult result);

	public delegate void OnCapturedToDiskCallback(PhotoCaptureResult result);

	public delegate void OnCapturedToMemoryCallback(PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame);

	internal IntPtr m_NativePtr;

	private static readonly long HR_SUCCESS;

	private static PhotoCaptureResult MakeCaptureResult(long hResult)
	{
		return default(PhotoCaptureResult);
	}

	[RequiredByNativeCode]
	private static void InvokeOnCreatedResourceDelegate(OnCaptureResourceCreatedCallback callback, IntPtr nativePtr)
	{
	}

	private PhotoCapture(IntPtr nativeCaptureObject)
	{
	}

	[RequiredByNativeCode]
	private static void InvokeOnPhotoModeStartedDelegate(OnPhotoModeStartedCallback callback, long hResult)
	{
	}

	[RequiredByNativeCode]
	private static void InvokeOnPhotoModeStoppedDelegate(OnPhotoModeStoppedCallback callback, long hResult)
	{
	}

	[RequiredByNativeCode]
	private static void InvokeOnCapturedPhotoToDiskDelegate(OnCapturedToDiskCallback callback, long hResult)
	{
	}

	[RequiredByNativeCode]
	private static void InvokeOnCapturedPhotoToMemoryDelegate(OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr)
	{
	}

	public void Dispose()
	{
	}

	[NativeName("Dispose")]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	private void Dispose_Internal()
	{
	}

	~PhotoCapture()
	{
	}

	[ThreadAndSerializationSafe]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeName("DisposeThreaded")]
	private void DisposeThreaded_Internal()
	{
	}
}
