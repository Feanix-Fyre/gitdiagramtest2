using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine;

[Serializable]
[StructLayout((LayoutKind)0)]
[RequiredByNativeCode]
public sealed class AnimationEvent
{
	internal float m_Time;

	internal string m_FunctionName;

	internal string m_StringParameter;

	internal Object m_ObjectReferenceParameter;

	internal float m_FloatParameter;

	internal int m_IntParameter;

	internal int m_MessageOptions;

	internal AnimationEventSource m_Source;

	internal AnimationState m_StateSender;

	internal AnimatorStateInfo m_AnimatorStateInfo;

	internal AnimatorClipInfo m_AnimatorClipInfo;

	public float time => 0f;
}
