using System;

namespace UnityEngine.Rendering;

public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier>
{
	public const int AllDepthSlices = -1;

	private BuiltinRenderTextureType m_Type;

	private int m_NameID;

	private int m_InstanceID;

	private IntPtr m_BufferPointer;

	private int m_MipLevel;

	private CubemapFace m_CubeFace;

	private int m_DepthSlice;

	public RenderTargetIdentifier(BuiltinRenderTextureType type)
	{
		m_Type = default(BuiltinRenderTextureType);
		m_NameID = 0;
		m_InstanceID = 0;
		m_BufferPointer = (IntPtr)0;
		m_MipLevel = 0;
		m_CubeFace = default(CubemapFace);
		m_DepthSlice = 0;
	}

	public RenderTargetIdentifier(string name)
	{
		m_Type = default(BuiltinRenderTextureType);
		m_NameID = 0;
		m_InstanceID = 0;
		m_BufferPointer = (IntPtr)0;
		m_MipLevel = 0;
		m_CubeFace = default(CubemapFace);
		m_DepthSlice = 0;
	}

	public RenderTargetIdentifier(string name, int mipLevel = 0, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
	{
		m_Type = default(BuiltinRenderTextureType);
		m_NameID = 0;
		m_InstanceID = 0;
		m_BufferPointer = (IntPtr)0;
		m_MipLevel = 0;
		m_CubeFace = default(CubemapFace);
		m_DepthSlice = 0;
	}

	public RenderTargetIdentifier(int nameID)
	{
		m_Type = default(BuiltinRenderTextureType);
		m_NameID = 0;
		m_InstanceID = 0;
		m_BufferPointer = (IntPtr)0;
		m_MipLevel = 0;
		m_CubeFace = default(CubemapFace);
		m_DepthSlice = 0;
	}

	public RenderTargetIdentifier(int nameID, int mipLevel = 0, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
	{
		m_Type = default(BuiltinRenderTextureType);
		m_NameID = 0;
		m_InstanceID = 0;
		m_BufferPointer = (IntPtr)0;
		m_MipLevel = 0;
		m_CubeFace = default(CubemapFace);
		m_DepthSlice = 0;
	}

	public RenderTargetIdentifier(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
	{
		m_Type = default(BuiltinRenderTextureType);
		m_NameID = 0;
		m_InstanceID = 0;
		m_BufferPointer = (IntPtr)0;
		m_MipLevel = 0;
		m_CubeFace = default(CubemapFace);
		m_DepthSlice = 0;
	}

	public RenderTargetIdentifier(Texture tex)
	{
		m_Type = default(BuiltinRenderTextureType);
		m_NameID = 0;
		m_InstanceID = 0;
		m_BufferPointer = (IntPtr)0;
		m_MipLevel = 0;
		m_CubeFace = default(CubemapFace);
		m_DepthSlice = 0;
	}

	public RenderTargetIdentifier(Texture tex, int mipLevel = 0, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
	{
		m_Type = default(BuiltinRenderTextureType);
		m_NameID = 0;
		m_InstanceID = 0;
		m_BufferPointer = (IntPtr)0;
		m_MipLevel = 0;
		m_CubeFace = default(CubemapFace);
		m_DepthSlice = 0;
	}

	public RenderTargetIdentifier(RenderBuffer buf, int mipLevel = 0, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
	{
		m_Type = default(BuiltinRenderTextureType);
		m_NameID = 0;
		m_InstanceID = 0;
		m_BufferPointer = (IntPtr)0;
		m_MipLevel = 0;
		m_CubeFace = default(CubemapFace);
		m_DepthSlice = 0;
	}

	public static implicit operator RenderTargetIdentifier(BuiltinRenderTextureType type)
	{
		return default(RenderTargetIdentifier);
	}

	public static implicit operator RenderTargetIdentifier(string name)
	{
		return default(RenderTargetIdentifier);
	}

	public static implicit operator RenderTargetIdentifier(int nameID)
	{
		return default(RenderTargetIdentifier);
	}

	public static implicit operator RenderTargetIdentifier(Texture tex)
	{
		return default(RenderTargetIdentifier);
	}

	public static implicit operator RenderTargetIdentifier(RenderBuffer buf)
	{
		return default(RenderTargetIdentifier);
	}

	public override string ToString()
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public bool Equals(RenderTargetIdentifier rhs)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public static bool operator ==(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs)
	{
		return false;
	}

	public static bool operator !=(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs)
	{
		return false;
	}
}
