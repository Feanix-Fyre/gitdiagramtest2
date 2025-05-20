using System.Collections.Generic;
using UnityEngine;

namespace StylizedWater2;

[DisallowMultipleComponent]
[AddComponentMenu("Stylized Water 2/Water Object")]
[ExecuteInEditMode]
public class WaterObject : MonoBehaviour
{
	public static readonly List<WaterObject> Instances;

	public Material material;

	public MeshFilter meshFilter;

	public MeshRenderer meshRenderer;

	private MaterialPropertyBlock _props;

	public MaterialPropertyBlock props
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	private void CreatePropertyBlock(Renderer sourceRenderer)
	{
	}

	private void Reset()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnValidate()
	{
	}

	public Material FetchWaterMaterial()
	{
		return null;
	}

	public void ApplyInstancedProperties()
	{
	}

	public bool CanTouch(Vector3 position)
	{
		return false;
	}

	public void AssignMesh(Mesh mesh)
	{
	}

	public void AssignMaterial(Material newMaterial)
	{
	}

	public static WaterObject New(Material waterMaterial = null, Mesh mesh = null)
	{
		return null;
	}

	public static WaterObject Find(Vector3 position, bool rotationSupport)
	{
		return null;
	}
}
