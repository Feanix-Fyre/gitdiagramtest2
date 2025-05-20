using System;
using System.ComponentModel;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Composites;

[DisplayStringFormat("{modifier}+{binding}")]
[DisplayName("Binding With One Modifier")]
public class OneModifierComposite : InputBindingComposite
{
	[InputControl(layout = "Button")]
	public int modifier;

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

	private bool ModifierIsPressed(ref InputBindingCompositeContext context)
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

	internal static void DetermineValueTypeAndSize(ref InputBindingCompositeContext context, int part, out Type valueType, out int valueSizeInBytes, out bool isButton)
	{
		valueType = null;
		valueSizeInBytes = default(int);
		isButton = default(bool);
	}
}
