using System.Collections;

namespace System.Windows.Forms;

/// <summary>Provides a low-level encapsulation of a window handle and a window procedure.</summary>
public class NativeWindow : MarshalByRefObject, IWin32Window
{
	private IntPtr window_handle;

	private static Hashtable window_collection;

	[ThreadStatic]
	private static NativeWindow WindowCreating;

	/// <summary>Gets the handle for this window.</summary>
	/// <returns>If successful, an <see cref="T:System.IntPtr" /> representing the handle to the associated native Win32 window; otherwise, 0 if no handle is associated with the window.</returns>
	public IntPtr Handle => (IntPtr)0;

	/// <summary>Initializes an instance of the <see cref="T:System.Windows.Forms.NativeWindow" /> class.</summary>
	public NativeWindow()
	{
	}

	/// <summary>Retrieves the window associated with the specified handle.</summary>
	/// <param name="handle">A handle to a window.</param>
	/// <returns>The <see cref="T:System.Windows.Forms.NativeWindow" /> associated with the specified handle. This method returns <see langword="null" /> when the handle does not have an associated window.</returns>
	public static NativeWindow FromHandle(IntPtr handle)
	{
		return null;
	}

	internal void InvalidateHandle()
	{
	}

	/// <summary>Assigns a handle to this window.</summary>
	/// <param name="handle">The handle to assign to this window.</param>
	/// <exception cref="T:System.Exception">This window already has a handle.</exception>
	/// <exception cref="T:System.ComponentModel.Win32Exception">The windows procedure for the associated native window could not be retrieved.</exception>
	public void AssignHandle(IntPtr handle)
	{
	}

	private static void AddToTable(NativeWindow window)
	{
	}

	private static void RemoveFromTable(NativeWindow window)
	{
	}

	private static NativeWindow FindFirstInTable(IntPtr handle)
	{
		return null;
	}

	/// <summary>Creates a window and its handle with the specified creation parameters.</summary>
	/// <param name="cp">A <see cref="T:System.Windows.Forms.CreateParams" /> that specifies the creation parameters for this window.</param>
	/// <exception cref="T:System.OutOfMemoryException">The operating system ran out of resources when trying to create the native window.</exception>
	/// <exception cref="T:System.ComponentModel.Win32Exception">The native Win32 API could not create the specified window.</exception>
	/// <exception cref="T:System.InvalidOperationException">The handle of the current native window is already assigned; in explanation, the <see cref="P:System.Windows.Forms.NativeWindow.Handle" /> property is not equal to <see cref="F:System.IntPtr.Zero" />.</exception>
	public virtual void CreateHandle(CreateParams cp)
	{
	}

	/// <summary>Invokes the default window procedure associated with this window.</summary>
	/// <param name="m">The message that is currently being processed.</param>
	public void DefWndProc(ref Message m)
	{
	}

	/// <summary>Destroys the window and its handle.</summary>
	public virtual void DestroyHandle()
	{
	}

	/// <summary>Releases the resources associated with this window.</summary>
	~NativeWindow()
	{
	}

	/// <summary>Specifies a notification method that is called when the handle for a window is changed.</summary>
	protected virtual void OnHandleChange()
	{
	}

	/// <summary>When overridden in a derived class, manages an unhandled thread exception.</summary>
	/// <param name="e">An <see cref="T:System.Exception" /> that specifies the unhandled thread exception.</param>
	protected virtual void OnThreadException(Exception e)
	{
	}

	/// <summary>Invokes the default window procedure associated with this window.</summary>
	/// <param name="m">A <see cref="T:System.Windows.Forms.Message" /> that is associated with the current Windows message.</param>
	protected virtual void WndProc(ref Message m)
	{
	}

	internal static IntPtr WndProc(IntPtr hWnd, Msg msg, IntPtr wParam, IntPtr lParam)
	{
		return (IntPtr)0;
	}

	private static NativeWindow EnsureCreated(NativeWindow window, IntPtr hWnd)
	{
		return null;
	}
}
