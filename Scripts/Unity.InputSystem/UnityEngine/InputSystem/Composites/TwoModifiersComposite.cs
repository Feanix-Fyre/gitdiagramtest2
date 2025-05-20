using System;
using System.ComponentModel;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Composites;

[DisplayName("Binding With Two Modifiers")]
[DisplayStringFormat("{modifier1}+{modifier2}+{binding}")]
public class TwoModifiersComposite : InputBindingComposite
{
	[InputControl(layout = "Button")]
	public int modifier1;

	[InputControl(layout = "Button")]
	public int modifier2;

	[InputControl]
	public int binding;

	public bool overrideModifiersNeedToBePressedFirst;

	private int m_ValueSizeInBytes;

	private Type m_ValueType;

	private bool m_BindingIsButton;

	public override Type valueType => null;

	public override int valueSizeInBytes => 0;

	public override float EvaluateMagnitude(ref InputBindingCompositeContext context)
	{
		return 0f;
	}

	public unsafe override void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize)
	{
	}

	private bool ModifiersArePressed(ref InputBindingCompositeContext context)
	{
		return false;
	}

	protected override void FinishSetup(ref InputBindingCompositeContext context)
	{
	}

	public override object ReadValueAsObject(ref InputBindingCompositeContext context)
	{
		return null;
	}
}
