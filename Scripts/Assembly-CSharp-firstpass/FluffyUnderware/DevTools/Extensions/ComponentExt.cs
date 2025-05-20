using System;
using JetBrains.Annotations;
using UnityEngine;

namespace FluffyUnderware.DevTools.Extensions;

public static class ComponentExt
{
	public static void StripComponents(this Component c, params Type[] toKeep)
	{
	}

	[Obsolete]
	[UsedImplicitly]
	public static GameObject AddChildGameObject(this Component c, string name)
	{
		return null;
	}

	[UsedImplicitly]
	[Obsolete]
	public static T AddChildGameObject<T>(this Component c, string name) where T : Component
	{
		return null;
	}

	[NotNull]
	public static T DuplicateGameObject<T>([NotNull] this Component source, [CanBeNull] Transform newParent) where T : Component
	{
		return null;
	}

	[CanBeNull]
	[UsedImplicitly]
	[Obsolete("Use the other DuplicateGameObject method instead")]
	public static T DuplicateGameObject<T>(this Component source, Transform newParent, bool keepPrefabConnection) where T : Component
	{
		return null;
	}

	[Obsolete("Use the other DuplicateGameObject method instead")]
	[UsedImplicitly]
	public static Component DuplicateGameObject(this Component source, Transform newParent, bool keepPrefabConnection = false)
	{
		return null;
	}
}
