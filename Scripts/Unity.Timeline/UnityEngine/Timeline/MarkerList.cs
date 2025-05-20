using System;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

[Serializable]
internal struct MarkerList : ISerializationCallbackReceiver
{
	[SerializeField]
	[HideInInspector]
	private List<ScriptableObject> m_Objects;

	[NonSerialized]
	[HideInInspector]
	private List<IMarker> m_Cache;

	private bool m_CacheDirty;

	private bool m_HasNotifications;

	public List<IMarker> markers => null;

	public int Count => 0;

	public IMarker this[int idx] => null;

	public MarkerList(int capacity)
	{
		m_Objects = null;
		m_Cache = null;
		m_CacheDirty = false;
		m_HasNotifications = false;
	}

	public void Add(ScriptableObject item)
	{
	}

	public bool Remove(IMarker item)
	{
		return false;
	}

	public bool Remove(ScriptableObject item, TimelineAsset timelineAsset, PlayableAsset thingToDirty)
	{
		return false;
	}

	public void Clear()
	{
	}

	public bool Contains(ScriptableObject item)
	{
		return false;
	}

	public IEnumerable<IMarker> GetMarkers()
	{
		return null;
	}

	public List<ScriptableObject> GetRawMarkerList()
	{
		return null;
	}

	public IMarker CreateMarker(Type type, double time, TrackAsset owner)
	{
		return null;
	}

	public bool HasNotifications()
	{
		return false;
	}

	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}

	private void BuildCache()
	{
	}
}
