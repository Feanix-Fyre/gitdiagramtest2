using System.Collections.Generic;

namespace UnityEngine.Rendering;

public class ConstantBuffer
{
	private static List<ConstantBufferBase> m_RegisteredConstantBuffers;

	public static void PushGlobal<CBType>(CommandBuffer cmd, in CBType data, int shaderId) where CBType : struct
	{
	}

	public static void PushGlobal<CBType>(in CBType data, int shaderId) where CBType : struct
	{
	}

	public static void Push<CBType>(CommandBuffer cmd, in CBType data, ComputeShader cs, int shaderId) where CBType : struct
	{
	}

	public static void Push<CBType>(in CBType data, ComputeShader cs, int shaderId) where CBType : struct
	{
	}

	public static void Push<CBType>(CommandBuffer cmd, in CBType data, Material mat, int shaderId) where CBType : struct
	{
	}

	public static void Push<CBType>(in CBType data, Material mat, int shaderId) where CBType : struct
	{
	}

	public static void UpdateData<CBType>(CommandBuffer cmd, in CBType data) where CBType : struct
	{
	}

	public static void UpdateData<CBType>(in CBType data) where CBType : struct
	{
	}

	public static void SetGlobal<CBType>(CommandBuffer cmd, int shaderId) where CBType : struct
	{
	}

	public static void SetGlobal<CBType>(int shaderId) where CBType : struct
	{
	}

	public static void Set<CBType>(CommandBuffer cmd, ComputeShader cs, int shaderId) where CBType : struct
	{
	}

	public static void Set<CBType>(ComputeShader cs, int shaderId) where CBType : struct
	{
	}

	public static void Set<CBType>(Material mat, int shaderId) where CBType : struct
	{
	}

	public static void ReleaseAll()
	{
	}

	internal static void Register(ConstantBufferBase cb)
	{
	}
}
public class ConstantBuffer<CBType> : ConstantBufferBase where CBType : struct
{
	private HashSet<int> m_GlobalBindings;

	private CBType[] m_Data;

	private ComputeBuffer m_GPUConstantBuffer;

	public void UpdateData(CommandBuffer cmd, in CBType data)
	{
	}

	public void UpdateData(in CBType data)
	{
	}

	public void SetGlobal(CommandBuffer cmd, int shaderId)
	{
	}

	public void SetGlobal(int shaderId)
	{
	}

	public void Set(CommandBuffer cmd, ComputeShader cs, int shaderId)
	{
	}

	public void Set(ComputeShader cs, int shaderId)
	{
	}

	public void Set(Material mat, int shaderId)
	{
	}

	public void PushGlobal(CommandBuffer cmd, in CBType data, int shaderId)
	{
	}

	public void PushGlobal(in CBType data, int shaderId)
	{
	}

	public override void Release()
	{
	}
}
