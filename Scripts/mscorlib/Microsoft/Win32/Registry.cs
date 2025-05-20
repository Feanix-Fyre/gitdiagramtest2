using System;

namespace Microsoft.Win32;

/// <summary>Provides <see cref="T:Microsoft.Win32.RegistryKey" /> objects that represent the root keys in the Windows registry, and <see langword="static" /> methods to access key/value pairs.</summary>
public static class Registry
{
	/// <summary>Contains information about the current user preferences. This field reads the Windows registry base key HKEY_CURRENT_USER.</summary>
	public static readonly RegistryKey CurrentUser;

	/// <summary>Contains the configuration data for the local machine. This field reads the Windows registry base key HKEY_LOCAL_MACHINE.</summary>
	public static readonly RegistryKey LocalMachine;

	/// <summary>Defines the types (or classes) of documents and the properties associated with those types. This field reads the Windows registry base key HKEY_CLASSES_ROOT.</summary>
	public static readonly RegistryKey ClassesRoot;

	/// <summary>Contains information about the default user configuration. This field reads the Windows registry base key HKEY_USERS.</summary>
	public static readonly RegistryKey Users;

	/// <summary>Contains performance information for software components. This field reads the Windows registry base key HKEY_PERFORMANCE_DATA.</summary>
	public static readonly RegistryKey PerformanceData;

	/// <summary>Contains configuration information pertaining to the hardware that is not specific to the user. This field reads the Windows registry base key HKEY_CURRENT_CONFIG.</summary>
	public static readonly RegistryKey CurrentConfig;

	/// <summary>Contains dynamic registry data. This field reads the Windows registry base key HKEY_DYN_DATA.</summary>
	/// <exception cref="T:System.ObjectDisposedException">The operating system does not support dynamic data; that is, it is not Windows 98, Windows 98 Second Edition, or Windows Millennium Edition (Windows Me).</exception>
	[Obsolete("Use PerformanceData instead")]
	public static readonly RegistryKey DynData;
}
