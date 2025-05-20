using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.InputSystem.Utilities;

internal static class StringHelpers
{
	[CompilerGenerated]
	private sealed class _003CSplit_003Ed__9 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string str;

		public string _003C_003E3__str;

		private Func<char, bool> predicate;

		public Func<char, bool> _003C_003E3__predicate;

		private int _003Clength_003E5__2;

		private int _003Cposition_003E5__3;

		string IEnumerator<string>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
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
		public _003CSplit_003Ed__9(int _003C_003E1__state)
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
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CTokenize_003Ed__8 : IEnumerable<Substring>, IEnumerable, IEnumerator<Substring>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private Substring _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string str;

		public string _003C_003E3__str;

		private int _003Clength_003E5__2;

		private int _003CendPos_003E5__3;

		Substring IEnumerator<Substring>.Current
		{
			[DebuggerHidden]
			get
			{
				return default(Substring);
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
		public _003CTokenize_003Ed__8(int _003C_003E1__state)
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
		IEnumerator<Substring> IEnumerable<Substring>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public static string Escape(this string str, string chars = "\n\t\r\\\"", string replacements = "ntr\\\"")
	{
		return null;
	}

	public static string Unescape(this string str, string chars = "ntr\\\"", string replacements = "\n\t\r\\\"")
	{
		return null;
	}

	public static bool Contains(this string str, char ch)
	{
		return false;
	}

	public static bool Contains(this string str, string text, StringComparison comparison)
	{
		return false;
	}

	public static string GetPlural(this string str)
	{
		return null;
	}

	public static string NicifyMemorySize(long numBytes)
	{
		return null;
	}

	public static bool FromNicifiedMemorySize(string text, out long result, long defaultMultiplier = 1L)
	{
		result = default(long);
		return false;
	}

	public static int CountOccurrences(this string str, char ch)
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CTokenize_003Ed__8))]
	public static IEnumerable<Substring> Tokenize(this string str)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSplit_003Ed__9))]
	public static IEnumerable<string> Split(this string str, Func<char, bool> predicate)
	{
		return null;
	}

	public static string Join<TValue>(string separator, params TValue[] values)
	{
		return null;
	}

	public static string Join<TValue>(IEnumerable<TValue> values, string separator)
	{
		return null;
	}

	public static string MakeUniqueName<TExisting>(string baseName, IEnumerable<TExisting> existingSet, Func<TExisting, string> getNameFunc)
	{
		return null;
	}

	public static bool CharacterSeparatedListsHaveAtLeastOneCommonElement(string firstList, string secondList, char separator)
	{
		return false;
	}

	public static int ParseInt(string str, int pos)
	{
		return 0;
	}

	public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters)
	{
		return false;
	}

	public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters, ref uint offset)
	{
		return false;
	}

	public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize)
	{
		return null;
	}

	public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize, ref uint offset)
	{
		return null;
	}

	public static bool IsPrintable(this char ch)
	{
		return false;
	}

	public static string WithAllWhitespaceStripped(this string str)
	{
		return null;
	}

	public static bool InvariantEqualsIgnoreCase(this string left, string right)
	{
		return false;
	}

	public static string ExpandTemplateString(string template, Func<string, string> mapFunc)
	{
		return null;
	}
}
