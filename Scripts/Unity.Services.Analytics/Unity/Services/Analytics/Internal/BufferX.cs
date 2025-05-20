using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Unity.Services.Analytics.Internal;

internal class BufferX : IBuffer, IBufferDebug
{
	private const long k_UploadBatchMaximumSizeInBytes = 4194304L;

	private const string k_MillisecondDateFormat = "yyyy-MM-dd HH:mm:ss.fff zzz";

	private readonly byte[] k_WorkingBuffer;

	private readonly char[] k_WorkingCharacterBuffer;

	private readonly byte[] k_PayloadHeader;

	private readonly byte[] k_HeaderEventName;

	private readonly byte[] k_HeaderUserName;

	private readonly byte[] k_HeaderSessionID;

	private readonly byte[] k_HeaderEventUUID;

	private readonly byte[] k_HeaderTimestamp;

	private readonly byte[] k_HeaderEventVersion;

	private readonly byte[] k_HeaderInstallationID;

	private readonly byte[] k_HeaderPlayerID;

	private readonly byte[] k_HeaderOpenEventParams;

	private readonly byte[] k_CloseEvent;

	private readonly byte k_Quote;

	private readonly byte[] k_QuoteColon;

	private readonly byte[] k_QuoteComma;

	private readonly byte[] k_Comma;

	private readonly byte[] k_OpenBrace;

	private readonly byte[] k_CloseBraceComma;

	private readonly byte[] k_OpenBracket;

	private readonly byte[] k_CloseBracketComma;

	private readonly byte k_Colon;

	private readonly byte k_Dash;

	private readonly byte k_Space;

	private readonly byte k_Point;

	private readonly byte k_Positive;

	private readonly byte k_Negative;

	private readonly byte[] k_True;

	private readonly byte[] k_False;

	private readonly byte[] k_Int2CharacterByte;

	private readonly long[] k_Order;

	private readonly IBufferSystemCalls m_SystemCalls;

	private readonly IDiskCache m_DiskCache;

	private readonly IIdentityManager m_UserIdentity;

	private readonly ISessionManager m_Session;

	private readonly List<EventSummary> m_EventSummaries;

	private string m_CurrentEventId;

	private string m_CurrentEventName;

	private DateTime m_CurrentEventTimestamp;

	private MemoryStream m_SpareBuffer;

	private MemoryStream m_Buffer;

	public int Length => 0;

	internal int EventsRecorded => 0;

	internal IReadOnlyList<EventSummary> EventSummaries => null;

	internal byte[] RawContents => null;

	public event Action<string, string, DateTime, byte[]> EventRecorded
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

	public event Action<HashSet<string>> EventsClearing
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

	public event Action<HashSet<string>> EventsCleared
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

	public BufferX(IBufferSystemCalls eventIdGenerator, IDiskCache diskCache, IIdentityManager userIdentity, ISessionManager session)
	{
	}

	private void WriteString(in string value)
	{
	}

	private void WriteLong(in long value)
	{
	}

	private void WriteByte(in byte value)
	{
	}

	private void WriteBytes(in byte[] bytes)
	{
	}

	private void WriteName(string name)
	{
	}

	private void WriteDateTime(DateTime dateTime)
	{
	}

	private int SerializeLong(in long number, in byte[] buffer, in int startIndex, in int minimumLength)
	{
		return 0;
	}

	public void PushStandardEventStart(string name, int version)
	{
	}

	public void PushCustomEventStart(string name)
	{
	}

	private void PushCommonEventStart(string name)
	{
	}

	private void StripTrailingCommaIfNecessary()
	{
	}

	public void PushEndEvent()
	{
	}

	public void PushObjectStart(string name)
	{
	}

	public void PushObjectEnd()
	{
	}

	public void PushArrayStart(string name)
	{
	}

	public void PushArrayEnd()
	{
	}

	public void PushDouble(string name, double value)
	{
	}

	public void PushFloat(string name, float value)
	{
	}

	public void PushString(string name, string value)
	{
	}

	private int ProcessCharacterOntoWorkingBuffer(int index, char character)
	{
		return 0;
	}

	public void PushInt64(string name, long value)
	{
	}

	public void PushInt(string name, int value)
	{
	}

	public void PushBool(string name, bool value)
	{
	}

	public void PushTimestamp(string name, DateTime value)
	{
	}

	public void PushProduct(string name, TransactionRealCurrency realCurrency, List<TransactionVirtualCurrency> virtualCurrencies, List<TransactionItem> items)
	{
	}

	public void PushObject(string name, object value)
	{
	}

	public byte[] Serialize()
	{
		return null;
	}

	public void ClearBuffer()
	{
	}

	public void ClearBuffer(long upTo)
	{
	}

	public void FlushToDisk()
	{
	}

	public void ClearDiskCache()
	{
	}

	public void LoadFromDisk()
	{
	}

	internal static string SerializeDateTime(DateTime dateTime)
	{
		return null;
	}
}
