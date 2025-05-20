using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine;

[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[NativeHeader("Runtime/Shaders/GpuPrograms/ShaderVariantCollection.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Misc/ResourceManager.h")]
[NativeHeader("Runtime/Shaders/ShaderNameRegistry.h")]
public sealed class Shader : Object
{
	public bool isSupported
	{
		[NativeMethod("IsSupported")]
		get
		{
			return false;
		}
	}

	public static string globalRenderPipeline
	{
		set
		{
		}
	}

	public LocalKeywordSpace keywordSpace => default(LocalKeywordSpace);

	public int passCount
	{
		[FreeFunction(Name = "ShaderScripting::GetPassCount", HasExplicitThis = true)]
		get
		{
			return 0;
		}
	}

	public static Shader Find(string name)
	{
		return null;
	}

	[FreeFunction("ShaderScripting::EnableKeyword")]
	public static void EnableKeyword(string keyword)
	{
	}

	[FreeFunction("ShaderScripting::DisableKeyword")]
	public static void DisableKeyword(string keyword)
	{
	}

	[FreeFunction("ShaderScripting::TagToID")]
	internal static int TagToID(string name)
	{
		return 0;
	}

	[FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = true)]
	public static int PropertyToID(string name)
	{
		return 0;
	}

	[FreeFunction("ShaderScripting::SetGlobalFloat")]
	private static void SetGlobalFloatImpl(int name, float value)
	{
	}

	[FreeFunction("ShaderScripting::SetGlobalVector")]
	private static void SetGlobalVectorImpl(int name, Vector4 value)
	{
	}

	[FreeFunction("ShaderScripting::SetGlobalMatrix")]
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value)
	{
	}

	[FreeFunction("ShaderScripting::SetGlobalTexture")]
	private static void SetGlobalTextureImpl(int name, Texture value)
	{
	}

	[FreeFunction("ShaderScripting::SetGlobalConstantBuffer")]
	private static void SetGlobalConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
	{
	}

	[FreeFunction("ShaderScripting::SetGlobalVectorArray")]
	private static void SetGlobalVectorArrayImpl(int name, Vector4[] values, int count)
	{
	}

	[FreeFunction("ShaderScripting::SetGlobalMatrixArray")]
	private static void SetGlobalMatrixArrayImpl(int name, Matrix4x4[] values, int count)
	{
	}

	private static void SetGlobalVectorArray(int name, Vector4[] values, int count)
	{
	}

	private static void SetGlobalMatrixArray(int name, Matrix4x4[] values, int count)
	{
	}

	public static void SetGlobalInt(string name, int value)
	{
	}

	public static void SetGlobalInt(int nameID, int value)
	{
	}

	public static void SetGlobalFloat(string name, float value)
	{
	}

	public static void SetGlobalFloat(int nameID, float value)
	{
	}

	public static void SetGlobalVector(string name, Vector4 value)
	{
	}

	public static void SetGlobalVector(int nameID, Vector4 value)
	{
	}

	public static void SetGlobalColor(string name, Color value)
	{
	}

	public static void SetGlobalColor(int nameID, Color value)
	{
	}

	public static void SetGlobalMatrix(int nameID, Matrix4x4 value)
	{
	}

	public static void SetGlobalTexture(string name, Texture value)
	{
	}

	public static void SetGlobalTexture(int nameID, Texture value)
	{
	}

	public static void SetGlobalConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
	{
	}

	public static void SetGlobalVectorArray(int nameID, Vector4[] values)
	{
	}

	public static void SetGlobalMatrixArray(int nameID, Matrix4x4[] values)
	{
	}

	private Shader()
	{
	}

	[SpecialName]
	private void get_keywordSpace_Injected(out LocalKeywordSpace ret)
	{
		ret = default(LocalKeywordSpace);
	}

	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value)
	{
	}

	private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value)
	{
	}
}
