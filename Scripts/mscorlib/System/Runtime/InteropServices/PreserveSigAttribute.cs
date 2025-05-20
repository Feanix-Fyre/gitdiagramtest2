namespace System.Runtime.InteropServices;

/// <summary>Indicates that the HRESULT or <see langword="retval" /> signature transformation that takes place during COM interop calls should be suppressed.</summary>
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
[ComVisible(true)]
public sealed class PreserveSigAttribute : Attribute
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.PreserveSigAttribute" /> class.</summary>
	public PreserveSigAttribute()
	{
	}
}
