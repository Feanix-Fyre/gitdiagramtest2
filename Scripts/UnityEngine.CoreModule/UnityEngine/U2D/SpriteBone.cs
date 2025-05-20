using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D;

[Serializable]
[NativeType(CodegenOptions.Custom, "ScriptingSpriteBone")]
[RequiredByNativeCode]
[NativeHeader("Runtime/2D/Common/SpriteDataMarshalling.h")]
[MovedFrom("UnityEngine.Experimental.U2D")]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
public struct SpriteBone
{
	[NativeName("name")]
	[SerializeField]
	private string m_Name;

	[SerializeField]
	[NativeName("guid")]
	private string m_Guid;

	[NativeName("position")]
	[SerializeField]
	private Vector3 m_Position;

	[SerializeField]
	[NativeName("rotation")]
	private Quaternion m_Rotation;

	[NativeName("length")]
	[SerializeField]
	private float m_Length;

	[NativeName("parentId")]
	[SerializeField]
	private int m_ParentId;

	[NativeName("color")]
	[SerializeField]
	private Color32 m_Color;
}
