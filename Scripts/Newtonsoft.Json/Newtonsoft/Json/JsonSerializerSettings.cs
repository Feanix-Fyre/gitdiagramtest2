using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json;

public class JsonSerializerSettings
{
	internal const ReferenceLoopHandling DefaultReferenceLoopHandling = ReferenceLoopHandling.Error;

	internal const MissingMemberHandling DefaultMissingMemberHandling = MissingMemberHandling.Ignore;

	internal const NullValueHandling DefaultNullValueHandling = NullValueHandling.Include;

	internal const DefaultValueHandling DefaultDefaultValueHandling = DefaultValueHandling.Include;

	internal const ObjectCreationHandling DefaultObjectCreationHandling = ObjectCreationHandling.Auto;

	internal const PreserveReferencesHandling DefaultPreserveReferencesHandling = PreserveReferencesHandling.None;

	internal const ConstructorHandling DefaultConstructorHandling = ConstructorHandling.Default;

	internal const TypeNameHandling DefaultTypeNameHandling = TypeNameHandling.None;

	internal const MetadataPropertyHandling DefaultMetadataPropertyHandling = MetadataPropertyHandling.Default;

	internal static readonly StreamingContext DefaultContext;

	internal const Formatting DefaultFormatting = Formatting.None;

	internal const DateFormatHandling DefaultDateFormatHandling = DateFormatHandling.IsoDateFormat;

	internal const DateTimeZoneHandling DefaultDateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind;

	internal const DateParseHandling DefaultDateParseHandling = DateParseHandling.DateTime;

	internal const FloatParseHandling DefaultFloatParseHandling = FloatParseHandling.Double;

	internal const FloatFormatHandling DefaultFloatFormatHandling = FloatFormatHandling.String;

	internal const StringEscapeHandling DefaultStringEscapeHandling = StringEscapeHandling.Default;

	internal const TypeNameAssemblyFormatHandling DefaultTypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple;

	internal static readonly CultureInfo DefaultCulture;

	internal const bool DefaultCheckAdditionalContent = false;

	internal const string DefaultDateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

	internal const int DefaultMaxDepth = 64;

	internal Formatting? _formatting;

	internal DateFormatHandling? _dateFormatHandling;

	internal DateTimeZoneHandling? _dateTimeZoneHandling;

	internal DateParseHandling? _dateParseHandling;

	internal FloatFormatHandling? _floatFormatHandling;

	internal FloatParseHandling? _floatParseHandling;

	internal StringEscapeHandling? _stringEscapeHandling;

	internal CultureInfo? _culture;

	internal bool? _checkAdditionalContent;

	internal int? _maxDepth;

	internal bool _maxDepthSet;

	internal string? _dateFormatString;

	internal bool _dateFormatStringSet;

	internal TypeNameAssemblyFormatHandling? _typeNameAssemblyFormatHandling;

	internal DefaultValueHandling? _defaultValueHandling;

	internal PreserveReferencesHandling? _preserveReferencesHandling;

	internal NullValueHandling? _nullValueHandling;

	internal ObjectCreationHandling? _objectCreationHandling;

	internal MissingMemberHandling? _missingMemberHandling;

	internal ReferenceLoopHandling? _referenceLoopHandling;

	internal StreamingContext? _context;

	internal ConstructorHandling? _constructorHandling;

	internal TypeNameHandling? _typeNameHandling;

	internal MetadataPropertyHandling? _metadataPropertyHandling;

	public ReferenceLoopHandling ReferenceLoopHandling
	{
		get
		{
			return default(ReferenceLoopHandling);
		}
		set
		{
		}
	}

	public MissingMemberHandling MissingMemberHandling
	{
		get
		{
			return default(MissingMemberHandling);
		}
		set
		{
		}
	}

	public ObjectCreationHandling ObjectCreationHandling
	{
		get
		{
			return default(ObjectCreationHandling);
		}
		set
		{
		}
	}

	public NullValueHandling NullValueHandling
	{
		get
		{
			return default(NullValueHandling);
		}
		set
		{
		}
	}

	public DefaultValueHandling DefaultValueHandling
	{
		get
		{
			return default(DefaultValueHandling);
		}
		set
		{
		}
	}

	public IList<JsonConverter> Converters { get; set; }

	public PreserveReferencesHandling PreserveReferencesHandling
	{
		get
		{
			return default(PreserveReferencesHandling);
		}
		set
		{
		}
	}

	public TypeNameHandling TypeNameHandling
	{
		get
		{
			return default(TypeNameHandling);
		}
		set
		{
		}
	}

	public MetadataPropertyHandling MetadataPropertyHandling
	{
		get
		{
			return default(MetadataPropertyHandling);
		}
		set
		{
		}
	}

	[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
	public FormatterAssemblyStyle TypeNameAssemblyFormat
	{
		get
		{
			return default(FormatterAssemblyStyle);
		}
		set
		{
		}
	}

	public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
	{
		get
		{
			return default(TypeNameAssemblyFormatHandling);
		}
		set
		{
		}
	}

	public ConstructorHandling ConstructorHandling
	{
		get
		{
			return default(ConstructorHandling);
		}
		set
		{
		}
	}

	public IContractResolver? ContractResolver { get; set; }

	public IEqualityComparer? EqualityComparer { get; set; }

	[Obsolete("ReferenceResolver property is obsolete. Use the ReferenceResolverProvider property to set the IReferenceResolver: settings.ReferenceResolverProvider = () => resolver")]
	public IReferenceResolver? ReferenceResolver
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Func<IReferenceResolver?>? ReferenceResolverProvider { get; set; }

	public ITraceWriter? TraceWriter { get; set; }

	[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
	public SerializationBinder? Binder
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ISerializationBinder? SerializationBinder { get; set; }

	public EventHandler<ErrorEventArgs>? Error { get; set; }

	public StreamingContext Context
	{
		get
		{
			return default(StreamingContext);
		}
		set
		{
		}
	}

	public string DateFormatString
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int? MaxDepth
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Formatting Formatting
	{
		get
		{
			return default(Formatting);
		}
		set
		{
		}
	}

	public DateFormatHandling DateFormatHandling
	{
		get
		{
			return default(DateFormatHandling);
		}
		set
		{
		}
	}

	public DateTimeZoneHandling DateTimeZoneHandling
	{
		get
		{
			return default(DateTimeZoneHandling);
		}
		set
		{
		}
	}

	public DateParseHandling DateParseHandling
	{
		get
		{
			return default(DateParseHandling);
		}
		set
		{
		}
	}

	public FloatFormatHandling FloatFormatHandling
	{
		get
		{
			return default(FloatFormatHandling);
		}
		set
		{
		}
	}

	public FloatParseHandling FloatParseHandling
	{
		get
		{
			return default(FloatParseHandling);
		}
		set
		{
		}
	}

	public StringEscapeHandling StringEscapeHandling
	{
		get
		{
			return default(StringEscapeHandling);
		}
		set
		{
		}
	}

	public CultureInfo Culture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool CheckAdditionalContent
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	static JsonSerializerSettings()
	{
	}

	[DebuggerStepThrough]
	public JsonSerializerSettings()
	{
	}

	public JsonSerializerSettings(JsonSerializerSettings original)
	{
	}
}
