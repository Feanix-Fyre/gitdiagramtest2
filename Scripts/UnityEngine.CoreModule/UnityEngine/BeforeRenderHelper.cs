using System.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine;

internal static class BeforeRenderHelper
{
	private struct OrderBlock
	{
		internal int order;

		internal UnityAction callback;
	}

	private static List<OrderBlock> s_OrderBlocks;

	public static void Invoke()
	{
	}
}
