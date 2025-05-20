using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering;

public sealed class ShaderDebugPrintManager
{
	private static class Profiling
	{
		public static readonly ProfilingSampler BufferReadComplete;
	}

	private enum DebugValueType
	{
		TypeUint = 1,
		TypeInt = 2,
		TypeFloat = 3,
		TypeUint2 = 4,
		TypeInt2 = 5,
		TypeFloat2 = 6,
		TypeUint3 = 7,
		TypeInt3 = 8,
		TypeFloat3 = 9,
		TypeUint4 = 10,
		TypeInt4 = 11,
		TypeFloat4 = 12,
		TypeBool = 13
	}

	private static readonly ShaderDebugPrintManager s_Instance;

	private const int k_DebugUAVSlot = 7;

	private const int k_FramesInFlight = 4;

	private const int k_MaxBufferElements = 16384;

	private List<GraphicsBuffer> m_OutputBuffers;

	private List<AsyncGPUReadbackRequest> m_ReadbackRequests;

	private Action<AsyncGPUReadbackRequest> m_BufferReadCompleteAction;

	private int m_FrameCounter;

	private bool m_FrameCleared;

	private string m_OutputLine;

	private Action<string> m_OutputAction;

	private static readonly int m_ShaderPropertyIDInputMouse;

	private static readonly int m_ShaderPropertyIDInputFrame;

	private const uint k_TypeHasTag = 128u;

	public static ShaderDebugPrintManager instance => null;

	public string outputLine => null;

	public Action<string> outputAction
	{
		set
		{
		}
	}

	private int DebugValueTypeToElemSize(DebugValueType type)
	{
		return 0;
	}

	private ShaderDebugPrintManager()
	{
	}

	public void SetShaderDebugPrintInputConstants(CommandBuffer cmd, ShaderDebugPrintInput input)
	{
	}

	public void SetShaderDebugPrintBindings(CommandBuffer cmd)
	{
	}

	private void ClearShaderDebugPrintBuffer()
	{
	}

	private void BufferReadComplete(AsyncGPUReadbackRequest request)
	{
	}

	public void EndFrame()
	{
	}

	public void DefaultOutput(string line)
	{
	}
}
