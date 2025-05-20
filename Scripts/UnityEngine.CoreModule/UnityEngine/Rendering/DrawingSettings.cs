using System;

namespace UnityEngine.Rendering;

public struct DrawingSettings : IEquatable<DrawingSettings>
{
	public static readonly int maxShaderPasses;

	private SortingSettings m_SortingSettings;

	internal unsafe fixed int shaderPassNames[16];

	private PerObjectData m_PerObjectData;

	private DrawRendererFlags m_Flags;

	private int m_OverrideShaderID;

	private int m_OverrideShaderPassIndex;

	private int m_OverrideMaterialInstanceId;

	private int m_OverrideMaterialPassIndex;

	private int m_fallbackMaterialInstanceId;

	private int m_MainLightIndex;

	private int m_UseSrpBatcher;

	public SortingSettings sortingSettings
	{
		get
		{
			return default(SortingSettings);
		}
		set
		{
		}
	}

	public PerObjectData perObjectData
	{
		set
		{
		}
	}

	public bool enableDynamicBatching
	{
		set
		{
		}
	}

	public bool enableInstancing
	{
		set
		{
		}
	}

	public Material overrideMaterial
	{
		set
		{
		}
	}

	public Shader overrideShader
	{
		set
		{
		}
	}

	public int overrideMaterialPassIndex
	{
		set
		{
		}
	}

	public int overrideShaderPassIndex
	{
		set
		{
		}
	}

	public Material fallbackMaterial
	{
		set
		{
		}
	}

	public int mainLightIndex
	{
		set
		{
		}
	}

	public DrawingSettings(ShaderTagId shaderPassName, SortingSettings sortingSettings)
	{
		m_SortingSettings = default(SortingSettings);
		m_PerObjectData = default(PerObjectData);
		m_Flags = default(DrawRendererFlags);
		m_OverrideShaderID = 0;
		m_OverrideShaderPassIndex = 0;
		m_OverrideMaterialInstanceId = 0;
		m_OverrideMaterialPassIndex = 0;
		m_fallbackMaterialInstanceId = 0;
		m_MainLightIndex = 0;
		m_UseSrpBatcher = 0;
	}

	public ShaderTagId GetShaderPassName(int index)
	{
		return default(ShaderTagId);
	}

	public void SetShaderPassName(int index, ShaderTagId shaderPassName)
	{
	}

	public bool Equals(DrawingSettings other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(DrawingSettings left, DrawingSettings right)
	{
		return false;
	}
}
