using System;
using System.Reflection;
using System.Text;

namespace Unity.Burst;

public sealed class BurstCompilerOptions
{
	private const string DisableCompilationArg = "--burst-disable-compilation";

	private const string ForceSynchronousCompilationArg = "--burst-force-sync-compilation";

	internal const string DefaultLibraryName = "lib_burst_generated";

	internal const string BurstInitializeName = "burst.initialize";

	internal const string BurstInitializeExternalsName = "burst.initialize.externals";

	internal const string BurstInitializeStaticsName = "burst.initialize.statics";

	internal const string OptionBurstcSwitch = "+burstc";

	internal const string OptionGroup = "group";

	internal const string OptionPlatform = "platform=";

	internal const string OptionBackend = "backend=";

	internal const string OptionGlobalSafetyChecksSetting = "global-safety-checks-setting=";

	internal const string OptionDisableSafetyChecks = "disable-safety-checks";

	internal const string OptionDisableOpt = "disable-opt";

	internal const string OptionFastMath = "fastmath";

	internal const string OptionTarget = "target=";

	internal const string OptionOptLevel = "opt-level=";

	internal const string OptionLogTimings = "log-timings";

	internal const string OptionOptForSize = "opt-for-size";

	internal const string OptionFloatPrecision = "float-precision=";

	internal const string OptionFloatMode = "float-mode=";

	internal const string OptionBranchProtection = "branch-protection=";

	internal const string OptionDisableWarnings = "disable-warnings=";

	internal const string OptionAssemblyDefines = "assembly-defines=";

	internal const string OptionDump = "dump=";

	internal const string OptionFormat = "format=";

	internal const string OptionDebugTrap = "debugtrap";

	internal const string OptionDisableVectors = "disable-vectors";

	internal const string OptionDebug = "debug=";

	internal const string OptionDebugMode = "debugMode";

	internal const string OptionStaticLinkage = "generate-static-linkage-methods";

	internal const string OptionJobMarshalling = "generate-job-marshalling-methods";

	internal const string OptionTempDirectory = "temp-folder=";

	internal const string OptionEnableDirectExternalLinking = "enable-direct-external-linking";

	internal const string OptionLinkerOptions = "linker-options=";

	internal const string OptionEnableAutoLayoutFallbackCheck = "enable-autolayout-fallback-check";

	internal const string OptionGenerateLinkXml = "generate-link-xml=";

	internal const string OptionMetaDataGeneration = "meta-data-generation=";

	internal const string OptionDisableStringInterpolationInExceptionMessages = "disable-string-interpolation-in-exception-messages";

	internal const string OptionPlatformConfiguration = "platform-configuration=";

	internal const string OptionCacheDirectory = "cache-directory=";

	internal const string OptionJitDisableFunctionCaching = "disable-function-caching";

	internal const string OptionJitDisableAssemblyCaching = "disable-assembly-caching";

	internal const string OptionJitEnableAssemblyCachingLogs = "enable-assembly-caching-logs";

	internal const string OptionJitEnableSynchronousCompilation = "enable-synchronous-compilation";

	internal const string OptionJitCompilationPriority = "compilation-priority=";

	internal const string OptionJitIsForFunctionPointer = "is-for-function-pointer";

	internal const string OptionJitManagedFunctionPointer = "managed-function-pointer=";

	internal const string OptionJitManagedDelegateHandle = "managed-delegate-handle=";

	internal const string OptionEnableInterpreter = "enable-interpreter";

	internal const string OptionAotAssemblyFolder = "assembly-folder=";

	internal const string OptionRootAssembly = "root-assembly=";

	internal const string OptionIncludeRootAssemblyReferences = "include-root-assembly-references=";

	internal const string OptionAotMethod = "method=";

	internal const string OptionAotType = "type=";

	internal const string OptionAotAssembly = "assembly=";

	internal const string OptionAotOutputPath = "output=";

	internal const string OptionAotKeepIntermediateFiles = "keep-intermediate-files";

	internal const string OptionAotNoLink = "nolink";

	internal const string OptionAotOnlyStaticMethods = "only-static-methods";

	internal const string OptionMethodPrefix = "method-prefix=";

	internal const string OptionAotNoNativeToolchain = "no-native-toolchain";

	internal const string OptionAotEmitLlvmObjects = "emit-llvm-objects";

	internal const string OptionAotKeyFolder = "key-folder=";

	internal const string OptionAotDecodeFolder = "decode-folder=";

	internal const string OptionVerbose = "verbose";

	internal const string OptionValidateExternalToolChain = "validate-external-tool-chain";

	internal const string OptionCompilerThreads = "threads=";

	internal const string OptionChunkSize = "chunk-size=";

	internal const string OptionPrintLogOnMissingPInvokeCallbackAttribute = "print-monopinvokecallbackmissing-message";

	internal const string OptionOutputMode = "output-mode=";

	internal const string OptionAlwaysCreateOutput = "always-create-output=";

	internal const string OptionAotPdbSearchPaths = "pdb-search-paths=";

	internal const string OptionSafetyChecks = "safety-checks";

	internal const string OptionLibraryOutputMode = "library-output-mode=";

	internal const string OptionCompilationId = "compilation-id=";

	internal const string OptionTargetFramework = "target-framework=";

	internal const string OptionDiscardAssemblies = "discard-assemblies=";

	internal const string OptionSaveExtraContext = "save-extra-context";

	internal const string CompilerCommandShutdown = "$shutdown";

	internal const string CompilerCommandCancel = "$cancel";

	internal const string CompilerCommandEnableCompiler = "$enable_compiler";

	internal const string CompilerCommandDisableCompiler = "$disable_compiler";

	internal const string CompilerCommandSetDefaultOptions = "$set_default_options";

	internal const string CompilerCommandTriggerSetupRecompilation = "$trigger_setup_recompilation";

	internal const string CompilerCommandIsCurrentCompilationDone = "$is_current_compilation_done";

	internal const string CompilerCommandTriggerRecompilation = "$trigger_recompilation";

	internal const string CompilerCommandInitialize = "$initialize";

	internal const string CompilerCommandDomainReload = "$domain_reload";

	internal const string CompilerCommandVersionNotification = "$version";

	internal const string CompilerCommandGetTargetCpuFromHost = "$get_target_cpu_from_host";

	internal const string CompilerCommandSetProfileCallbacks = "$set_profile_callbacks";

	internal const string CompilerCommandUnloadBurstNatives = "$unload_burst_natives";

	internal const string CompilerCommandIsNativeApiAvailable = "$is_native_api_available";

	internal const string CompilerCommandILPPCompilation = "$ilpp_compilation";

	internal const string CompilerCommandIsArmTestEnv = "$is_arm_test_env";

	internal const string CompilerCommandNotifyAssemblyCompilationNotRequired = "$notify_assembly_compilation_not_required";

	internal const string CompilerCommandNotifyAssemblyCompilationFinished = "$notify_assembly_compilation_finished";

	internal const string CompilerCommandNotifyCompilationStarted = "$notify_compilation_started";

	internal const string CompilerCommandNotifyCompilationFinished = "$notify_compilation_finished";

	internal const string CompilerCommandAotCompilation = "$aot_compilation";

	internal const string CompilerCommandRequestInitialiseDebuggerCommmand = "$request_debug_command";

	internal const string CompilerCommandInitialiseDebuggerCommmand = "$load_debugger_interface";

	internal const string CompilerCommandRequestSetProtocolVersionEditor = "$request_set_protocol_version_editor";

	internal const string CompilerCommandSetProtocolVersionBurst = "$set_protocol_version_burst";

	internal static readonly bool ForceDisableBurstCompilation;

	private static readonly bool ForceBurstCompilationSynchronously;

	internal static readonly bool IsSecondaryUnityProcess;

	private bool _enableBurstCompilation;

	private bool _enableBurstCompileSynchronously;

	private bool _enableBurstSafetyChecks;

	private bool _enableBurstTimings;

	private bool _enableBurstDebug;

	private bool _forceEnableBurstSafetyChecks;

	private bool IsGlobal { get; }

	public bool IsEnabled => false;

	public bool EnableBurstCompilation
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool EnableBurstCompileSynchronously
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool EnableBurstSafetyChecks
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ForceEnableBurstSafetyChecks
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool EnableBurstDebug
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Obsolete("This property is no longer used and will be removed in a future major release")]
	public bool DisableOptimizations
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Obsolete("This property is no longer used and will be removed in a future major release. Use the [BurstCompile(FloatMode = FloatMode.Fast)] on the method directly to enable this feature")]
	public bool EnableFastMath
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool EnableBurstTimings
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool RequiresSynchronousCompilation => false;

	internal Action OptionsChanged { get; set; }

	internal static string SerialiseCompilationOptionsSafe(string[] roots, string[] folders, string options)
	{
		return null;
	}

	internal static (string[], string[], string) DeserialiseCompilationOptionsSafe(string from)
	{
		return default((string[], string[], string));
	}

	private BurstCompilerOptions()
	{
	}

	internal BurstCompilerOptions(bool isGlobal)
	{
	}

	internal BurstCompilerOptions Clone()
	{
		return null;
	}

	private static bool TryGetAttribute(MemberInfo member, out BurstCompileAttribute attribute)
	{
		attribute = null;
		return false;
	}

	private static bool TryGetAttribute(Assembly assembly, out BurstCompileAttribute attribute)
	{
		attribute = null;
		return false;
	}

	private static BurstCompileAttribute GetBurstCompileAttribute(MemberInfo memberInfo)
	{
		return null;
	}

	internal static bool HasBurstCompileAttribute(MemberInfo member)
	{
		return false;
	}

	internal static void MergeAttributes(ref BurstCompileAttribute memberAttribute, in BurstCompileAttribute assemblyAttribute)
	{
	}

	internal bool TryGetOptions(MemberInfo member, out string flagsOut, bool isForILPostProcessing = false, bool isForCompilerClient = false)
	{
		flagsOut = null;
		return false;
	}

	internal string GetOptions(BurstCompileAttribute attr = null, bool isForILPostProcessing = false, bool isForCompilerClient = false)
	{
		return null;
	}

	private static void AddOption(StringBuilder builder, string option)
	{
	}

	internal static string GetOption(string optionName, object value = null)
	{
		return null;
	}

	private void OnOptionsChanged()
	{
	}

	private void MaybeTriggerRecompilation()
	{
	}

	static BurstCompilerOptions()
	{
	}

	private static bool CheckIsSecondaryUnityProcess()
	{
		return false;
	}
}
