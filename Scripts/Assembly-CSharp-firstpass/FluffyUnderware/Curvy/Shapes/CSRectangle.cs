using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Shapes;

[AddComponentMenu("Curvy/Shapes/Rectangle")]
[CurvyShapeInfo("2D/Rectangle", true)]
[RequireComponent(typeof(CurvySpline))]
public class CSRectangle : CurvyShape2D
{
	[SerializeField]
	[Positive]
	private float m_Width;

	[Positive]
	[SerializeField]
	private float m_Height;

	public float Width
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float Height
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected override void ApplyShape()
	{
	}
}
