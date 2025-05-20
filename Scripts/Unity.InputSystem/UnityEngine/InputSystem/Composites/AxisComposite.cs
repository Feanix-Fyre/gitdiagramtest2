using System.ComponentModel;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Composites;

[DisplayStringFormat("{negative}/{positive}")]
[DisplayName("Positive/Negative Binding")]
public class AxisComposite : InputBindingComposite<float>
{
	public enum WhichSideWins
	{
		Neither = 0,
		Positive = 1,
		Negative = 2
	}

	[InputControl(layout = "Axis")]
	public int negative;

	[InputControl(layout = "Axis")]
	public int positive;

	[Tooltip("Value to return when the negative side is fully actuated.")]
	public float minValue;

	[Tooltip("Value to return when the positive side is fully actuated.")]
	public float maxValue;

	[Tooltip("If both the positive and negative side are actuated, decides what value to return. 'Neither' (default) means that the resulting value is the midpoint between min and max. 'Positive' means that max will be returned. 'Negative' means that min will be returned.")]
	public WhichSideWins whichSideWins;

	public float midPoint => 0f;

	public override float ReadValue(ref InputBindingCompositeContext context)
	{
		return 0f;
	}

	public override float EvaluateMagnitude(ref InputBindingCompositeContext context)
	{
		return 0f;
	}
}
