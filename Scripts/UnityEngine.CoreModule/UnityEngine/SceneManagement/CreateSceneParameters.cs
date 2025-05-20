using System;

namespace UnityEngine.SceneManagement;

[Serializable]
public struct CreateSceneParameters
{
	[SerializeField]
	private LocalPhysicsMode m_LocalPhysicsMode;

	public CreateSceneParameters(LocalPhysicsMode physicsMode)
	{
		m_LocalPhysicsMode = default(LocalPhysicsMode);
	}
}
