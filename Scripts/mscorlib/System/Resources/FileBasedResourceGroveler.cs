using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace System.Resources;

internal class FileBasedResourceGroveler : IResourceGroveler
{
	private ResourceManager.ResourceManagerMediator _mediator;

	public FileBasedResourceGroveler(ResourceManager.ResourceManagerMediator mediator)
	{
	}

	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark)
	{
		return null;
	}

	private string FindResourceFile(CultureInfo culture, string fileName)
	{
		return null;
	}

	private ResourceSet CreateResourceSet(string file)
	{
		return null;
	}
}
