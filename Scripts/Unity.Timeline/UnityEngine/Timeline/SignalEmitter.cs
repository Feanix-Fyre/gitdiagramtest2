using System;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

[Serializable]
[CustomStyle("SignalEmitter")]
[ExcludeFromPreset]
public class SignalEmitter : Marker, INotification, INotificationOptionProvider
{
	[SerializeField]
	private bool m_Retroactive;

	[SerializeField]
	private bool m_EmitOnce;

	[SerializeField]
	private SignalAsset m_Asset;

	public bool retroactive
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool emitOnce
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public SignalAsset asset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	PropertyName INotification.id => default(PropertyName);

	NotificationFlags INotificationOptionProvider.flags => default(NotificationFlags);
}
