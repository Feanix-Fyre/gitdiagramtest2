using System.Collections;
using System.Runtime.InteropServices;

namespace System.Drawing;

internal static class MacSupport
{
	internal static Hashtable contextReference;

	internal static object lockobj;

	internal static Delegate hwnd_delegate;

	static MacSupport()
	{
	}

	internal static CocoaContext GetCGContextForNSView(IntPtr handle)
	{
		return null;
	}

	internal static CarbonContext GetCGContextForView(IntPtr handle)
	{
		return default(CarbonContext);
	}

	internal static IntPtr GetContext(IntPtr port)
	{
		return (IntPtr)0;
	}

	internal static void ReleaseContext(IntPtr port, IntPtr context)
	{
	}

	[PreserveSig]
	public static extern IntPtr objc_getClass(string className);

	[PreserveSig]
	public static extern IntPtr objc_msgSend(IntPtr basePtr, IntPtr selector);

	[PreserveSig]
	public static extern void objc_msgSend_stret(ref CGRect32 arect, IntPtr basePtr, IntPtr selector);

	[PreserveSig]
	public static extern void objc_msgSend_stret(ref CGRect64 arect, IntPtr basePtr, IntPtr selector);

	[PreserveSig]
	public static extern bool bool_objc_msgSend(IntPtr handle, IntPtr selector);

	[PreserveSig]
	public static extern IntPtr sel_registerName(string selectorName);

	[PreserveSig]
	internal static extern IntPtr CGMainDisplayID();

	[PreserveSig]
	internal static extern CGRect32 CGDisplayBounds32(IntPtr display);

	[PreserveSig]
	internal static extern int HIViewGetBounds(IntPtr vHnd, ref CGRect32 r);

	[PreserveSig]
	internal static extern int HIViewConvertRect(ref CGRect32 r, IntPtr a, IntPtr b);

	[PreserveSig]
	internal static extern IntPtr GetControlOwner(IntPtr aView);

	[PreserveSig]
	internal static extern int GetWindowBounds(IntPtr wHnd, uint reg, ref QDRect rect);

	[PreserveSig]
	internal static extern IntPtr GetWindowPort(IntPtr hWnd);

	[PreserveSig]
	internal static extern IntPtr GetQDGlobalsThePort();

	[PreserveSig]
	internal static extern void CreateCGContextForPort(IntPtr port, ref IntPtr context);

	[PreserveSig]
	internal static extern void CFRelease(IntPtr context);

	[PreserveSig]
	internal static extern void CGContextTranslateCTM32(IntPtr context, float tx, float ty);

	[PreserveSig]
	internal static extern void CGContextScaleCTM32(IntPtr context, float x, float y);

	[PreserveSig]
	internal static extern void CGContextTranslateCTM64(IntPtr context, double tx, double ty);

	[PreserveSig]
	internal static extern void CGContextScaleCTM64(IntPtr context, double x, double y);

	[PreserveSig]
	internal static extern void CGContextFlush(IntPtr context);

	[PreserveSig]
	internal static extern void CGContextSynchronize(IntPtr context);

	[PreserveSig]
	internal static extern void CGContextAddRect32(IntPtr context, CGRect32 rect);

	[PreserveSig]
	internal static extern void CGContextBeginPath(IntPtr context);

	[PreserveSig]
	internal static extern void CGContextClosePath(IntPtr context);

	[PreserveSig]
	internal static extern void CGContextClip(IntPtr context);

	[PreserveSig]
	internal static extern void CGContextEOClip(IntPtr context);

	[PreserveSig]
	internal static extern void CGContextSaveGState(IntPtr context);

	[PreserveSig]
	internal static extern void CGContextRestoreGState(IntPtr context);
}
