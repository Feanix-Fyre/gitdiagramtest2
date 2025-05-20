using System;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Material.h")]
public class Material : Object
{
	public Shader shader
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Color color
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Texture mainTexture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int renderQueue
	{
		[NativeName("GetActualRenderQueue")]
		get
		{
			return 0;
		}
		[NativeName("SetCustomRenderQueue")]
		set
		{
		}
	}

	internal int rawRenderQueue
	{
		[NativeName("GetCustomRenderQueue")]
		get
		{
			return 0;
		}
	}

	public LocalKeyword[] enabledKeywords
	{
		set
		{
		}
	}

	[NativeProperty("EnableInstancingVariants")]
	public bool enableInstancing
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int passCount
	{
		[NativeName("GetShader()->GetPassCount")]
		get
		{
			return 0;
		}
	}

	public string[] shaderKeywords
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[FreeFunction("MaterialScripting::CreateWithShader")]
	private static void CreateWithShader([Writable] Material self, [NotNull("ArgumentNullException")] Shader shader)
	{
	}

	[FreeFunction("MaterialScripting::CreateWithMaterial")]
	private static void CreateWithMaterial([Writable] Material self, [NotNull("ArgumentNullException")] Material source)
	{
	}

	[FreeFunction("MaterialScripting::CreateWithString")]
	private static void CreateWithString([Writable] Material self)
	{
	}

	public Material(Shader shader)
	{
	}

	[RequiredByNativeCode]
	public Material(Material source)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", false)]
	public Material(string contents)
	{
	}

	[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag)
	{
		return 0;
	}

	[NativeName("HasPropertyFromScript")]
	public bool HasProperty(int nameID)
	{
		return false;
	}

	public bool HasProperty(string name)
	{
		return false;
	}

	public void EnableKeyword(string keyword)
	{
	}

	public void DisableKeyword(string keyword)
	{
	}

	public bool IsKeywordEnabled(string keyword)
	{
		return false;
	}

	[FreeFunction("MaterialScripting::SetEnabledKeywords", HasExplicitThis = true)]
	private void SetEnabledKeywords(LocalKeyword[] keywords)
	{
	}

	[FreeFunction("MaterialScripting::SetShaderPassEnabled", HasExplicitThis = true)]
	public void SetShaderPassEnabled(string passName, bool enabled)
	{
	}

	public int FindPass(string passName)
	{
		return 0;
	}

	[NativeName("GetTag")]
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue)
	{
		return null;
	}

	public string GetTag(string tag, bool searchFallbacks)
	{
		return null;
	}

	[FreeFunction("MaterialScripting::Lerp", HasExplicitThis = true)]
	[NativeThrows]
	public void Lerp(Material start, Material end, float t)
	{
	}

	[FreeFunction("MaterialScripting::SetPass", HasExplicitThis = true)]
	public bool SetPass(int pass)
	{
		return false;
	}

	[FreeFunction("MaterialScripting::CopyPropertiesFrom", HasExplicitThis = true)]
	public void CopyPropertiesFromMaterial(Material mat)
	{
	}

	[FreeFunction("MaterialScripting::GetShaderKeywords", HasExplicitThis = true)]
	private string[] GetShaderKeywords()
	{
		return null;
	}

	[FreeFunction("MaterialScripting::SetShaderKeywords", HasExplicitThis = true)]
	private void SetShaderKeywords(string[] names)
	{
	}

	public int ComputeCRC()
	{
		return 0;
	}

	[NativeName("SetIntFromScript")]
	private void SetIntImpl(int name, int value)
	{
	}

	[NativeName("SetFloatFromScript")]
	private void SetFloatImpl(int name, float value)
	{
	}

	[NativeName("SetColorFromScript")]
	private void SetColorImpl(int name, Color value)
	{
	}

	[NativeName("SetMatrixFromScript")]
	private void SetMatrixImpl(int name, Matrix4x4 value)
	{
	}

	[NativeName("SetTextureFromScript")]
	private void SetTextureImpl(int name, Texture value)
	{
	}

	[NativeName("SetBufferFromScript")]
	private void SetBufferImpl(int name, ComputeBuffer value)
	{
	}

	[NativeName("SetConstantBufferFromScript")]
	private void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
	{
	}

	[NativeName("GetFloatFromScript")]
	private float GetFloatImpl(int name)
	{
		return 0f;
	}

	[NativeName("GetColorFromScript")]
	private Color GetColorImpl(int name)
	{
		return default(Color);
	}

	[NativeName("GetTextureFromScript")]
	private Texture GetTextureImpl(int name)
	{
		return null;
	}

	[FreeFunction(Name = "MaterialScripting::SetFloatArray", HasExplicitThis = true)]
	private void SetFloatArrayImpl(int name, float[] values, int count)
	{
	}

	[FreeFunction(Name = "MaterialScripting::SetVectorArray", HasExplicitThis = true)]
	private void SetVectorArrayImpl(int name, Vector4[] values, int count)
	{
	}

	[FreeFunction(Name = "MaterialScripting::SetMatrixArray", HasExplicitThis = true)]
	private void SetMatrixArrayImpl(int name, Matrix4x4[] values, int count)
	{
	}

	[NativeName("GetTextureScaleAndOffsetFromScript")]
	private Vector4 GetTextureScaleAndOffsetImpl(int name)
	{
		return default(Vector4);
	}

	private void SetFloatArray(int name, float[] values, int count)
	{
	}

	private void SetVectorArray(int name, Vector4[] values, int count)
	{
	}

	private void SetMatrixArray(int name, Matrix4x4[] values, int count)
	{
	}

	public void SetInt(string name, int value)
	{
	}

	public void SetInt(int nameID, int value)
	{
	}

	public void SetFloat(string name, float value)
	{
	}

	public void SetFloat(int nameID, float value)
	{
	}

	public void SetInteger(int nameID, int value)
	{
	}

	public void SetColor(string name, Color value)
	{
	}

	public void SetColor(int nameID, Color value)
	{
	}

	public void SetVector(string name, Vector4 value)
	{
	}

	public void SetVector(int nameID, Vector4 value)
	{
	}

	public void SetMatrix(string name, Matrix4x4 value)
	{
	}

	public void SetMatrix(int nameID, Matrix4x4 value)
	{
	}

	public void SetTexture(string name, Texture value)
	{
	}

	public void SetTexture(int nameID, Texture value)
	{
	}

	public void SetBuffer(string name, ComputeBuffer value)
	{
	}

	public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
	{
	}

	public void SetFloatArray(int nameID, float[] values)
	{
	}

	public void SetVectorArray(int nameID, Vector4[] values)
	{
	}

	public void SetMatrixArray(int nameID, Matrix4x4[] values)
	{
	}

	public int GetInt(string name)
	{
		return 0;
	}

	public int GetInt(int nameID)
	{
		return 0;
	}

	public float GetFloat(string name)
	{
		return 0f;
	}

	public float GetFloat(int nameID)
	{
		return 0f;
	}

	public Color GetColor(string name)
	{
		return default(Color);
	}

	public Color GetColor(int nameID)
	{
		return default(Color);
	}

	public Vector4 GetVector(string name)
	{
		return default(Vector4);
	}

	public Vector4 GetVector(int nameID)
	{
		return default(Vector4);
	}

	public Texture GetTexture(string name)
	{
		return null;
	}

	public Texture GetTexture(int nameID)
	{
		return null;
	}

	public Vector2 GetTextureOffset(int nameID)
	{
		return default(Vector2);
	}

	public Vector2 GetTextureScale(int nameID)
	{
		return default(Vector2);
	}

	private void SetColorImpl_Injected(int name, ref Color value)
	{
	}

	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value)
	{
	}

	private void GetColorImpl_Injected(int name, out Color ret)
	{
		ret = default(Color);
	}

	private void GetTextureScaleAndOffsetImpl_Injected(int name, out Vector4 ret)
	{
		ret = default(Vector4);
	}
}
