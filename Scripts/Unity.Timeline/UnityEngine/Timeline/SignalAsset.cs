using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Timeline;

[AssetFileNameExtension("signal", new string[] { })]
public class SignalAsset : ScriptableObject
{
	internal static event Action<SignalAsset> OnEnableCallback
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

	private void OnEnable()
	{
	}
}
