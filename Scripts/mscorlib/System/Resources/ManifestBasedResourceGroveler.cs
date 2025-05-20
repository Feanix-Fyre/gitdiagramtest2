using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Resources;

internal class ManifestBasedResourceGroveler : IResourceGroveler
{
	private ResourceManager.ResourceManagerMediator _mediator;

	public ManifestBasedResourceGroveler(ResourceManager.ResourceManagerMediator mediator)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark)
	{
		return null;
	}

	private CultureInfo UltimateFallbackFixup(CultureInfo lookForCulture)
	{
		return null;
	}

	internal static CultureInfo GetNeutralResourcesLanguage(Assembly a, ref UltimateResourceFallbackLocation fallbackLocation)
	{
		return null;
	}

	internal ResourceSet CreateResourceSet(Stream store, Assembly assembly)
	{
		return null;
	}

	private Stream GetManifestResourceStream(RuntimeAssembly satellite, string fileName, ref StackCrawlMark stackMark)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Stream CaseInsensitiveManifestResourceStreamLookup(RuntimeAssembly satellite, string name)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RuntimeAssembly GetSatelliteAssembly(CultureInfo lookForCulture, ref StackCrawlMark stackMark)
	{
		return null;
	}

	private bool CanUseDefaultResourceClasses(string readerTypeName, string resSetTypeName)
	{
		return false;
	}

	private string GetSatelliteAssemblyName()
	{
		return null;
	}

	private void HandleSatelliteMissing()
	{
	}

	private void HandleResourceStreamMissing(string fileName)
	{
	}

	private static bool GetNeutralResourcesLanguageAttribute(Assembly assembly, ref string cultureName, ref short fallbackLocation)
	{
		return false;
	}
}
