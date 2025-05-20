using System.ComponentModel;
using System.IO;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics;

/// <summary>Provides access to local and remote processes and enables you to start and stop local system processes.</summary>
[DefaultEvent("Exited")]
[DefaultProperty("StartInfo")]
[MonitoringDescription("Provides access to local and remote processes, enabling starting and stopping of local processes.")]
public class Process : Component
{
	private enum StreamReadMode
	{
		undefined = 0,
		syncMode = 1,
		asyncMode = 2
	}

	private enum State
	{
		HaveId = 1,
		IsLocal = 2,
		IsNt = 4,
		HaveProcessInfo = 8,
		Exited = 16,
		Associated = 32,
		IsWin2k = 64,
		HaveNtProcessInfo = 12
	}

	private bool haveProcessId;

	private int processId;

	private bool haveProcessHandle;

	private SafeProcessHandle m_processHandle;

	private bool isRemoteMachine;

	private string machineName;

	private int m_processAccess;

	private ProcessThreadCollection threads;

	private ProcessModuleCollection modules;

	private bool haveWorkingSetLimits;

	private bool havePriorityClass;

	private bool watchForExit;

	private bool watchingForExit;

	private EventHandler onExited;

	private bool exited;

	private int exitCode;

	private bool signaled;

	private bool haveExitTime;

	private bool raisedOnExited;

	private RegisteredWaitHandle registeredWaitHandle;

	private WaitHandle waitHandle;

	private ISynchronizeInvoke synchronizingObject;

	private StreamReader standardOutput;

	private StreamWriter standardInput;

	private StreamReader standardError;

	private bool disposed;

	private StreamReadMode outputStreamReadMode;

	private StreamReadMode errorStreamReadMode;

	private StreamReadMode inputStreamReadMode;

	internal AsyncStreamReader output;

	internal AsyncStreamReader error;

	private string process_name;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("Indicates if the process component is associated with a real process.")]
	[Browsable(false)]
	private bool Associated => false;

	/// <summary>Gets a value indicating whether the associated process has been terminated.</summary>
	/// <returns>
	///   <see langword="true" /> if the operating system process referenced by the <see cref="T:System.Diagnostics.Process" /> component has terminated; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">There is no process associated with the object.</exception>
	/// <exception cref="T:System.ComponentModel.Win32Exception">The exit code for the process could not be retrieved.</exception>
	/// <exception cref="T:System.NotSupportedException">You are trying to access the <see cref="P:System.Diagnostics.Process.HasExited" /> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer.</exception>
	[MonitoringDescription("Indicates if the associated process has been terminated.")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool HasExited => false;

	/// <summary>Gets the unique identifier for the associated process.</summary>
	/// <returns>The system-generated unique identifier of the process that is referenced by this <see cref="T:System.Diagnostics.Process" /> instance.</returns>
	/// <exception cref="T:System.InvalidOperationException">The process's <see cref="P:System.Diagnostics.Process.Id" /> property has not been set.  
	///  -or-  
	///  There is no process associated with this <see cref="T:System.Diagnostics.Process" /> object.</exception>
	/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me); set the <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> property to <see langword="false" /> to access this property on Windows 98 and Windows Me.</exception>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("The unique identifier for the process.")]
	public int Id => 0;

	/// <summary>Gets or sets the object used to marshal the event handler calls that are issued as a result of a process exit event.</summary>
	/// <returns>The <see cref="T:System.ComponentModel.ISynchronizeInvoke" /> used to marshal event handler calls that are issued as a result of an <see cref="E:System.Diagnostics.Process.Exited" /> event on the process.</returns>
	[DefaultValue(null)]
	[MonitoringDescription("The object used to marshal the event handler calls issued as a result of a Process exit.")]
	[Browsable(false)]
	public ISynchronizeInvoke SynchronizingObject => null;

	/// <summary>Gets the name of the process.</summary>
	/// <returns>The name that the system uses to identify the process to the user.</returns>
	/// <exception cref="T:System.InvalidOperationException">The process does not have an identifier, or no process is associated with the <see cref="T:System.Diagnostics.Process" />.  
	///  -or-  
	///  The associated process has exited.</exception>
	/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me); set <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> to <see langword="false" /> to access this property on Windows 98 and Windows Me.</exception>
	/// <exception cref="T:System.NotSupportedException">The process is not on this computer.</exception>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("The name of this process.")]
	public string ProcessName => null;

	private Process(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo)
	{
	}

	private void ReleaseProcessHandle(SafeProcessHandle handle)
	{
	}

	/// <summary>Release all resources used by this process.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Frees all the resources that are associated with this component.</summary>
	public void Close()
	{
	}

	private void EnsureState(State state)
	{
	}

	/// <summary>Gets a new <see cref="T:System.Diagnostics.Process" /> component and associates it with the currently active process.</summary>
	/// <returns>A new <see cref="T:System.Diagnostics.Process" /> component associated with the process resource that is running the calling application.</returns>
	public static Process GetCurrentProcess()
	{
		return null;
	}

	/// <summary>Raises the <see cref="E:System.Diagnostics.Process.Exited" /> event.</summary>
	protected void OnExited()
	{
	}

	private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited)
	{
		return null;
	}

	private SafeProcessHandle GetProcessHandle(int access)
	{
		return null;
	}

	/// <summary>Discards any information about the associated process that has been cached inside the process component.</summary>
	public void Refresh()
	{
	}

	private void StopWatchingForExit()
	{
	}

	/// <summary>Formats the process's name as a string, combined with the parent component type, if applicable.</summary>
	/// <returns>The <see cref="P:System.Diagnostics.Process.ProcessName" />, combined with the base component's <see cref="M:System.Object.ToString" /> return value.</returns>
	/// <exception cref="T:System.PlatformNotSupportedException">
	///   <see cref="M:System.Diagnostics.Process.ToString" /> is not supported on Windows 98.</exception>
	public override string ToString()
	{
		return null;
	}

	private static string ProcessName_icall(IntPtr handle)
	{
		return null;
	}

	private static string ProcessName_internal(SafeProcessHandle handle)
	{
		return null;
	}

	private void RaiseOnExited()
	{
	}
}
