namespace System.Runtime.InteropServices;

/// <summary>Controls the marshaling behavior of a delegate signature passed as an unmanaged function pointer to or from unmanaged code. This class cannot be inherited.</summary>
[AttributeUsage(AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
[ComVisible(true)]
public sealed class UnmanagedFunctionPointerAttribute : Attribute
{
	private CallingConvention m_callingConvention;

	/// <summary>Gets the value of the calling convention.</summary>
	/// <returns>The value of the calling convention specified by the <see cref="M:System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute.#ctor(System.Runtime.InteropServices.CallingConvention)" /> constructor.</returns>
	public CallingConvention CallingConvention => default(CallingConvention);

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute" /> class with the specified calling convention.</summary>
	/// <param name="callingConvention">The specified calling convention.</param>
	public UnmanagedFunctionPointerAttribute(CallingConvention callingConvention)
	{
	}
}
