using System;

namespace FluffyUnderware.Curvy;

[AttributeUsage(AttributeTargets.Class)]
public sealed class CurvyShapeInfo : Attribute
{
	public readonly string Name;

	public readonly bool Is2D;

	public CurvyShapeInfo(string name, bool is2D = true)
	{
	}
}
