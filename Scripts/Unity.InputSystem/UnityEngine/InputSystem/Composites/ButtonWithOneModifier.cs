using System.ComponentModel;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Composites;

[DesignTimeVisible(false)]
[DisplayStringFormat("{modifier}+{button}")]
public class ButtonWithOneModifier : InputBindingComposite<float>
{
	[InputControl(layout = "Button")]
	public int modifier;

	[InputControl(layout = "Button")]
	public int button;

	public bool overrideModifiersNeedToBePressedFirst;

	public override float ReadValue(ref InputBindingCompositeContext context)
	{
		return 0f;
	}

	private bool ModifierIsPressed(ref InputBindingCompositeContext context)
	{
		return false;
	}

	public override float EvaluateMagnitude(ref InputBindingCompositeContext context)
	{
		return 0f;
	}

	protected override void FinishSetup(ref InputBindingCompositeContext context)
	{
	}
}
