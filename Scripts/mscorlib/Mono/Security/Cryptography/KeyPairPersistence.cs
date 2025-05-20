using System.Security.Cryptography;

namespace Mono.Security.Cryptography;

internal class KeyPairPersistence
{
	private static bool _userPathExists;

	private static string _userPath;

	private static bool _machinePathExists;

	private static string _machinePath;

	private CspParameters _params;

	private string _keyvalue;

	private string _filename;

	private string _container;

	private static object lockobj;

	public string Filename => null;

	public string KeyValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private static string UserPath => null;

	private static string MachinePath => null;

	private bool CanChange => false;

	private bool UseDefaultKeyContainer => false;

	private bool UseMachineKeyStore => false;

	private string ContainerName => null;

	public KeyPairPersistence(CspParameters parameters)
	{
	}

	public KeyPairPersistence(CspParameters parameters, string keyPair)
	{
	}

	public bool Load()
	{
		return false;
	}

	public void Save()
	{
	}

	public void Remove()
	{
	}

	internal unsafe static bool _CanSecure(char* root)
	{
		return false;
	}

	internal unsafe static bool _ProtectUser(char* path)
	{
		return false;
	}

	internal unsafe static bool _ProtectMachine(char* path)
	{
		return false;
	}

	internal unsafe static bool _IsUserProtected(char* path)
	{
		return false;
	}

	internal unsafe static bool _IsMachineProtected(char* path)
	{
		return false;
	}

	private static bool CanSecure(string path)
	{
		return false;
	}

	private static bool ProtectUser(string path)
	{
		return false;
	}

	private static bool ProtectMachine(string path)
	{
		return false;
	}

	private static bool IsUserProtected(string path)
	{
		return false;
	}

	private static bool IsMachineProtected(string path)
	{
		return false;
	}

	private CspParameters Copy(CspParameters p)
	{
		return null;
	}

	private void FromXml(string xml)
	{
	}

	private string ToXml()
	{
		return null;
	}
}
