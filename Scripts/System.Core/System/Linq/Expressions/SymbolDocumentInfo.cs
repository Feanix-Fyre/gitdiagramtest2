namespace System.Linq.Expressions;

/// <summary>Stores information necessary to emit debugging symbol information for a source file, in particular the file name and unique language identifier.</summary>
public class SymbolDocumentInfo
{
	internal static readonly Guid DocumentType_Text;

	/// <summary>The source file name.</summary>
	/// <returns>The string representing the source file name.</returns>
	public string FileName { get; }
}
