using System;

namespace Unity.Collections;

[Obsolete("FixedListByte512DebugView is deprecated. (UnityUpgradable) -> FixedList512BytesDebugView<byte>", true)]
internal sealed class FixedListByte512DebugView
{
	private FixedList512Bytes<byte> m_List;

	public byte[] Items => null;

	public FixedListByte512DebugView(FixedList512Bytes<byte> list)
	{
	}
}
