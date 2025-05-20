using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[AddComponentMenu(null)]
[RequireComponent(typeof(SphereCollider))]
public class AmplifyColorTriggerProxy : AmplifyColorTriggerProxyBase
{
	private SphereCollider sphereCollider;

	private Rigidbody rigidBody;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
