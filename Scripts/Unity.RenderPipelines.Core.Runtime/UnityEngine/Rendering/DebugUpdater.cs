using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering;

internal class DebugUpdater : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDoAfterInputModuleUpdated_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action action;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDoAfterInputModuleUpdated_003Ed__9(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CRefreshRuntimeUINextFrame_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CRefreshRuntimeUINextFrame_003Ed__15(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private static DebugUpdater s_Instance;

	private ScreenOrientation m_Orientation;

	private bool m_RuntimeUiWasVisibleLastFrame;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
	private static void RuntimeInit()
	{
	}

	internal static void SetEnabled(bool enabled)
	{
	}

	private static void EnableRuntime()
	{
	}

	private static void DisableRuntime()
	{
	}

	internal static void HandleInternalEventSystemComponents(bool uiEnabled)
	{
	}

	private void EnsureExactlyOneEventSystem()
	{
	}

	[IteratorStateMachine(typeof(_003CDoAfterInputModuleUpdated_003Ed__9))]
	private IEnumerator DoAfterInputModuleUpdated(Action action)
	{
		return null;
	}

	private void CheckInputModuleExists()
	{
	}

	private void AssignDefaultActions()
	{
	}

	private void CreateDebugEventSystem()
	{
	}

	private void DestroyDebugEventSystem()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshRuntimeUINextFrame_003Ed__15))]
	private static IEnumerator RefreshRuntimeUINextFrame()
	{
		return null;
	}
}
