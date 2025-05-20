using System;

namespace UnityEngine.Windows.Speech;

public struct PhraseRecognizedEventArgs
{
	public readonly ConfidenceLevel confidence;

	public readonly SemanticMeaning[] semanticMeanings;

	public readonly string text;

	public readonly DateTime phraseStartTime;

	public readonly TimeSpan phraseDuration;

	internal PhraseRecognizedEventArgs(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, DateTime phraseStartTime, TimeSpan phraseDuration)
	{
		this.confidence = default(ConfidenceLevel);
		this.semanticMeanings = null;
		this.text = null;
		this.phraseStartTime = default(DateTime);
		this.phraseDuration = default(TimeSpan);
	}
}
