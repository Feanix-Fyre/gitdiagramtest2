using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public static class InputControlPath
{
	[Flags]
	public enum HumanReadableStringOptions
	{
		None = 0,
		OmitDevice = 2,
		UseShortNames = 4
	}

	private enum PathComponentType
	{
		Name = 0,
		DisplayName = 1,
		Usage = 2,
		Layout = 3
	}

	public struct ParsedPathComponent
	{
		internal Substring m_Layout;

		internal InlinedArray<Substring> m_Usages;

		internal Substring m_Name;

		internal Substring m_DisplayName;

		public string layout => null;

		public IEnumerable<string> usages => null;

		public string name => null;

		public string displayName => null;

		internal bool isWildcard => false;

		internal bool isDoubleWildcard => false;

		internal string ToHumanReadableString(string parentLayoutName, string parentControlPath, out string referencedLayoutName, out string controlPath, HumanReadableStringOptions options)
		{
			referencedLayoutName = null;
			controlPath = null;
			return null;
		}

		private static string ToHumanReadableString(Substring substring)
		{
			return null;
		}

		public bool Matches(InputControl control)
		{
			return false;
		}

		private static bool ComparePathElementToString(Substring pathElement, string element)
		{
			return false;
		}
	}

	private struct PathParser
	{
		private string path;

		private int length;

		private int leftIndexInPath;

		private int rightIndexInPath;

		public ParsedPathComponent current;

		public bool isAtEnd => false;

		public PathParser(string path)
		{
			this.path = null;
			length = 0;
			leftIndexInPath = 0;
			rightIndexInPath = 0;
			current = default(ParsedPathComponent);
		}

		public bool MoveToNextComponent()
		{
			return false;
		}

		private Substring ParseComponentPart(char terminator)
		{
			return default(Substring);
		}
	}

	[CompilerGenerated]
	private sealed class _003CParse_003Ed__34 : IEnumerable<ParsedPathComponent>, IEnumerable, IEnumerator<ParsedPathComponent>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ParsedPathComponent _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string path;

		public string _003C_003E3__path;

		private PathParser _003Cparser_003E5__2;

		ParsedPathComponent IEnumerator<ParsedPathComponent>.Current
		{
			[DebuggerHidden]
			get
			{
				return default(ParsedPathComponent);
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
		public _003CParse_003Ed__34(int _003C_003E1__state)
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
		IEnumerator<ParsedPathComponent> IEnumerable<ParsedPathComponent>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public const string Wildcard = "*";

	public const string DoubleWildcard = "**";

	public const char Separator = '/';

	internal const char SeparatorReplacement = ' ';

	internal static string CleanSlashes(this string pathComponent)
	{
		return null;
	}

	public static string Combine(InputControl parent, string path)
	{
		return null;
	}

	public static string ToHumanReadableString(string path, HumanReadableStringOptions options = HumanReadableStringOptions.None, InputControl control = null)
	{
		return null;
	}

	public static string ToHumanReadableString(string path, out string deviceLayoutName, out string controlPath, HumanReadableStringOptions options = HumanReadableStringOptions.None, InputControl control = null)
	{
		deviceLayoutName = null;
		controlPath = null;
		return null;
	}

	public static string[] TryGetDeviceUsages(string path)
	{
		return null;
	}

	public static string TryGetDeviceLayout(string path)
	{
		return null;
	}

	public static string TryGetControlLayout(string path)
	{
		return null;
	}

	private static string FindControlLayoutRecursive(ref PathParser parser, string layoutName)
	{
		return null;
	}

	private static string FindControlLayoutRecursive(ref PathParser parser, InputControlLayout layout)
	{
		return null;
	}

	private static bool ControlLayoutMatchesPathComponent(ref InputControlLayout.ControlItem controlItem, ref PathParser parser)
	{
		return false;
	}

	private static bool StringMatches(Substring str, InternedString matchTo)
	{
		return false;
	}

	public static InputControl TryFindControl(InputControl control, string path, int indexInPath = 0)
	{
		return null;
	}

	public static InputControl[] TryFindControls(InputControl control, string path, int indexInPath = 0)
	{
		return null;
	}

	public static int TryFindControls(InputControl control, string path, ref InputControlList<InputControl> matches, int indexInPath = 0)
	{
		return 0;
	}

	public static TControl TryFindControl<TControl>(InputControl control, string path, int indexInPath = 0) where TControl : InputControl
	{
		return null;
	}

	public static int TryFindControls<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches) where TControl : InputControl
	{
		return 0;
	}

	public static InputControl TryFindChild(InputControl control, string path, int indexInPath = 0)
	{
		return null;
	}

	public static TControl TryFindChild<TControl>(InputControl control, string path, int indexInPath = 0) where TControl : InputControl
	{
		return null;
	}

	public static bool Matches(string expected, InputControl control)
	{
		return false;
	}

	internal static bool MatchControlComponent(ref ParsedPathComponent expectedControlComponent, ref InputControlLayout.ControlItem controlItem, bool matchAlias = false)
	{
		return false;
	}

	public static bool MatchesPrefix(string expected, InputControl control)
	{
		return false;
	}

	private static bool MatchesRecursive(ref PathParser parser, InputControl currentControl, bool prefixOnly = false)
	{
		return false;
	}

	private static TControl MatchControlsRecursive<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple) where TControl : InputControl
	{
		return null;
	}

	private static TControl MatchByUsageAtDeviceRootRecursive<TControl>(InputDevice device, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple) where TControl : InputControl
	{
		return null;
	}

	private static TControl MatchChildrenRecursive<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple) where TControl : InputControl
	{
		return null;
	}

	private static bool MatchPathComponent(string component, string path, ref int indexInPath, PathComponentType componentType, int startIndexInComponent = 0)
	{
		return false;
	}

	private static bool PathComponentCanYieldMultipleMatches(string path, int indexInPath)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CParse_003Ed__34))]
	public static IEnumerable<ParsedPathComponent> Parse(string path)
	{
		return null;
	}
}
