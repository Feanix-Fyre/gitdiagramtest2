using System.IO;
using System.Net.Sockets;
using System.Text;

namespace System.Net;

internal class CommandStream : NetworkStreamWrapper
{
	internal enum PipelineInstruction
	{
		Abort = 0,
		Advance = 1,
		Pause = 2,
		Reread = 3,
		GiveStream = 4
	}

	[Flags]
	internal enum PipelineEntryFlags
	{
		UserCommand = 1,
		GiveDataStream = 2,
		CreateDataConnection = 4,
		DontLogParameter = 8
	}

	internal class PipelineEntry
	{
		internal string Command;

		internal PipelineEntryFlags Flags;

		internal PipelineEntry(string command)
		{
		}

		internal PipelineEntry(string command, PipelineEntryFlags flags)
		{
		}

		internal bool HasFlag(PipelineEntryFlags flags)
		{
			return false;
		}
	}

	private static readonly AsyncCallback s_writeCallbackDelegate;

	private static readonly AsyncCallback s_readCallbackDelegate;

	private bool _recoverableFailure;

	protected WebRequest _request;

	protected bool _isAsync;

	private bool _aborted;

	protected PipelineEntry[] _commands;

	protected int _index;

	private bool _doRead;

	private bool _doSend;

	private ResponseDescription _currentResponseDescription;

	protected string _abortReason;

	private string _buffer;

	private Encoding _encoding;

	private Decoder _decoder;

	internal bool RecoverableFailure => false;

	protected Encoding Encoding
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal CommandStream(TcpClient client)
		: base(null)
	{
	}

	internal virtual void Abort(Exception e)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	protected void InvokeRequestCallback(object obj)
	{
	}

	protected void MarkAsRecoverableFailure()
	{
	}

	internal Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect)
	{
		return null;
	}

	protected virtual void ClearState()
	{
	}

	protected virtual PipelineEntry[] BuildCommandsList(WebRequest request)
	{
		return null;
	}

	protected Exception GenerateException(string message, WebExceptionStatus status, Exception innerException)
	{
		return null;
	}

	protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException)
	{
		return null;
	}

	protected void InitCommandPipeline(WebRequest request, PipelineEntry[] commands, bool isAsync)
	{
	}

	internal void CheckContinuePipeline()
	{
	}

	protected Stream ContinueCommandPipeline()
	{
		return null;
	}

	private bool PostSendCommandProcessing(ref Stream stream)
	{
		return false;
	}

	private bool PostReadCommandProcessing(ref Stream stream)
	{
		return false;
	}

	protected virtual PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream)
	{
		return default(PipelineInstruction);
	}

	private static void ReadCallback(IAsyncResult asyncResult)
	{
	}

	private static void WriteCallback(IAsyncResult asyncResult)
	{
	}

	protected virtual bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength)
	{
		return false;
	}

	private ResponseDescription ReceiveCommandResponse()
	{
		return null;
	}

	private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead)
	{
	}
}
