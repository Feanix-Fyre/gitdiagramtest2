using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public static class InputActionRebindingExtensions
{
	internal struct Parameter
	{
		public object instance;

		public FieldInfo field;

		public int bindingIndex;
	}

	private struct ParameterEnumerable : IEnumerable<Parameter>, IEnumerable
	{
		private InputActionState m_State;

		private ParameterOverride m_Parameter;

		private int m_MapIndex;

		public ParameterEnumerable(InputActionState state, ParameterOverride parameter, int mapIndex = -1)
		{
			m_State = null;
			m_Parameter = default(ParameterOverride);
			m_MapIndex = 0;
		}

		public ParameterEnumerator GetEnumerator()
		{
			return default(ParameterEnumerator);
		}

		IEnumerator<Parameter> IEnumerable<Parameter>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	private struct ParameterEnumerator : IEnumerator<Parameter>, IEnumerator, IDisposable
	{
		private InputActionState m_State;

		private int m_MapIndex;

		private int m_BindingCurrentIndex;

		private int m_BindingEndIndex;

		private int m_InteractionCurrentIndex;

		private int m_InteractionEndIndex;

		private int m_ProcessorCurrentIndex;

		private int m_ProcessorEndIndex;

		private InputBinding m_BindingMask;

		private Type m_ObjectType;

		private string m_ParameterName;

		private bool m_MayBeInteraction;

		private bool m_MayBeProcessor;

		private bool m_MayBeComposite;

		private bool m_CurrentBindingIsComposite;

		private object m_CurrentObject;

		private FieldInfo m_CurrentParameter;

		public Parameter Current => default(Parameter);

		object IEnumerator.Current => null;

		public ParameterEnumerator(InputActionState state, ParameterOverride parameter, int mapIndex = -1)
		{
			m_State = null;
			m_MapIndex = 0;
			m_BindingCurrentIndex = 0;
			m_BindingEndIndex = 0;
			m_InteractionCurrentIndex = 0;
			m_InteractionEndIndex = 0;
			m_ProcessorCurrentIndex = 0;
			m_ProcessorEndIndex = 0;
			m_BindingMask = default(InputBinding);
			m_ObjectType = null;
			m_ParameterName = null;
			m_MayBeInteraction = false;
			m_MayBeProcessor = false;
			m_MayBeComposite = false;
			m_CurrentBindingIsComposite = false;
			m_CurrentObject = null;
			m_CurrentParameter = null;
		}

		private bool MoveToNextBinding()
		{
			return false;
		}

		private bool MoveToNextInteraction()
		{
			return false;
		}

		private bool MoveToNextProcessor()
		{
			return false;
		}

		private bool FindParameter(object instance)
		{
			return false;
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}
	}

	internal struct ParameterOverride
	{
		public string objectRegistrationName;

		public string parameter;

		public InputBinding bindingMask;

		public PrimitiveValue value;

		public Type objectType => null;

		public ParameterOverride(string parameterName, InputBinding bindingMask, PrimitiveValue value = default(PrimitiveValue))
		{
			objectRegistrationName = null;
			parameter = null;
			this.bindingMask = default(InputBinding);
			this.value = default(PrimitiveValue);
		}

		public ParameterOverride(string objectRegistrationName, string parameterName, InputBinding bindingMask, PrimitiveValue value = default(PrimitiveValue))
		{
			this.objectRegistrationName = null;
			parameter = null;
			this.bindingMask = default(InputBinding);
			this.value = default(PrimitiveValue);
		}

		public static ParameterOverride? Find(InputActionMap actionMap, ref InputBinding binding, string parameterName, string objectRegistrationName)
		{
			return null;
		}

		private static ParameterOverride? Find(ParameterOverride[] overrides, int overrideCount, ref InputBinding binding, string parameterName, string objectRegistrationName)
		{
			return null;
		}

		private static ParameterOverride? PickMoreSpecificOne(ParameterOverride? first, ParameterOverride? second)
		{
			return null;
		}
	}

	public sealed class RebindingOperation : IDisposable
	{
		[Flags]
		private enum Flags
		{
			Started = 1,
			Completed = 2,
			Canceled = 4,
			OnEventHooked = 8,
			OnAfterUpdateHooked = 0x10,
			DontIgnoreNoisyControls = 0x40,
			DontGeneralizePathOfSelectedControl = 0x80,
			AddNewBinding = 0x100,
			SuppressMatchingEvents = 0x200
		}

		public const float kDefaultMagnitudeThreshold = 0.2f;

		private InputAction m_ActionToRebind;

		private InputBinding? m_BindingMask;

		private Type m_ControlType;

		private InternedString m_ExpectedLayout;

		private int m_IncludePathCount;

		private string[] m_IncludePaths;

		private int m_ExcludePathCount;

		private string[] m_ExcludePaths;

		private int m_TargetBindingIndex;

		private string m_BindingGroupForNewBinding;

		private string m_CancelBinding;

		private float m_MagnitudeThreshold;

		private float[] m_Scores;

		private float[] m_Magnitudes;

		private double m_LastMatchTime;

		private double m_StartTime;

		private float m_Timeout;

		private float m_WaitSecondsAfterMatch;

		private InputControlList<InputControl> m_Candidates;

		private Action<RebindingOperation> m_OnComplete;

		private Action<RebindingOperation> m_OnCancel;

		private Action<RebindingOperation> m_OnPotentialMatch;

		private Func<InputControl, string> m_OnGeneratePath;

		private Func<InputControl, InputEventPtr, float> m_OnComputeScore;

		private Action<RebindingOperation, string> m_OnApplyBinding;

		private Action<InputEventPtr, InputDevice> m_OnEventDelegate;

		private Action m_OnAfterUpdateDelegate;

		private InputControlLayout.Cache m_LayoutCache;

		private StringBuilder m_PathBuilder;

		private Flags m_Flags;

		private Dictionary<InputControl, float> m_StartingActuations;

		public InputAction action => null;

		public InputBinding? bindingMask => null;

		public InputControlList<InputControl> candidates => default(InputControlList<InputControl>);

		public ReadOnlyArray<float> scores => default(ReadOnlyArray<float>);

		public ReadOnlyArray<float> magnitudes => default(ReadOnlyArray<float>);

		public InputControl selectedControl => null;

		public bool started => false;

		public bool completed => false;

		public bool canceled => false;

		public double startTime => 0.0;

		public float timeout => 0f;

		public string expectedControlType => null;

		public RebindingOperation WithAction(InputAction action)
		{
			return null;
		}

		public RebindingOperation WithMatchingEventsBeingSuppressed(bool value = true)
		{
			return null;
		}

		public RebindingOperation WithCancelingThrough(string binding)
		{
			return null;
		}

		public RebindingOperation WithCancelingThrough(InputControl control)
		{
			return null;
		}

		public RebindingOperation WithExpectedControlType(string layoutName)
		{
			return null;
		}

		public RebindingOperation WithExpectedControlType(Type type)
		{
			return null;
		}

		public RebindingOperation WithExpectedControlType<TControl>() where TControl : InputControl
		{
			return null;
		}

		public RebindingOperation WithTargetBinding(int bindingIndex)
		{
			return null;
		}

		public RebindingOperation WithBindingMask(InputBinding? bindingMask)
		{
			return null;
		}

		public RebindingOperation WithBindingGroup(string group)
		{
			return null;
		}

		public RebindingOperation WithoutGeneralizingPathOfSelectedControl()
		{
			return null;
		}

		public RebindingOperation WithRebindAddingNewBinding(string group = null)
		{
			return null;
		}

		public RebindingOperation WithMagnitudeHavingToBeGreaterThan(float magnitude)
		{
			return null;
		}

		public RebindingOperation WithoutIgnoringNoisyControls()
		{
			return null;
		}

		public RebindingOperation WithControlsHavingToMatchPath(string path)
		{
			return null;
		}

		public RebindingOperation WithControlsExcluding(string path)
		{
			return null;
		}

		public RebindingOperation WithTimeout(float timeInSeconds)
		{
			return null;
		}

		public RebindingOperation OnComplete(Action<RebindingOperation> callback)
		{
			return null;
		}

		public RebindingOperation OnCancel(Action<RebindingOperation> callback)
		{
			return null;
		}

		public RebindingOperation OnPotentialMatch(Action<RebindingOperation> callback)
		{
			return null;
		}

		public RebindingOperation OnGeneratePath(Func<InputControl, string> callback)
		{
			return null;
		}

		public RebindingOperation OnComputeScore(Func<InputControl, InputEventPtr, float> callback)
		{
			return null;
		}

		public RebindingOperation OnApplyBinding(Action<RebindingOperation, string> callback)
		{
			return null;
		}

		public RebindingOperation OnMatchWaitForAnother(float seconds)
		{
			return null;
		}

		public RebindingOperation Start()
		{
			return null;
		}

		public void Cancel()
		{
		}

		public void Complete()
		{
		}

		public void AddCandidate(InputControl control, float score, float magnitude = -1f)
		{
		}

		public void RemoveCandidate(InputControl control)
		{
		}

		public void Dispose()
		{
		}

		~RebindingOperation()
		{
		}

		public RebindingOperation Reset()
		{
			return null;
		}

		private void HookOnEvent()
		{
		}

		private void UnhookOnEvent()
		{
		}

		private void OnEvent(InputEventPtr eventPtr, InputDevice device)
		{
		}

		private void SortCandidatesByScore()
		{
		}

		private static bool HavePathMatch(InputControl control, string[] paths, int pathCount)
		{
			return false;
		}

		private void HookOnAfterUpdate()
		{
		}

		private void UnhookOnAfterUpdate()
		{
		}

		private void OnAfterUpdate()
		{
		}

		private void OnComplete()
		{
		}

		private void OnCancel()
		{
		}

		private void ResetAfterMatchCompleted()
		{
		}

		private void ThrowIfRebindInProgress()
		{
		}

		private string GeneratePathForControl(InputControl control)
		{
			return null;
		}
	}

	internal class DeferBindingResolutionWrapper : IDisposable
	{
		public void Acquire()
		{
		}

		public void Dispose()
		{
		}
	}

	private static DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper;

	public static PrimitiveValue? GetParameterValue(this InputAction action, string name, InputBinding bindingMask = default(InputBinding))
	{
		return null;
	}

	private static PrimitiveValue? GetParameterValue(this InputAction action, ParameterOverride parameterOverride)
	{
		return null;
	}

	public static PrimitiveValue? GetParameterValue(this InputAction action, string name, int bindingIndex)
	{
		return null;
	}

	public static TValue? GetParameterValue<TObject, TValue>(this InputAction action, Expression<Func<TObject, TValue>> expr, InputBinding bindingMask = default(InputBinding)) where TValue : struct
	{
		return null;
	}

	public static void ApplyParameterOverride<TObject, TValue>(this InputAction action, Expression<Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask = default(InputBinding)) where TValue : struct
	{
	}

	public static void ApplyParameterOverride<TObject, TValue>(this InputActionMap actionMap, Expression<Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask = default(InputBinding)) where TValue : struct
	{
	}

	public static void ApplyParameterOverride<TObject, TValue>(this InputActionAsset asset, Expression<Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask = default(InputBinding)) where TValue : struct
	{
	}

	private static ParameterOverride ExtractParameterOverride<TObject, TValue>(Expression<Func<TObject, TValue>> expr, InputBinding bindingMask = default(InputBinding), PrimitiveValue value = default(PrimitiveValue))
	{
		return default(ParameterOverride);
	}

	public static void ApplyParameterOverride(this InputActionMap actionMap, string name, PrimitiveValue value, InputBinding bindingMask = default(InputBinding))
	{
	}

	public static void ApplyParameterOverride(this InputActionAsset asset, string name, PrimitiveValue value, InputBinding bindingMask = default(InputBinding))
	{
	}

	public static void ApplyParameterOverride(this InputAction action, string name, PrimitiveValue value, InputBinding bindingMask = default(InputBinding))
	{
	}

	public static void ApplyParameterOverride(this InputAction action, string name, PrimitiveValue value, int bindingIndex)
	{
	}

	private static void ApplyParameterOverride(InputActionState state, int mapIndex, ref ParameterOverride[] parameterOverrides, ref int parameterOverridesCount, ParameterOverride parameterOverride)
	{
	}

	public static int GetBindingIndex(this InputAction action, InputBinding bindingMask)
	{
		return 0;
	}

	public static int GetBindingIndex(this InputActionMap actionMap, InputBinding bindingMask)
	{
		return 0;
	}

	public static int GetBindingIndex(this InputAction action, string group = null, string path = null)
	{
		return 0;
	}

	public static InputBinding? GetBindingForControl(this InputAction action, InputControl control)
	{
		return null;
	}

	public static int GetBindingIndexForControl(this InputAction action, InputControl control)
	{
		return 0;
	}

	public static string GetBindingDisplayString(this InputAction action, InputBinding.DisplayStringOptions options = (InputBinding.DisplayStringOptions)0, string group = null)
	{
		return null;
	}

	public static string GetBindingDisplayString(this InputAction action, InputBinding bindingMask, InputBinding.DisplayStringOptions options = (InputBinding.DisplayStringOptions)0)
	{
		return null;
	}

	public static string GetBindingDisplayString(this InputAction action, int bindingIndex, InputBinding.DisplayStringOptions options = (InputBinding.DisplayStringOptions)0)
	{
		return null;
	}

	public static string GetBindingDisplayString(this InputAction action, int bindingIndex, out string deviceLayoutName, out string controlPath, InputBinding.DisplayStringOptions options = (InputBinding.DisplayStringOptions)0)
	{
		deviceLayoutName = null;
		controlPath = null;
		return null;
	}

	public static void ApplyBindingOverride(this InputAction action, string newPath, string group = null, string path = null)
	{
	}

	public static void ApplyBindingOverride(this InputAction action, InputBinding bindingOverride)
	{
	}

	public static void ApplyBindingOverride(this InputAction action, int bindingIndex, InputBinding bindingOverride)
	{
	}

	public static void ApplyBindingOverride(this InputAction action, int bindingIndex, string path)
	{
	}

	public static int ApplyBindingOverride(this InputActionMap actionMap, InputBinding bindingOverride)
	{
		return 0;
	}

	public static void ApplyBindingOverride(this InputActionMap actionMap, int bindingIndex, InputBinding bindingOverride)
	{
	}

	public static void RemoveBindingOverride(this InputAction action, int bindingIndex)
	{
	}

	public static void RemoveBindingOverride(this InputAction action, InputBinding bindingMask)
	{
	}

	private static void RemoveBindingOverride(this InputActionMap actionMap, InputBinding bindingMask)
	{
	}

	public static void RemoveAllBindingOverrides(this IInputActionCollection2 actions)
	{
	}

	public static void RemoveAllBindingOverrides(this InputAction action)
	{
	}

	public static void ApplyBindingOverrides(this InputActionMap actionMap, IEnumerable<InputBinding> overrides)
	{
	}

	public static void RemoveBindingOverrides(this InputActionMap actionMap, IEnumerable<InputBinding> overrides)
	{
	}

	public static int ApplyBindingOverridesOnMatchingControls(this InputAction action, InputControl control)
	{
		return 0;
	}

	public static int ApplyBindingOverridesOnMatchingControls(this InputActionMap actionMap, InputControl control)
	{
		return 0;
	}

	public static string SaveBindingOverridesAsJson(this IInputActionCollection2 actions)
	{
		return null;
	}

	public static string SaveBindingOverridesAsJson(this InputAction action)
	{
		return null;
	}

	private static void AddBindingOverrideJsonTo(this IInputActionCollection2 actions, InputBinding binding, List<InputActionMap.BindingOverrideJson> list, InputAction action = null)
	{
	}

	public static void LoadBindingOverridesFromJson(this IInputActionCollection2 actions, string json, bool removeExisting = true)
	{
	}

	public static void LoadBindingOverridesFromJson(this InputAction action, string json, bool removeExisting = true)
	{
	}

	private static void LoadBindingOverridesFromJsonInternal(this IInputActionCollection2 actions, string json)
	{
	}

	public static RebindingOperation PerformInteractiveRebinding(this InputAction action, int bindingIndex = -1)
	{
		return null;
	}

	internal static DeferBindingResolutionWrapper DeferBindingResolution()
	{
		return null;
	}
}
