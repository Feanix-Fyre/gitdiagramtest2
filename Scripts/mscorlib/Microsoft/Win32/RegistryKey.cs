using System;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Win32;

/// <summary>Represents a key-level node in the Windows registry. This class is a registry encapsulation.</summary>
public sealed class RegistryKey : MarshalByRefObject, IDisposable
{
	[Flags]
	private enum StateFlags
	{
		Dirty = 1,
		SystemKey = 2,
		WriteAccess = 4,
		PerfData = 8
	}

	internal static readonly IntPtr HKEY_CLASSES_ROOT;

	internal static readonly IntPtr HKEY_CURRENT_USER;

	internal static readonly IntPtr HKEY_LOCAL_MACHINE;

	internal static readonly IntPtr HKEY_USERS;

	internal static readonly IntPtr HKEY_PERFORMANCE_DATA;

	internal static readonly IntPtr HKEY_CURRENT_CONFIG;

	internal static readonly IntPtr HKEY_DYN_DATA;

	private static readonly string[] s_hkeyNames;

	private SafeRegistryHandle _hkey;

	private string _keyName;

	private bool _remoteKey;

	private StateFlags _state;

	private RegistryKeyPermissionCheck _checkMode;

	private RegistryView _regView;

	private void ClosePerfDataKey()
	{
	}

	private static RegistryKey OpenBaseKeyCore(RegistryHive hKeyHive, RegistryView view)
	{
		return null;
	}

	private RegistryKey InternalOpenSubKeyCore(string name, bool writable, bool throwOnPermissionFailure)
	{
		return null;
	}

	private int InternalSubKeyCountCore()
	{
		return 0;
	}

	private string[] InternalGetSubKeyNamesCore(int subkeys)
	{
		return null;
	}

	private object InternalGetValueCore(string name, object defaultValue, bool doNotExpand)
	{
		return null;
	}

	private void Win32Error(int errorCode, string str)
	{
	}

	private static int GetRegistryKeyAccess(bool isWritable)
	{
		return 0;
	}

	private RegistryKey(SafeRegistryHandle hkey, bool writable, bool systemkey, bool remoteKey, bool isPerfData, RegistryView view)
	{
	}

	/// <summary>Releases all resources used by the current instance of the <see cref="T:Microsoft.Win32.RegistryKey" /> class.</summary>
	public void Dispose()
	{
	}

	/// <summary>Opens a new <see cref="T:Microsoft.Win32.RegistryKey" /> that represents the requested key on the local machine with the specified view.</summary>
	/// <param name="hKey">The HKEY to open.</param>
	/// <param name="view">The registry view to use.</param>
	/// <returns>The requested registry key.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="hKey" /> or <paramref name="view" /> is invalid.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception>
	/// <exception cref="T:System.Security.SecurityException">The user does not have the permissions required to perform this action.</exception>
	public static RegistryKey OpenBaseKey(RegistryHive hKey, RegistryView view)
	{
		return null;
	}

	/// <summary>Retrieves a specified subkey, and specifies whether write access is to be applied to the key.</summary>
	/// <param name="name">Name or path of the subkey to open.</param>
	/// <param name="writable">Set to <see langword="true" /> if you need write access to the key.</param>
	/// <returns>The subkey requested, or <see langword="null" /> if the operation failed.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> is closed (closed keys cannot be accessed).</exception>
	/// <exception cref="T:System.Security.SecurityException">The user does not have the permissions required to access the registry key in the specified mode.</exception>
	public RegistryKey OpenSubKey(string name, bool writable)
	{
		return null;
	}

	private int InternalSubKeyCount()
	{
		return 0;
	}

	/// <summary>Retrieves an array of strings that contains all the subkey names.</summary>
	/// <returns>An array of strings that contains the names of the subkeys for the current key.</returns>
	/// <exception cref="T:System.Security.SecurityException">The user does not have the permissions required to read from the key.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> being manipulated is closed (closed keys cannot be accessed).</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception>
	/// <exception cref="T:System.IO.IOException">A system error occurred, for example the current key has been deleted.</exception>
	public string[] GetSubKeyNames()
	{
		return null;
	}

	private string[] InternalGetSubKeyNames()
	{
		return null;
	}

	/// <summary>Retrieves the value associated with the specified name and retrieval options. If the name is not found, returns the default value that you provide.</summary>
	/// <param name="name">The name of the value to retrieve. This string is not case-sensitive.</param>
	/// <param name="defaultValue">The value to return if <paramref name="name" /> does not exist.</param>
	/// <param name="options">One of the enumeration values that specifies optional processing of the retrieved value.</param>
	/// <returns>The value associated with <paramref name="name" />, processed according to the specified <paramref name="options" />, or <paramref name="defaultValue" /> if <paramref name="name" /> is not found.</returns>
	/// <exception cref="T:System.Security.SecurityException">The user does not have the permissions required to read from the registry key.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> that contains the specified value is closed (closed keys cannot be accessed).</exception>
	/// <exception cref="T:System.IO.IOException">The <see cref="T:Microsoft.Win32.RegistryKey" /> that contains the specified value has been marked for deletion.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="options" /> is not a valid <see cref="T:Microsoft.Win32.RegistryValueOptions" /> value; for example, an invalid value is cast to <see cref="T:Microsoft.Win32.RegistryValueOptions" />.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception>
	public object GetValue(string name, object defaultValue, RegistryValueOptions options)
	{
		return null;
	}

	private object InternalGetValue(string name, object defaultValue, bool doNotExpand, bool checkSecurity)
	{
		return null;
	}

	/// <summary>Retrieves a string representation of this key.</summary>
	/// <returns>A string representing the key. If the specified key is invalid (cannot be found) then <see langword="null" /> is returned.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> being accessed is closed (closed keys cannot be accessed).</exception>
	public override string ToString()
	{
		return null;
	}

	private static string FixupName(string name)
	{
		return null;
	}

	private static void FixupPath(StringBuilder path)
	{
	}

	private void EnsureNotDisposed()
	{
	}

	private RegistryKeyPermissionCheck GetSubKeyPermissionCheck(bool subkeyWritable)
	{
		return default(RegistryKeyPermissionCheck);
	}

	private static void ValidateKeyName(string name)
	{
	}

	private static void ValidateKeyView(RegistryView view)
	{
	}

	private bool IsSystemKey()
	{
		return false;
	}

	private bool IsPerfDataKey()
	{
		return false;
	}
}
