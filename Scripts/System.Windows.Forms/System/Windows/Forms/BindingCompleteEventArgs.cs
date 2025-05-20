using System.ComponentModel;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.Binding.BindingComplete" /> event.</summary>
public class BindingCompleteEventArgs : CancelEventArgs
{
	private Binding binding;

	private BindingCompleteState state;

	private BindingCompleteContext context;

	private string error_text;

	private Exception exception;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.BindingCompleteEventArgs" /> class with the specified binding, error state, and binding context.</summary>
	/// <param name="binding">The binding associated with this occurrence of a <see cref="E:System.Windows.Forms.Binding.BindingComplete" /> event.</param>
	/// <param name="state">One of the <see cref="T:System.Windows.Forms.BindingCompleteState" /> values.</param>
	/// <param name="context">One of the <see cref="T:System.Windows.Forms.BindingCompleteContext" /> values.</param>
	public BindingCompleteEventArgs(Binding binding, BindingCompleteState state, BindingCompleteContext context)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.BindingCompleteEventArgs" /> class with the specified binding, error state and text, binding context, exception, and whether the binding should be cancelled.</summary>
	/// <param name="binding">The binding associated with this occurrence of a <see cref="E:System.Windows.Forms.Binding.BindingComplete" /> event.</param>
	/// <param name="state">One of the <see cref="T:System.Windows.Forms.BindingCompleteState" /> values.</param>
	/// <param name="context">One of the <see cref="T:System.Windows.Forms.BindingCompleteContext" /> values.</param>
	/// <param name="errorText">The error text or exception message for errors that occurred during the binding.</param>
	/// <param name="exception">The <see cref="T:System.Exception" /> that occurred during the binding.</param>
	/// <param name="cancel">
	///   <see langword="true" /> to cancel the binding and keep focus on the current control; <see langword="false" /> to allow focus to shift to another control.</param>
	public BindingCompleteEventArgs(Binding binding, BindingCompleteState state, BindingCompleteContext context, string errorText, Exception exception, bool cancel)
	{
	}

	internal void SetErrorText(string error_text)
	{
	}

	internal void SetException(Exception exception)
	{
	}
}
