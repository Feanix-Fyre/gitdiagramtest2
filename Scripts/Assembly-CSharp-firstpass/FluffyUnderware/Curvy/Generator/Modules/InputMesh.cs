using System.Collections.Generic;
using System.Diagnostics;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules;

[ModuleInfo("Input/Meshes", ModuleName = "Input Meshes", Description = "Create VMeshes")]
[HelpURL("https://curvyeditor.com/doclink/cginputmesh")]
public class InputMesh : CGModule, IExternalInput
{
	[OutputSlotInfo(typeof(CGVMesh), Array = true)]
	[HideInInspector]
	public CGModuleOutputSlot OutVMesh;

	[SerializeField]
	[ArrayEx]
	private List<CGMeshProperties> m_Meshes;

	public List<CGMeshProperties> Meshes => null;

	public bool SupportsIPE => false;

	protected override void OnValidate()
	{
	}

	public override void Reset()
	{
	}

	public override void Refresh()
	{
	}

	public override void OnTemplateCreated()
	{
	}

	[System.Diagnostics.Conditional("UNITY_EDITOR")]
	private void WarnAboutInvalidInputs()
	{
	}
}
