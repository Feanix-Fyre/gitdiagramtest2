using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables;

[UsedByNativeCode]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Export/Director/PlayableOutputHandle.bindings.h")]
public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle>
{
	internal IntPtr m_Handle;

	internal uint m_Version;

	private static readonly PlayableOutputHandle m_Null;

	public static PlayableOutputHandle Null => default(PlayableOutputHandle);

	[VisibleToOtherModules]
	internal bool IsPlayableOutputOfType<T>()
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
	{
		return false;
	}

	public override bool Equals(object p)
	{
		return false;
	}

	public bool Equals(PlayableOutputHandle other)
	{
		return false;
	}

	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
	{
		return false;
	}

	[VisibleToOtherModules]
	internal bool IsValid()
	{
		return false;
	}

	[FreeFunction("PlayableOutputHandleBindings::GetPlayableOutputType", HasExplicitThis = true, ThrowsException = true)]
	internal Type GetPlayableOutputType()
	{
		return null;
	}

	[FreeFunction("PlayableOutputHandleBindings::SetReferenceObject", HasExplicitThis = true, ThrowsException = true)]
	internal void SetReferenceObject(Object target)
	{
	}

	[FreeFunction("PlayableOutputHandleBindings::SetUserData", HasExplicitThis = true, ThrowsException = true)]
	internal void SetUserData([Writable] Object target)
	{
	}

	[FreeFunction("PlayableOutputHandleBindings::GetSourcePlayable", HasExplicitThis = true, ThrowsException = true)]
	internal PlayableHandle GetSourcePlayable()
	{
		return default(PlayableHandle);
	}

	[FreeFunction("PlayableOutputHandleBindings::SetSourcePlayable", HasExplicitThis = true, ThrowsException = true)]
	internal void SetSourcePlayable(PlayableHandle target, int port)
	{
	}

	[FreeFunction("PlayableOutputHandleBindings::GetSourceOutputPort", HasExplicitThis = true, ThrowsException = true)]
	internal int GetSourceOutputPort()
	{
		return 0;
	}

	[FreeFunction("PlayableOutputHandleBindings::SetWeight", HasExplicitThis = true, ThrowsException = true)]
	internal void SetWeight(float weight)
	{
	}

	[FreeFunction("PlayableOutputHandleBindings::PushNotification", HasExplicitThis = true, ThrowsException = true)]
	internal void PushNotification(PlayableHandle origin, INotification notification, object context)
	{
	}

	[FreeFunction("PlayableOutputHandleBindings::AddNotificationReceiver", HasExplicitThis = true, ThrowsException = true)]
	internal void AddNotificationReceiver(INotificationReceiver receiver)
	{
	}

	private static bool IsValid_Injected(ref PlayableOutputHandle _unity_self)
	{
		return false;
	}

	private static Type GetPlayableOutputType_Injected(ref PlayableOutputHandle _unity_self)
	{
		return null;
	}

	private static void SetReferenceObject_Injected(ref PlayableOutputHandle _unity_self, Object target)
	{
	}

	private static void SetUserData_Injected(ref PlayableOutputHandle _unity_self, [Writable] Object target)
	{
	}

	private static void GetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, out PlayableHandle ret)
	{
		ret = default(PlayableHandle);
	}

	private static void SetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle target, int port)
	{
	}

	private static int GetSourceOutputPort_Injected(ref PlayableOutputHandle _unity_self)
	{
		return 0;
	}

	private static void SetWeight_Injected(ref PlayableOutputHandle _unity_self, float weight)
	{
	}

	private static void PushNotification_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle origin, INotification notification, object context)
	{
	}

	private static void AddNotificationReceiver_Injected(ref PlayableOutputHandle _unity_self, INotificationReceiver receiver)
	{
	}
}
