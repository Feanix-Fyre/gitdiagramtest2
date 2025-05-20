using UnityEngine;

namespace FluffyUnderware.Curvy;

[HelpURL("https://curvyeditor.com/doclink/curvyuispline")]
[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("Curvy/Curvy UI Spline")]
public class CurvyUISpline : CurvySpline
{
	public static CurvyUISpline CreateUISpline(string gameObjectName = "Curvy UI Spline")
	{
		return null;
	}

	protected override void Reset()
	{
	}

	private void SetupUISpline()
	{
	}
}
