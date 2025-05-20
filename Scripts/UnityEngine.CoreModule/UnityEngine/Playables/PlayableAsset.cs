using System;
using System.Collections.Generic;
using UnityEngine.Scripting;

namespace UnityEngine.Playables;

[Serializable]
[AssetFileNameExtension("playable", new string[] { })]
[RequiredByNativeCode]
public abstract class PlayableAsset : ScriptableObject, IPlayableAsset
{
	public virtual double duration => 0.0;

	public virtual IEnumerable<PlayableBinding> outputs => null;

	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner);

	[RequiredByNativeCode]
	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr)
	{
	}

	[RequiredByNativeCode]
	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble)
	{
	}
}
