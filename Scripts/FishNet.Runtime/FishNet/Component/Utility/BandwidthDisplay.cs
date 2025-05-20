using FishNet.Managing.Statistic;
using UnityEngine;

namespace FishNet.Component.Utility;

[AddComponentMenu("FishNet/Component/BandwidthDisplay")]
public class BandwidthDisplay : MonoBehaviour
{
	private enum Corner
	{
		TopLeft = 0,
		TopRight = 1,
		BottomLeft = 2,
		BottomRight = 3
	}

	[SerializeField]
	[Tooltip("Color for text.")]
	private Color _color;

	[SerializeField]
	[Tooltip("Which corner to display network statistics in.")]
	private Corner _placement;

	[Tooltip("True to show outgoing data bytes.")]
	[SerializeField]
	private bool _showOutgoing;

	[Tooltip("True to show incoming data bytes.")]
	[SerializeField]
	private bool _showIncoming;

	private GUIStyle _style;

	private string _clientText;

	private string _serverText;

	private NetworkTraficStatistics _networkTrafficStatistics;

	public void SetShowOutgoing(bool value)
	{
	}

	public void SetShowIncoming(bool value)
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void NetworkTraffic_OnClientNetworkTraffic(NetworkTrafficArgs obj)
	{
	}

	private void NetworkTraffic_OnServerNetworkTraffic(NetworkTrafficArgs obj)
	{
	}

	private void OnGUI()
	{
	}
}
