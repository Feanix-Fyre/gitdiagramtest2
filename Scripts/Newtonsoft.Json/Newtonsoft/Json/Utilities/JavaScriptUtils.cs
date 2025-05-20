using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Utilities;

internal static class JavaScriptUtils
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CWriteCharAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Task task;

		public TextWriter writer;

		public char c;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CWriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public char[] writeBuffer;

		public int lastWritePosition;

		public JsonTextWriter client;

		public string s;

		public TextWriter writer;

		public CancellationToken cancellationToken;

		public bool[] charEscapeFlags;

		public StringEscapeHandling stringEscapeHandling;

		private bool _003CisEscapedUnicodeText_003E5__2;

		private string _003CescapedValue_003E5__3;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private int _003Ci_003E5__4;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CWriteEscapedJavaScriptStringWithDelimitersAsync_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Task task;

		public string s;

		public TextWriter writer;

		public bool[] charEscapeFlags;

		public StringEscapeHandling stringEscapeHandling;

		public JsonTextWriter client;

		public char[] writeBuffer;

		public CancellationToken cancellationToken;

		public char delimiter;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	internal static readonly bool[] SingleQuoteCharEscapeFlags;

	internal static readonly bool[] DoubleQuoteCharEscapeFlags;

	internal static readonly bool[] HtmlCharEscapeFlags;

	private const int UnicodeTextLength = 6;

	private const string EscapedUnicodeText = "!";

	static JavaScriptUtils()
	{
	}

	public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar)
	{
		return null;
	}

	public static bool ShouldEscapeJavaScriptString(string? s, bool[] charEscapeFlags)
	{
		return false;
	}

	public static void WriteEscapedJavaScriptString(TextWriter writer, string? s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char>? bufferPool, ref char[]? writeBuffer)
	{
	}

	public static string ToEscapedJavaScriptString(string? value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling)
	{
		return null;
	}

	private static int FirstCharToEscape(string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling)
	{
		return 0;
	}

	public static Task WriteEscapedJavaScriptStringAsync(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	private static Task WriteEscapedJavaScriptStringWithDelimitersAsync(TextWriter writer, string s, char delimiter, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CWriteEscapedJavaScriptStringWithDelimitersAsync_003Ed__13))]
	private static Task WriteEscapedJavaScriptStringWithDelimitersAsync(Task task, TextWriter writer, string s, char delimiter, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CWriteCharAsync_003Ed__14))]
	public static Task WriteCharAsync(Task task, TextWriter writer, char c, CancellationToken cancellationToken)
	{
		return null;
	}

	private static Task WriteEscapedJavaScriptStringWithoutDelimitersAsync(TextWriter writer, string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CWriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_003Ed__16))]
	private static Task WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync(TextWriter writer, string s, int lastWritePosition, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken)
	{
		return null;
	}

	public static bool TryGetDateFromConstructorJson(JsonReader reader, out DateTime dateTime, [NotNullWhen(false)] out string? errorMessage)
	{
		dateTime = default(DateTime);
		errorMessage = null;
		return false;
	}

	private static bool TryGetDateConstructorValue(JsonReader reader, out long? integer, [NotNullWhen(false)] out string? errorMessage)
	{
		integer = null;
		errorMessage = null;
		return false;
	}
}
