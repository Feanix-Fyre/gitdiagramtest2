using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Windows.Speech;

public sealed class DictationRecognizer
{
	public delegate void DictationHypothesisDelegate(string text);

	public delegate void DictationResultDelegate(string text, ConfidenceLevel confidence);

	public delegate void DictationCompletedDelegate(DictationCompletionCause cause);

	public delegate void DictationErrorHandler(string error, int hresult);

	private IntPtr m_Recognizer;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DictationHypothesisDelegate DictationHypothesis;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DictationResultDelegate DictationResult;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DictationCompletedDelegate DictationComplete;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DictationErrorHandler DictationError;

	[RequiredByNativeCode]
	private void DictationRecognizer_InvokeHypothesisGeneratedEvent(string keyword)
	{
	}

	[RequiredByNativeCode]
	private void DictationRecognizer_InvokeResultGeneratedEvent(string keyword, ConfidenceLevel minimumConfidence)
	{
	}

	[RequiredByNativeCode]
	private void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause)
	{
	}

	[RequiredByNativeCode]
	private void DictationRecognizer_InvokeErrorEvent(string error, int hresult)
	{
	}
}
