using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Shapes;

[CurvyShapeInfo("2D/Circle", true)]
[RequireComponent(typeof(CurvySpline))]
[AddComponentMenu("Curvy/Shapes/Circle")]
public class CSCircle : CurvyShape2D
{
	private const int MinCount = 2;

	[SerializeField]
	[Positive(MinValue = 2f, Tooltip = "Number of Control Points")]
	private int m_Count;

	[Positive]
	[SerializeField]
	private float m_Radius;

	public int Count
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float Radius
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
