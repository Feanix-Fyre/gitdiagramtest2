using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.SafeHandles;

internal static class Interop
{
	internal static class Kernel32
	{
		[StructLayout((LayoutKind)0, CharSet = CharSet.Unicode)]
		internal struct WIN32_FIND_DATA
		{
			internal uint dwFileAttributes;

			internal FILE_TIME ftCreationTime;

			internal FILE_TIME ftLastAccessTime;

			internal FILE_TIME ftLastWriteTime;

			internal uint nFileSizeHigh;

			internal uint nFileSizeLow;

			internal uint dwReserved0;

			internal uint dwReserved1;

			private unsafe fixed char _cFileName[260];

			private unsafe fixed char _cAlternateFileName[14];

			internal ReadOnlySpan<char> cFileName => default(ReadOnlySpan<char>);

			internal void SetFileName(string fileName)
			{
			}
		}

		internal struct REG_TZI_FORMAT
		{
			internal int Bias;

			internal int StandardBias;

			internal int DaylightBias;

			internal SYSTEMTIME StandardDate;

			internal SYSTEMTIME DaylightDate;

			internal REG_TZI_FORMAT(in TIME_ZONE_INFORMATION tzi)
			{
				Bias = 0;
				StandardBias = 0;
				DaylightBias = 0;
				StandardDate = default(SYSTEMTIME);
				DaylightDate = default(SYSTEMTIME);
			}
		}

		internal struct SYSTEMTIME
		{
			internal ushort Year;

			internal ushort Month;

			internal ushort DayOfWeek;

			internal ushort Day;

			internal ushort Hour;

			internal ushort Minute;

			internal ushort Second;

			internal ushort Milliseconds;

			internal bool Equals(in SYSTEMTIME other)
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)0, CharSet = CharSet.Unicode)]
		internal struct TIME_DYNAMIC_ZONE_INFORMATION
		{
			internal int Bias;

			internal unsafe fixed char StandardName[32];

			internal SYSTEMTIME StandardDate;

			internal int StandardBias;

			internal unsafe fixed char DaylightName[32];

			internal SYSTEMTIME DaylightDate;

			internal int DaylightBias;

			internal unsafe fixed char TimeZoneKeyName[128];

			internal byte DynamicDaylightTimeDisabled;

			internal string GetTimeZoneKeyName()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, CharSet = CharSet.Unicode)]
		internal struct TIME_ZONE_INFORMATION
		{
			internal int Bias;

			internal unsafe fixed char StandardName[32];

			internal SYSTEMTIME StandardDate;

			internal int StandardBias;

			internal unsafe fixed char DaylightName[32];

			internal SYSTEMTIME DaylightDate;

			internal int DaylightBias;

			internal TIME_ZONE_INFORMATION(in TIME_DYNAMIC_ZONE_INFORMATION dtzi)
			{
				Bias = 0;
				StandardDate = default(SYSTEMTIME);
				StandardBias = 0;
				DaylightDate = default(SYSTEMTIME);
				DaylightBias = 0;
			}

			internal string GetStandardName()
			{
				return null;
			}

			internal string GetDaylightName()
			{
				return null;
			}
		}

		internal struct COPYFILE2_EXTENDED_PARAMETERS
		{
			internal uint dwSize;

			internal uint dwCopyFlags;

			internal IntPtr pfCancel;

			internal IntPtr pProgressRoutine;

			internal IntPtr pvCallbackContext;
		}

		internal enum FILE_INFO_BY_HANDLE_CLASS : uint
		{
			FileBasicInfo = 0u,
			FileStandardInfo = 1u,
			FileNameInfo = 2u,
			FileRenameInfo = 3u,
			FileDispositionInfo = 4u,
			FileAllocationInfo = 5u,
			FileEndOfFileInfo = 6u,
			FileStreamInfo = 7u,
			FileCompressionInfo = 8u,
			FileAttributeTagInfo = 9u,
			FileIdBothDirectoryInfo = 10u,
			FileIdBothDirectoryRestartInfo = 11u,
			FileIoPriorityHintInfo = 12u,
			FileRemoteProtocolInfo = 13u,
			FileFullDirectoryInfo = 14u,
			FileFullDirectoryRestartInfo = 15u
		}

		internal struct FILE_TIME
		{
			internal uint dwLowDateTime;

			internal uint dwHighDateTime;

			internal long ToTicks()
			{
				return 0L;
			}

			internal DateTimeOffset ToDateTimeOffset()
			{
				return default(DateTimeOffset);
			}
		}

		internal enum FINDEX_INFO_LEVELS : uint
		{
			FindExInfoStandard = 0u,
			FindExInfoBasic = 1u,
			FindExInfoMaxInfoLevel = 2u
		}

		internal enum FINDEX_SEARCH_OPS : uint
		{
			FindExSearchNameMatch = 0u,
			FindExSearchLimitToDirectories = 1u,
			FindExSearchLimitToDevices = 2u,
			FindExSearchMaxSearchOp = 3u
		}

		internal enum GET_FILEEX_INFO_LEVELS : uint
		{
			GetFileExInfoStandard = 0u,
			GetFileExMaxInfoLevel = 1u
		}

		internal struct SECURITY_ATTRIBUTES
		{
			internal uint nLength;

			internal IntPtr lpSecurityDescriptor;

			internal BOOL bInheritHandle;
		}

		internal struct FILE_BASIC_INFO
		{
			internal long CreationTime;

			internal long LastAccessTime;

			internal long LastWriteTime;

			internal long ChangeTime;

			internal uint FileAttributes;
		}

		internal struct WIN32_FILE_ATTRIBUTE_DATA
		{
			internal int dwFileAttributes;

			internal FILE_TIME ftCreationTime;

			internal FILE_TIME ftLastAccessTime;

			internal FILE_TIME ftLastWriteTime;

			internal uint nFileSizeHigh;

			internal uint nFileSizeLow;

			internal void PopulateFrom(ref WIN32_FIND_DATA findData)
			{
			}
		}

		private static bool useUWPFallback;

		internal static int CopyFileUWP(string src, string dst, bool failIfExists)
		{
			return 0;
		}

		internal static int CopyFile(string src, string dst, bool failIfExists)
		{
			return 0;
		}

		[PreserveSig]
		internal static extern bool DeleteVolumeMountPointPrivate(string mountPoint);

		internal static bool DeleteVolumeMountPoint(string mountPoint)
		{
			return false;
		}

		[PreserveSig]
		internal static extern bool FreeLibrary(IntPtr hModule);

		[PreserveSig]
		internal static extern SafeLibraryHandle LoadLibraryEx(string libFilename, IntPtr reserved, int flags);

		[PreserveSig]
		internal static extern bool GetFileMUIPath(uint flags, string filePath, [Out] StringBuilder language, ref int languageLength, [Out] StringBuilder fileMuiPath, ref int fileMuiPathLength, ref long enumerator);

		[PreserveSig]
		internal static extern uint GetDynamicTimeZoneInformation(out TIME_DYNAMIC_ZONE_INFORMATION pTimeZoneInformation);

		[PreserveSig]
		internal static extern uint GetTimeZoneInformation(out TIME_ZONE_INFORMATION lpTimeZoneInformation);

		[PreserveSig]
		internal static extern bool CloseHandle(IntPtr handle);

		[PreserveSig]
		internal static extern int CopyFile2(string pwszExistingFileName, string pwszNewFileName, ref COPYFILE2_EXTENDED_PARAMETERS pExtendedParameters);

		[PreserveSig]
		private static extern bool CopyFileExPrivate(string src, string dst, IntPtr progressRoutine, IntPtr progressData, ref int cancel, int flags);

		internal static bool CopyFileEx(string src, string dst, IntPtr progressRoutine, IntPtr progressData, ref int cancel, int flags)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool CreateDirectoryPrivate(string path, ref SECURITY_ATTRIBUTES lpSecurityAttributes);

		internal static bool CreateDirectory(string path, ref SECURITY_ATTRIBUTES lpSecurityAttributes)
		{
			return false;
		}

		[PreserveSig]
		private unsafe static extern IntPtr CreateFilePrivate(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, SECURITY_ATTRIBUTES* securityAttrs, FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile);

		internal static SafeFileHandle CreateFile(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes)
		{
			return null;
		}

		internal static IntPtr CreateFile_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern bool DeleteFilePrivate(string path);

		internal static bool DeleteFile(string path)
		{
			return false;
		}

		[PreserveSig]
		private static extern SafeFindHandle FindFirstFileExPrivate(string lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, ref WIN32_FIND_DATA lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, IntPtr lpSearchFilter, int dwAdditionalFlags);

		internal static SafeFindHandle FindFirstFile(string fileName, ref WIN32_FIND_DATA data)
		{
			return null;
		}

		[PreserveSig]
		internal static extern bool FindNextFile(SafeFindHandle hndFindFile, ref WIN32_FIND_DATA lpFindFileData);

		[PreserveSig]
		private unsafe static extern int FormatMessage(int dwFlags, IntPtr lpSource, uint dwMessageId, int dwLanguageId, char* lpBuffer, int nSize, IntPtr[] arguments);

		internal static string GetMessage(int errorCode)
		{
			return null;
		}

		internal static string GetMessage(IntPtr moduleHandle, int errorCode)
		{
			return null;
		}

		private static bool TryGetErrorMessage(IntPtr moduleHandle, int errorCode, Span<char> buffer, out string errorMsg)
		{
			errorMsg = null;
			return false;
		}

		[PreserveSig]
		private static extern bool GetFileAttributesExPrivate(string name, GET_FILEEX_INFO_LEVELS fileInfoLevel, ref WIN32_FILE_ATTRIBUTE_DATA lpFileInformation);

		internal static bool GetFileAttributesEx(string name, GET_FILEEX_INFO_LEVELS fileInfoLevel, ref WIN32_FILE_ATTRIBUTE_DATA lpFileInformation)
		{
			return false;
		}

		[PreserveSig]
		public static extern bool GetFileInformationByHandleEx(IntPtr hFile, FILE_INFO_BY_HANDLE_CLASS FileInformationClass, IntPtr lpFileInformation, uint dwBufferSize);

		[PreserveSig]
		internal static extern int GetLogicalDrives();

		[PreserveSig]
		private static extern bool MoveFileExPrivate(string src, string dst, uint flags);

		internal static bool MoveFile(string src, string dst)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool RemoveDirectoryPrivate(string path);

		internal static bool RemoveDirectory(string path)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool SetFileAttributesPrivate(string name, int attr);

		internal static bool SetFileAttributes(string name, int attr)
		{
			return false;
		}

		[PreserveSig]
		internal static extern bool SetFileInformationByHandle(SafeFileHandle hFile, FILE_INFO_BY_HANDLE_CLASS FileInformationClass, ref FILE_BASIC_INFO lpFileInformation, uint dwBufferSize);

		internal static bool SetFileTime(SafeFileHandle hFile, long creationTime = -1L, long lastAccessTime = -1L, long lastWriteTime = -1L, long changeTime = -1L, uint fileAttributes = 0u)
		{
			return false;
		}

		[PreserveSig]
		internal static extern bool SetThreadErrorMode(uint dwNewMode, out uint lpOldMode);
	}

	internal class BCrypt
	{
		internal enum NTSTATUS : uint
		{
			STATUS_SUCCESS = 0u,
			STATUS_NOT_FOUND = 3221226021u,
			STATUS_INVALID_PARAMETER = 3221225485u,
			STATUS_NO_MEMORY = 3221225495u
		}

		[PreserveSig]
		internal unsafe static extern NTSTATUS BCryptGenRandom(IntPtr hAlgorithm, byte* pbBuffer, int cbBuffer, int dwFlags);
	}

	internal class User32
	{
		[PreserveSig]
		internal static extern int LoadString(SafeLibraryHandle handle, int id, [Out] StringBuilder buffer, int bufferLength);
	}

	internal enum BOOL
	{
		FALSE = 0,
		TRUE = 1
	}

	internal enum BOOLEAN : byte
	{
		FALSE = 0,
		TRUE = 1
	}

	internal struct LongFileTime
	{
		internal long TicksSince1601;
	}

	internal struct UNICODE_STRING
	{
		internal ushort Length;

		internal ushort MaximumLength;

		internal IntPtr Buffer;
	}

	internal class NtDll
	{
		[StructLayout((LayoutKind)0, CharSet = CharSet.Unicode)]
		public struct FILE_FULL_DIR_INFORMATION
		{
			public uint NextEntryOffset;

			public uint FileIndex;

			public LongFileTime CreationTime;

			public LongFileTime LastAccessTime;

			public LongFileTime LastWriteTime;

			public LongFileTime ChangeTime;

			public long EndOfFile;

			public long AllocationSize;

			public FileAttributes FileAttributes;

			public uint FileNameLength;

			public uint EaSize;

			private char _fileName;

			public ReadOnlySpan<char> FileName => default(ReadOnlySpan<char>);

			public unsafe static FILE_FULL_DIR_INFORMATION* GetNextInfo(FILE_FULL_DIR_INFORMATION* info)
			{
				return null;
			}
		}

		public enum FILE_INFORMATION_CLASS : uint
		{
			FileDirectoryInformation = 1u,
			FileFullDirectoryInformation = 2u,
			FileBothDirectoryInformation = 3u,
			FileBasicInformation = 4u,
			FileStandardInformation = 5u,
			FileInternalInformation = 6u,
			FileEaInformation = 7u,
			FileAccessInformation = 8u,
			FileNameInformation = 9u,
			FileRenameInformation = 10u,
			FileLinkInformation = 11u,
			FileNamesInformation = 12u,
			FileDispositionInformation = 13u,
			FilePositionInformation = 14u,
			FileFullEaInformation = 15u,
			FileModeInformation = 16u,
			FileAlignmentInformation = 17u,
			FileAllInformation = 18u,
			FileAllocationInformation = 19u,
			FileEndOfFileInformation = 20u,
			FileAlternateNameInformation = 21u,
			FileStreamInformation = 22u,
			FilePipeInformation = 23u,
			FilePipeLocalInformation = 24u,
			FilePipeRemoteInformation = 25u,
			FileMailslotQueryInformation = 26u,
			FileMailslotSetInformation = 27u,
			FileCompressionInformation = 28u,
			FileObjectIdInformation = 29u,
			FileCompletionInformation = 30u,
			FileMoveClusterInformation = 31u,
			FileQuotaInformation = 32u,
			FileReparsePointInformation = 33u,
			FileNetworkOpenInformation = 34u,
			FileAttributeTagInformation = 35u,
			FileTrackingInformation = 36u,
			FileIdBothDirectoryInformation = 37u,
			FileIdFullDirectoryInformation = 38u,
			FileValidDataLengthInformation = 39u,
			FileShortNameInformation = 40u,
			FileIoCompletionNotificationInformation = 41u,
			FileIoStatusBlockRangeInformation = 42u,
			FileIoPriorityHintInformation = 43u,
			FileSfioReserveInformation = 44u,
			FileSfioVolumeInformation = 45u,
			FileHardLinkInformation = 46u,
			FileProcessIdsUsingFileInformation = 47u,
			FileNormalizedNameInformation = 48u,
			FileNetworkPhysicalNameInformation = 49u,
			FileIdGlobalTxDirectoryInformation = 50u,
			FileIsRemoteDeviceInformation = 51u,
			FileUnusedInformation = 52u,
			FileNumaNodeInformation = 53u,
			FileStandardLinkInformation = 54u,
			FileRemoteProtocolInformation = 55u,
			FileRenameInformationBypassAccessCheck = 56u,
			FileLinkInformationBypassAccessCheck = 57u,
			FileVolumeNameInformation = 58u,
			FileIdInformation = 59u,
			FileIdExtdDirectoryInformation = 60u,
			FileReplaceCompletionInformation = 61u,
			FileHardLinkFullIdInformation = 62u,
			FileIdExtdBothDirectoryInformation = 63u,
			FileDispositionInformationEx = 64u,
			FileRenameInformationEx = 65u,
			FileRenameInformationExBypassAccessCheck = 66u,
			FileDesiredStorageClassInformation = 67u,
			FileStatInformation = 68u
		}

		public struct IO_STATUS_BLOCK
		{
			[StructLayout((LayoutKind)2)]
			public struct IO_STATUS
			{
				[FieldOffset(0)]
				public uint Status;

				[FieldOffset(0)]
				public IntPtr Pointer;
			}

			public IO_STATUS Status;

			public IntPtr Information;
		}

		public struct OBJECT_ATTRIBUTES
		{
			public uint Length;

			public IntPtr RootDirectory;

			public unsafe UNICODE_STRING* ObjectName;

			public ObjectAttributes Attributes;

			public unsafe void* SecurityDescriptor;

			public unsafe void* SecurityQualityOfService;

			public unsafe OBJECT_ATTRIBUTES(UNICODE_STRING* objectName, ObjectAttributes attributes, IntPtr rootDirectory)
			{
				Length = 0u;
				RootDirectory = (IntPtr)0;
				ObjectName = null;
				Attributes = default(ObjectAttributes);
				SecurityDescriptor = null;
				SecurityQualityOfService = null;
			}
		}

		[Flags]
		public enum ObjectAttributes : uint
		{
			OBJ_INHERIT = 2u,
			OBJ_PERMANENT = 0x10u,
			OBJ_EXCLUSIVE = 0x20u,
			OBJ_CASE_INSENSITIVE = 0x40u,
			OBJ_OPENIF = 0x80u,
			OBJ_OPENLINK = 0x100u
		}

		public enum CreateDisposition : uint
		{
			FILE_SUPERSEDE = 0u,
			FILE_OPEN = 1u,
			FILE_CREATE = 2u,
			FILE_OPEN_IF = 3u,
			FILE_OVERWRITE = 4u,
			FILE_OVERWRITE_IF = 5u
		}

		public enum CreateOptions : uint
		{
			FILE_DIRECTORY_FILE = 1u,
			FILE_WRITE_THROUGH = 2u,
			FILE_SEQUENTIAL_ONLY = 4u,
			FILE_NO_INTERMEDIATE_BUFFERING = 8u,
			FILE_SYNCHRONOUS_IO_ALERT = 0x10u,
			FILE_SYNCHRONOUS_IO_NONALERT = 0x20u,
			FILE_NON_DIRECTORY_FILE = 0x40u,
			FILE_CREATE_TREE_CONNECTION = 0x80u,
			FILE_COMPLETE_IF_OPLOCKED = 0x100u,
			FILE_NO_EA_KNOWLEDGE = 0x200u,
			FILE_RANDOM_ACCESS = 0x800u,
			FILE_DELETE_ON_CLOSE = 0x1000u,
			FILE_OPEN_BY_FILE_ID = 0x2000u,
			FILE_OPEN_FOR_BACKUP_INTENT = 0x4000u,
			FILE_NO_COMPRESSION = 0x8000u,
			FILE_OPEN_REQUIRING_OPLOCK = 0x10000u,
			FILE_DISALLOW_EXCLUSIVE = 0x20000u,
			FILE_SESSION_AWARE = 0x40000u,
			FILE_RESERVE_OPFILTER = 0x100000u,
			FILE_OPEN_REPARSE_POINT = 0x200000u,
			FILE_OPEN_NO_RECALL = 0x400000u
		}

		[Flags]
		public enum DesiredAccess : uint
		{
			FILE_READ_DATA = 1u,
			FILE_LIST_DIRECTORY = 1u,
			FILE_WRITE_DATA = 2u,
			FILE_ADD_FILE = 2u,
			FILE_APPEND_DATA = 4u,
			FILE_ADD_SUBDIRECTORY = 4u,
			FILE_CREATE_PIPE_INSTANCE = 4u,
			FILE_READ_EA = 8u,
			FILE_WRITE_EA = 0x10u,
			FILE_EXECUTE = 0x20u,
			FILE_TRAVERSE = 0x20u,
			FILE_DELETE_CHILD = 0x40u,
			FILE_READ_ATTRIBUTES = 0x80u,
			FILE_WRITE_ATTRIBUTES = 0x100u,
			FILE_ALL_ACCESS = 0xF01FFu,
			DELETE = 0x10000u,
			READ_CONTROL = 0x20000u,
			WRITE_DAC = 0x40000u,
			WRITE_OWNER = 0x80000u,
			SYNCHRONIZE = 0x100000u,
			STANDARD_RIGHTS_READ = 0x20000u,
			STANDARD_RIGHTS_WRITE = 0x20000u,
			STANDARD_RIGHTS_EXECUTE = 0x20000u,
			FILE_GENERIC_READ = 0x80000000u,
			FILE_GENERIC_WRITE = 0x40000000u,
			FILE_GENERIC_EXECUTE = 0x20000000u
		}

		[PreserveSig]
		private unsafe static extern int NtCreateFile(out IntPtr FileHandle, DesiredAccess DesiredAccess, ref OBJECT_ATTRIBUTES ObjectAttributes, out IO_STATUS_BLOCK IoStatusBlock, long* AllocationSize, FileAttributes FileAttributes, FileShare ShareAccess, CreateDisposition CreateDisposition, CreateOptions CreateOptions, void* EaBuffer, uint EaLength);

		internal static (int, IntPtr) CreateFile(ReadOnlySpan<char> path, IntPtr rootDirectory, CreateDisposition createDisposition, DesiredAccess desiredAccess = DesiredAccess.SYNCHRONIZE | DesiredAccess.FILE_GENERIC_READ, FileShare shareAccess = FileShare.ReadWrite | FileShare.Delete, FileAttributes fileAttributes = (FileAttributes)0, CreateOptions createOptions = CreateOptions.FILE_SYNCHRONOUS_IO_NONALERT, ObjectAttributes objectAttributes = ObjectAttributes.OBJ_CASE_INSENSITIVE)
		{
			return default((int, IntPtr));
		}

		[PreserveSig]
		public unsafe static extern int NtQueryDirectoryFile(IntPtr FileHandle, IntPtr Event, IntPtr ApcRoutine, IntPtr ApcContext, out IO_STATUS_BLOCK IoStatusBlock, IntPtr FileInformation, uint Length, FILE_INFORMATION_CLASS FileInformationClass, BOOLEAN ReturnSingleEntry, UNICODE_STRING* FileName, BOOLEAN RestartScan);

		[PreserveSig]
		public static extern uint RtlNtStatusToDosError(int Status);
	}

	internal class Advapi32
	{
		[PreserveSig]
		internal static extern int RegCloseKey(IntPtr hKey);

		[PreserveSig]
		internal static extern int RegEnumKeyEx(SafeRegistryHandle hKey, int dwIndex, char[] lpName, ref int lpcbName, int[] lpReserved, [Out] StringBuilder lpClass, int[] lpcbClass, long[] lpftLastWriteTime);

		[PreserveSig]
		internal static extern int RegOpenKeyEx(SafeRegistryHandle hKey, string lpSubKey, int ulOptions, int samDesired, out SafeRegistryHandle hkResult);

		[PreserveSig]
		internal static extern int RegQueryInfoKey(SafeRegistryHandle hKey, [Out] StringBuilder lpClass, int[] lpcbClass, IntPtr lpReserved_MustBeZero, ref int lpcSubKeys, int[] lpcbMaxSubKeyLen, int[] lpcbMaxClassLen, ref int lpcValues, int[] lpcbMaxValueNameLen, int[] lpcbMaxValueLen, int[] lpcbSecurityDescriptor, int[] lpftLastWriteTime);

		[PreserveSig]
		internal static extern int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, int[] lpReserved, ref int lpType, [Out] byte[] lpData, ref int lpcbData);

		[PreserveSig]
		internal static extern int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, int[] lpReserved, ref int lpType, ref int lpData, ref int lpcbData);

		[PreserveSig]
		internal static extern int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, int[] lpReserved, ref int lpType, ref long lpData, ref int lpcbData);

		[PreserveSig]
		internal static extern int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, int[] lpReserved, ref int lpType, [Out] char[] lpData, ref int lpcbData);
	}

	internal unsafe static void GetRandomBytes(byte* buffer, int length)
	{
	}
}
