using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Threading;

namespace System;

/// <summary>Represents an application domain, which is an isolated environment where applications execute. This class cannot be inherited.</summary>
[StructLayout((LayoutKind)0)]
[ClassInterface(ClassInterfaceType.None)]
[ComVisible(true)]
public sealed class AppDomain : MarshalByRefObject
{
	private IntPtr _mono_app_domain;

	private static string _process_guid;

	[ThreadStatic]
	private static Dictionary<string, object> type_resolve_in_progress;

	[ThreadStatic]
	private static Dictionary<string, object> assembly_resolve_in_progress;

	[ThreadStatic]
	private static Dictionary<string, object> assembly_resolve_in_progress_refonly;

	private object _evidence;

	private object _granted;

	private int _principalPolicy;

	private static AppDomain default_domain;

	[CompilerGenerated]
	private AssemblyLoadEventHandler AssemblyLoad;

	[CompilerGenerated]
	private ResolveEventHandler ResourceResolve;

	[CompilerGenerated]
	private ResolveEventHandler TypeResolve;

	[CompilerGenerated]
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException;

	private object _domain_manager;

	[CompilerGenerated]
	private ResolveEventHandler ReflectionOnlyAssemblyResolve;

	private object _activation;

	private object _applicationIdentity;

	private List<string> compatibility_switch;

	/// <summary>Gets the current application domain for the current <see cref="T:System.Threading.Thread" />.</summary>
	/// <returns>The current application domain.</returns>
	public static AppDomain CurrentDomain => null;

	internal static AppDomain DefaultDomain => null;

	/// <summary>Gets a value that indicates whether the current application domain has a set of permissions that is granted to all assemblies that are loaded into the application domain.</summary>
	/// <returns>
	///   <see langword="true" /> if the current application domain has a homogenous set of permissions; otherwise, <see langword="false" />.</returns>
	[MonoTODO]
	public bool IsHomogenous => false;

	/// <summary>Gets a value that indicates whether assemblies that are loaded into the current application domain execute with full trust.</summary>
	/// <returns>
	///   <see langword="true" /> if assemblies that are loaded into the current application domain execute with full trust; otherwise, <see langword="false" />.</returns>
	[MonoTODO]
	public bool IsFullyTrusted => false;

	/// <summary>Occurs when the resolution of an assembly fails.</summary>
	public event ResolveEventHandler AssemblyResolve
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	/// <summary>Occurs when an <see cref="T:System.AppDomain" /> is about to be unloaded.</summary>
	public event EventHandler DomainUnload
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	/// <summary>Occurs when the default application domain's parent process exits.</summary>
	public event EventHandler ProcessExit
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	/// <summary>Occurs when an exception is not caught.</summary>
	public event UnhandledExceptionEventHandler UnhandledException
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Intrinsic]
	internal static bool IsAppXModel()
	{
		return false;
	}

	private AppDomain()
	{
	}

	private string getFriendlyName()
	{
		return null;
	}

	private static AppDomain getCurDomain()
	{
		return null;
	}

	private static AppDomain getRootDomain()
	{
		return null;
	}

	private Assembly[] GetAssemblies(bool refOnly)
	{
		return null;
	}

	/// <summary>Gets the assemblies that have been loaded into the execution context of this application domain.</summary>
	/// <returns>An array of assemblies in this application domain.</returns>
	/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain.</exception>
	public Assembly[] GetAssemblies()
	{
		return null;
	}

	/// <summary>Gets the value stored in the current application domain for the specified name.</summary>
	/// <param name="name">The name of a predefined application domain property, or the name of an application domain property you have defined.</param>
	/// <returns>The value of the <paramref name="name" /> property, or <see langword="null" /> if the property does not exist.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain.</exception>
	public object GetData(string name)
	{
		return null;
	}

	/// <summary>Gives the <see cref="T:System.AppDomain" /> an infinite lifetime by preventing a lease from being created.</summary>
	/// <returns>Always <see langword="null" />.</returns>
	/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain.</exception>
	public override object InitializeLifetimeService()
	{
		return null;
	}

	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly, ref StackCrawlMark stackMark)
	{
		return null;
	}

	internal Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError, ref StackCrawlMark stackMark)
	{
		return null;
	}

	/// <summary>Loads an <see cref="T:System.Reflection.Assembly" /> given its display name.</summary>
	/// <param name="assemblyString">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param>
	/// <returns>The loaded assembly.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="assemblyString" /> is <see langword="null" /></exception>
	/// <exception cref="T:System.IO.FileNotFoundException">
	///   <paramref name="assemblyString" /> is not found.</exception>
	/// <exception cref="T:System.BadImageFormatException">
	///   <paramref name="assemblyString" /> is not a valid assembly.  
	/// -or-  
	/// Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyString" /> was compiled with a later version.</exception>
	/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain.</exception>
	/// <exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Assembly Load(string assemblyString)
	{
		return null;
	}

	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly, ref StackCrawlMark stackMark)
	{
		return null;
	}

	private static AppDomain InternalSetDomainByID(int domain_id)
	{
		return null;
	}

	private static AppDomain InternalSetDomain(AppDomain context)
	{
		return null;
	}

	internal static void InternalPushDomainRef(AppDomain domain)
	{
	}

	internal static void InternalPushDomainRefByID(int domain_id)
	{
	}

	internal static void InternalPopDomainRef()
	{
	}

	internal static Context InternalSetContext(Context context)
	{
		return null;
	}

	internal static Context InternalGetContext()
	{
		return null;
	}

	internal static Context InternalGetDefaultContext()
	{
		return null;
	}

	internal static string InternalGetProcessGuid(string newguid)
	{
		return null;
	}

	internal static object InvokeInDomain(AppDomain domain, MethodInfo method, object obj, object[] args)
	{
		return null;
	}

	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args)
	{
		return null;
	}

	internal static string GetProcessGuid()
	{
		return null;
	}

	private static bool InternalIsFinalizingForUnload(int domain_id)
	{
		return false;
	}

	/// <summary>Indicates whether this application domain is unloading, and the objects it contains are being finalized by the common language runtime.</summary>
	/// <returns>
	///   <see langword="true" /> if this application domain is unloading and the common language runtime has started invoking finalizers; otherwise, <see langword="false" />.</returns>
	public bool IsFinalizingForUnload()
	{
		return false;
	}

	private int getDomainID()
	{
		return 0;
	}

	/// <summary>Obtains a string representation that includes the friendly name of the application domain and any context policies.</summary>
	/// <returns>A string formed by concatenating the literal string "Name:", the friendly name of the application domain, and either string representations of the context policies or the string "There are no context policies."</returns>
	/// <exception cref="T:System.AppDomainUnloadedException">The application domain represented by the current <see cref="T:System.AppDomain" /> has been unloaded.</exception>
	public override string ToString()
	{
		return null;
	}

	private void DoAssemblyLoad(Assembly assembly)
	{
	}

	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly)
	{
		return null;
	}

	internal Assembly DoTypeResolve(string name)
	{
		return null;
	}

	internal Assembly DoResourceResolve(string name, Assembly requesting)
	{
		return null;
	}

	private void DoDomainUnload()
	{
	}

	internal byte[] GetMarshalledDomainObjRef()
	{
		return null;
	}

	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm)
	{
		arrResponse = null;
		cadMrm = null;
	}

	/// <summary>Returns a value that indicates whether the application domain is the default application domain for the process.</summary>
	/// <returns>
	///   <see langword="true" /> if the current <see cref="T:System.AppDomain" /> object represents the default application domain for the process; otherwise, <see langword="false" />.</returns>
	public bool IsDefaultAppDomain()
	{
		return false;
	}
}
