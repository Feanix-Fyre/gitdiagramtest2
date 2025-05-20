using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
public sealed class ComputeShader : Object
{
	[NativeMethod(Name = "ComputeShaderScripting::FindKernel", HasExplicitThis = true, IsFreeFunction = true, ThrowsException = true)]
	[RequiredByNativeCode]
	public int FindKernel(string name)
	{
		return 0;
	}

	[FreeFunction(Name = "ComputeShaderScripting::SetValue<int>", HasExplicitThis = true)]
	public void SetInt(int nameID, int val)
	{
	}

	[FreeFunction(Name = "ComputeShaderScripting::SetValue<Vector4f>", HasExplicitThis = true)]
	public void SetVector(int nameID, Vector4 val)
	{
	}

	[NativeMethod(Name = "ComputeShaderScripting::SetTexture", HasExplicitThis = true, IsFreeFunction = true, ThrowsException = true)]
	public void SetTexture(int kernelIndex, int nameID, [NotNull("ArgumentNullException")] Texture texture, int mipLevel)
	{
	}

	[FreeFunction(Name = "ComputeShaderScripting::SetBuffer", HasExplicitThis = true)]
	private void Internal_SetBuffer(int kernelIndex, int nameID, [NotNull("ArgumentNullException")] ComputeBuffer buffer)
	{
	}

	public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer)
	{
	}

	[FreeFunction(Name = "ComputeShaderScripting::SetConstantBuffer", HasExplicitThis = true)]
	private void SetConstantComputeBuffer(int nameID, [NotNull("ArgumentNullException")] ComputeBuffer buffer, int offset, int size)
	{
	}

	[NativeMethod(Name = "ComputeShaderScripting::GetKernelThreadGroupSizes", HasExplicitThis = true, IsFreeFunction = true, ThrowsException = true)]
	public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z)
	{
		x = default(uint);
		y = default(uint);
		z = default(uint);
	}

	[NativeName("DispatchComputeShader")]
	public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
	{
	}

	[FreeFunction("ComputeShaderScripting::EnableKeyword", HasExplicitThis = true)]
	public void EnableKeyword(string keyword)
	{
	}

	[FreeFunction("ComputeShaderScripting::DisableKeyword", HasExplicitThis = true)]
	public void DisableKeyword(string keyword)
	{
	}

	public void SetVector(string name, Vector4 val)
	{
	}

	public void SetTexture(int kernelIndex, string name, Texture texture)
	{
	}

	public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer)
	{
	}

	public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
	{
	}

	private void SetVector_Injected(int nameID, ref Vector4 val)
	{
	}
}
