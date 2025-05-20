namespace System.Text;

internal class Normalization
{
	private unsafe static byte* props;

	private unsafe static int* mappedChars;

	private unsafe static short* charMapIndex;

	private unsafe static short* helperIndex;

	private unsafe static ushort* mapIdxToComposite;

	private unsafe static byte* combiningClass;

	private static object forLock;

	public static readonly bool isReady;

	private static uint PropValue(int cp)
	{
		return 0u;
	}

	private static int CharMapIdx(int cp)
	{
		return 0;
	}

	private static byte GetCombiningClass(int c)
	{
		return 0;
	}

	private static int GetPrimaryCompositeFromMapIndex(int src)
	{
		return 0;
	}

	private static int GetPrimaryCompositeHelperIndex(int cp)
	{
		return 0;
	}

	private static string Compose(string source, int checkType)
	{
		return null;
	}

	private static StringBuilder Combine(string source, int start, int checkType)
	{
		return null;
	}

	private static void Combine(StringBuilder sb, int i, int checkType)
	{
	}

	private static int CombineHangul(StringBuilder sb, string s, int current)
	{
		return 0;
	}

	private static int Fetch(StringBuilder sb, string s, int i)
	{
		return 0;
	}

	private static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current)
	{
		return 0;
	}

	private static int TryCompose(int i, int starter, int candidate)
	{
		return 0;
	}

	private static string Decompose(string source, int checkType)
	{
		return null;
	}

	private static void Decompose(string source, ref StringBuilder sb, int checkType)
	{
	}

	private static void ReorderCanonical(string src, ref StringBuilder sb, int start)
	{
	}

	private static void DecomposeChar(ref StringBuilder sb, ref int[] buf, string s, int i, int checkType, ref int start)
	{
	}

	public static NormalizationCheck QuickCheck(char c, int type)
	{
		return default(NormalizationCheck);
	}

	private static int GetCanonicalHangul(int s, int[] buf, int bufIdx)
	{
		return 0;
	}

	private static int GetCanonical(int c, int[] buf, int bufIdx, int checkType)
	{
		return 0;
	}

	public static string Normalize(string source, NormalizationForm normalizationForm)
	{
		return null;
	}

	public static string Normalize(string source, int type)
	{
		return null;
	}

	private static void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass)
	{
		props = default(IntPtr);
		mappedChars = default(IntPtr);
		charMapIndex = default(IntPtr);
		helperIndex = default(IntPtr);
		mapIdxToComposite = default(IntPtr);
		combiningClass = default(IntPtr);
	}

	static Normalization()
	{
	}
}
