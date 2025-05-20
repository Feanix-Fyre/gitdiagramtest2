using System;
using UnityEngine.Bindings;

namespace UnityEngine;

[VisibleToOtherModules]
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
internal sealed class AssetFileNameExtensionAttribute : Attribute
{
	public AssetFileNameExtensionAttribute(string preferredExtension, params string[] otherExtensions)
	{
	}
}
