using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace System.Drawing;

internal class SafeNativeMethods
{
	internal class Gdip : GDIPlus
	{
		private static readonly TraceSwitch s_gdiPlusInitialization;

		private static IntPtr s_initToken;

		private static bool Initialized => false;

		internal static IDictionary ThreadData => null;

		static Gdip()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ClearThreadData()
		{
		}

		private static void Shutdown()
		{
		}

		[PrePrepareMethod]
		private static void OnProcessExit(object sender, EventArgs e)
		{
		}

		internal static void CheckStatus(int status)
		{
		}

		internal static Exception StatusException(int status)
		{
			return null;
		}
	}
}
