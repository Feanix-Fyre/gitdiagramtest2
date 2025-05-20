using System.Collections.Generic;
using System.Runtime.InteropServices;
using Mono.Interop;

namespace System.Globalization;

/// <summary>Provides information about a specific culture (called a locale for unmanaged code development). The information includes the names for the culture, the writing system, the calendar used, the sort order of strings, and formatting for dates and numbers.</summary>
[Serializable]
[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public class CultureInfo : ICloneable, IFormatProvider
{
	private struct Data
	{
		public int ansi;

		public int ebcdic;

		public int mac;

		public int oem;

		public bool right_to_left;

		public byte list_sep;
	}

	private delegate void OnCultureInfoChangedDelegate(string language);

	private static CultureInfo invariant_culture_info;

	private static object shared_table_lock;

	private static CultureInfo default_current_culture;

	private bool m_isReadOnly;

	private int cultureID;

	[NonSerialized]
	private int parent_lcid;

	[NonSerialized]
	private int datetime_index;

	[NonSerialized]
	private int number_index;

	[NonSerialized]
	private int default_calendar_type;

	private bool m_useUserOverride;

	internal NumberFormatInfo numInfo;

	internal DateTimeFormatInfo dateTimeInfo;

	private TextInfo textInfo;

	internal string m_name;

	[NonSerialized]
	private string englishname;

	[NonSerialized]
	private string nativename;

	[NonSerialized]
	private string iso3lang;

	[NonSerialized]
	private string iso2lang;

	[NonSerialized]
	private string win3lang;

	[NonSerialized]
	private string territory;

	[NonSerialized]
	private string[] native_calendar_names;

	private CompareInfo compareInfo;

	[NonSerialized]
	private unsafe readonly void* textinfo_data;

	private int m_dataItem;

	private Calendar calendar;

	[NonSerialized]
	private CultureInfo parent_culture;

	[NonSerialized]
	private bool constructed;

	[NonSerialized]
	internal byte[] cached_serialized_form;

	[NonSerialized]
	internal CultureData m_cultureData;

	[NonSerialized]
	internal bool m_isInherited;

	internal const int InvariantCultureId = 127;

	private const int CalendarTypeBits = 8;

	internal const int LOCALE_INVARIANT = 127;

	private const string MSG_READONLY = "This instance is read only";

	private static CultureInfo s_DefaultThreadCurrentUICulture;

	private static CultureInfo s_DefaultThreadCurrentCulture;

	private static Dictionary<int, CultureInfo> shared_by_number;

	private static Dictionary<string, CultureInfo> shared_by_name;

	private static CultureInfo s_UserPreferredCultureInfoInAppX;

	internal static readonly bool IsTaiwanSku;

	internal CultureData _cultureData => null;

	internal bool _isInherited => false;

	/// <summary>Gets the <see cref="T:System.Globalization.CultureInfo" /> object that is culture-independent (invariant).</summary>
	/// <returns>The object that is culture-independent (invariant).</returns>
	public static CultureInfo InvariantCulture => null;

	/// <summary>Gets or sets the <see cref="T:System.Globalization.CultureInfo" /> object that represents the culture used by the current thread.</summary>
	/// <returns>An object that represents the culture used by the current thread.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is set to <see langword="null" />.</exception>
	public static CultureInfo CurrentCulture => null;

	/// <summary>Gets or sets the <see cref="T:System.Globalization.CultureInfo" /> object that represents the current user interface culture used by the Resource Manager to look up culture-specific resources at run time.</summary>
	/// <returns>The culture used by the Resource Manager to look up culture-specific resources at run time.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is set to <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The property is set to a culture name that cannot be used to locate a resource file. Resource filenames can include only letters, numbers, hyphens, or underscores.</exception>
	public static CultureInfo CurrentUICulture => null;

	internal string Territory => null;

	internal string _name => null;

	/// <summary>Gets the culture identifier for the current <see cref="T:System.Globalization.CultureInfo" />.</summary>
	/// <returns>The culture identifier for the current <see cref="T:System.Globalization.CultureInfo" />.</returns>
	public virtual int LCID => 0;

	/// <summary>Gets the culture name in the format languagecode2-country/regioncode2.</summary>
	/// <returns>The culture name in the format languagecode2-country/regioncode2. languagecode2 is a lowercase two-letter code derived from ISO 639-1. country/regioncode2 is derived from ISO 3166 and usually consists of two uppercase letters, or a BCP-47 language tag.</returns>
	public virtual string Name => null;

	/// <summary>Gets the default calendar used by the culture.</summary>
	/// <returns>A <see cref="T:System.Globalization.Calendar" /> that represents the default calendar used by the culture.</returns>
	public virtual Calendar Calendar => null;

	/// <summary>Gets the <see cref="T:System.Globalization.CultureInfo" /> that represents the parent culture of the current <see cref="T:System.Globalization.CultureInfo" />.</summary>
	/// <returns>The <see cref="T:System.Globalization.CultureInfo" /> that represents the parent culture of the current <see cref="T:System.Globalization.CultureInfo" />.</returns>
	public virtual CultureInfo Parent => null;

	/// <summary>Gets the <see cref="T:System.Globalization.TextInfo" /> that defines the writing system associated with the culture.</summary>
	/// <returns>The <see cref="T:System.Globalization.TextInfo" /> that defines the writing system associated with the culture.</returns>
	public virtual TextInfo TextInfo => null;

	/// <summary>Gets the ISO 639-1 two-letter code for the language of the current <see cref="T:System.Globalization.CultureInfo" />.</summary>
	/// <returns>The ISO 639-1 two-letter code for the language of the current <see cref="T:System.Globalization.CultureInfo" />.</returns>
	public virtual string TwoLetterISOLanguageName => null;

	/// <summary>Gets the <see cref="T:System.Globalization.CompareInfo" /> that defines how to compare strings for the culture.</summary>
	/// <returns>The <see cref="T:System.Globalization.CompareInfo" /> that defines how to compare strings for the culture.</returns>
	public virtual CompareInfo CompareInfo => null;

	/// <summary>Gets a value indicating whether the current <see cref="T:System.Globalization.CultureInfo" /> represents a neutral culture.</summary>
	/// <returns>
	///   <see langword="true" /> if the current <see cref="T:System.Globalization.CultureInfo" /> represents a neutral culture; otherwise, <see langword="false" />.</returns>
	public virtual bool IsNeutralCulture => false;

	/// <summary>Gets or sets a <see cref="T:System.Globalization.NumberFormatInfo" /> that defines the culturally appropriate format of displaying numbers, currency, and percentage.</summary>
	/// <returns>A <see cref="T:System.Globalization.NumberFormatInfo" /> that defines the culturally appropriate format of displaying numbers, currency, and percentage.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is set to null.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Globalization.CultureInfo.NumberFormat" /> property or any of the <see cref="T:System.Globalization.NumberFormatInfo" /> properties is set, and the <see cref="T:System.Globalization.CultureInfo" /> is read-only.</exception>
	public virtual NumberFormatInfo NumberFormat
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a <see cref="T:System.Globalization.DateTimeFormatInfo" /> that defines the culturally appropriate format of displaying dates and times.</summary>
	/// <returns>A <see cref="T:System.Globalization.DateTimeFormatInfo" /> that defines the culturally appropriate format of displaying dates and times.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is set to null.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Globalization.CultureInfo.DateTimeFormat" /> property or any of the <see cref="T:System.Globalization.DateTimeFormatInfo" /> properties is set, and the <see cref="T:System.Globalization.CultureInfo" /> is read-only.</exception>
	public virtual DateTimeFormatInfo DateTimeFormat
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the culture name in the format languagefull [country/regionfull] in English.</summary>
	/// <returns>The culture name in the format languagefull [country/regionfull] in English, where languagefull is the full name of the language and country/regionfull is the full name of the country/region.</returns>
	public virtual string EnglishName => null;

	internal int CalendarType => 0;

	/// <summary>Gets or sets the default culture for threads in the current application domain.</summary>
	/// <returns>The default culture for threads in the current application domain, or <see langword="null" /> if the current system culture is the default thread culture in the application domain.</returns>
	public static CultureInfo DefaultThreadCurrentCulture => null;

	/// <summary>Gets or sets the default UI culture for threads in the current application domain.</summary>
	/// <returns>The default UI culture for threads in the current application domain, or <see langword="null" /> if the current system UI culture is the default thread UI culture in the application domain.</returns>
	/// <exception cref="T:System.ArgumentException">In a set operation, the <see cref="P:System.Globalization.CultureInfo.Name" /> property value is invalid.</exception>
	public static CultureInfo DefaultThreadCurrentUICulture => null;

	internal string SortName => null;

	internal static CultureInfo UserDefaultUICulture => null;

	internal static CultureInfo UserDefaultCulture => null;

	internal bool HasInvariantCultureName => false;

	internal static CultureInfo ConstructCurrentCulture()
	{
		return null;
	}

	internal static CultureInfo ConstructCurrentUICulture()
	{
		return null;
	}

	/// <summary>Creates a copy of the current <see cref="T:System.Globalization.CultureInfo" />.</summary>
	/// <returns>A copy of the current <see cref="T:System.Globalization.CultureInfo" />.</returns>
	public virtual object Clone()
	{
		return null;
	}

	/// <summary>Determines whether the specified object is the same culture as the current <see cref="T:System.Globalization.CultureInfo" />.</summary>
	/// <param name="value">The object to compare with the current <see cref="T:System.Globalization.CultureInfo" />.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is the same culture as the current <see cref="T:System.Globalization.CultureInfo" />; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Gets the list of supported cultures filtered by the specified <see cref="T:System.Globalization.CultureTypes" /> parameter.</summary>
	/// <param name="types">A bitwise combination of the enumeration values that filter the cultures to retrieve.</param>
	/// <returns>An array that contains the cultures specified by the <paramref name="types" /> parameter. The array of cultures is unsorted.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="types" /> specifies an invalid combination of <see cref="T:System.Globalization.CultureTypes" /> values.</exception>
	public static CultureInfo[] GetCultures(CultureTypes types)
	{
		return null;
	}

	private Data GetTextInfoData()
	{
		return default(Data);
	}

	/// <summary>Serves as a hash function for the current <see cref="T:System.Globalization.CultureInfo" />, suitable for hashing algorithms and data structures, such as a hash table.</summary>
	/// <returns>A hash code for the current <see cref="T:System.Globalization.CultureInfo" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Returns a string containing the name of the current <see cref="T:System.Globalization.CultureInfo" /> in the format languagecode2-country/regioncode2.</summary>
	/// <returns>A string containing the name of the current <see cref="T:System.Globalization.CultureInfo" />.</returns>
	public override string ToString()
	{
		return null;
	}

	private void CheckNeutral()
	{
	}

	/// <summary>Gets an object that defines how to format the specified type.</summary>
	/// <param name="formatType">The <see cref="T:System.Type" /> for which to get a formatting object. This method only supports the <see cref="T:System.Globalization.NumberFormatInfo" /> and <see cref="T:System.Globalization.DateTimeFormatInfo" /> types.</param>
	/// <returns>The value of the <see cref="P:System.Globalization.CultureInfo.NumberFormat" /> property, which is a <see cref="T:System.Globalization.NumberFormatInfo" /> containing the default number format information for the current <see cref="T:System.Globalization.CultureInfo" />, if <paramref name="formatType" /> is the <see cref="T:System.Type" /> object for the <see cref="T:System.Globalization.NumberFormatInfo" /> class.  
	///  -or-  
	///  The value of the <see cref="P:System.Globalization.CultureInfo.DateTimeFormat" /> property, which is a <see cref="T:System.Globalization.DateTimeFormatInfo" /> containing the default date and time format information for the current <see cref="T:System.Globalization.CultureInfo" />, if <paramref name="formatType" /> is the <see cref="T:System.Type" /> object for the <see cref="T:System.Globalization.DateTimeFormatInfo" /> class.  
	///  -or-  
	///  null, if <paramref name="formatType" /> is any other object.</returns>
	public virtual object GetFormat(Type formatType)
	{
		return null;
	}

	private void Construct()
	{
	}

	private bool construct_internal_locale_from_lcid(int lcid)
	{
		return false;
	}

	private bool construct_internal_locale_from_name(string name)
	{
		return false;
	}

	private static string get_current_locale_name()
	{
		return null;
	}

	private static CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed)
	{
		return null;
	}

	private void ConstructInvariant(bool read_only)
	{
	}

	private TextInfo CreateTextInfo(bool readOnly)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureInfo" /> class based on the culture specified by the culture identifier.</summary>
	/// <param name="culture">A predefined <see cref="T:System.Globalization.CultureInfo" /> identifier, <see cref="P:System.Globalization.CultureInfo.LCID" /> property of an existing <see cref="T:System.Globalization.CultureInfo" /> object, or Windows-only culture identifier.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="culture" /> is less than zero.</exception>
	/// <exception cref="T:System.Globalization.CultureNotFoundException">
	///   <paramref name="culture" /> is not a valid culture identifier. See the Notes to Callers section for more information.</exception>
	public CultureInfo(int culture)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureInfo" /> class based on the culture specified by the culture identifier and on the Boolean that specifies whether to use the user-selected culture settings from the system.</summary>
	/// <param name="culture">A predefined <see cref="T:System.Globalization.CultureInfo" /> identifier, <see cref="P:System.Globalization.CultureInfo.LCID" /> property of an existing <see cref="T:System.Globalization.CultureInfo" /> object, or Windows-only culture identifier.</param>
	/// <param name="useUserOverride">A Boolean that denotes whether to use the user-selected culture settings (<see langword="true" />) or the default culture settings (<see langword="false" />).</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="culture" /> is less than zero.</exception>
	/// <exception cref="T:System.Globalization.CultureNotFoundException">
	///   <paramref name="culture" /> is not a valid culture identifier. See the Notes to Callers section for more information.</exception>
	public CultureInfo(int culture, bool useUserOverride)
	{
	}

	private CultureInfo(int culture, bool useUserOverride, bool read_only)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureInfo" /> class based on the culture specified by name.</summary>
	/// <param name="name">A predefined <see cref="T:System.Globalization.CultureInfo" /> name, <see cref="P:System.Globalization.CultureInfo.Name" /> of an existing <see cref="T:System.Globalization.CultureInfo" />, or Windows-only culture name. <paramref name="name" /> is not case-sensitive.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is null.</exception>
	/// <exception cref="T:System.Globalization.CultureNotFoundException">
	///   <paramref name="name" /> is not a valid culture name. For more information, see the Notes to Callers section.</exception>
	public CultureInfo(string name)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureInfo" /> class based on the culture specified by name and on the Boolean that specifies whether to use the user-selected culture settings from the system.</summary>
	/// <param name="name">A predefined <see cref="T:System.Globalization.CultureInfo" /> name, <see cref="P:System.Globalization.CultureInfo.Name" /> of an existing <see cref="T:System.Globalization.CultureInfo" />, or Windows-only culture name. <paramref name="name" /> is not case-sensitive.</param>
	/// <param name="useUserOverride">A Boolean that denotes whether to use the user-selected culture settings (<see langword="true" />) or the default culture settings (<see langword="false" />).</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is null.</exception>
	/// <exception cref="T:System.Globalization.CultureNotFoundException">
	///   <paramref name="name" /> is not a valid culture name. See the Notes to Callers section for more information.</exception>
	public CultureInfo(string name, bool useUserOverride)
	{
	}

	private CultureInfo(string name, bool useUserOverride, bool read_only)
	{
	}

	private CultureInfo()
	{
	}

	private static void insert_into_shared_tables(CultureInfo c)
	{
	}

	/// <summary>Retrieves a cached, read-only instance of a culture by using the specified culture identifier.</summary>
	/// <param name="culture">A locale identifier (LCID).</param>
	/// <returns>A read-only <see cref="T:System.Globalization.CultureInfo" /> object.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="culture" /> is less than zero.</exception>
	/// <exception cref="T:System.Globalization.CultureNotFoundException">
	///   <paramref name="culture" /> specifies a culture that is not supported. See the Notes to Caller section for more information.</exception>
	public static CultureInfo GetCultureInfo(int culture)
	{
		return null;
	}

	/// <summary>Retrieves a cached, read-only instance of a culture using the specified culture name.</summary>
	/// <param name="name">The name of a culture. <paramref name="name" /> is not case-sensitive.</param>
	/// <returns>A read-only <see cref="T:System.Globalization.CultureInfo" /> object.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is null.</exception>
	/// <exception cref="T:System.Globalization.CultureNotFoundException">
	///   <paramref name="name" /> specifies a culture that is not supported. See the Notes to Callers section for more information.</exception>
	public static CultureInfo GetCultureInfo(string name)
	{
		return null;
	}

	internal static CultureInfo CreateCulture(string name, bool reference)
	{
		return null;
	}

	/// <summary>Creates a <see cref="T:System.Globalization.CultureInfo" /> that represents the specific culture that is associated with the specified name.</summary>
	/// <param name="name">A predefined <see cref="T:System.Globalization.CultureInfo" /> name or the name of an existing <see cref="T:System.Globalization.CultureInfo" /> object. <paramref name="name" /> is not case-sensitive.</param>
	/// <returns>A <see cref="T:System.Globalization.CultureInfo" /> object that represents:  
	///  The invariant culture, if <paramref name="name" /> is an empty string ("").  
	///  -or-  
	///  The specific culture associated with <paramref name="name" />, if <paramref name="name" /> is a neutral culture.  
	///  -or-  
	///  The culture specified by <paramref name="name" />, if <paramref name="name" /> is already a specific culture.</returns>
	/// <exception cref="T:System.Globalization.CultureNotFoundException">
	///   <paramref name="name" /> is not a valid culture name.  
	/// -or-  
	/// The culture specified by <paramref name="name" /> does not have a specific culture associated with it.</exception>
	/// <exception cref="T:System.NullReferenceException">
	///   <paramref name="name" /> is null.</exception>
	public static CultureInfo CreateSpecificCulture(string name)
	{
		return null;
	}

	private bool ConstructLocaleFromName(string name)
	{
		return false;
	}

	private static CultureInfo CreateSpecificCultureFromNeutral(string name)
	{
		return null;
	}

	private static Calendar CreateCalendar(int calendarType)
	{
		return null;
	}

	private static Exception CreateNotFoundException(string name)
	{
		return null;
	}

	[PreserveSig]
	private static extern void InitializeUserPreferredCultureInfoInAppX(OnCultureInfoChangedDelegate onCultureInfoChangedInAppX);

	[MonoPInvokeCallback(typeof(OnCultureInfoChangedDelegate))]
	private static void OnCultureInfoChangedInAppX(string language)
	{
	}

	internal static CultureInfo GetCultureInfoForUserPreferredLanguageInAppX()
	{
		return null;
	}

	internal static bool VerifyCultureName(string cultureName, bool throwException)
	{
		return false;
	}
}
