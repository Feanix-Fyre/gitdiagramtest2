using System;
using JetBrains.Annotations;

namespace FluffyUnderware.Curvy.Generator;

[UsedImplicitly]
[AttributeUsage(AttributeTargets.Class)]
[Obsolete("Curvy Splines does not use this attribute anymore. You have now to register your resource loaders using CGResourceHandler.RegisterResourceLoader")]
public sealed class ResourceLoaderAttribute : Attribute
{
	public readonly string ResourceName;

	public ResourceLoaderAttribute([NotNull] string resName)
	{
	}
}
