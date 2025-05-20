using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Modules/Animation/Animator.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
[UsedByNativeCode]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
public class Animator : Behaviour
{
	public bool isHuman
	{
		[NativeMethod("IsHuman")]
		get
		{
			return false;
		}
	}

	public bool hasRootMotion
	{
		[NativeMethod("HasRootMotion")]
		get
		{
			return false;
		}
	}

	public float humanScale => 0f;

	public Vector3 deltaPosition => default(Vector3);

	public Quaternion deltaRotation => default(Quaternion);

	public bool applyRootMotion
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public AnimatorUpdateMode updateMode
	{
		get
		{
			return default(AnimatorUpdateMode);
		}
		set
		{
		}
	}

	public int layerCount => 0;

	public AnimatorControllerParameter[] parameters
	{
		[FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = true)]
		get
		{
			return null;
		}
	}

	public Vector3 pivotPosition => default(Vector3);

	public float speed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public AnimatorCullingMode cullingMode
	{
		get
		{
			return default(AnimatorCullingMode);
		}
		set
		{
		}
	}

	public RuntimeAnimatorController runtimeAnimatorController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool hasBoundPlayables
	{
		[NativeMethod("HasBoundPlayables")]
		get
		{
			return false;
		}
	}

	public Avatar avatar
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool logWarnings => false;

	public bool keepAnimatorStateOnDisable
	{
		set
		{
		}
	}

	public float GetFloat(string name)
	{
		return 0f;
	}

	public float GetFloat(int id)
	{
		return 0f;
	}

	public void SetFloat(string name, float value)
	{
	}

	public void SetFloat(int id, float value)
	{
	}

	public bool GetBool(int id)
	{
		return false;
	}

	public void SetBool(string name, bool value)
	{
	}

	public void SetBool(int id, bool value)
	{
	}

	public int GetInteger(int id)
	{
		return 0;
	}

	public void SetInteger(int id, int value)
	{
	}

	public void SetTrigger(string name)
	{
	}

	public void SetTrigger(int id)
	{
	}

	public void ResetTrigger(string name)
	{
	}

	public void ResetTrigger(int id)
	{
	}

	public bool IsParameterControlledByCurve(string name)
	{
		return false;
	}

	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition)
	{
	}

	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition)
	{
	}

	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation)
	{
	}

	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation)
	{
	}

	public void SetIKPositionWeight(AvatarIKGoal goal, float value)
	{
	}

	private void SetGoalWeightPosition(AvatarIKGoal goal, float value)
	{
	}

	public void SetIKRotationWeight(AvatarIKGoal goal, float value)
	{
	}

	private void SetGoalWeightRotation(AvatarIKGoal goal, float value)
	{
	}

	public void SetLookAtPosition(Vector3 lookAtPosition)
	{
	}

	[NativeMethod("SetLookAtPosition")]
	private void SetLookAtPositionInternal(Vector3 lookAtPosition)
	{
	}

	public void SetLookAtWeight(float weight)
	{
	}

	public void SetLookAtWeight(float weight, [DefaultValue("0.0f")] float bodyWeight, [DefaultValue("1.0f")] float headWeight, [DefaultValue("0.0f")] float eyesWeight, [DefaultValue("0.5f")] float clampWeight)
	{
	}

	[NativeMethod("SetLookAtWeight")]
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
	{
	}

	public float GetLayerWeight(int layerIndex)
	{
		return 0f;
	}

	public void SetLayerWeight(int layerIndex, float weight)
	{
	}

	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info)
	{
		info = default(AnimatorStateInfo);
	}

	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex)
	{
		return default(AnimatorStateInfo);
	}

	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex)
	{
		return default(AnimatorStateInfo);
	}

	private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info)
	{
		info = default(AnimatorTransitionInfo);
	}

	public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex)
	{
		return default(AnimatorTransitionInfo);
	}

	public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::GetAnimatorClipInfoInternal", HasExplicitThis = true)]
	private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips)
	{
	}

	public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
	{
	}

	public bool IsInTransition(int layerIndex)
	{
		return false;
	}

	[FreeFunction(Name = "AnimatorBindings::CrossFadeInFixedTime", HasExplicitThis = true)]
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float fixedTimeOffset, [DefaultValue("0.0f")] float normalizedTransitionTime)
	{
	}

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset)
	{
	}

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer)
	{
	}

	public void CrossFade(string stateName, float normalizedTransitionDuration)
	{
	}

	public void CrossFade(string stateName, float normalizedTransitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTimeOffset, [DefaultValue("0.0f")] float normalizedTransitionTime)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::CrossFade", HasExplicitThis = true)]
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float normalizedTimeOffset, [DefaultValue("0.0f")] float normalizedTransitionTime)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::PlayInFixedTime", HasExplicitThis = true)]
	public void PlayInFixedTime(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime)
	{
	}

	public void Play(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = true)]
	public void Play(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
	{
	}

	public Transform GetBoneTransform(HumanBodyBones humanBoneId)
	{
		return null;
	}

	[NativeMethod("GetBoneTransform")]
	internal Transform GetBoneTransformInternal(int humanBoneId)
	{
		return null;
	}

	public bool HasState(int layerIndex, int stateID)
	{
		return false;
	}

	[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = true)]
	public static int StringToHash(string name)
	{
		return 0;
	}

	private void CheckIfInIKPass()
	{
	}

	private bool IsInIKPass()
	{
		return false;
	}

	[FreeFunction(Name = "AnimatorBindings::SetFloatString", HasExplicitThis = true)]
	private void SetFloatString(string name, float value)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::SetFloatID", HasExplicitThis = true)]
	private void SetFloatID(int id, float value)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::GetFloatString", HasExplicitThis = true)]
	private float GetFloatString(string name)
	{
		return 0f;
	}

	[FreeFunction(Name = "AnimatorBindings::GetFloatID", HasExplicitThis = true)]
	private float GetFloatID(int id)
	{
		return 0f;
	}

	[FreeFunction(Name = "AnimatorBindings::SetBoolString", HasExplicitThis = true)]
	private void SetBoolString(string name, bool value)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::SetBoolID", HasExplicitThis = true)]
	private void SetBoolID(int id, bool value)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::GetBoolID", HasExplicitThis = true)]
	private bool GetBoolID(int id)
	{
		return false;
	}

	[FreeFunction(Name = "AnimatorBindings::SetIntegerID", HasExplicitThis = true)]
	private void SetIntegerID(int id, int value)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::GetIntegerID", HasExplicitThis = true)]
	private int GetIntegerID(int id)
	{
		return 0;
	}

	[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = true)]
	private void SetTriggerString(string name)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::SetTriggerID", HasExplicitThis = true)]
	private void SetTriggerID(int id)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = true)]
	private void ResetTriggerString(string name)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerID", HasExplicitThis = true)]
	private void ResetTriggerID(int id)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveString", HasExplicitThis = true)]
	private bool IsParameterControlledByCurveString(string name)
	{
		return false;
	}

	[NativeMethod("UpdateWithDelta")]
	public void Update(float deltaTime)
	{
	}

	public void Rebind()
	{
	}

	private void Rebind(bool writeDefaultValues)
	{
	}

	[SpecialName]
	private void get_deltaPosition_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}

	[SpecialName]
	private void get_deltaRotation_Injected(out Quaternion ret)
	{
		ret = default(Quaternion);
	}

	private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition)
	{
	}

	private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation)
	{
	}

	private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition)
	{
	}

	[SpecialName]
	private void get_pivotPosition_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}
}
