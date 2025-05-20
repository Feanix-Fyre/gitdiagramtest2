namespace System.Windows.Forms;

/// <summary>Specifies the reason that a form was closed.</summary>
public enum CloseReason
{
	/// <summary>The cause of the closure was not defined or could not be determined.</summary>
	None = 0,
	/// <summary>The operating system is closing all applications before shutting down.</summary>
	WindowsShutDown = 1,
	/// <summary>The parent form of this multiple document interface (MDI) form is closing.</summary>
	MdiFormClosing = 2,
	/// <summary>The user is closing the form through the user interface (UI), for example by clicking the Close button on the form window, selecting Close from the window's control menu, or pressing ALT+F4.</summary>
	UserClosing = 3,
	/// <summary>The Microsoft Windows Task Manager is closing the application.</summary>
	TaskManagerClosing = 4,
	/// <summary>The owner form is closing.</summary>
	FormOwnerClosing = 5,
	/// <summary>The <see cref="M:System.Windows.Forms.Application.Exit" /> method of the <see cref="T:System.Windows.Forms.Application" /> class was invoked.</summary>
	ApplicationExitCall = 6
}
