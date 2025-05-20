namespace System.Runtime.CompilerServices;

/// <summary>Specifies whether to wrap exceptions that do not derive from the <see cref="T:System.Exception" /> class with a <see cref="T:System.Runtime.CompilerServices.RuntimeWrappedException" /> object. This class cannot be inherited.</summary>
[Serializable]
[AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
public sealed class RuntimeCompatibilityAttribute : Attribute
{
	[CompilerGenerated]
	private bool _003CWrapNonExceptionThrows_003Ek__BackingField;

	/// <summary>Gets or sets a value that indicates whether to wrap exceptions that do not derive from the <see cref="T:System.Exception" /> class with a <see cref="T:System.Runtime.CompilerServices.RuntimeWrappedException" /> object.</summary>
	/// <returns>
	///   <see langword="true" /> if exceptions that do not derive from the <see cref="T:System.Exception" /> class should appear wrapped with a <see cref="T:System.Runtime.CompilerServices.RuntimeWrappedException" /> object; otherwise, <see langword="false" />.</returns>
	public bool WrapNonExceptionThrows
	{
		[CompilerGenerated]
		set
		{
			_003CWrapNonExceptionThrows_003Ek__BackingField = value;
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute" /> class.</summary>
	public RuntimeCompatibilityAttribute()
	{
	}
}
