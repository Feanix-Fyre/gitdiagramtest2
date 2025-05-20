using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

/// <summary>Represents errors that occur during application execution.</summary>
[Serializable]
[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public class Exception : ISerializable
{
	internal enum ExceptionMessageKind
	{
		ThreadAbort = 1,
		ThreadInterrupted = 2,
		OutOfMemory = 3
	}

	[OptionalField]
	private static object s_EDILock;

	private string _className;

	internal string _message;

	private IDictionary _data;

	private Exception _innerException;

	private string _helpURL;

	private object _stackTrace;

	private string _stackTraceString;

	private string _remoteStackTraceString;

	private int _remoteStackIndex;

	private object _dynamicMethods;

	internal int _HResult;

	private string _source;

	[OptionalField(VersionAdded = 4)]
	private SafeSerializationManager _safeSerializationManager;

	internal StackTrace[] captured_traces;

	private IntPtr[] native_trace_ips;

	private int caught_in_unmanaged;

	private const int _COMPlusExceptionCode = -532462766;

	/// <summary>Gets a message that describes the current exception.</summary>
	/// <returns>The error message that explains the reason for the exception, or an empty string ("").</returns>
	public virtual string Message => null;

	/// <summary>Gets a collection of key/value pairs that provide additional user-defined information about the exception.</summary>
	/// <returns>An object that implements the <see cref="T:System.Collections.IDictionary" /> interface and contains a collection of user-defined key/value pairs. The default is an empty collection.</returns>
	public virtual IDictionary Data => null;

	/// <summary>Gets the <see cref="T:System.Exception" /> instance that caused the current exception.</summary>
	/// <returns>An object that describes the error that caused the current exception. The <see cref="P:System.Exception.InnerException" /> property returns the same value as was passed into the <see cref="M:System.Exception.#ctor(System.String,System.Exception)" /> constructor, or <see langword="null" /> if the inner exception value was not supplied to the constructor. This property is read-only.</returns>
	public Exception InnerException => null;

	/// <summary>Gets the method that throws the current exception.</summary>
	/// <returns>The <see cref="T:System.Reflection.MethodBase" /> that threw the current exception.</returns>
	public MethodBase TargetSite => null;

	/// <summary>Gets a string representation of the immediate frames on the call stack.</summary>
	/// <returns>A string that describes the immediate frames of the call stack.</returns>
	public virtual string StackTrace => null;

	/// <summary>Gets or sets a link to the help file associated with this exception.</summary>
	/// <returns>The Uniform Resource Name (URN) or Uniform Resource Locator (URL).</returns>
	public virtual string HelpLink
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the name of the application or the object that causes the error.</summary>
	/// <returns>The name of the application or the object that causes the error.</returns>
	/// <exception cref="T:System.ArgumentException">The object must be a runtime <see cref="N:System.Reflection" /> object.</exception>
	public virtual string Source
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal string RemoteStackTrace => null;

	/// <summary>Gets or sets HRESULT, a coded numerical value that is assigned to a specific exception.</summary>
	/// <returns>The HRESULT value.</returns>
	public int HResult
	{
		get
		{
			return 0;
		}
		protected set
		{
		}
	}

	internal bool IsTransient => false;

	private void Init()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class.</summary>
	public Exception()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error message.</summary>
	/// <param name="message">The message that describes the error.</param>
	public Exception(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference (<see langword="Nothing" /> in Visual Basic) if no inner exception is specified.</param>
	public Exception(string message, Exception innerException)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class with serialized data.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is <see langword="null" /> or <see cref="P:System.Exception.HResult" /> is zero (0).</exception>
	protected Exception(SerializationInfo info, StreamingContext context)
	{
	}

	private string GetClassName()
	{
		return null;
	}

	private string GetStackTrace(bool needFileInfo)
	{
		return null;
	}

	internal void SetErrorCode(int hr)
	{
	}

	/// <summary>Creates and returns a string representation of the current exception.</summary>
	/// <returns>A string representation of the current exception.</returns>
	public override string ToString()
	{
		return null;
	}

	private string ToString(bool needFileLineInfo, bool needMessage)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (<see langword="Nothing" /> in Visual Basic).</exception>
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context)
	{
	}

	private string StripFileInfo(string stackTrace, bool isRemoteStackTrace)
	{
		return null;
	}

	internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo)
	{
	}

	/// <summary>Gets the runtime type of the current instance.</summary>
	/// <returns>A <see cref="T:System.Type" /> object that represents the exact runtime type of the current instance.</returns>
	public new Type GetType()
	{
		return null;
	}

	private static bool nIsTransient(int hr)
	{
		return false;
	}

	internal static string GetMessageFromNativeResources(ExceptionMessageKind kind)
	{
		return null;
	}

	internal Exception FixRemotingException()
	{
		return null;
	}

	internal static void ReportUnhandledException(Exception exception)
	{
	}
}
