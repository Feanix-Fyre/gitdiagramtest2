namespace UnityEngine.Rendering;

internal static class ColorSpaceUtils
{
	public static readonly Matrix4x4 Rec709ToRec2020Mat;

	public static readonly Matrix4x4 Rec709ToP3D65Mat;

	public static readonly Matrix4x4 Rec2020ToRec709Mat;

	public static readonly Matrix4x4 Rec2020ToP3D65Mat;

	public static readonly Matrix4x4 P3D65ToRec2020Mat;
}
