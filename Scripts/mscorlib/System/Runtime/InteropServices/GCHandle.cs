namespace System.Runtime.InteropServices;

/// <summary>Provides a way to access a managed object from unmanaged memory.</summary>
[ComVisible(true)]
public struct GCHandle
{
	private IntPtr handle;

	/// <summary>Gets a value indicating whether the handle is allocated.</summary>
	/// <returns>
	///   <see langword="true" /> if the handle is allocated; otherwise, <see langword="false" />.</returns>
	public bool IsAllocated => false;

	/// <summary>Gets or sets the object this handle represents.</summary>
	/// <returns>The object this handle represents.</returns>
	/// <exception cref="T:System.InvalidOperationException">The handle was freed, or never initialized.</exception>
	public object Target
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private GCHandle(IntPtr h)
	{
		handle = (IntPtr)0;
	}

	private GCHandle(object obj)
	{
		handle = (IntPtr)0;
	}

	internal GCHandle(object value, GCHandleType type)
	{
		handle = (IntPtr)0;
	}

	/// <summary>Retrieves the address of an object in a <see cref="F:System.Runtime.InteropServices.GCHandleType.Pinned" /> handle.</summary>
	/// <returns>The address of the pinned object as an <see cref="T:System.IntPtr" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">The handle is any type other than <see cref="F:System.Runtime.InteropServices.GCHandleType.Pinned" />.</exception>
	public IntPtr AddrOfPinnedObject()
	{
		return (IntPtr)0;
	}

	/// <summary>Allocates a <see cref="F:System.Runtime.InteropServices.GCHandleType.Normal" /> handle for the specified object.</summary>
	/// <param name="value">The object that uses the <see cref="T:System.Runtime.InteropServices.GCHandle" />.</param>
	/// <returns>A new <see cref="T:System.Runtime.InteropServices.GCHandle" /> that protects the object from garbage collection. This <see cref="T:System.Runtime.InteropServices.GCHandle" /> must be released with <see cref="M:System.Runtime.InteropServices.GCHandle.Free" /> when it is no longer needed.</returns>
	/// <exception cref="T:System.ArgumentException">An instance with nonprimitive (non-blittable) members cannot be pinned.</exception>
	public static GCHandle Alloc(object value)
	{
		return default(GCHandle);
	}

	/// <summary>Allocates a handle of the specified type for the specified object.</summary>
	/// <param name="value">The object that uses the <see cref="T:System.Runtime.InteropServices.GCHandle" />.</param>
	/// <param name="type">One of the <see cref="T:System.Runtime.InteropServices.GCHandleType" /> values, indicating the type of <see cref="T:System.Runtime.InteropServices.GCHandle" /> to create.</param>
	/// <returns>A new <see cref="T:System.Runtime.InteropServices.GCHandle" /> of the specified type. This <see cref="T:System.Runtime.InteropServices.GCHandle" /> must be released with <see cref="M:System.Runtime.InteropServices.GCHandle.Free" /> when it is no longer needed.</returns>
	/// <exception cref="T:System.ArgumentException">An instance with nonprimitive (non-blittable) members cannot be pinned.</exception>
	public static GCHandle Alloc(object value, GCHandleType type)
	{
		return default(GCHandle);
	}

	/// <summary>Releases a <see cref="T:System.Runtime.InteropServices.GCHandle" />.</summary>
	/// <exception cref="T:System.InvalidOperationException">The handle was freed or never initialized.</exception>
	public void Free()
	{
	}

	/// <summary>A <see cref="T:System.Runtime.InteropServices.GCHandle" /> is stored using an internal integer representation.</summary>
	/// <param name="value">The <see cref="T:System.Runtime.InteropServices.GCHandle" /> for which the integer is required.</param>
	/// <returns>The integer value.</returns>
	public static explicit operator IntPtr(GCHandle value)
	{
		return (IntPtr)0;
	}

	/// <summary>A <see cref="T:System.Runtime.InteropServices.GCHandle" /> is stored using an internal integer representation.</summary>
	/// <param name="value">An <see cref="T:System.IntPtr" /> that indicates the handle for which the conversion is required.</param>
	/// <returns>The stored <see cref="T:System.Runtime.InteropServices.GCHandle" /> object using an internal integer representation.</returns>
	public static explicit operator GCHandle(IntPtr value)
	{
		return default(GCHandle);
	}

	private static bool CheckCurrentDomain(IntPtr handle)
	{
		return false;
	}

	private static object GetTarget(IntPtr handle)
	{
		return null;
	}

	private static IntPtr GetTargetHandle(object obj, IntPtr handle, GCHandleType type)
	{
		return (IntPtr)0;
	}

	private static void FreeHandle(IntPtr handle)
	{
	}

	private static IntPtr GetAddrOfPinnedObject(IntPtr handle)
	{
		return (IntPtr)0;
	}

	/// <summary>Returns a value indicating whether two <see cref="T:System.Runtime.InteropServices.GCHandle" /> objects are equal.</summary>
	/// <param name="a">A <see cref="T:System.Runtime.InteropServices.GCHandle" /> object to compare with the <paramref name="b" /> parameter.</param>
	/// <param name="b">A <see cref="T:System.Runtime.InteropServices.GCHandle" /> object to compare with the <paramref name="a" /> parameter.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="a" /> and <paramref name="b" /> parameters are equal; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(GCHandle a, GCHandle b)
	{
		return false;
	}

	/// <summary>Determines whether the specified <see cref="T:System.Runtime.InteropServices.GCHandle" /> object is equal to the current <see cref="T:System.Runtime.InteropServices.GCHandle" /> object.</summary>
	/// <param name="o">The <see cref="T:System.Runtime.InteropServices.GCHandle" /> object to compare with the current <see cref="T:System.Runtime.InteropServices.GCHandle" /> object.</param>
	/// <returns>
	///   <see langword="true" /> if the specified <see cref="T:System.Runtime.InteropServices.GCHandle" /> object is equal to the current <see cref="T:System.Runtime.InteropServices.GCHandle" /> object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object o)
	{
		return false;
	}

	/// <summary>Returns an identifier for the current <see cref="T:System.Runtime.InteropServices.GCHandle" /> object.</summary>
	/// <returns>An identifier for the current <see cref="T:System.Runtime.InteropServices.GCHandle" /> object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Returns a new <see cref="T:System.Runtime.InteropServices.GCHandle" /> object created from a handle to a managed object.</summary>
	/// <param name="value">An <see cref="T:System.IntPtr" /> handle to a managed object to create a <see cref="T:System.Runtime.InteropServices.GCHandle" /> object from.</param>
	/// <returns>A new <see cref="T:System.Runtime.InteropServices.GCHandle" /> object that corresponds to the value parameter.</returns>
	/// <exception cref="T:System.InvalidOperationException">The value of the <paramref name="value" /> parameter is <see cref="F:System.IntPtr.Zero" />.</exception>
	public static GCHandle FromIntPtr(IntPtr value)
	{
		return default(GCHandle);
	}

	/// <summary>Returns the internal integer representation of a <see cref="T:System.Runtime.InteropServices.GCHandle" /> object.</summary>
	/// <param name="value">A <see cref="T:System.Runtime.InteropServices.GCHandle" /> object to retrieve an internal integer representation from.</param>
	/// <returns>An <see cref="T:System.IntPtr" /> object that represents a <see cref="T:System.Runtime.InteropServices.GCHandle" /> object.</returns>
	public static IntPtr ToIntPtr(GCHandle value)
	{
		return (IntPtr)0;
	}
}
