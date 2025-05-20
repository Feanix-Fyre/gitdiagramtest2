using System.ComponentModel;
using System.Threading;

namespace System.Windows.Forms;

/// <summary>Provides a synchronization context for the Windows Forms application model.</summary>
public sealed class WindowsFormsSynchronizationContext : SynchronizationContext, IDisposable
{
	private static bool auto_installed;

	private static Control invoke_control;

	private static SynchronizationContext previous_context;

	/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Windows.Forms.WindowsFormsSynchronizationContext" /> is installed when a control is created.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.WindowsFormsSynchronizationContext" /> is installed; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static bool AutoInstall => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.WindowsFormsSynchronizationContext" /> class.</summary>
	public WindowsFormsSynchronizationContext()
	{
	}

	static WindowsFormsSynchronizationContext()
	{
	}

	/// <summary>Copies the synchronization context.</summary>
	/// <returns>A copy of the synchronization context.</returns>
	public override SynchronizationContext CreateCopy()
	{
		return null;
	}

	/// <summary>Releases all resources used by the <see cref="T:System.Windows.Forms.WindowsFormsSynchronizationContext" />.</summary>
	public void Dispose()
	{
	}

	/// <summary>Dispatches an asynchronous message to a synchronization context.</summary>
	/// <param name="d">The <see cref="T:System.Threading.SendOrPostCallback" /> delegate to call.</param>
	/// <param name="state">The object passed to the delegate.</param>
	public override void Post(SendOrPostCallback d, object state)
	{
	}

	/// <summary>Dispatches a synchronous message to a synchronization context</summary>
	/// <param name="d">The <see cref="T:System.Threading.SendOrPostCallback" /> delegate to call.</param>
	/// <param name="state">The object passed to the delegate.</param>
	/// <exception cref="T:System.ComponentModel.InvalidAsynchronousStateException">The destination thread no longer exists.</exception>
	public override void Send(SendOrPostCallback d, object state)
	{
	}
}
