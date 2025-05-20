namespace Unity.Services.Analytics.Data;

internal class DeviceDataWrapper : IDeviceData
{
	public string CpuType => null;

	public string GpuType => null;

	public int CpuCores => 0;

	public int RamTotal => 0;

	public int ScreenWidth => 0;

	public int ScreenHeight => 0;

	public float ScreenDpi => 0f;

	public string OperatingSystem => null;

	public string DeviceModel => null;

	public bool IsDebugDevice => false;

	public bool IsTiny => false;
}
