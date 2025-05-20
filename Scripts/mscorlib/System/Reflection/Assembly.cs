using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Threading;

namespace System.Reflection;

/// <summary>Represents an assembly, which is a reusable, versionable, and self-describing building block of a common language runtime application.</summary>
[Serializable]
[StructLayout((LayoutKind)0)]
[ComDefaultInterface(typeof(_Assembly))]
[ComVisible(true)]
[ClassInterface(ClassInterfaceType.None)]
public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly
{
	internal class ResolveEventHolder
	{
	}

	/// <summary>Gets the location of the assembly as specified originally, for example, in an <see cref="T:System.Reflection.AssemblyName" /> object.</summary>
	/// <returns>The location of the assembly as specified originally.</returns>
	public virtual string CodeBase => null;

	/// <summary>Gets the display name of the assembly.</summary>
	/// <returns>The display name of the assembly.</returns>
	public virtual string FullName => null;

	internal virtual IntPtr MonoAssembly => (IntPtr)0;

	/// <summary>Gets the full path or UNC location of the loaded file that contains the manifest.</summary>
	/// <returns>The location of the loaded file that contains the manifest. If the loaded file was shadow-copied, the location is that of the file after being shadow-copied. If the assembly is loaded from a byte array, such as when using the <see cref="M:System.Reflection.Assembly.Load(System.Byte[])" /> method overload, the value returned is an empty string ("").</returns>
	/// <exception cref="T:System.NotSupportedException">The current assembly is a dynamic assembly, represented by an <see cref="T:System.Reflection.Emit.AssemblyBuilder" /> object.</exception>
	public virtual string Location => null;

	/// <summary>Gets a <see cref="T:System.Boolean" /> value indicating whether this assembly was loaded into the reflection-only context.</summary>
	/// <returns>
	///   <see langword="true" /> if the assembly was loaded into the reflection-only context, rather than the execution context; otherwise, <see langword="false" />.</returns>
	[ComVisible(false)]
	public virtual bool ReflectionOnly => false;

	/// <summary>Gets a value that indicates whether the current assembly is loaded with full trust.</summary>
	/// <returns>
	///   <see langword="true" /> if the current assembly is loaded with full trust; otherwise, <see langword="false" />.</returns>
	[MonoTODO]
	public bool IsFullyTrusted => false;

	/// <summary>Gets serialization information with all of the data needed to reinstantiate this assembly.</summary>
	/// <param name="info">The object to be populated with serialization information.</param>
	/// <param name="context">The destination context of the serialization.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Indicates whether or not a specified attribute has been applied to the assembly.</summary>
	/// <param name="attributeType">The type of the attribute to be checked for this assembly.</param>
	/// <param name="inherit">This argument is ignored for objects of this type.</param>
	/// <returns>
	///   <see langword="true" /> if the attribute has been applied to the assembly; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> uses an invalid type.</exception>
	public virtual bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	/// <summary>Gets all the custom attributes for this assembly.</summary>
	/// <param name="inherit">This argument is ignored for objects of type <see cref="T:System.Reflection.Assembly" />.</param>
	/// <returns>An array that contains the custom attributes for this assembly.</returns>
	public virtual object[] GetCustomAttributes(bool inherit)
	{
		return null;
	}

	/// <summary>Gets the custom attributes for this assembly as specified by type.</summary>
	/// <param name="attributeType">The type for which the custom attributes are to be returned.</param>
	/// <param name="inherit">This argument is ignored for objects of type <see cref="T:System.Reflection.Assembly" />.</param>
	/// <returns>An array that contains the custom attributes for this assembly as specified by <paramref name="attributeType" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not a runtime type.</exception>
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	/// <summary>Loads the specified manifest resource from this assembly.</summary>
	/// <param name="name">The case-sensitive name of the manifest resource being requested.</param>
	/// <returns>The manifest resource; or <see langword="null" /> if no resources were specified during compilation or if the resource is not visible to the caller.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is an empty string ("").</exception>
	/// <exception cref="T:System.IO.FileLoadException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.IO.IOException" />, instead.  
	///
	///
	///
	///
	///  A file that was found could not be loaded.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">
	///   <paramref name="name" /> was not found.</exception>
	/// <exception cref="T:System.BadImageFormatException">
	///   <paramref name="name" /> is not a valid assembly.</exception>
	/// <exception cref="T:System.NotImplementedException">Resource length is greater than <see cref="F:System.Int64.MaxValue" />.</exception>
	public virtual Stream GetManifestResourceStream(string name)
	{
		return null;
	}

	/// <summary>Loads the specified manifest resource, scoped by the namespace of the specified type, from this assembly.</summary>
	/// <param name="type">The type whose namespace is used to scope the manifest resource name.</param>
	/// <param name="name">The case-sensitive name of the manifest resource being requested.</param>
	/// <returns>The manifest resource; or <see langword="null" /> if no resources were specified during compilation or if the resource is not visible to the caller.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is an empty string ("").</exception>
	/// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">
	///   <paramref name="name" /> was not found.</exception>
	/// <exception cref="T:System.BadImageFormatException">
	///   <paramref name="name" /> is not a valid assembly.</exception>
	/// <exception cref="T:System.NotImplementedException">Resource length is greater than <see cref="F:System.Int64.MaxValue" />.</exception>
	public virtual Stream GetManifestResourceStream(Type type, string name)
	{
		return null;
	}

	internal Stream GetManifestResourceStream(Type type, string name, bool skipSecurityCheck, ref StackCrawlMark stackMark)
	{
		return null;
	}

	internal Stream GetManifestResourceStream(string name, ref StackCrawlMark stackMark, bool skipSecurityCheck)
	{
		return null;
	}

	internal string GetSimpleName()
	{
		return null;
	}

	internal byte[] GetPublicKey()
	{
		return null;
	}

	internal Version GetVersion()
	{
		return null;
	}

	private AssemblyNameFlags GetFlags()
	{
		return default(AssemblyNameFlags);
	}

	internal virtual Type[] GetTypes(bool exportedOnly)
	{
		return null;
	}

	/// <summary>Gets the types defined in this assembly.</summary>
	/// <returns>An array that contains all the types that are defined in this assembly.</returns>
	/// <exception cref="T:System.Reflection.ReflectionTypeLoadException">The assembly contains one or more types that cannot be loaded. The array returned by the <see cref="P:System.Reflection.ReflectionTypeLoadException.Types" /> property of this exception contains a <see cref="T:System.Type" /> object for each type that was loaded and <see langword="null" /> for each type that could not be loaded, while the <see cref="P:System.Reflection.ReflectionTypeLoadException.LoaderExceptions" /> property contains an exception for each type that could not be loaded.</exception>
	public virtual Type[] GetTypes()
	{
		return null;
	}

	/// <summary>Gets the <see cref="T:System.Type" /> object with the specified name in the assembly instance and optionally throws an exception if the type is not found.</summary>
	/// <param name="name">The full name of the type.</param>
	/// <param name="throwOnError">
	///   <see langword="true" /> to throw an exception if the type is not found; <see langword="false" /> to return <see langword="null" />.</param>
	/// <returns>An object that represents the specified class.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="name" /> is invalid.  
	/// -or-  
	/// The length of <paramref name="name" /> exceeds 1024 characters.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.TypeLoadException">
	///   <paramref name="throwOnError" /> is <see langword="true" />, and the type cannot be found.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">
	///   <paramref name="name" /> requires a dependent assembly that could not be found.</exception>
	/// <exception cref="T:System.IO.FileLoadException">
	///   <paramref name="name" /> requires a dependent assembly that was found but could not be loaded.  
	/// -or-  
	/// The current assembly was loaded into the reflection-only context, and <paramref name="name" /> requires a dependent assembly that was not preloaded.</exception>
	/// <exception cref="T:System.BadImageFormatException">
	///   <paramref name="name" /> requires a dependent assembly, but the file is not a valid assembly.  
	/// -or-  
	/// <paramref name="name" /> requires a dependent assembly which was compiled for a version of the runtime later than the currently loaded version.</exception>
	public virtual Type GetType(string name, bool throwOnError)
	{
		return null;
	}

	/// <summary>Gets the <see cref="T:System.Type" /> object with the specified name in the assembly instance.</summary>
	/// <param name="name">The full name of the type.</param>
	/// <returns>An object that represents the specified class, or <see langword="null" /> if the class is not found.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="name" /> is invalid.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">
	///   <paramref name="name" /> requires a dependent assembly that could not be found.</exception>
	/// <exception cref="T:System.IO.FileLoadException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.IO.IOException" />, instead.  
	///
	///
	///     <paramref name="name" /> requires a dependent assembly that was found but could not be loaded.  
	///  -or-  
	///  The current assembly was loaded into the reflection-only context, and <paramref name="name" /> requires a dependent assembly that was not preloaded.</exception>
	/// <exception cref="T:System.BadImageFormatException">
	///   <paramref name="name" /> requires a dependent assembly, but the file is not a valid assembly.  
	/// -or-  
	/// <paramref name="name" /> requires a dependent assembly which was compiled for a version of the runtime later than the currently loaded version.</exception>
	public virtual Type GetType(string name)
	{
		return null;
	}

	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase)
	{
		return null;
	}

	/// <summary>Gets an <see cref="T:System.Reflection.AssemblyName" /> for this assembly, setting the codebase as specified by <paramref name="copiedName" />.</summary>
	/// <param name="copiedName">
	///   <see langword="true" /> to set the <see cref="P:System.Reflection.Assembly.CodeBase" /> to the location of the assembly after it was shadow copied; <see langword="false" /> to set <see cref="P:System.Reflection.Assembly.CodeBase" /> to the original location.</param>
	/// <returns>An object that contains the fully parsed display name for this assembly.</returns>
	public virtual AssemblyName GetName(bool copiedName)
	{
		return null;
	}

	/// <summary>Gets an <see cref="T:System.Reflection.AssemblyName" /> for this assembly.</summary>
	/// <returns>An object that contains the fully parsed display name for this assembly.</returns>
	public virtual AssemblyName GetName()
	{
		return null;
	}

	/// <summary>Returns the full name of the assembly, also known as the display name.</summary>
	/// <returns>The full name of the assembly, or the class name if the full name of the assembly cannot be determined.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Gets the currently loaded assembly in which the specified type is defined.</summary>
	/// <param name="type">An object representing a type in the assembly that will be returned.</param>
	/// <returns>The assembly in which the specified type is defined.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.</exception>
	public static Assembly GetAssembly(Type type)
	{
		return null;
	}

	internal RuntimeAssembly InternalGetSatelliteAssembly(string name, CultureInfo culture, Version version, bool throwOnFileNotFound, ref StackCrawlMark stackMark)
	{
		return null;
	}

	private static Assembly LoadFrom(string assemblyFile, bool refOnly, ref StackCrawlMark stackMark)
	{
		return null;
	}

	/// <summary>Loads an assembly given the long form of its name.</summary>
	/// <param name="assemblyString">The long form of the assembly name.</param>
	/// <returns>The loaded assembly.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="assemblyString" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="assemblyString" /> is a zero-length string.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">
	///   <paramref name="assemblyString" /> is not found.</exception>
	/// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded.</exception>
	/// <exception cref="T:System.BadImageFormatException">
	///   <paramref name="assemblyString" /> is not a valid assembly.  
	/// -or-  
	/// Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyString" /> was compiled with a later version.</exception>
	public static Assembly Load(string assemblyString)
	{
		return null;
	}

	/// <summary>Loads an assembly into the reflection-only context, given its display name.</summary>
	/// <param name="assemblyString">The display name of the assembly, as returned by the <see cref="P:System.Reflection.AssemblyName.FullName" /> property.</param>
	/// <returns>The loaded assembly.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="assemblyString" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="assemblyString" /> is an empty string ("").</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">
	///   <paramref name="assemblyString" /> is not found.</exception>
	/// <exception cref="T:System.IO.FileLoadException">
	///   <paramref name="assemblyString" /> is found, but cannot be loaded.</exception>
	/// <exception cref="T:System.BadImageFormatException">
	///   <paramref name="assemblyString" /> is not a valid assembly.  
	/// -or-  
	/// Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyString" /> was compiled with a later version.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Assembly ReflectionOnlyLoad(string assemblyString)
	{
		return null;
	}

	/// <summary>Loads an assembly from the application directory or from the global assembly cache using a partial name.</summary>
	/// <param name="partialName">The display name of the assembly.</param>
	/// <returns>The loaded assembly. If <paramref name="partialName" /> is not found, this method returns <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="partialName" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.BadImageFormatException">
	///   <paramref name="assemblyFile" /> is not a valid assembly.  
	/// -or-  
	/// Version 2.0 or later of the common language runtime is currently loaded and <paramref name="partialName" /> was compiled with a later version.</exception>
	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public static Assembly LoadWithPartialName(string partialName)
	{
		return null;
	}

	private static Assembly load_with_partial_name(string name, Evidence e)
	{
		return null;
	}

	/// <summary>Loads an assembly from the application directory or from the global assembly cache using a partial name. The assembly is loaded into the domain of the caller using the supplied evidence.</summary>
	/// <param name="partialName">The display name of the assembly.</param>
	/// <param name="securityEvidence">Evidence for loading the assembly.</param>
	/// <returns>The loaded assembly. If <paramref name="partialName" /> is not found, this method returns <see langword="null" />.</returns>
	/// <exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different sets of evidence.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="partialName" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.BadImageFormatException">
	///   <paramref name="assemblyFile" /> is not a valid assembly.  
	/// -or-  
	/// Version 2.0 or later of the common language runtime is currently loaded and <paramref name="partialName" /> was compiled with a later version.</exception>
	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence)
	{
		return null;
	}

	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior)
	{
		return null;
	}

	/// <summary>Locates the specified type from this assembly and creates an instance of it using the system activator, using case-sensitive search.</summary>
	/// <param name="typeName">The <see cref="P:System.Type.FullName" /> of the type to locate.</param>
	/// <returns>An instance of the specified type created with the default constructor; or <see langword="null" /> if <paramref name="typeName" /> is not found. The type is resolved using the default binder, without specifying culture or activation attributes, and with <see cref="T:System.Reflection.BindingFlags" /> set to <see langword="Public" /> or <see langword="Instance" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="typeName" /> is an empty string ("") or a string beginning with a null character.  
	/// -or-  
	/// The current assembly was loaded into the reflection-only context.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="typeName" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.MissingMethodException">No matching constructor was found.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">
	///   <paramref name="typeName" /> requires a dependent assembly that could not be found.</exception>
	/// <exception cref="T:System.IO.FileLoadException">
	///   <paramref name="typeName" /> requires a dependent assembly that was found but could not be loaded.  
	/// -or-  
	/// The current assembly was loaded into the reflection-only context, and <paramref name="typeName" /> requires a dependent assembly that was not preloaded.</exception>
	/// <exception cref="T:System.BadImageFormatException">
	///   <paramref name="typeName" /> requires a dependent assembly, but the file is not a valid assembly.  
	/// -or-  
	/// <paramref name="typeName" /> requires a dependent assembly that was compiled for a version of the runtime that is later than the currently loaded version.</exception>
	public object CreateInstance(string typeName)
	{
		return null;
	}

	/// <summary>Locates the specified type from this assembly and creates an instance of it using the system activator, with optional case-sensitive search.</summary>
	/// <param name="typeName">The <see cref="P:System.Type.FullName" /> of the type to locate.</param>
	/// <param name="ignoreCase">
	///   <see langword="true" /> to ignore the case of the type name; otherwise, <see langword="false" />.</param>
	/// <returns>An instance of the specified type created with the default constructor; or <see langword="null" /> if <paramref name="typeName" /> is not found. The type is resolved using the default binder, without specifying culture or activation attributes, and with <see cref="T:System.Reflection.BindingFlags" /> set to <see langword="Public" /> or <see langword="Instance" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="typeName" /> is an empty string ("") or a string beginning with a null character.  
	/// -or-  
	/// The current assembly was loaded into the reflection-only context.</exception>
	/// <exception cref="T:System.MissingMethodException">No matching constructor was found.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="typeName" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">
	///   <paramref name="typeName" /> requires a dependent assembly that could not be found.</exception>
	/// <exception cref="T:System.IO.FileLoadException">
	///   <paramref name="typeName" /> requires a dependent assembly that was found but could not be loaded.  
	/// -or-  
	/// The current assembly was loaded into the reflection-only context, and <paramref name="typeName" /> requires a dependent assembly that was not preloaded.</exception>
	/// <exception cref="T:System.BadImageFormatException">
	///   <paramref name="typeName" /> requires a dependent assembly, but the file is not a valid assembly.  
	/// -or-  
	/// <paramref name="typeName" /> requires a dependent assembly that was compiled for a version of the runtime that is later than the currently loaded version.</exception>
	public object CreateInstance(string typeName, bool ignoreCase)
	{
		return null;
	}

	/// <summary>Gets all the modules that are part of this assembly.</summary>
	/// <returns>An array of modules.</returns>
	/// <exception cref="T:System.IO.FileNotFoundException">The module to be loaded does not specify a file name extension.</exception>
	public Module[] GetModules()
	{
		return null;
	}

	internal virtual Module[] GetModulesInternal()
	{
		return null;
	}

	/// <summary>Gets the assembly that contains the code that is currently executing.</summary>
	/// <returns>The assembly that contains the code that is currently executing.</returns>
	public static Assembly GetExecutingAssembly()
	{
		return null;
	}

	/// <summary>Returns the <see cref="T:System.Reflection.Assembly" /> of the method that invoked the currently executing method.</summary>
	/// <returns>The <see langword="Assembly" /> object of the method that invoked the currently executing method.</returns>
	public static Assembly GetCallingAssembly()
	{
		return null;
	}

	/// <summary>Returns the names of all the resources in this assembly.</summary>
	/// <returns>An array that contains the names of all the resources.</returns>
	public virtual string[] GetManifestResourceNames()
	{
		return null;
	}

	/// <summary>Returns information about how the given resource has been persisted.</summary>
	/// <param name="resourceName">The case-sensitive name of the resource.</param>
	/// <returns>An object that is populated with information about the resource's topology, or <see langword="null" /> if the resource is not found.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="resourceName" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="resourceName" /> parameter is an empty string ("").</exception>
	public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName)
	{
		return null;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Determines whether this assembly and the specified object are equal.</summary>
	/// <param name="o">The object to compare with this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="o" /> is equal to this instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object o)
	{
		return false;
	}

	private static Exception CreateNIE()
	{
		return null;
	}

	/// <summary>Gets the <see cref="T:System.Type" /> object with the specified name in the assembly instance, with the options of ignoring the case, and of throwing an exception if the type is not found.</summary>
	/// <param name="name">The full name of the type.</param>
	/// <param name="throwOnError">
	///   <see langword="true" /> to throw an exception if the type is not found; <see langword="false" /> to return <see langword="null" />.</param>
	/// <param name="ignoreCase">
	///   <see langword="true" /> to ignore the case of the type name; otherwise, <see langword="false" />.</param>
	/// <returns>An object that represents the specified class.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="name" /> is invalid.  
	/// -or-  
	/// The length of <paramref name="name" /> exceeds 1024 characters.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.TypeLoadException">
	///   <paramref name="throwOnError" /> is <see langword="true" />, and the type cannot be found.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">
	///   <paramref name="name" /> requires a dependent assembly that could not be found.</exception>
	/// <exception cref="T:System.IO.FileLoadException">
	///   <paramref name="name" /> requires a dependent assembly that was found but could not be loaded.  
	/// -or-  
	/// The current assembly was loaded into the reflection-only context, and <paramref name="name" /> requires a dependent assembly that was not preloaded.</exception>
	/// <exception cref="T:System.BadImageFormatException">
	///   <paramref name="name" /> requires a dependent assembly, but the file is not a valid assembly.  
	/// -or-  
	/// <paramref name="name" /> requires a dependent assembly which was compiled for a version of the runtime later than the currently loaded version.</exception>
	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase)
	{
		return null;
	}

	/// <summary>Gets the specified module in this assembly.</summary>
	/// <param name="name">The name of the module being requested.</param>
	/// <returns>The module being requested, or <see langword="null" /> if the module is not found.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is an empty string ("").</exception>
	/// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">
	///   <paramref name="name" /> was not found.</exception>
	/// <exception cref="T:System.BadImageFormatException">
	///   <paramref name="name" /> is not a valid assembly.</exception>
	public virtual Module GetModule(string name)
	{
		return null;
	}

	/// <summary>Gets all the modules that are part of this assembly, specifying whether to include resource modules.</summary>
	/// <param name="getResourceModules">
	///   <see langword="true" /> to include resource modules; otherwise, <see langword="false" />.</param>
	/// <returns>An array of modules.</returns>
	public virtual Module[] GetModules(bool getResourceModules)
	{
		return null;
	}

	/// <summary>Indicates whether two <see cref="T:System.Reflection.Assembly" /> objects are equal.</summary>
	/// <param name="left">The assembly to compare to <paramref name="right" />.</param>
	/// <param name="right">The assembly to compare to <paramref name="left" />.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(Assembly left, Assembly right)
	{
		return false;
	}

	/// <summary>Indicates whether two <see cref="T:System.Reflection.Assembly" /> objects are not equal.</summary>
	/// <param name="left">The assembly to compare to <paramref name="right" />.</param>
	/// <param name="right">The assembly to compare to <paramref name="left" />.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(Assembly left, Assembly right)
	{
		return false;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.Assembly" /> class.</summary>
	public Assembly()
	{
	}
}
