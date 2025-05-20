namespace System.Net.Sockets;

/// <summary>Represents an element in a <see cref="T:System.Net.Sockets.SendPacketsElement" /> array.</summary>
public class SendPacketsElement
{
	internal string m_FilePath;

	internal byte[] m_Buffer;

	internal int m_Offset;

	internal int m_Count;

	private bool m_endOfPacket;
}
