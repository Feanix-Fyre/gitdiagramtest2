namespace System.Windows.Forms;

/// <summary>Specifies the contextual information about an application thread.</summary>
public class ApplicationContext : IDisposable
{
	private Form main_form;

	private object tag;

	private bool thread_exit_raised;

	private EventHandler ThreadExit;

	/// <summary>Gets or sets the <see cref="T:System.Windows.Forms.Form" /> to use as context.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.Form" /> to use as context.</returns>
	public Form MainForm
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ApplicationContext" /> class with no context.</summary>
	public ApplicationContext()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ApplicationContext" /> class with the specified <see cref="T:System.Windows.Forms.Form" />.</summary>
	/// <param name="mainForm">The main <see cref="T:System.Windows.Forms.Form" /> of the application to use for context.</param>
	public ApplicationContext(Form mainForm)
	{
	}

	/// <summary>Attempts to free resources and perform other cleanup operations before the application context is reclaimed by garbage collection.</summary>
	~ApplicationContext()
	{
	}

	/// <summary>Releases all resources used by the <see cref="T:System.Windows.Forms.ApplicationContext" />.</summary>
	public void Dispose()
	{
	}

	/// <summary>Terminates the message loop of the thread.</summary>
	public void ExitThread()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.ApplicationContext" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>Terminates the message loop of the thread.</summary>
	protected virtual void ExitThreadCore()
	{
	}

	/// <summary>Calls <see cref="M:System.Windows.Forms.ApplicationContext.ExitThreadCore" />, which raises the <see cref="E:System.Windows.Forms.ApplicationContext.ThreadExit" /> event.</summary>
	/// <param name="sender">The object that raised the event.</param>
	/// <param name="e">The <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnMainFormClosed(object sender, EventArgs e)
	{
	}
}
