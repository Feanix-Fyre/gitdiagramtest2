using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Streaming/TextureStreamingManager.h")]
[NativeHeader("Runtime/Graphics/Texture.h")]
[UsedByNativeCode]
public class Texture : Object
{
	public static readonly int GenerateAllMips;

	public int mipmapCount
	{
		[NativeName("GetMipmapCount")]
		get
		{
			return 0;
		}
	}

	public virtual GraphicsFormat graphicsFormat => default(GraphicsFormat);

	public virtual int width
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int height
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual TextureDimension dimension
	{
		get
		{
			return default(TextureDimension);
		}
		set
		{
		}
	}

	public virtual bool isReadable => false;

	public TextureWrapMode wrapMode
	{
		[NativeName("GetWrapModeU")]
		get
		{
			return default(TextureWrapMode);
		}
		set
		{
		}
	}

	public TextureWrapMode wrapModeU
	{
		set
		{
		}
	}

	public TextureWrapMode wrapModeV
	{
		set
		{
		}
	}

	public TextureWrapMode wrapModeW
	{
		set
		{
		}
	}

	public FilterMode filterMode
	{
		get
		{
			return default(FilterMode);
		}
		set
		{
		}
	}

	public int anisoLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float mipMapBias
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Vector2 texelSize
	{
		[NativeName("GetTexelSize")]
		get
		{
			return default(Vector2);
		}
	}

	public uint updateCount => 0u;

	internal ColorSpace activeTextureColorSpace
	{
		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule", "Unity.UIElements" })]
		get
		{
			return default(ColorSpace);
		}
	}

	protected Texture()
	{
	}

	private int GetDataWidth()
	{
		return 0;
	}

	private int GetDataHeight()
	{
		return 0;
	}

	private TextureDimension GetDimension()
	{
		return default(TextureDimension);
	}

	[NativeMethod("GetActiveTextureColorSpace")]
	private int Internal_GetActiveTextureColorSpace()
	{
		return 0;
	}

	internal ulong GetPixelDataSize(int mipLevel, int element = 0)
	{
		return 0uL;
	}

	internal ulong GetPixelDataOffset(int mipLevel, int element = 0)
	{
		return 0uL;
	}

	internal TextureColorSpace GetTextureColorSpace(bool linear)
	{
		return default(TextureColorSpace);
	}

	internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format)
	{
		return default(TextureColorSpace);
	}

	internal bool ValidateFormat(TextureFormat format)
	{
		return false;
	}

	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage)
	{
		return false;
	}

	internal UnityException CreateNonReadableException(Texture t)
	{
		return null;
	}

	internal UnityException CreateNativeArrayLengthOverflowException()
	{
		return null;
	}

	[SpecialName]
	private void get_texelSize_Injected(out Vector2 ret)
	{
		ret = default(Vector2);
	}
}
