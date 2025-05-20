using System;
using Unity.Burst;

namespace Unity.Collections;

internal class NativeQueueBlockPool
{
	private static readonly SharedStatic<IntPtr> Data;

	internal unsafe static NativeQueueBlockPoolData* GetQueueBlockPool()
	{
		return null;
	}

	[BurstDiscard]
	private static void AppDomainOnDomainUnload()
	{
	}

	private static void OnDomainUnload(object sender, EventArgs e)
	{
	}
}
