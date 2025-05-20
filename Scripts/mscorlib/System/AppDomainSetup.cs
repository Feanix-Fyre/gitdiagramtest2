using System.Runtime.InteropServices;

namespace System;

/// <summary>Represents assembly binding information that can be added to an instance of <see cref="T:System.AppDomain" />.</summary>
[Serializable]
[StructLayout((LayoutKind)0)]
[ClassInterface(ClassInterfaceType.None)]
[ComVisible(true)]
public sealed class AppDomainSetup
{
	private string application_base;

	private string application_name;

	private string cache_path;

	private string configuration_file;

	private string dynamic_base;

	private string license_file;

	private string private_bin_path;

	private string private_bin_path_probe;

	private string shadow_copy_directories;

	private string shadow_copy_files;

	private bool publisher_policy;

	private bool path_changed;

	private int loader_optimization;

	private bool disallow_binding_redirects;

	private bool disallow_code_downloads;

	private object _activationArguments;

	private object domain_initializer;

	private object application_trust;

	private string[] domain_initializer_args;

	private bool disallow_appbase_probe;

	private byte[] configuration_bytes;

	private byte[] serialized_non_primitives;

	private string manager_assembly;

	private string manager_type;

	private string[] partial_visible_assemblies;

	/// <summary>Initializes a new instance of the <see cref="T:System.AppDomainSetup" /> class.</summary>
	public AppDomainSetup()
	{
	}
}
