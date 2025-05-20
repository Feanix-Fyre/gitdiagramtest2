using System;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules;

[HelpURL("https://curvyeditor.com/doclink/cgtrspath")]
[ModuleInfo("Modifier/TRS Path", ModuleName = "TRS Path", Description = "Transform,Rotate,Scale a Path")]
public class ModifierTRSPath : TRSModuleBase, IOnRequestProcessing, IPathProvider
{
	[HideInInspector]
	[InputSlotInfo(new Type[] { typeof(CGPath) }, Name = "Path A", ModifiesData = true)]
	public CGModuleInputSlot InPath;

	[OutputSlotInfo(typeof(CGPath))]
	[HideInInspector]
	public CGModuleOutputSlot OutPath;

	public bool PathIsClosed => false;

	public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
	{
		return null;
	}
}
