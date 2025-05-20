using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[NativeType(CodegenOptions.Custom, "MonoAnimatorControllerParameter")]
[UsedByNativeCode]
[NativeAsStruct]
[NativeHeader("Modules/Animation/AnimatorControllerParameter.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
public class AnimatorControllerParameter
{
	internal string m_Name;

	internal AnimatorControllerParameterType m_Type;

	internal float m_DefaultFloat;

	internal int m_DefaultInt;

	internal bool m_DefaultBool;

	public string name => null;

	public int nameHash => 0;

	public AnimatorControllerParameterType type => default(AnimatorControllerParameterType);

	public override bool Equals(object o)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
