using System.Runtime.InteropServices;
using System.Threading;

namespace System.Runtime.Remoting.Messaging;

/// <summary>Encapsulates the results of an asynchronous operation on a delegate.</summary>
[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem
{
	private object async_state;

	private WaitHandle handle;

	private object async_delegate;

	private IntPtr data;

	private object object_data;

	private bool sync_completed;

	private bool completed;

	private bool endinvoke_called;

	private object async_callback;

	private ExecutionContext current;

	private ExecutionContext original;

	private long add_time;

	private MonoMethodMessage call_message;

	private IMessageCtrl message_ctrl;

	private IMessage reply_message;

	private WaitCallback orig_cb;

	/// <summary>Gets the object provided as the last parameter of a <see langword="BeginInvoke" /> method call.</summary>
	/// <returns>The object provided as the last parameter of a <see langword="BeginInvoke" /> method call.</returns>
	public virtual object AsyncState => null;

	/// <summary>Gets a <see cref="T:System.Threading.WaitHandle" /> that encapsulates Win32 synchronization handles, and allows the implementation of various synchronization schemes.</summary>
	/// <returns>A <see cref="T:System.Threading.WaitHandle" /> that encapsulates Win32 synchronization handles, and allows the implementation of various synchronization schemes.</returns>
	public virtual WaitHandle AsyncWaitHandle => null;

	/// <summary>Gets a value indicating whether the <see langword="BeginInvoke" /> call completed synchronously.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see langword="BeginInvoke" /> call completed synchronously; otherwise, <see langword="false" />.</returns>
	public virtual bool CompletedSynchronously => false;

	/// <summary>Gets a value indicating whether the server has completed the call.</summary>
	/// <returns>
	///   <see langword="true" /> after the server has completed the call; otherwise, <see langword="false" />.</returns>
	public virtual bool IsCompleted => false;

	/// <summary>Gets or sets a value indicating whether <see langword="EndInvoke" /> has been called on the current <see cref="T:System.Runtime.Remoting.Messaging.AsyncResult" />.</summary>
	/// <returns>
	///   <see langword="true" /> if <see langword="EndInvoke" /> has been called on the current <see cref="T:System.Runtime.Remoting.Messaging.AsyncResult" />; otherwise, <see langword="false" />.</returns>
	public bool EndInvokeCalled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets the delegate object on which the asynchronous call was invoked.</summary>
	/// <returns>The delegate object on which the asynchronous call was invoked.</returns>
	public virtual object AsyncDelegate => null;

	/// <summary>Gets the next message sink in the sink chain.</summary>
	/// <returns>An <see cref="T:System.Runtime.Remoting.Messaging.IMessageSink" /> interface that represents the next message sink in the sink chain.</returns>
	public IMessageSink NextSink => null;

	internal MonoMethodMessage CallMessage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal AsyncResult()
	{
	}

	/// <summary>Implements the <see cref="T:System.Runtime.Remoting.Messaging.IMessageSink" /> interface.</summary>
	/// <param name="msg">The request <see cref="T:System.Runtime.Remoting.Messaging.IMessage" /> interface.</param>
	/// <param name="replySink">The response <see cref="T:System.Runtime.Remoting.Messaging.IMessageSink" /> interface.</param>
	/// <returns>No value is returned.</returns>
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
	{
		return null;
	}

	/// <summary>Gets the response message for the asynchronous call.</summary>
	/// <returns>A remoting message that should represent a response to a method call on a remote object.</returns>
	public virtual IMessage GetReplyMessage()
	{
		return null;
	}

	/// <summary>Sets an <see cref="T:System.Runtime.Remoting.Messaging.IMessageCtrl" /> for the current remote method call, which provides a way to control asynchronous messages after they have been dispatched.</summary>
	/// <param name="mc">The <see cref="T:System.Runtime.Remoting.Messaging.IMessageCtrl" /> for the current remote method call.</param>
	public virtual void SetMessageCtrl(IMessageCtrl mc)
	{
	}

	internal void SetCompletedSynchronously(bool completed)
	{
	}

	internal IMessage EndInvoke()
	{
		return null;
	}

	/// <summary>Synchronously processes a response message returned by a method call on a remote object.</summary>
	/// <param name="msg">A response message to a method call on a remote object.</param>
	/// <returns>Returns <see langword="null" />.</returns>
	public virtual IMessage SyncProcessMessage(IMessage msg)
	{
		return null;
	}

	void IThreadPoolWorkItem.ExecuteWorkItem()
	{
	}

	void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
	{
	}

	internal object Invoke()
	{
		return null;
	}
}
