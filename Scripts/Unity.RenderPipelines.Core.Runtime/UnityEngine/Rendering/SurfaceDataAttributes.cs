using System;

namespace UnityEngine.Rendering;

[AttributeUsage(AttributeTargets.Field)]
public class SurfaceDataAttributes : Attribute
{
	public string[] displayNames;

	public bool isDirection;

	public bool sRGBDisplay;

	public FieldPrecision precision;

	public bool checkIsNormalized;

	public string preprocessor;

	public SurfaceDataAttributes(string displayName = "", bool isDirection = false, bool sRGBDisplay = false, FieldPrecision precision = FieldPrecision.Default, bool checkIsNormalized = false, string preprocessor = "")
	{
	}

	public SurfaceDataAttributes(string[] displayNames, bool isDirection = false, bool sRGBDisplay = false, FieldPrecision precision = FieldPrecision.Default, bool checkIsNormalized = false, string preprocessor = "")
	{
	}
}
