namespace Mono.Globalization.Unicode;

internal class NormalizationTableUtil
{
	public static readonly CodePointIndexer Prop;

	public static readonly CodePointIndexer Map;

	public static readonly CodePointIndexer Combining;

	public static readonly CodePointIndexer Composite;

	public static readonly CodePointIndexer Helper;

	static NormalizationTableUtil()
	{
	}

	public static int PropIdx(int cp)
	{
		return 0;
	}

	public static int MapIdx(int cp)
	{
		return 0;
	}
}
