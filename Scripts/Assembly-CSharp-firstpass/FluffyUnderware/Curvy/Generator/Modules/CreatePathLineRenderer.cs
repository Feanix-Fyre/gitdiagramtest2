using System;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules;

[ModuleInfo("Create/Path Line Renderer", ModuleName = "Create Path Line Renderer", Description = "Feeds a Line Renderer with a Path")]
[HelpURL("https://curvyeditor.com/doclink/cgcreatepathlinerenderer")]
[RequireComponent(typeof(LineRenderer))]
public class CreatePathLineRenderer : CGModule
{
	[HideInInspector]
	[InputSlotInfo(new Type[] { typeof(CGPath) }, DisplayName = "Rasterized Path")]
	public CGModuleInputSlot InPath;

	private LineRenderer mLineRenderer;

	public LineRenderer LineRenderer => null;

	public override void Reset()
	{
	}

	public override void Refresh()
	{
	}
}
