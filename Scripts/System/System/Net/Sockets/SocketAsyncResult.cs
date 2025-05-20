using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Net.Sockets;

[StructLayout((LayoutKind)0)]
internal sealed class SocketAsyncResult : IOAsyncResult
{
	public Socket socket;

	public SocketOperation operation;

	private Exception DelayedException;

	public EndPoint EndPoint;

	public Memory<byte> Buffer;

	public int Offset;

	public int Size;

	public SocketFlags SockFlags;

	public Socket AcceptSocket;

	public IPAddress[] Addresses;

	public int Port;

	public IList<ArraySegment<byte>> Buffers;

	public bool ReuseSocket;

	public int CurrentAddress;

	public Socket AcceptedSocket;

	public int Total;

	internal int error;

	public int EndCalled;

	public IntPtr Handle => (IntPtr)0;

	public SocketError ErrorCode => default(SocketError);

	public SocketAsyncResult()
	{
	}

	public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation)
	{
	}

	public SocketAsyncResult(Socket socket, AsyncCallback callback, object state, SocketOperation operation)
	{
	}

	public void CheckIfThrowDelayedException()
	{
	}

	internal override void CompleteDisposed()
	{
	}

	public void Complete()
	{
	}

	public void Complete(bool synch)
	{
	}

	public void Complete(int total)
	{
	}

	public void Complete(Exception e, bool synch)
	{
	}

	public void Complete(Exception e)
	{
	}

	public void Complete(Socket s)
	{
	}

	public void Complete(Socket s, int total)
	{
	}
}
