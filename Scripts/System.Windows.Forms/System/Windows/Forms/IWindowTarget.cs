namespace System.Windows.Forms;

/// <summary>Defines the communication layer between a control and the Win32 API.</summary>
public interface IWindowTarget
{
	/// <summary>Sets the handle of the <see cref="T:System.Windows.Forms.IWindowTarget" /> to the specified handle.</summary>
	/// <param name="newHandle">The new handle of the <see cref="T:System.Windows.Forms.IWindowTarget" />.</param>
	void OnHandleChange(IntPtr newHandle);

	/// <summary>Processes the Windows messages.</summary>
	/// <param name="m">The Windows message to process.</param>
	void OnMessage(ref Message m);
}
