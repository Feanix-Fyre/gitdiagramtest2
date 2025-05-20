using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEngine;

public struct RenderTextureDescriptor
{
	private GraphicsFormat _graphicsFormat;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private GraphicsFormat _003CstencilFormat_003Ek__BackingField;

	private RenderTextureCreationFlags _flags;

	public int width { get; set; }

	public int height { get; set; }

	public int msaaSamples { get; set; }

	public int volumeDepth { get; set; }

	public int mipCount { get; set; }

	public GraphicsFormat graphicsFormat
	{
		get
		{
			return default(GraphicsFormat);
		}
		set
		{
		}
	}

	public GraphicsFormat stencilFormat
	{
		[CompilerGenerated]
		set
		{
			_003CstencilFormat_003Ek__BackingField = value;
		}
	}

	public GraphicsFormat depthStencilFormat { get; set; }

	public RenderTextureFormat colorFormat
	{
		get
		{
			return default(RenderTextureFormat);
		}
		set
		{
		}
	}

	public bool sRGB
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int depthBufferBits
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public TextureDimension dimension { get; set; }

	public ShadowSamplingMode shadowSamplingMode { get; set; }

	public VRTextureUsage vrUsage { get; set; }

	public RenderTextureMemoryless memoryless { get; set; }

	public bool useMipMap
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool autoGenerateMips
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool enableRandomWrite
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool bindMS
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool createdFromScript
	{
		set
		{
		}
	}

	public bool useDynamicScale
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height)
	{
		this.width = 0;
		this.height = 0;
		msaaSamples = 0;
		volumeDepth = 0;
		mipCount = 0;
		_graphicsFormat = default(GraphicsFormat);
		_003CstencilFormat_003Ek__BackingField = default(GraphicsFormat);
		depthStencilFormat = default(GraphicsFormat);
		dimension = default(TextureDimension);
		shadowSamplingMode = default(ShadowSamplingMode);
		vrUsage = default(VRTextureUsage);
		_flags = default(RenderTextureCreationFlags);
		memoryless = default(RenderTextureMemoryless);
	}

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat)
	{
		this.width = 0;
		this.height = 0;
		msaaSamples = 0;
		volumeDepth = 0;
		mipCount = 0;
		_graphicsFormat = default(GraphicsFormat);
		_003CstencilFormat_003Ek__BackingField = default(GraphicsFormat);
		depthStencilFormat = default(GraphicsFormat);
		dimension = default(TextureDimension);
		shadowSamplingMode = default(ShadowSamplingMode);
		vrUsage = default(VRTextureUsage);
		_flags = default(RenderTextureCreationFlags);
		memoryless = default(RenderTextureMemoryless);
	}

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits)
	{
		this.width = 0;
		this.height = 0;
		msaaSamples = 0;
		volumeDepth = 0;
		mipCount = 0;
		_graphicsFormat = default(GraphicsFormat);
		_003CstencilFormat_003Ek__BackingField = default(GraphicsFormat);
		depthStencilFormat = default(GraphicsFormat);
		dimension = default(TextureDimension);
		shadowSamplingMode = default(ShadowSamplingMode);
		vrUsage = default(VRTextureUsage);
		_flags = default(RenderTextureCreationFlags);
		memoryless = default(RenderTextureMemoryless);
	}

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits)
	{
		this.width = 0;
		this.height = 0;
		msaaSamples = 0;
		volumeDepth = 0;
		mipCount = 0;
		_graphicsFormat = default(GraphicsFormat);
		_003CstencilFormat_003Ek__BackingField = default(GraphicsFormat);
		depthStencilFormat = default(GraphicsFormat);
		dimension = default(TextureDimension);
		shadowSamplingMode = default(ShadowSamplingMode);
		vrUsage = default(VRTextureUsage);
		_flags = default(RenderTextureCreationFlags);
		memoryless = default(RenderTextureMemoryless);
	}

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount)
	{
		this.width = 0;
		this.height = 0;
		msaaSamples = 0;
		volumeDepth = 0;
		this.mipCount = 0;
		_graphicsFormat = default(GraphicsFormat);
		_003CstencilFormat_003Ek__BackingField = default(GraphicsFormat);
		depthStencilFormat = default(GraphicsFormat);
		dimension = default(TextureDimension);
		shadowSamplingMode = default(ShadowSamplingMode);
		vrUsage = default(VRTextureUsage);
		_flags = default(RenderTextureCreationFlags);
		memoryless = default(RenderTextureMemoryless);
	}

	public RenderTextureDescriptor(int width, int height, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat colorFormat, [DefaultValue("0")] int depthBufferBits, [DefaultValue("Texture.GenerateAllMips")] int mipCount, [DefaultValue("RenderTextureReadWrite.Linear")] RenderTextureReadWrite readWrite)
	{
		this.width = 0;
		this.height = 0;
		msaaSamples = 0;
		volumeDepth = 0;
		this.mipCount = 0;
		_graphicsFormat = default(GraphicsFormat);
		_003CstencilFormat_003Ek__BackingField = default(GraphicsFormat);
		depthStencilFormat = default(GraphicsFormat);
		dimension = default(TextureDimension);
		shadowSamplingMode = default(ShadowSamplingMode);
		vrUsage = default(VRTextureUsage);
		_flags = default(RenderTextureCreationFlags);
		memoryless = default(RenderTextureMemoryless);
	}

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits, int mipCount)
	{
		this.width = 0;
		this.height = 0;
		msaaSamples = 0;
		volumeDepth = 0;
		this.mipCount = 0;
		_graphicsFormat = default(GraphicsFormat);
		_003CstencilFormat_003Ek__BackingField = default(GraphicsFormat);
		depthStencilFormat = default(GraphicsFormat);
		dimension = default(TextureDimension);
		shadowSamplingMode = default(ShadowSamplingMode);
		vrUsage = default(VRTextureUsage);
		_flags = default(RenderTextureCreationFlags);
		memoryless = default(RenderTextureMemoryless);
	}

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat)
	{
		this.width = 0;
		this.height = 0;
		msaaSamples = 0;
		volumeDepth = 0;
		mipCount = 0;
		_graphicsFormat = default(GraphicsFormat);
		_003CstencilFormat_003Ek__BackingField = default(GraphicsFormat);
		this.depthStencilFormat = default(GraphicsFormat);
		dimension = default(TextureDimension);
		shadowSamplingMode = default(ShadowSamplingMode);
		vrUsage = default(VRTextureUsage);
		_flags = default(RenderTextureCreationFlags);
		memoryless = default(RenderTextureMemoryless);
	}

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount)
	{
		this.width = 0;
		this.height = 0;
		msaaSamples = 0;
		volumeDepth = 0;
		this.mipCount = 0;
		_graphicsFormat = default(GraphicsFormat);
		_003CstencilFormat_003Ek__BackingField = default(GraphicsFormat);
		this.depthStencilFormat = default(GraphicsFormat);
		dimension = default(TextureDimension);
		shadowSamplingMode = default(ShadowSamplingMode);
		vrUsage = default(VRTextureUsage);
		_flags = default(RenderTextureCreationFlags);
		memoryless = default(RenderTextureMemoryless);
	}

	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag)
	{
	}
}
