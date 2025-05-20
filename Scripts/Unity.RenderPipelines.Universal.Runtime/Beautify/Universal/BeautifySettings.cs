using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace Beautify.Universal;

[ExecuteInEditMode]
public class BeautifySettings : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDoBlink_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public float maxValue;

		private Beautify _003Cbeautify_003E5__2;

		private float _003Cstart_003E5__3;

		private WaitForEndOfFrame _003Cw_003E5__4;

		private float _003Ct_003E5__5;

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
		public _003CDoBlink_003Ed__24(int _003C_003E1__state)
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

	[Header("Scene Settings")]
	public Transform sun;

	public Transform depthOfFieldTarget;

	public OnBeforeFocusEvent OnBeforeFocus;

	[NonSerialized]
	public static float depthOfFieldCurrentFocalPointDistance;

	[NonSerialized]
	public static int bloomExcludeMask;

	[NonSerialized]
	public static int anamorphicFlaresExcludeMask;

	[NonSerialized]
	public static bool dofTransparentSupport;

	[NonSerialized]
	public static int dofTransparentLayerMask;

	[NonSerialized]
	public static bool dofTransparentDoubleSided;

	[NonSerialized]
	public static bool dofAlphaTestSupport;

	[NonSerialized]
	public static int dofAlphaTestLayerMask;

	[NonSerialized]
	public static bool dofAlphaTestDoubleSided;

	private static BeautifySettings _instance;

	private static Volume _beautifyVolume;

	private static Beautify _beautify;

	public static BeautifySettings instance => null;

	public static Beautify sharedSettings => null;

	public static Beautify settings => null;

	public static void UnloadBeautify()
	{
	}

	private static Volume FindBeautifyVolume()
	{
		return null;
	}

	public static void Blink(float duration, float maxValue = 1f)
	{
	}

	[IteratorStateMachine(typeof(_003CDoBlink_003Ed__24))]
	private IEnumerator DoBlink(float duration, float maxValue)
	{
		return null;
	}

	private void OnEnable()
	{
	}
}
