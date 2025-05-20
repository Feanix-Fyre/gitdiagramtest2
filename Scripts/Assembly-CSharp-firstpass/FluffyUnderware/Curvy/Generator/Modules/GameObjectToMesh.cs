using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules;

[HelpURL("https://curvyeditor.com/doclink/cggameobject2mesh")]
[ModuleInfo("Convert/GameObject To Mesh", ModuleName = "GameObject To Mesh", Description = "Converts GameObjects to Volume Meshes")]
public class GameObjectToMesh : CGModule
{
	[HideInInspector]
	[InputSlotInfo(new Type[] { typeof(CGGameObject) }, Array = true)]
	public CGModuleInputSlot InGameObjects;

	[OutputSlotInfo(typeof(CGVMesh), Array = true)]
	[HideInInspector]
	public CGModuleOutputSlot OutVMesh;

	[SerializeField]
	[Tooltip("Whether to include or not the meshes from the input Game Objects' children")]
	private bool useChildrenMeshes;

	[SerializeField]
	[Tooltip("Forces the output mesh to be centered")]
	private bool centerMesh;

	public bool UseChildrenMeshes
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool CenterMesh
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override void Reset()
	{
	}

	public override void Refresh()
	{
	}

	public static Mesh CombineMeshFilters(MeshFilter[] meshFilters, out List<Material> materials, Matrix4x4 originTrs, [CanBeNull] List<string> errorMessages)
	{
		materials = null;
		return null;
	}
}
