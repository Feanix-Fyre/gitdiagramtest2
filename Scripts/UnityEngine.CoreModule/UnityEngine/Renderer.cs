using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine;

[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[RequireComponent(typeof(Transform))]
[NativeHeader("Runtime/Graphics/Renderer.h")]
public class Renderer : Component
{
	public Bounds bounds
	{
		[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = true)]
		get
		{
			return default(Bounds);
		}
	}

	public Bounds localBounds
	{
		[FreeFunction(Name = "RendererScripting::GetLocalBounds", HasExplicitThis = true)]
		get
		{
			return default(Bounds);
		}
		[NativeName("SetLocalAABB")]
		set
		{
		}
	}

	public bool enabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isVisible
	{
		[NativeName("IsVisibleInScene")]
		get
		{
			return false;
		}
	}

	public ShadowCastingMode shadowCastingMode
	{
		get
		{
			return default(ShadowCastingMode);
		}
		set
		{
		}
	}

	public bool receiveShadows
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool forceRenderingOff
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public MotionVectorGenerationMode motionVectorGenerationMode
	{
		get
		{
			return default(MotionVectorGenerationMode);
		}
		set
		{
		}
	}

	public LightProbeUsage lightProbeUsage
	{
		set
		{
		}
	}

	public ReflectionProbeUsage reflectionProbeUsage
	{
		set
		{
		}
	}

	public uint renderingLayerMask
	{
		set
		{
		}
	}

	public int sortingLayerID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int sortingOrder
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int sortingGroupID => 0;

	internal int sortingGroupOrder => 0;

	[NativeProperty("IsDynamicOccludee")]
	public bool allowOcclusionWhenDynamic
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isPartOfStaticBatch
	{
		[NativeName("IsPartOfStaticBatch")]
		get
		{
			return false;
		}
	}

	public Matrix4x4 localToWorldMatrix => default(Matrix4x4);

	public Transform probeAnchor
	{
		set
		{
		}
	}

	public int lightmapIndex => 0;

	public int realtimeLightmapIndex => 0;

	public Vector4 lightmapScaleOffset => default(Vector4);

	public Vector4 realtimeLightmapScaleOffset => default(Vector4);

	public Material[] materials
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Material material
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Material sharedMaterial
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Material[] sharedMaterials
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = true)]
	private Material GetMaterial()
	{
		return null;
	}

	[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = true)]
	private Material GetSharedMaterial()
	{
		return null;
	}

	[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = true)]
	private void SetMaterial(Material m)
	{
	}

	[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = true)]
	private Material[] GetMaterialArray()
	{
		return null;
	}

	[FreeFunction(Name = "RendererScripting::GetSharedMaterialArray", HasExplicitThis = true)]
	private void CopySharedMaterialArray([Out] Material[] m)
	{
	}

	[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = true)]
	private void SetMaterialArray([NotNull("ArgumentNullException")] Material[] m, int length)
	{
	}

	private void SetMaterialArray(Material[] m)
	{
	}

	[FreeFunction(Name = "RendererScripting::SetPropertyBlock", HasExplicitThis = true)]
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties)
	{
	}

	[FreeFunction(Name = "RendererScripting::GetPropertyBlock", HasExplicitThis = true)]
	internal void Internal_GetPropertyBlock([NotNull("ArgumentNullException")] MaterialPropertyBlock dest)
	{
	}

	[FreeFunction(Name = "RendererScripting::SetPropertyBlockMaterialIndex", HasExplicitThis = true)]
	internal void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex)
	{
	}

	public void SetPropertyBlock(MaterialPropertyBlock properties)
	{
	}

	public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex)
	{
	}

	public void GetPropertyBlock(MaterialPropertyBlock properties)
	{
	}

	[NativeName("GetLightmapIndexInt")]
	private int GetLightmapIndex(LightmapType lt)
	{
		return 0;
	}

	[NativeName("GetLightmapST")]
	private Vector4 GetLightmapST(LightmapType lt)
	{
		return default(Vector4);
	}

	private int GetMaterialCount()
	{
		return 0;
	}

	[NativeName("GetMaterialArray")]
	private Material[] GetSharedMaterialArray()
	{
		return null;
	}

	public void GetSharedMaterials(List<Material> m)
	{
	}

	[SpecialName]
	private void get_bounds_Injected(out Bounds ret)
	{
		ret = default(Bounds);
	}

	[SpecialName]
	private void get_localBounds_Injected(out Bounds ret)
	{
		ret = default(Bounds);
	}

	[SpecialName]
	private void set_localBounds_Injected(ref Bounds value)
	{
	}

	[SpecialName]
	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret)
	{
		ret = default(Matrix4x4);
	}

	private void GetLightmapST_Injected(LightmapType lt, out Vector4 ret)
	{
		ret = default(Vector4);
	}
}
