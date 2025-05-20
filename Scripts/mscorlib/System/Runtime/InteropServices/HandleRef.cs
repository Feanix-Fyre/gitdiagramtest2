namespace System.Runtime.InteropServices;

/// <summary>Wraps a managed object holding a handle to a resource that is passed to unmanaged code using platform invoke.</summary>
public readonly struct HandleRef
{
	private readonly object _wrapper;

	private readonly IntPtr _handle;

	/// <summary>Gets the handle to a resource.</summary>
	/// <returns>The handle to a resource.</returns>
	public IntPtr Handle => (IntPtr)0;

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.HandleRef" /> class with the object to wrap and a handle to the resource used by unmanaged code.</summary>
	/// <param name="wrapper">A managed object that should not be finalized until the platform invoke call returns.</param>
	/// <param name="handle">An <see cref="T:System.IntPtr" /> that indicates a handle to a resource.</param>
	public HandleRef(object wrapper, IntPtr handle)
	{
		_wrapper = null;
		_handle = (IntPtr)0;
	}
}
