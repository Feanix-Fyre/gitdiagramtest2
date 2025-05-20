using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/SkinnedMeshRenderer.h")]
[RequiredByNativeCode]
public class SkinnedMeshRenderer : Renderer
{
	public bool updateWhenOffscreen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Transform rootBone
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Transform[] bones
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[NativeProperty("Mesh")]
	public Mesh sharedMesh
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[NativeProperty("SkinnedMeshMotionVectors")]
	public bool skinnedMotionVectors
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float GetBlendShapeWeight(int index)
	{
		return 0f;
	}

	public void SetBlendShapeWeight(int index, float value)
	{
	}
}
