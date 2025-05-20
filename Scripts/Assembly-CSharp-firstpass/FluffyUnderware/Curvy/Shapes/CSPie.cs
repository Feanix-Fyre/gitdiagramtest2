using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Shapes;

[CurvyShapeInfo("2D/Pie", true)]
[RequireComponent(typeof(CurvySpline))]
[AddComponentMenu("Curvy/Shapes/Pie")]
public class CSPie : CSCircle
{
	public enum EatModeEnum
	{
		Left = 0,
		Right = 1,
		Center = 2
	}

	[SerializeField]
	[Range(0f, 1f)]
	private float m_Roundness;

	[RangeEx(0f, "maxEmpty", "Empty", "Number of empty slices")]
	[SerializeField]
	private int m_Empty;

	[SerializeField]
	[Label(Tooltip = "Eat Mode")]
	private EatModeEnum m_Eat;

	public float Roundness
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int Empty
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private int maxEmpty => 0;

	public EatModeEnum Eat
	{
		get
		{
			return default(EatModeEnum);
		}
		set
		{
		}
	}

	private Vector3 cpPosition(int i, int empty, float d)
	{
		return default(Vector3);
	}

	protected override void ApplyShape()
	{
	}
}
