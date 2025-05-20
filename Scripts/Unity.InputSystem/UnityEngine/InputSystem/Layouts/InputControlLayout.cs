using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Layouts;

public class InputControlLayout
{
	public struct ControlItem
	{
		[Flags]
		private enum Flags
		{
			isModifyingExistingControl = 1,
			IsNoisy = 2,
			IsSynthetic = 4,
			IsFirstDefinedInThisLayout = 8,
			DontReset = 0x10
		}

		public InternedString name { get; internal set; }

		public InternedString layout { get; internal set; }

		public InternedString variants { get; internal set; }

		public string useStateFrom { get; internal set; }

		public string displayName { get; internal set; }

		public string shortDisplayName { get; internal set; }

		public ReadOnlyArray<InternedString> usages { get; internal set; }

		public ReadOnlyArray<InternedString> aliases { get; internal set; }

		public ReadOnlyArray<NamedValue> parameters { get; internal set; }

		public ReadOnlyArray<NameAndParameters> processors { get; internal set; }

		public uint offset { get; internal set; }

		public uint bit { get; internal set; }

		public uint sizeInBits { get; internal set; }

		public FourCC format { get; internal set; }

		private Flags flags { get; set; }

		public int arraySize { get; internal set; }

		public PrimitiveValue defaultState { get; internal set; }

		public PrimitiveValue minValue { get; internal set; }

		public PrimitiveValue maxValue { get; internal set; }

		public bool isModifyingExistingControl
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public bool isNoisy
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public bool isSynthetic
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public bool dontReset
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public bool isFirstDefinedInThisLayout
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public bool isArray => false;

		public ControlItem Merge(ControlItem other)
		{
			return default(ControlItem);
		}
	}

	public class Builder
	{
		public struct ControlBuilder
		{
			internal Builder builder;

			internal int index;

			public ControlBuilder WithDisplayName(string displayName)
			{
				return default(ControlBuilder);
			}

			public ControlBuilder WithLayout(string layout)
			{
				return default(ControlBuilder);
			}

			public ControlBuilder WithFormat(FourCC format)
			{
				return default(ControlBuilder);
			}

			public ControlBuilder WithFormat(string format)
			{
				return default(ControlBuilder);
			}

			public ControlBuilder WithByteOffset(uint offset)
			{
				return default(ControlBuilder);
			}

			public ControlBuilder WithBitOffset(uint bit)
			{
				return default(ControlBuilder);
			}

			public ControlBuilder IsSynthetic(bool value)
			{
				return default(ControlBuilder);
			}

			public ControlBuilder IsNoisy(bool value)
			{
				return default(ControlBuilder);
			}

			public ControlBuilder DontReset(bool value)
			{
				return default(ControlBuilder);
			}

			public ControlBuilder WithSizeInBits(uint sizeInBits)
			{
				return default(ControlBuilder);
			}

			public ControlBuilder WithRange(float minValue, float maxValue)
			{
				return default(ControlBuilder);
			}

			public ControlBuilder WithUsages(params InternedString[] usages)
			{
				return default(ControlBuilder);
			}

			public ControlBuilder WithUsages(IEnumerable<string> usages)
			{
				return default(ControlBuilder);
			}

			public ControlBuilder WithUsages(params string[] usages)
			{
				return default(ControlBuilder);
			}

			public ControlBuilder WithParameters(string parameters)
			{
				return default(ControlBuilder);
			}

			public ControlBuilder WithProcessors(string processors)
			{
				return default(ControlBuilder);
			}

			public ControlBuilder WithDefaultState(PrimitiveValue value)
			{
				return default(ControlBuilder);
			}

			public ControlBuilder UsingStateFrom(string path)
			{
				return default(ControlBuilder);
			}

			public ControlBuilder AsArrayOfControlsWithSize(int arraySize)
			{
				return default(ControlBuilder);
			}
		}

		private string m_ExtendsLayout;

		private int m_ControlCount;

		private ControlItem[] m_Controls;

		public string name { get; set; }

		public string displayName { get; set; }

		public Type type { get; set; }

		public FourCC stateFormat { get; set; }

		public int stateSizeInBytes { get; set; }

		public string extendsLayout
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool? updateBeforeRender { get; set; }

		public ReadOnlyArray<ControlItem> controls => default(ReadOnlyArray<ControlItem>);

		public ControlBuilder AddControl(string name)
		{
			return default(ControlBuilder);
		}

		public Builder WithName(string name)
		{
			return null;
		}

		public Builder WithDisplayName(string displayName)
		{
			return null;
		}

		public Builder WithType<T>() where T : InputControl
		{
			return null;
		}

		public Builder WithFormat(FourCC format)
		{
			return null;
		}

		public Builder WithFormat(string format)
		{
			return null;
		}

		public Builder WithSizeInBytes(int sizeInBytes)
		{
			return null;
		}

		public Builder Extend(string baseLayoutName)
		{
			return null;
		}

		public InputControlLayout Build()
		{
			return null;
		}
	}

	[Flags]
	private enum Flags
	{
		IsGenericTypeOfDevice = 1,
		HideInUI = 2,
		IsOverride = 4,
		CanRunInBackground = 8,
		CanRunInBackgroundIsSet = 0x10,
		IsNoisy = 0x20
	}

	[Serializable]
	internal struct LayoutJsonNameAndDescriptorOnly
	{
		public string name;

		public string extend;

		public string[] extendMultiple;

		public InputDeviceMatcher.MatcherJson device;
	}

	[Serializable]
	private struct LayoutJson
	{
		public string name;

		public string extend;

		public string[] extendMultiple;

		public string format;

		public string beforeRender;

		public string runInBackground;

		public string[] commonUsages;

		public string displayName;

		public string description;

		public string type;

		public string variant;

		public bool isGenericTypeOfDevice;

		public bool hideInUI;

		public ControlItemJson[] controls;

		public InputControlLayout ToLayout()
		{
			return null;
		}

		public static LayoutJson FromLayout(InputControlLayout layout)
		{
			return default(LayoutJson);
		}
	}

	[Serializable]
	private class ControlItemJson
	{
		public string name;

		public string layout;

		public string variants;

		public string usage;

		public string alias;

		public string useStateFrom;

		public uint offset;

		public uint bit;

		public uint sizeInBits;

		public string format;

		public int arraySize;

		public string[] usages;

		public string[] aliases;

		public string parameters;

		public string processors;

		public string displayName;

		public string shortDisplayName;

		public bool noisy;

		public bool dontReset;

		public bool synthetic;

		public string defaultState;

		public string minValue;

		public string maxValue;

		public ControlItem ToLayout()
		{
			return default(ControlItem);
		}

		public static ControlItemJson[] FromControlItems(ControlItem[] items)
		{
			return null;
		}
	}

	internal struct Collection
	{
		public struct LayoutMatcher
		{
			public InternedString layoutName;

			public InputDeviceMatcher deviceMatcher;
		}

		public struct PrecompiledLayout
		{
			public Func<InputDevice> factoryMethod;

			public string metadata;
		}

		[CompilerGenerated]
		private sealed class _003CGetBaseLayouts_003Ed__24 : IEnumerable<InternedString>, IEnumerable, IEnumerator<InternedString>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private InternedString _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private bool includeSelf;

			public bool _003C_003E3__includeSelf;

			private InternedString layout;

			public InternedString _003C_003E3__layout;

			public Collection _003C_003E4__this;

			public Collection _003C_003E3___003C_003E4__this;

			InternedString IEnumerator<InternedString>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(InternedString);
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGetBaseLayouts_003Ed__24(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<InternedString> IEnumerable<InternedString>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public const float kBaseScoreForNonGeneratedLayouts = 1f;

		public Dictionary<InternedString, Type> layoutTypes;

		public Dictionary<InternedString, string> layoutStrings;

		public Dictionary<InternedString, Func<InputControlLayout>> layoutBuilders;

		public Dictionary<InternedString, InternedString> baseLayoutTable;

		public Dictionary<InternedString, InternedString[]> layoutOverrides;

		public HashSet<InternedString> layoutOverrideNames;

		public Dictionary<InternedString, PrecompiledLayout> precompiledLayouts;

		public List<LayoutMatcher> layoutMatchers;

		public void Allocate()
		{
		}

		public InternedString TryFindLayoutForType(Type layoutType)
		{
			return default(InternedString);
		}

		public InternedString TryFindMatchingLayout(InputDeviceDescription deviceDescription)
		{
			return default(InternedString);
		}

		public bool HasLayout(InternedString name)
		{
			return false;
		}

		private InputControlLayout TryLoadLayoutInternal(InternedString name)
		{
			return null;
		}

		public InputControlLayout TryLoadLayout(InternedString name, Dictionary<InternedString, InputControlLayout> table = null)
		{
			return null;
		}

		public InternedString GetBaseLayoutName(InternedString layoutName)
		{
			return default(InternedString);
		}

		public InternedString GetRootLayoutName(InternedString layoutName)
		{
			return default(InternedString);
		}

		public bool ComputeDistanceInInheritanceHierarchy(InternedString firstLayout, InternedString secondLayout, out int distance)
		{
			distance = default(int);
			return false;
		}

		public InternedString FindLayoutThatIntroducesControl(InputControl control, Cache cache)
		{
			return default(InternedString);
		}

		public Type GetControlTypeForLayout(InternedString layoutName)
		{
			return null;
		}

		public bool ValueTypeIsAssignableFrom(InternedString layoutName, Type valueType)
		{
			return false;
		}

		public bool IsGeneratedLayout(InternedString layout)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CGetBaseLayouts_003Ed__24))]
		public IEnumerable<InternedString> GetBaseLayouts(InternedString layout, bool includeSelf = true)
		{
			return null;
		}

		public bool IsBasedOn(InternedString parentLayout, InternedString childLayout)
		{
			return false;
		}

		public void AddMatcher(InternedString layout, InputDeviceMatcher matcher)
		{
		}
	}

	public class LayoutNotFoundException : Exception
	{
		public string layout { get; }

		public LayoutNotFoundException()
		{
		}

		public LayoutNotFoundException(string name, string message)
		{
		}

		public LayoutNotFoundException(string name)
		{
		}

		public LayoutNotFoundException(string message, Exception innerException)
		{
		}

		protected LayoutNotFoundException(SerializationInfo info, StreamingContext context)
		{
		}
	}

	internal struct Cache
	{
		public Dictionary<InternedString, InputControlLayout> table;

		public void Clear()
		{
		}

		public InputControlLayout FindOrLoadLayout(string name, bool throwIfNotFound = true)
		{
			return null;
		}
	}

	internal struct CacheRefInstance : IDisposable
	{
		public bool valid;

		public void Dispose()
		{
		}
	}

	private static InternedString s_DefaultVariant;

	public const string VariantSeparator = ";";

	private InternedString m_Name;

	private Type m_Type;

	private InternedString m_Variants;

	private FourCC m_StateFormat;

	internal int m_StateSizeInBytes;

	internal bool? m_UpdateBeforeRender;

	internal InlinedArray<InternedString> m_BaseLayouts;

	private InlinedArray<InternedString> m_AppliedOverrides;

	private InternedString[] m_CommonUsages;

	internal ControlItem[] m_Controls;

	internal string m_DisplayName;

	private string m_Description;

	private Flags m_Flags;

	internal static Collection s_Layouts;

	internal static Cache s_CacheInstance;

	internal static int s_CacheInstanceRef;

	public static InternedString DefaultVariant => default(InternedString);

	public InternedString name => default(InternedString);

	public string displayName => null;

	public Type type => null;

	public InternedString variants => default(InternedString);

	public FourCC stateFormat => default(FourCC);

	public int stateSizeInBytes => 0;

	public IEnumerable<InternedString> baseLayouts => null;

	public IEnumerable<InternedString> appliedOverrides => null;

	public ReadOnlyArray<InternedString> commonUsages => default(ReadOnlyArray<InternedString>);

	public ReadOnlyArray<ControlItem> controls => default(ReadOnlyArray<ControlItem>);

	public bool updateBeforeRender => false;

	public bool isDeviceLayout => false;

	public bool isControlLayout => false;

	public bool isOverride
	{
		get
		{
			return false;
		}
		internal set
		{
		}
	}

	public bool isGenericTypeOfDevice
	{
		get
		{
			return false;
		}
		internal set
		{
		}
	}

	public bool hideInUI
	{
		get
		{
			return false;
		}
		internal set
		{
		}
	}

	public bool isNoisy
	{
		get
		{
			return false;
		}
		internal set
		{
		}
	}

	public bool? canRunInBackground
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public ControlItem this[string path] => default(ControlItem);

	internal static ref Cache cache
	{
		get
		{
			throw null;
		}
	}

	public ControlItem? FindControl(InternedString path)
	{
		return null;
	}

	public ControlItem? FindControlIncludingArrayElements(string path, out int arrayIndex)
	{
		arrayIndex = default(int);
		return null;
	}

	public Type GetValueType()
	{
		return null;
	}

	public static InputControlLayout FromType(string name, Type type)
	{
		return null;
	}

	public string ToJson()
	{
		return null;
	}

	public static InputControlLayout FromJson(string json)
	{
		return null;
	}

	private InputControlLayout(string name, Type type)
	{
	}

	private static void AddControlItems(Type type, List<ControlItem> controlLayouts, string layoutName)
	{
	}

	private static void AddControlItemsFromFields(Type type, List<ControlItem> controlLayouts, string layoutName)
	{
	}

	private static void AddControlItemsFromProperties(Type type, List<ControlItem> controlLayouts, string layoutName)
	{
	}

	private static void AddControlItemsFromMembers(MemberInfo[] members, List<ControlItem> controlItems, string layoutName)
	{
	}

	private static void AddControlItemsFromMember(MemberInfo member, InputControlAttribute[] attributes, List<ControlItem> controlItems)
	{
	}

	private static ControlItem CreateControlItemFromMember(MemberInfo member, InputControlAttribute attribute)
	{
		return default(ControlItem);
	}

	private static string InferLayoutFromValueType(Type type)
	{
		return null;
	}

	public void MergeLayout(InputControlLayout other)
	{
	}

	private static Dictionary<string, ControlItem> CreateLookupTableForControls(ControlItem[] controlItems, List<string> variants = null)
	{
		return null;
	}

	internal static bool VariantsMatch(InternedString expected, InternedString actual)
	{
		return false;
	}

	internal static bool VariantsMatch(string expected, string actual)
	{
		return false;
	}

	internal static void ParseHeaderFieldsFromJson(string json, out InternedString name, out InlinedArray<InternedString> baseLayouts, out InputDeviceMatcher deviceMatcher)
	{
		name = default(InternedString);
		baseLayouts = default(InlinedArray<InternedString>);
		deviceMatcher = default(InputDeviceMatcher);
	}

	internal static CacheRefInstance CacheRef()
	{
		return default(CacheRefInstance);
	}
}
