using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeType("Runtime/Graphics/Mesh/SpriteRenderer.h")]
[RequireComponent(typeof(Transform))]
public sealed class SpriteRenderer : Renderer
{
	private UnityEvent<SpriteRenderer> m_SpriteChangeEvent;

	public Sprite sprite
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[RequiredByNativeCode]
	private void InvokeSpriteChanged()
	{
	}
}
