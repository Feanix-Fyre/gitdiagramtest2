using UnityEngine;

namespace VLB;

[DisallowMultipleComponent]
[HelpURL("http://saladgamer.com/vlb-doc/comp-trackrealtimechanges-hd/")]
[RequireComponent(typeof(Light), typeof(VolumetricLightBeamHD))]
public class TrackRealtimeChangesOnLightHD : MonoBehaviour
{
	public const string ClassName = "TrackRealtimeChangesOnLightHD";

	private VolumetricLightBeamHD m_Master;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
