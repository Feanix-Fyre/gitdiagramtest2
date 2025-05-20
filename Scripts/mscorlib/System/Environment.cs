using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System;

/// <summary>Provides information about, and means to manipulate, the current environment and platform. This class cannot be inherited.</summary>
[ComVisible(true)]
public static class Environment
{
	/// <summary>Specifies enumerated constants used to retrieve directory paths to system special folders.</summary>
	[ComVisible(true)]
	public enum SpecialFolder
	{
		/// <summary>The My Documents folder.</summary>
		MyDocuments = 5,
		/// <summary>The logical Desktop rather than the physical file system location.</summary>
		Desktop = 0,
		/// <summary>The My Computer folder.</summary>
		MyComputer = 17,
		/// <summary>The directory that contains the user's program groups.</summary>
		Programs = 2,
		/// <summary>The directory that serves as a common repository for documents.</summary>
		Personal = 5,
		/// <summary>The directory that serves as a common repository for the user's favorite items.</summary>
		Favorites = 6,
		/// <summary>The directory that corresponds to the user's Startup program group.</summary>
		Startup = 7,
		/// <summary>The directory that contains the user's most recently used documents.</summary>
		Recent = 8,
		/// <summary>The directory that contains the Send To menu items.</summary>
		SendTo = 9,
		/// <summary>The directory that contains the Start menu items.</summary>
		StartMenu = 11,
		/// <summary>The My Music folder.</summary>
		MyMusic = 13,
		/// <summary>The directory used to physically store file objects on the desktop.</summary>
		DesktopDirectory = 16,
		/// <summary>The directory that serves as a common repository for document templates.</summary>
		Templates = 21,
		/// <summary>The directory that serves as a common repository for application-specific data for the current roaming user.</summary>
		ApplicationData = 26,
		/// <summary>The directory that serves as a common repository for application-specific data that is used by the current, non-roaming user.</summary>
		LocalApplicationData = 28,
		/// <summary>The directory that serves as a common repository for temporary Internet files.</summary>
		InternetCache = 32,
		/// <summary>The directory that serves as a common repository for Internet cookies.</summary>
		Cookies = 33,
		/// <summary>The directory that serves as a common repository for Internet history items.</summary>
		History = 34,
		/// <summary>The directory that serves as a common repository for application-specific data that is used by all users.</summary>
		CommonApplicationData = 35,
		/// <summary>The System directory.</summary>
		System = 37,
		/// <summary>The program files directory.  
		///  On a non-x86 system, passing <see cref="F:System.Environment.SpecialFolder.ProgramFiles" /> to the <see cref="M:System.Environment.GetFolderPath(System.Environment.SpecialFolder)" /> method returns the path for non-x86 programs. To get the x86 program files directory on a non-x86 system, use the <see cref="F:System.Environment.SpecialFolder.ProgramFilesX86" /> member.</summary>
		ProgramFiles = 38,
		/// <summary>The My Pictures folder.</summary>
		MyPictures = 39,
		/// <summary>The directory for components that are shared across applications.  
		///  To get the x86 common program files directory on a non-x86 system, use the <see cref="F:System.Environment.SpecialFolder.ProgramFilesX86" /> member.</summary>
		CommonProgramFiles = 43,
		/// <summary>The file system directory that serves as a repository for videos that belong to a user.  Added in the .NET Framework 4.</summary>
		MyVideos = 14,
		/// <summary>A file system directory that contains the link objects that may exist in the My Network Places virtual folder. Added in the .NET Framework 4.</summary>
		NetworkShortcuts = 19,
		/// <summary>A virtual folder that contains fonts. Added in the .NET Framework 4.</summary>
		Fonts = 20,
		/// <summary>The file system directory that contains the programs and folders that appear on the Start menu for all users. This special folder is valid only for Windows NT systems. Added in the .NET Framework 4.</summary>
		CommonStartMenu = 22,
		/// <summary>A folder for components that are shared across applications. This special folder is valid only for Windows NT, Windows 2000, and Windows XP systems. Added in the .NET Framework 4.</summary>
		CommonPrograms = 23,
		/// <summary>The file system directory that contains the programs that appear in the Startup folder for all users. This special folder is valid only for Windows NT systems. Added in the .NET Framework 4.</summary>
		CommonStartup = 24,
		/// <summary>The file system directory that contains files and folders that appear on the desktop for all users. This special folder is valid only for Windows NT systems. Added in the .NET Framework 4.</summary>
		CommonDesktopDirectory = 25,
		/// <summary>The file system directory that contains the link objects that can exist in the Printers virtual folder. Added in the .NET Framework 4.</summary>
		PrinterShortcuts = 27,
		/// <summary>The Windows directory or SYSROOT. This corresponds to the %windir% or %SYSTEMROOT% environment variables. Added in the .NET Framework 4.</summary>
		Windows = 36,
		/// <summary>The user's profile folder. Applications should not create files or folders at this level; they should put their data under the locations referred to by <see cref="F:System.Environment.SpecialFolder.ApplicationData" />. Added in the .NET Framework 4.</summary>
		UserProfile = 40,
		/// <summary>The Windows System folder. Added in the .NET Framework 4.</summary>
		SystemX86 = 41,
		/// <summary>The x86 Program Files folder. Added in the .NET Framework 4.</summary>
		ProgramFilesX86 = 42,
		/// <summary>The Program Files folder. Added in the .NET Framework 4.</summary>
		CommonProgramFilesX86 = 44,
		/// <summary>The file system directory that contains the templates that are available to all users. This special folder is valid only for Windows NT systems.  Added in the .NET Framework 4.</summary>
		CommonTemplates = 45,
		/// <summary>The file system directory that contains documents that are common to all users. This special folder is valid for Windows NT systems, Windows 95, and Windows 98 systems with Shfolder.dll installed. Added in the .NET Framework 4.</summary>
		CommonDocuments = 46,
		/// <summary>The file system directory that contains administrative tools for all users of the computer. Added in the .NET Framework 4.</summary>
		CommonAdminTools = 47,
		/// <summary>The file system directory that is used to store administrative tools for an individual user. The Microsoft Management Console (MMC) will save customized consoles to this directory, and it will roam with the user. Added in the .NET Framework 4.</summary>
		AdminTools = 48,
		/// <summary>The file system directory that serves as a repository for music files common to all users. Added in the .NET Framework 4.</summary>
		CommonMusic = 53,
		/// <summary>The file system directory that serves as a repository for image files common to all users. Added in the .NET Framework 4.</summary>
		CommonPictures = 54,
		/// <summary>The file system directory that serves as a repository for video files common to all users. Added in the .NET Framework 4.</summary>
		CommonVideos = 55,
		/// <summary>The file system directory that contains resource data. Added in the .NET Framework 4.</summary>
		Resources = 56,
		/// <summary>The file system directory that contains localized resource data. Added in the .NET Framework 4.</summary>
		LocalizedResources = 57,
		/// <summary>This value is recognized in Windows Vista for backward compatibility, but the special folder itself is no longer used. Added in the .NET Framework 4.</summary>
		CommonOemLinks = 58,
		/// <summary>The file system directory that acts as a staging area for files waiting to be written to a CD. Added in the .NET Framework 4.</summary>
		CDBurning = 59
	}

	/// <summary>Specifies options to use for getting the path to a special folder.</summary>
	public enum SpecialFolderOption
	{
		/// <summary>The path to the folder is verified. If the folder exists, the path is returned. If the folder does not exist, an empty string is returned. This is the default behavior.</summary>
		None = 0,
		/// <summary>The path to the folder is returned without verifying whether the path exists. If the folder is located on a network, specifying this option can reduce lag time.</summary>
		DoNotVerify = 0x4000,
		/// <summary>The path to the folder is created if it does not already exist.</summary>
		Create = 0x8000
	}

	private const string mono_corlib_version = "1A5E0066-58DC-428A-B21C-0AD6CDAE2789";

	private static string nl;

	private static OperatingSystem os;

	/// <summary>Gets or sets the fully qualified path of the current working directory.</summary>
	/// <returns>A string containing a directory path.</returns>
	/// <exception cref="T:System.ArgumentException">Attempted to set to an empty string ("").</exception>
	/// <exception cref="T:System.ArgumentNullException">Attempted to set to <see langword="null." /></exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">Attempted to set a local path that cannot be found.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the appropriate permission.</exception>
	public static string CurrentDirectory => null;

	/// <summary>Gets a unique identifier for the current managed thread.</summary>
	/// <returns>An integer that represents a unique identifier for this managed thread.</returns>
	public static int CurrentManagedThreadId => 0;

	/// <summary>Gets a value that indicates whether the current application domain is being unloaded or the common language runtime (CLR) is shutting down.</summary>
	/// <returns>
	///   <see langword="true" /> if the current application domain is being unloaded or the CLR is shutting down; otherwise, <see langword="false" />.</returns>
	public static bool HasShutdownStarted => false;

	/// <summary>Gets the NetBIOS name of this local computer.</summary>
	/// <returns>A string containing the name of this computer.</returns>
	/// <exception cref="T:System.InvalidOperationException">The name of this computer cannot be obtained.</exception>
	public static string MachineName => null;

	/// <summary>Gets the newline string defined for this environment.</summary>
	/// <returns>A string containing "\r\n" for non-Unix platforms, or a string containing "\n" for Unix platforms.</returns>
	public static string NewLine => null;

	internal static PlatformID Platform
	{
		[CompilerGenerated]
		get
		{
			return default(PlatformID);
		}
	}

	/// <summary>Gets an <see cref="T:System.OperatingSystem" /> object that contains the current platform identifier and version number.</summary>
	/// <returns>An object that contains the platform identifier and version number.</returns>
	/// <exception cref="T:System.InvalidOperationException">This property was unable to obtain the system version.  
	///  -or-  
	///  The obtained platform identifier is not a member of <see cref="T:System.PlatformID" /></exception>
	public static OperatingSystem OSVersion => null;

	/// <summary>Gets current stack trace information.</summary>
	/// <returns>A string containing stack trace information. This value can be <see cref="F:System.String.Empty" />.</returns>
	public static string StackTrace => null;

	/// <summary>Gets the fully qualified path of the system directory.</summary>
	/// <returns>A string containing a directory path.</returns>
	public static string SystemDirectory => null;

	/// <summary>Gets the number of milliseconds elapsed since the system started.</summary>
	/// <returns>A 32-bit signed integer containing the amount of time in milliseconds that has passed since the last time the computer was started.</returns>
	public static int TickCount => 0;

	/// <summary>Gets the network domain name associated with the current user.</summary>
	/// <returns>The network domain name associated with the current user.</returns>
	/// <exception cref="T:System.PlatformNotSupportedException">The operating system does not support retrieving the network domain name.</exception>
	/// <exception cref="T:System.InvalidOperationException">The network domain name cannot be retrieved.</exception>
	public static string UserDomainName => null;

	/// <summary>Gets a value indicating whether the current process is running in user interactive mode.</summary>
	/// <returns>
	///   <see langword="true" /> if the current process is running in user interactive mode; otherwise, <see langword="false" />.</returns>
	[MonoTODO("Currently always returns false, regardless of interactive state")]
	public static bool UserInteractive => false;

	/// <summary>Gets the user name of the person who is currently logged on to the operating system.</summary>
	/// <returns>The user name of the person who is logged on to the operating system.</returns>
	public static string UserName => null;

	/// <summary>Determines whether the current operating system is a 64-bit operating system.</summary>
	/// <returns>
	///   <see langword="true" /> if the operating system is 64-bit; otherwise, <see langword="false" />.</returns>
	public static bool Is64BitOperatingSystem => false;

	/// <summary>Determines whether the current process is a 64-bit process.</summary>
	/// <returns>
	///   <see langword="true" /> if the process is 64-bit; otherwise, <see langword="false" />.</returns>
	public static bool Is64BitProcess => false;

	/// <summary>Gets the number of processors on the current machine.</summary>
	/// <returns>The 32-bit signed integer that specifies the number of processors on the current machine. There is no default. If the current machine contains multiple processor groups, this property returns the number of logical processors that are available for use by the common language runtime (CLR).</returns>
	public static int ProcessorCount => 0;

	internal static bool IsRunningOnWindows => false;

	internal static bool IsUnix => false;

	internal static string GetResourceString(string key)
	{
		return null;
	}

	internal static string GetResourceString(string key, params object[] values)
	{
		return null;
	}

	internal static string GetResourceStringEncodingName(int codePage)
	{
		return null;
	}

	private static string GetNewLine()
	{
		return null;
	}

	internal static string GetOSVersionString()
	{
		return null;
	}

	internal static Version CreateVersionFromString(string info)
	{
		return null;
	}

	/// <summary>Terminates this process and returns an exit code to the operating system.</summary>
	/// <param name="exitCode">The exit code to return to the operating system. Use 0 (zero) to indicate that the process completed successfully.</param>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have sufficient security permission to perform this function.</exception>
	public static void Exit(int exitCode)
	{
	}

	/// <summary>Replaces the name of each environment variable embedded in the specified string with the string equivalent of the value of the variable, then returns the resulting string.</summary>
	/// <param name="name">A string containing the names of zero or more environment variables. Each environment variable is quoted with the percent sign character (%).</param>
	/// <returns>A string with each environment variable replaced by its value.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	public static string ExpandEnvironmentVariables(string name)
	{
		return null;
	}

	/// <summary>Returns a string array containing the command-line arguments for the current process.</summary>
	/// <returns>An array of string where each element contains a command-line argument. The first element is the executable file name, and the following zero or more elements contain the remaining command-line arguments.</returns>
	/// <exception cref="T:System.NotSupportedException">The system does not support command-line arguments.</exception>
	public static string[] GetCommandLineArgs()
	{
		return null;
	}

	internal static string internalGetEnvironmentVariable_native(IntPtr variable)
	{
		return null;
	}

	internal static string internalGetEnvironmentVariable(string variable)
	{
		return null;
	}

	/// <summary>Retrieves the value of an environment variable from the current process.</summary>
	/// <param name="variable">The name of the environment variable.</param>
	/// <returns>The value of the environment variable specified by <paramref name="variable" />, or <see langword="null" /> if the environment variable is not found.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="variable" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission to perform this operation.</exception>
	public static string GetEnvironmentVariable(string variable)
	{
		return null;
	}

	private static Hashtable GetEnvironmentVariablesNoCase()
	{
		return null;
	}

	/// <summary>Gets the path to the system special folder that is identified by the specified enumeration.</summary>
	/// <param name="folder">One of enumeration values that identifies a system special folder.</param>
	/// <returns>The path to the specified system special folder, if that folder physically exists on your computer; otherwise, an empty string ("").  
	///  A folder will not physically exist if the operating system did not create it, the existing folder was deleted, or the folder is a virtual directory, such as My Computer, which does not correspond to a physical path.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="folder" /> is not a member of <see cref="T:System.Environment.SpecialFolder" />.</exception>
	/// <exception cref="T:System.PlatformNotSupportedException">The current platform is not supported.</exception>
	public static string GetFolderPath(SpecialFolder folder)
	{
		return null;
	}

	private static string GetWindowsFolderPath(int folder)
	{
		return null;
	}

	/// <summary>Gets the path to the system special folder that is identified by the specified enumeration, and uses a specified option for accessing special folders.</summary>
	/// <param name="folder">One of the enumeration values that identifies a system special folder.</param>
	/// <param name="option">One of the enumeration values taht specifies options to use for accessing a special folder.</param>
	/// <returns>The path to the specified system special folder, if that folder physically exists on your computer; otherwise, an empty string ("").  
	///  A folder will not physically exist if the operating system did not create it, the existing folder was deleted, or the folder is a virtual directory, such as My Computer, which does not correspond to a physical path.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="folder" /> is not a member of <see cref="T:System.Environment.SpecialFolder" />.
	/// -or-
	/// <paramref name="options" /> is not a member of <see cref="T:System.Environment.SpecialFolderOption" />.</exception>
	/// <exception cref="T:System.PlatformNotSupportedException">The current platform is not supported.</exception>
	public static string GetFolderPath(SpecialFolder folder, SpecialFolderOption option)
	{
		return null;
	}

	private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback)
	{
		return null;
	}

	internal static string UnixGetFolderPath(SpecialFolder folder, SpecialFolderOption option)
	{
		return null;
	}

	/// <summary>Immediately terminates a process after writing a message to the Windows Application event log, and then includes the message in error reporting to Microsoft.</summary>
	/// <param name="message">A message that explains why the process was terminated, or <see langword="null" /> if no explanation is provided.</param>
	public static void FailFast(string message)
	{
	}

	/// <summary>Immediately terminates a process after writing a message to the Windows Application event log, and then includes the message and exception information in error reporting to Microsoft.</summary>
	/// <param name="message">A message that explains why the process was terminated, or <see langword="null" /> if no explanation is provided.</param>
	/// <param name="exception">An exception that represents the error that caused the termination. This is typically the exception in a <see langword="catch" /> block.</param>
	public static void FailFast(string message, Exception exception)
	{
	}

	internal static void FailFast(string message, Exception exception, string errorSource)
	{
	}

	private static bool GetIs64BitOperatingSystem()
	{
		return false;
	}

	private static string[] GetEnvironmentVariableNames()
	{
		return null;
	}

	internal static string GetMachineConfigPath()
	{
		return null;
	}

	internal static string internalGetHome()
	{
		return null;
	}

	internal static int GetPageSize()
	{
		return 0;
	}

	internal static string GetStackTrace(Exception e, bool needFileInfo)
	{
		return null;
	}
}
