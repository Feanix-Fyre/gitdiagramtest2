using System.Runtime.CompilerServices;
using System.Threading;

namespace System.ComponentModel;

/// <summary>Executes an operation on a separate thread.</summary>
[DefaultEvent("DoWork")]
public class BackgroundWorker : Component
{
	private bool _canCancelWorker;

	private bool _workerReportsProgress;

	private bool _cancellationPending;

	private bool _isRunning;

	private AsyncOperation _asyncOperation;

	private readonly SendOrPostCallback _operationCompleted;

	private readonly SendOrPostCallback _progressReporter;

	/// <summary>Gets a value indicating whether the <see cref="T:System.ComponentModel.BackgroundWorker" /> is running an asynchronous operation.</summary>
	/// <returns>
	///   <see langword="true" />, if the <see cref="T:System.ComponentModel.BackgroundWorker" /> is running an asynchronous operation; otherwise, <see langword="false" />.</returns>
	public bool IsBusy => false;

	/// <summary>Gets or sets a value indicating whether the <see cref="T:System.ComponentModel.BackgroundWorker" /> can report progress updates.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.ComponentModel.BackgroundWorker" /> supports progress updates; otherwise <see langword="false" />. The default is <see langword="false" />.</returns>
	public bool WorkerReportsProgress
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the <see cref="T:System.ComponentModel.BackgroundWorker" /> supports asynchronous cancellation.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.ComponentModel.BackgroundWorker" /> supports cancellation; otherwise <see langword="false" />. The default is <see langword="false" />.</returns>
	public bool WorkerSupportsCancellation
	{
		set
		{
		}
	}

	/// <summary>Occurs when <see cref="M:System.ComponentModel.BackgroundWorker.RunWorkerAsync" /> is called.</summary>
	public event DoWorkEventHandler DoWork
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	/// <summary>Occurs when <see cref="M:System.ComponentModel.BackgroundWorker.ReportProgress(System.Int32)" /> is called.</summary>
	public event ProgressChangedEventHandler ProgressChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	/// <summary>Occurs when the background operation has completed, has been canceled, or has raised an exception.</summary>
	public event RunWorkerCompletedEventHandler RunWorkerCompleted
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.BackgroundWorker" /> class.</summary>
	public BackgroundWorker()
	{
	}

	private void AsyncOperationCompleted(object arg)
	{
	}

	/// <summary>Raises the <see cref="E:System.ComponentModel.BackgroundWorker.DoWork" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnDoWork(DoWorkEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.ComponentModel.BackgroundWorker.RunWorkerCompleted" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.ComponentModel.BackgroundWorker.ProgressChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnProgressChanged(ProgressChangedEventArgs e)
	{
	}

	private void ProgressReporter(object arg)
	{
	}

	/// <summary>Raises the <see cref="E:System.ComponentModel.BackgroundWorker.ProgressChanged" /> event.</summary>
	/// <param name="percentProgress">The percentage, from 0 to 100, of the background operation that is complete.</param>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.ComponentModel.BackgroundWorker.WorkerReportsProgress" /> property is set to <see langword="false" />.</exception>
	public void ReportProgress(int percentProgress)
	{
	}

	/// <summary>Raises the <see cref="E:System.ComponentModel.BackgroundWorker.ProgressChanged" /> event.</summary>
	/// <param name="percentProgress">The percentage, from 0 to 100, of the background operation that is complete.</param>
	/// <param name="userState">The state object passed to <see cref="M:System.ComponentModel.BackgroundWorker.RunWorkerAsync(System.Object)" />.</param>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.ComponentModel.BackgroundWorker.WorkerReportsProgress" /> property is set to <see langword="false" />.</exception>
	public void ReportProgress(int percentProgress, object userState)
	{
	}

	/// <summary>Starts execution of a background operation.</summary>
	/// <param name="argument">A parameter for use by the background operation to be executed in the <see cref="E:System.ComponentModel.BackgroundWorker.DoWork" /> event handler.</param>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="P:System.ComponentModel.BackgroundWorker.IsBusy" /> is <see langword="true" />.</exception>
	public void RunWorkerAsync(object argument)
	{
	}

	private void WorkerThreadStart(object argument)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
