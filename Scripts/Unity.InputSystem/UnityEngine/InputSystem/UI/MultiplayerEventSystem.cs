using UnityEngine.EventSystems;

namespace UnityEngine.InputSystem.UI;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/UISupport.html#multiplayer-uis")]
public class MultiplayerEventSystem : EventSystem
{
	[SerializeField]
	[Tooltip("If set, only process mouse and navigation events for any game objects which are children of this game object.")]
	private GameObject m_PlayerRoot;

	public GameObject playerRoot
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	private void InitializePlayerRoot()
	{
	}

	protected override void Update()
	{
	}
}
