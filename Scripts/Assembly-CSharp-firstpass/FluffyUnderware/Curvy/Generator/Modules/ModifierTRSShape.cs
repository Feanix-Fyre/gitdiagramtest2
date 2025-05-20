using System;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules;

[HelpURL("https://curvyeditor.com/doclink/cgtrsshape")]
[ModuleInfo("Modifier/TRS Shape", ModuleName = "TRS Shape", Description = "Transform,Rotate,Scale a Shape")]
public class ModifierTRSShape : TRSModuleBase, IOnRequestProcessing, IPathProvider
{
	[InputSlotInfo(new Type[] { typeof(CGShape) }, Name = "Shape A", ModifiesData = true)]
	[HideInInspector]
	public CGModuleInputSlot InShape;

	[HideInInspector]
	[OutputSlotInfo(typeof(CGShape))]
	public CGModuleOutputSlot OutShape;

	public bool PathIsClosed => false;

	public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
	{
		return null;
	}
}
