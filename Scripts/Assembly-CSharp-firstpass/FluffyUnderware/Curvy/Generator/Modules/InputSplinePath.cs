using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules;

[HelpURL("https://curvyeditor.com/doclink/cginputsplinepath")]
[ModuleInfo("Input/Spline Path", ModuleName = "Input Spline Path", Description = "Spline Path")]
public class InputSplinePath : SplineInputModuleBase, IExternalInput, IOnRequestProcessing, IPathProvider
{
	[HideInInspector]
	[OutputSlotInfo(typeof(CGPath))]
	public CGModuleOutputSlot Path;

	[FieldCondition(/*Could not decode attribute arguments.*/)]
	[Tab("General", Sort = 0)]
	[SerializeField]
	[CGResourceManager("Spline")]
	private CurvySpline m_Spline;

	public CurvySpline Spline
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool SupportsIPE => false;

	protected override CurvySpline InputSpline
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
	{
		return null;
	}

	public override void OnTemplateCreated()
	{
	}
}
