using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
[NativeHeader("Modules/TextRendering/Public/Font.h")]
[StaticAccessor("TextRenderingPrivate", StaticAccessorType.DoubleColon)]
[NativeClass("TextRendering::Font")]
public sealed class Font : Object
{
	public delegate void FontTextureRebuildCallback();

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private FontTextureRebuildCallback m_FontTextureRebuildCallback;

	public Material material => null;

	public bool dynamic => false;

	public int fontSize => 0;

	public static event Action<Font> textureRebuilt
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

	[RequiredByNativeCode]
	internal static void InvokeTextureRebuilt_Internal(Font font)
	{
	}

	public bool HasCharacter(char c)
	{
		return false;
	}

	private bool HasCharacter(int c)
	{
		return false;
	}

	public static string[] GetPathsToOSFonts()
	{
		return null;
	}
}
