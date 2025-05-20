using System.Reflection;

namespace System.Runtime.InteropServices;

/// <summary>Indicates that the attributed method is exposed by an unmanaged dynamic-link library (DLL) as a static entry point.</summary>
[ComVisible(true)]
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public sealed class DllImportAttribute : Attribute
{
	internal string _val;

	/// <summary>Indicates the name or ordinal of the DLL entry point to be called.</summary>
	public string EntryPoint;

	/// <summary>Indicates how to marshal string parameters to the method and controls name mangling.</summary>
	public CharSet CharSet;

	/// <summary>Indicates whether the callee calls the <see langword="SetLastError" /> Win32 API function before returning from the attributed method.</summary>
	public bool SetLastError;

	/// <summary>Controls whether the <see cref="F:System.Runtime.InteropServices.DllImportAttribute.CharSet" /> field causes the common language runtime to search an unmanaged DLL for entry-point names other than the one specified.</summary>
	public bool ExactSpelling;

	/// <summary>Indicates whether unmanaged methods that have <see langword="HRESULT" /> or <see langword="retval" /> return values are directly translated or whether <see langword="HRESULT" /> or <see langword="retval" /> return values are automatically converted to exceptions.</summary>
	public bool PreserveSig;

	/// <summary>Indicates the calling convention of an entry point.</summary>
	public CallingConvention CallingConvention;

	/// <summary>Enables or disables best-fit mapping behavior when converting Unicode characters to ANSI characters.</summary>
	public bool BestFitMapping;

	/// <summary>Enables or disables the throwing of an exception on an unmappable Unicode character that is converted to an ANSI "?" character.</summary>
	public bool ThrowOnUnmappableChar;

	/// <summary>Gets the name of the DLL file that contains the entry point.</summary>
	/// <returns>The name of the DLL file that contains the entry point.</returns>
	public string Value => null;

	internal static Attribute GetCustomAttribute(RuntimeMethodInfo method)
	{
		return null;
	}

	internal static bool IsDefined(RuntimeMethodInfo method)
	{
		return false;
	}

	internal DllImportAttribute(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.DllImportAttribute" /> class with the name of the DLL containing the method to import.</summary>
	/// <param name="dllName">The name of the DLL that contains the unmanaged method. This can include an assembly display name, if the DLL is included in an assembly.</param>
	public DllImportAttribute(string dllName)
	{
	}
}
