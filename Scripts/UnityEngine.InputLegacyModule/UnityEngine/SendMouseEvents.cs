using System;
using System.Collections.Generic;
using UnityEngine.Scripting;

namespace UnityEngine;

internal class SendMouseEvents
{
	private struct HitInfo
	{
		public GameObject target;

		public Camera camera;

		public void SendMessage(string name)
		{
		}

		public static implicit operator bool(HitInfo exists)
		{
			return false;
		}

		public static bool Compare(HitInfo lhs, HitInfo rhs)
		{
			return false;
		}
	}

	private static bool s_MouseUsed;

	private static readonly HitInfo[] m_LastHit;

	private static readonly HitInfo[] m_MouseDownHit;

	private static readonly HitInfo[] m_CurrentHit;

	private static Camera[] m_Cameras;

	public static Func<KeyValuePair<int, Vector2>> s_GetMouseState;

	private static Vector2 s_MousePosition;

	private static bool s_MouseButtonPressedThisFrame;

	private static bool s_MouseButtonIsPressed;

	private static void UpdateMouse()
	{
	}

	[RequiredByNativeCode]
	private static void SetMouseMoved()
	{
	}

	[RequiredByNativeCode]
	private static void DoSendMouseEvents(int skipRTCameras)
	{
	}

	private static void SendEvents(int i, HitInfo hit)
	{
	}
}
