using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

[StaticAccessor("GetGraphicsSettings()", StaticAccessorType.Dot)]
[NativeHeader("Runtime/Camera/GraphicsSettings.h")]
public sealed class GraphicsSettings : Object
{
	public static bool lightsUseLinearIntensity
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool lightsUseColorTemperature
	{
		set
		{
		}
	}

	public static uint defaultRenderingLayerMask
	{
		set
		{
		}
	}

	public static bool useScriptableRenderPipelineBatching
	{
		set
		{
		}
	}

	[NativeName("CurrentRenderPipeline")]
	private static ScriptableObject INTERNAL_currentRenderPipeline => null;

	public static RenderPipelineAsset currentRenderPipeline => null;

	public static RenderPipelineAsset renderPipelineAsset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[NativeName("DefaultRenderPipeline")]
	private static ScriptableObject INTERNAL_defaultRenderPipeline
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static RenderPipelineAsset defaultRenderPipeline
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static RenderPipelineAsset[] allConfiguredRenderPipelines => null;

	public static bool HasShaderDefine(GraphicsTier tier, BuiltinShaderDefine defineHash)
	{
		return false;
	}

	public static bool HasShaderDefine(BuiltinShaderDefine defineHash)
	{
		return false;
	}

	[NativeName("GetAllConfiguredRenderPipelinesForScript")]
	private static ScriptableObject[] GetAllConfiguredRenderPipelines()
	{
		return null;
	}

	[NativeName("GetShaderModeScript")]
	public static BuiltinShaderMode GetShaderMode(BuiltinShaderType type)
	{
		return default(BuiltinShaderMode);
	}

	public static void RegisterRenderPipelineSettings<T>(RenderPipelineGlobalSettings settings) where T : RenderPipeline
	{
	}

	[NativeName("RegisterRenderPipelineSettings")]
	private static void RegisterRenderPipeline(string renderpipelineName, Object settings)
	{
	}

	public static void UnregisterRenderPipelineSettings<T>() where T : RenderPipeline
	{
	}

	[NativeName("UnregisterRenderPipelineSettings")]
	private static void UnregisterRenderPipeline(string renderpipelineName)
	{
	}

	public static RenderPipelineGlobalSettings GetSettingsForRenderPipeline<T>() where T : RenderPipeline
	{
		return null;
	}

	[NativeName("GetSettingsForRenderPipeline")]
	private static Object GetSettingsForRenderPipeline(string renderpipelineName)
	{
		return null;
	}
}
