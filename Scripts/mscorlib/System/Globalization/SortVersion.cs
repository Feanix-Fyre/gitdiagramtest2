namespace System.Globalization;

/// <summary>Provides information about the version of Unicode used to compare and order strings.</summary>
[Serializable]
public sealed class SortVersion
{
	private int m_NlsVersion;

	private Guid m_SortId;
}
