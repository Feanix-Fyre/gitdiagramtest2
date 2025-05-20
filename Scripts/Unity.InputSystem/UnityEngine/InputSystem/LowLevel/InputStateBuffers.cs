using System;

namespace UnityEngine.InputSystem.LowLevel;

internal struct InputStateBuffers
{
	[Serializable]
	internal struct DoubleBuffers
	{
		public unsafe void** deviceToBufferMapping;

		public bool valid => false;

		public unsafe void SetFrontBuffer(int deviceIndex, void* ptr)
		{
		}

		public unsafe void SetBackBuffer(int deviceIndex, void* ptr)
		{
		}

		public unsafe void* GetFrontBuffer(int deviceIndex)
		{
			return null;
		}

		public unsafe void* GetBackBuffer(int deviceIndex)
		{
			return null;
		}

		public void SwapBuffers(int deviceIndex)
		{
		}
	}

	public uint sizePerBuffer;

	public uint totalSize;

	public unsafe void* defaultStateBuffer;

	public unsafe void* noiseMaskBuffer;

	public unsafe void* resetMaskBuffer;

	private unsafe void* m_AllBuffers;

	internal DoubleBuffers m_PlayerStateBuffers;

	internal unsafe static void* s_DefaultStateBuffer;

	internal unsafe static void* s_NoiseMaskBuffer;

	internal unsafe static void* s_ResetMaskBuffer;

	internal static DoubleBuffers s_CurrentBuffers;

	public DoubleBuffers GetDoubleBuffersFor(InputUpdateType updateType)
	{
		return default(DoubleBuffers);
	}

	public unsafe static void* GetFrontBufferForDevice(int deviceIndex)
	{
		return null;
	}

	public unsafe static void* GetBackBufferForDevice(int deviceIndex)
	{
		return null;
	}

	public static void SwitchTo(InputStateBuffers buffers, InputUpdateType update)
	{
	}

	public void AllocateAll(InputDevice[] devices, int deviceCount)
	{
	}

	private unsafe static DoubleBuffers SetUpDeviceToBufferMappings(int deviceCount, ref byte* bufferPtr, uint sizePerBuffer, uint mappingTableSizePerBuffer)
	{
		return default(DoubleBuffers);
	}

	public void FreeAll()
	{
	}

	public void MigrateAll(InputDevice[] devices, int deviceCount, InputStateBuffers oldBuffers)
	{
	}

	private static void MigrateDoubleBuffer(DoubleBuffers newBuffer, InputDevice[] devices, int deviceCount, DoubleBuffers oldBuffer)
	{
	}

	private unsafe static void MigrateSingleBuffer(void* newBuffer, InputDevice[] devices, int deviceCount, void* oldBuffer)
	{
	}

	private static uint ComputeSizeOfSingleStateBuffer(InputDevice[] devices, int deviceCount)
	{
		return 0u;
	}

	private static uint NextDeviceOffset(uint currentOffset, InputDevice device)
	{
		return 0u;
	}
}
