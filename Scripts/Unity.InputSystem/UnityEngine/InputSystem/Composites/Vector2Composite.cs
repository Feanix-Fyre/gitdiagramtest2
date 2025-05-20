using System;
using System.ComponentModel;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Composites;

[DisplayName("Up/Down/Left/Right Composite")]
[DisplayStringFormat("{up}/{left}/{down}/{right}")]
public class Vector2Composite : InputBindingComposite<Vector2>
{
	public enum Mode
	{
		Analog = 2,
		DigitalNormalized = 0,
		Digital = 1
	}

	[InputControl(layout = "Axis")]
	public int up;

	[InputControl(layout = "Axis")]
	public int down;

	[InputControl(layout = "Axis")]
	public int left;

	[InputControl(layout = "Axis")]
	public int right;

	[Obsolete("Use Mode.DigitalNormalized with 'mode' instead")]
	public bool normalize;

	public Mode mode;

	public override Vector2 ReadValue(ref InputBindingCompositeContext context)
	{
		return default(Vector2);
	}

	public override float EvaluateMagnitude(ref InputBindingCompositeContext context)
	{
		return 0f;
	}
}
