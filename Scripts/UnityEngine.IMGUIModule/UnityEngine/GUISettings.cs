using System;
using UnityEngine.Bindings;

namespace UnityEngine;

[Serializable]
[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
public sealed class GUISettings
{
	[SerializeField]
	private bool m_DoubleClickSelectsWord;

	[SerializeField]
	private bool m_TripleClickSelectsLine;

	[SerializeField]
	private Color m_CursorColor;

	[SerializeField]
	private float m_CursorFlashSpeed;

	[SerializeField]
	private Color m_SelectionColor;
}
