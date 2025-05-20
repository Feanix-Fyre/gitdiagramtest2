using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[AddComponentMenu(null)]
[RequireComponent(typeof(Rigidbody2D))]
public class AmplifyColorTriggerProxy2D : AmplifyColorTriggerProxyBase
{
	private CircleCollider2D circleCollider;

	private Rigidbody2D rigidBody;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
