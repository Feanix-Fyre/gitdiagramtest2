using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Diagnostics;

/// <summary>Provides information about a <see cref="T:System.Diagnostics.StackFrame" />, which represents a function call on the call stack for the current thread.</summary>
[Serializable]
[StructLayout((LayoutKind)0)]
[MonoTODO("Serialized objects are not compatible with MS.NET")]
[ComVisible(true)]
public class StackFrame
{
	/// <summary>Defines the value that is returned from the <see cref="M:System.Diagnostics.StackFrame.GetNativeOffset" /> or <see cref="M:System.Diagnostics.StackFrame.GetILOffset" /> method when the native or Microsoft intermediate language (MSIL) offset is unknown. This field is constant.</summary>
	public const int OFFSET_UNKNOWN = -1;

	private int ilOffset;

	private int nativeOffset;

	private long methodAddress;

	private uint methodIndex;

	private MethodBase methodBase;

	private string fileName;

	private int lineNumber;

	private int columnNumber;

	private string internalMethodName;

	private static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column)
	{
		method = null;
		iloffset = default(int);
		native_offset = default(int);
		file = null;
		line = default(int);
		column = default(int);
		return false;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackFrame" /> class.</summary>
	public StackFrame()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackFrame" /> class that corresponds to a frame above the current stack frame.</summary>
	/// <param name="skipFrames">The number of frames up the stack to skip.</param>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StackFrame(int skipFrames)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackFrame" /> class that corresponds to a frame above the current stack frame, optionally capturing source information.</summary>
	/// <param name="skipFrames">The number of frames up the stack to skip.</param>
	/// <param name="fNeedFileInfo">
	///   <see langword="true" /> to capture the file name, line number, and column number of the stack frame; otherwise, <see langword="false" />.</param>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StackFrame(int skipFrames, bool fNeedFileInfo)
	{
	}

	/// <summary>Gets the line number in the file that contains the code that is executing. This information is typically extracted from the debugging symbols for the executable.</summary>
	/// <returns>The file line number, or 0 (zero) if the file line number cannot be determined.</returns>
	public virtual int GetFileLineNumber()
	{
		return 0;
	}

	/// <summary>Gets the file name that contains the code that is executing. This information is typically extracted from the debugging symbols for the executable.</summary>
	/// <returns>The file name, or <see langword="null" /> if the file name cannot be determined.</returns>
	public virtual string GetFileName()
	{
		return null;
	}

	internal string GetSecureFileName()
	{
		return null;
	}

	/// <summary>Gets the offset from the start of the Microsoft intermediate language (MSIL) code for the method that is executing. This offset might be an approximation depending on whether or not the just-in-time (JIT) compiler is generating debugging code. The generation of this debugging information is controlled by the <see cref="T:System.Diagnostics.DebuggableAttribute" />.</summary>
	/// <returns>The offset from the start of the MSIL code for the method that is executing.</returns>
	public virtual int GetILOffset()
	{
		return 0;
	}

	/// <summary>Gets the method in which the frame is executing.</summary>
	/// <returns>The method in which the frame is executing.</returns>
	public virtual MethodBase GetMethod()
	{
		return null;
	}

	/// <summary>Gets the offset from the start of the native just-in-time (JIT)-compiled code for the method that is being executed. The generation of this debugging information is controlled by the <see cref="T:System.Diagnostics.DebuggableAttribute" /> class.</summary>
	/// <returns>The offset from the start of the JIT-compiled code for the method that is being executed.</returns>
	public virtual int GetNativeOffset()
	{
		return 0;
	}

	internal long GetMethodAddress()
	{
		return 0L;
	}

	internal uint GetMethodIndex()
	{
		return 0u;
	}

	internal string GetInternalMethodName()
	{
		return null;
	}

	/// <summary>Builds a readable representation of the stack trace.</summary>
	/// <returns>A readable representation of the stack trace.</returns>
	public override string ToString()
	{
		return null;
	}
}
