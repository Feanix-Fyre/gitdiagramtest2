using System;

namespace Unity.Collections.LowLevel.Unsafe;

[Obsolete("This storage will no longer be used. (RemovedAfter 2021-06-01)")]
internal sealed class WordStorageDebugView
{
	private WordStorage m_wordStorage;

	public FixedString128Bytes[] Table => null;

	public WordStorageDebugView(WordStorage wordStorage)
	{
	}
}
