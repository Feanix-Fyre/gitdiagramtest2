using System;
using UnityEngine.Bindings;

namespace UnityEngine;

[VisibleToOtherModules]
internal class SystemClock
{
	private static readonly DateTime s_Epoch;

	public static DateTime now => default(DateTime);
}
