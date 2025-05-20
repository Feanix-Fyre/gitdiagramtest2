using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Resources;

/// <summary>Represents a resource manager that provides convenient access to culture-specific resources at run time.</summary>
[Serializable]
[ComVisible(true)]
public class ResourceManager
{
	internal class CultureNameResourceSetPair
	{
		public string lastCultureName;

		public ResourceSet lastResourceSet;
	}

	internal class ResourceManagerMediator
	{
		private ResourceManager _rm;

		internal string ModuleDir => null;

		internal Type LocationInfo => null;

		internal Type UserResourceSet => null;

		internal string BaseNameField => null;

		internal CultureInfo NeutralResourcesCulture => null;

		internal bool LookedForSatelliteContractVersion
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal Version SatelliteContractVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal UltimateResourceFallbackLocation FallbackLoc => default(UltimateResourceFallbackLocation);

		internal RuntimeAssembly CallingAssembly => null;

		internal RuntimeAssembly MainAssembly => null;

		internal string BaseName => null;

		internal ResourceManagerMediator(ResourceManager rm)
		{
		}

		internal string GetResourceFileName(CultureInfo culture)
		{
			return null;
		}

		internal Version ObtainSatelliteContractVersion(Assembly a)
		{
			return null;
		}
	}

	/// <summary>Specifies the root name of the resource files that the <see cref="T:System.Resources.ResourceManager" /> searches for resources.</summary>
	protected string BaseNameField;

	/// <summary>Contains a <see cref="T:System.Collections.Hashtable" /> that returns a mapping from cultures to <see cref="T:System.Resources.ResourceSet" /> objects.</summary>
	[Obsolete("call InternalGetResourceSet instead")]
	protected Hashtable ResourceSets;

	[NonSerialized]
	private Dictionary<string, ResourceSet> _resourceSets;

	private string moduleDir;

	/// <summary>Specifies the main assembly that contains the resources.</summary>
	protected Assembly MainAssembly;

	private Type _locationInfo;

	private Type _userResourceSet;

	private CultureInfo _neutralResourcesCulture;

	[NonSerialized]
	private CultureNameResourceSetPair _lastUsedResourceCache;

	private bool _ignoreCase;

	private bool UseManifest;

	[OptionalField(VersionAdded = 1)]
	private bool UseSatelliteAssem;

	[OptionalField]
	private UltimateResourceFallbackLocation _fallbackLoc;

	[OptionalField]
	private Version _satelliteContractVersion;

	[OptionalField]
	private bool _lookedForSatelliteContractVersion;

	[OptionalField(VersionAdded = 1)]
	private Assembly _callingAssembly;

	[OptionalField(VersionAdded = 4)]
	private RuntimeAssembly m_callingAssembly;

	[NonSerialized]
	private IResourceGroveler resourceGroveler;

	/// <summary>Holds the number used to identify resource files.</summary>
	public static readonly int MagicNumber;

	/// <summary>Specifies the version of resource file headers that the current implementation of <see cref="T:System.Resources.ResourceManager" /> can interpret and produce.</summary>
	public static readonly int HeaderVersionNumber;

	private static readonly Type _minResourceSet;

	internal static readonly string ResReaderTypeName;

	internal static readonly string ResSetTypeName;

	internal static readonly string MscorlibName;

	internal static readonly int DEBUG;

	/// <summary>Gets the root name of the resource files that the <see cref="T:System.Resources.ResourceManager" /> searches for resources.</summary>
	/// <returns>The root name of the resource files that the <see cref="T:System.Resources.ResourceManager" /> searches for resources.</returns>
	public virtual string BaseName => null;

	/// <summary>Gets or sets a value that indicates whether the resource manager allows case-insensitive resource lookups in the <see cref="M:System.Resources.ResourceManager.GetString(System.String)" /> and <see cref="M:System.Resources.ResourceManager.GetObject(System.String)" /> methods.</summary>
	/// <returns>
	///   <see langword="true" /> to ignore case during resource lookup; otherwise, <see langword="false" />.</returns>
	public virtual bool IgnoreCase => false;

	/// <summary>Gets or sets the location from which to retrieve default fallback resources.</summary>
	/// <returns>One of the enumeration values that specifies where the resource manager can look for fallback resources.</returns>
	protected UltimateResourceFallbackLocation FallbackLocation => default(UltimateResourceFallbackLocation);

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Resources.ResourceManager" /> class with default values.</summary>
	protected ResourceManager()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Resources.ResourceManager" /> class that looks up resources contained in files with the specified root name in the given assembly.</summary>
	/// <param name="baseName">The root name of the resource file without its extension but including any fully qualified namespace name. For example, the root name for the resource file named MyApplication.MyResource.en-US.resources is MyApplication.MyResource.</param>
	/// <param name="assembly">The main assembly for the resources.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="baseName" /> or <paramref name="assembly" /> parameter is <see langword="null" />.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResourceManager(string baseName, Assembly assembly)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Resources.ResourceManager" /> class that looks up resources in satellite assemblies based on information from the specified type object.</summary>
	/// <param name="resourceSource">A type from which the resource manager derives all information for finding .resources files.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="resourceSource" /> parameter is <see langword="null" />.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResourceManager(Type resourceSource)
	{
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx)
	{
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
	}

	private void CommonAssemblyInit()
	{
	}

	/// <summary>Generates the name of the resource file for the given <see cref="T:System.Globalization.CultureInfo" /> object.</summary>
	/// <param name="culture">The culture object for which a resource file name is constructed.</param>
	/// <returns>The name that can be used for a resource file for the given <see cref="T:System.Globalization.CultureInfo" /> object.</returns>
	protected virtual string GetResourceFileName(CultureInfo culture)
	{
		return null;
	}

	internal ResourceSet GetFirstResourceSet(CultureInfo culture)
	{
		return null;
	}

	/// <summary>Retrieves the resource set for a particular culture.</summary>
	/// <param name="culture">The culture whose resources are to be retrieved.</param>
	/// <param name="createIfNotExists">
	///   <see langword="true" /> to load the resource set, if it has not been loaded yet; otherwise, <see langword="false" />.</param>
	/// <param name="tryParents">
	///   <see langword="true" /> to use resource fallback to load an appropriate resource if the resource set cannot be found; <see langword="false" /> to bypass the resource fallback process.</param>
	/// <returns>The resource set for the specified culture.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="culture" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Resources.MissingManifestResourceException">
	///   <paramref name="tryParents" /> is <see langword="true" />, no usable set of resources has been found, and there are no default culture resources.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual ResourceSet GetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents)
	{
		return null;
	}

	/// <summary>Provides the implementation for finding a resource set.</summary>
	/// <param name="culture">The culture object to look for.</param>
	/// <param name="createIfNotExists">
	///   <see langword="true" /> to load the resource set, if it has not been loaded yet; otherwise, <see langword="false" />.</param>
	/// <param name="tryParents">
	///   <see langword="true" /> to check parent <see cref="T:System.Globalization.CultureInfo" /> objects if the resource set cannot be loaded; otherwise, <see langword="false" />.</param>
	/// <returns>The specified resource set.</returns>
	/// <exception cref="T:System.Resources.MissingManifestResourceException">The main assembly does not contain a .resources file, which is required to look up a resource.</exception>
	/// <exception cref="T:System.ExecutionEngineException">There was an internal error in the runtime.</exception>
	/// <exception cref="T:System.Resources.MissingSatelliteAssemblyException">The satellite assembly associated with <paramref name="culture" /> could not be located.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents)
	{
		return null;
	}

	private ResourceSet InternalGetResourceSet(CultureInfo requestedCulture, bool createIfNotExists, bool tryParents, ref StackCrawlMark stackMark)
	{
		return null;
	}

	private static void AddResourceSet(Dictionary<string, ResourceSet> localResourceSets, string cultureName, ref ResourceSet rs)
	{
	}

	/// <summary>Returns the version specified by the <see cref="T:System.Resources.SatelliteContractVersionAttribute" /> attribute in the given assembly.</summary>
	/// <param name="a">The assembly to check for the <see cref="T:System.Resources.SatelliteContractVersionAttribute" /> attribute.</param>
	/// <returns>The satellite contract version of the given assembly, or <see langword="null" /> if no version was found.</returns>
	/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Version" /> found in the assembly <paramref name="a" /> is invalid.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="a" /> is <see langword="null" />.</exception>
	protected static Version GetSatelliteContractVersion(Assembly a)
	{
		return null;
	}

	/// <summary>Returns culture-specific information for the main assembly's default resources by retrieving the value of the <see cref="T:System.Resources.NeutralResourcesLanguageAttribute" /> attribute on a specified assembly.</summary>
	/// <param name="a">The assembly for which to return culture-specific information.</param>
	/// <returns>The culture from the <see cref="T:System.Resources.NeutralResourcesLanguageAttribute" /> attribute, if found; otherwise, the invariant culture.</returns>
	protected static CultureInfo GetNeutralResourcesLanguage(Assembly a)
	{
		return null;
	}

	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2)
	{
		return false;
	}

	private void SetAppXConfiguration()
	{
	}

	/// <summary>Returns the value of the string resource localized for the specified culture.</summary>
	/// <param name="name">The name of the resource to retrieve.</param>
	/// <param name="culture">An object that represents the culture for which the resource is localized.</param>
	/// <returns>The value of the resource localized for the specified culture, or <see langword="null" /> if <paramref name="name" /> cannot be found in a resource set.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The value of the specified resource is not a string.</exception>
	/// <exception cref="T:System.Resources.MissingManifestResourceException">No usable set of resources has been found, and there are no resources for a default culture. For information about how to handle this exception, see the "Handling MissingManifestResourceException and MissingSatelliteAssemblyException Exceptions" section in the <see cref="T:System.Resources.ResourceManager" /> class topic.</exception>
	/// <exception cref="T:System.Resources.MissingSatelliteAssemblyException">The default culture's resources reside in a satellite assembly that could not be found. For information about how to handle this exception, see the "Handling MissingManifestResourceException and MissingSatelliteAssemblyException Exceptions" section in the <see cref="T:System.Resources.ResourceManager" /> class topic.</exception>
	public virtual string GetString(string name, CultureInfo culture)
	{
		return null;
	}

	/// <summary>Returns the value of the specified non-string resource.</summary>
	/// <param name="name">The name of the resource to get.</param>
	/// <returns>The value of the resource localized for the caller's current culture settings. If an appropriate resource set exists but <paramref name="name" /> cannot be found, the method returns <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Resources.MissingManifestResourceException">No usable set of localized resources has been found, and there are no default culture resources. For information about how to handle this exception, see the "Handling MissingManifestResourceException and MissingSatelliteAssemblyException Exceptions" section in the <see cref="T:System.Resources.ResourceManager" /> class topic.</exception>
	/// <exception cref="T:System.Resources.MissingSatelliteAssemblyException">The default culture's resources reside in a satellite assembly that could not be found. For information about how to handle this exception, see the "Handling MissingManifestResourceException and MissingSatelliteAssemblyException Exceptions" section in the <see cref="T:System.Resources.ResourceManager" /> class topic.</exception>
	public virtual object GetObject(string name)
	{
		return null;
	}

	private object GetObject(string name, CultureInfo culture, bool wrapUnmanagedMemStream)
	{
		return null;
	}
}
