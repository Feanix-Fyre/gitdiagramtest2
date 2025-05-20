using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Claims;

namespace System.Security.Principal;

/// <summary>Represents a Windows user.</summary>
[Serializable]
[ComVisible(true)]
public class WindowsIdentity : ClaimsIdentity, IIdentity, IDeserializationCallback, ISerializable, IDisposable
{
	private IntPtr _token;

	private string _type;

	private WindowsAccountType _account;

	private bool _authenticated;

	private string _name;

	private SerializationInfo _info;

	private static IntPtr invalidWindows;

	/// <summary>Gets the type of authentication used to identify the user.</summary>
	/// <returns>The type of authentication used to identify the user.</returns>
	/// <exception cref="T:System.UnauthorizedAccessException">Windows returned the Windows NT status code STATUS_ACCESS_DENIED.</exception>
	/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory available.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions.  
	///  -or-  
	///  The computer is not attached to a Windows 2003 or later domain.  
	///  -or-  
	///  The computer is not running Windows 2003 or later.  
	///  -or-  
	///  The user is not a member of the domain the computer is attached to.</exception>
	public sealed override string AuthenticationType => null;

	/// <summary>Gets the user's Windows logon name.</summary>
	/// <returns>The Windows logon name of the user on whose behalf the code is being run.</returns>
	public override string Name => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsIdentity" /> class for the user represented by the specified Windows account token, the specified authentication type, the specified Windows account type, and the specified authentication status.</summary>
	/// <param name="userToken">The account token for the user on whose behalf the code is running.</param>
	/// <param name="type">(Informational use only.) The type of authentication used to identify the user.</param>
	/// <param name="acctType">One of the enumeration values.</param>
	/// <param name="isAuthenticated">
	///   <see langword="true" /> to indicate that the user is authenticated; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="userToken" /> is 0.  
	/// -or-  
	/// <paramref name="userToken" /> is duplicated and invalid for impersonation.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions.  
	///  -or-  
	///  A Win32 error occurred.</exception>
	public WindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsIdentity" /> class for the user represented by information in a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> stream.</summary>
	/// <param name="info">The object containing the account information for the user.</param>
	/// <param name="context">An object that indicates the stream characteristics.</param>
	/// <exception cref="T:System.NotSupportedException">A <see cref="T:System.Security.Principal.WindowsIdentity" /> cannot be serialized across processes.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions.  
	///  -or-  
	///  A Win32 error occurred.</exception>
	public WindowsIdentity(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Releases all resources used by the <see cref="T:System.Security.Principal.WindowsIdentity" />.</summary>
	[ComVisible(false)]
	public void Dispose()
	{
	}

	/// <summary>Returns a <see cref="T:System.Security.Principal.WindowsIdentity" /> object that represents the current Windows user.</summary>
	/// <returns>An object that represents the current user.</returns>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions.</exception>
	public static WindowsIdentity GetCurrent()
	{
		return null;
	}

	/// <summary>Impersonates the user represented by the <see cref="T:System.Security.Principal.WindowsIdentity" /> object.</summary>
	/// <returns>An object that represents the Windows user prior to impersonation; this can be used to revert to the original user's context.</returns>
	/// <exception cref="T:System.InvalidOperationException">An anonymous identity attempted to perform an impersonation.</exception>
	/// <exception cref="T:System.Security.SecurityException">A Win32 error occurred.</exception>
	public virtual WindowsImpersonationContext Impersonate()
	{
		return null;
	}

	/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and is called back by the deserialization event when deserialization is complete.</summary>
	/// <param name="sender">The source of the deserialization event.</param>
	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the logical context information needed to recreate an instance of this execution context.</summary>
	/// <param name="info">An object containing the information required to serialize the <see cref="T:System.Collections.Hashtable" />.</param>
	/// <param name="context">An object containing the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Hashtable" />.</param>
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	private void SetToken(IntPtr token)
	{
	}

	internal static IntPtr GetCurrentToken()
	{
		return (IntPtr)0;
	}

	private static string GetTokenName(IntPtr token)
	{
		return null;
	}
}
