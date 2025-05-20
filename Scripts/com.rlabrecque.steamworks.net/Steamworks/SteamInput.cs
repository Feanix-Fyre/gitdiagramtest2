using System;

namespace Steamworks;

public static class SteamInput
{
	public static bool Init(bool bExplicitlyCallRunFrame)
	{
		return false;
	}

	public static bool Shutdown()
	{
		return false;
	}

	public static bool SetInputActionManifestFilePath(string pchInputActionManifestAbsolutePath)
	{
		return false;
	}

	public static void RunFrame(bool bReservedValue = true)
	{
	}

	public static bool BWaitForData(bool bWaitForever, uint unTimeout)
	{
		return false;
	}

	public static bool BNewDataAvailable()
	{
		return false;
	}

	public static int GetConnectedControllers(InputHandle_t[] handlesOut)
	{
		return 0;
	}

	public static void EnableDeviceCallbacks()
	{
	}

	public static void EnableActionEventCallbacks(SteamInputActionEventCallbackPointer pCallback)
	{
	}

	public static InputActionSetHandle_t GetActionSetHandle(string pszActionSetName)
	{
		return default(InputActionSetHandle_t);
	}

	public static void ActivateActionSet(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle)
	{
	}

	public static InputActionSetHandle_t GetCurrentActionSet(InputHandle_t inputHandle)
	{
		return default(InputActionSetHandle_t);
	}

	public static void ActivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle)
	{
	}

	public static void DeactivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle)
	{
	}

	public static void DeactivateAllActionSetLayers(InputHandle_t inputHandle)
	{
	}

	public static int GetActiveActionSetLayers(InputHandle_t inputHandle, InputActionSetHandle_t[] handlesOut)
	{
		return 0;
	}

	public static InputDigitalActionHandle_t GetDigitalActionHandle(string pszActionName)
	{
		return default(InputDigitalActionHandle_t);
	}

	public static InputDigitalActionData_t GetDigitalActionData(InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle)
	{
		return default(InputDigitalActionData_t);
	}

	public static int GetDigitalActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, EInputActionOrigin[] originsOut)
	{
		return 0;
	}

	public static string GetStringForDigitalActionName(InputDigitalActionHandle_t eActionHandle)
	{
		return null;
	}

	public static InputAnalogActionHandle_t GetAnalogActionHandle(string pszActionName)
	{
		return default(InputAnalogActionHandle_t);
	}

	public static InputAnalogActionData_t GetAnalogActionData(InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle)
	{
		return default(InputAnalogActionData_t);
	}

	public static int GetAnalogActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, EInputActionOrigin[] originsOut)
	{
		return 0;
	}

	public static string GetGlyphPNGForActionOrigin(EInputActionOrigin eOrigin, ESteamInputGlyphSize eSize, uint unFlags)
	{
		return null;
	}

	public static string GetGlyphSVGForActionOrigin(EInputActionOrigin eOrigin, uint unFlags)
	{
		return null;
	}

	public static string GetGlyphForActionOrigin_Legacy(EInputActionOrigin eOrigin)
	{
		return null;
	}

	public static string GetStringForActionOrigin(EInputActionOrigin eOrigin)
	{
		return null;
	}

	public static string GetStringForAnalogActionName(InputAnalogActionHandle_t eActionHandle)
	{
		return null;
	}

	public static void StopAnalogActionMomentum(InputHandle_t inputHandle, InputAnalogActionHandle_t eAction)
	{
	}

	public static InputMotionData_t GetMotionData(InputHandle_t inputHandle)
	{
		return default(InputMotionData_t);
	}

	public static void TriggerVibration(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed)
	{
	}

	public static void TriggerVibrationExtended(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed)
	{
	}

	public static void TriggerSimpleHapticEvent(InputHandle_t inputHandle, EControllerHapticLocation eHapticLocation, byte nIntensity, char nGainDB, byte nOtherIntensity, char nOtherGainDB)
	{
	}

	public static void SetLEDColor(InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
	{
	}

	public static void Legacy_TriggerHapticPulse(InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec)
	{
	}

	public static void Legacy_TriggerRepeatedHapticPulse(InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
	{
	}

	public static bool ShowBindingPanel(InputHandle_t inputHandle)
	{
		return false;
	}

	public static ESteamInputType GetInputTypeForHandle(InputHandle_t inputHandle)
	{
		return default(ESteamInputType);
	}

	public static InputHandle_t GetControllerForGamepadIndex(int nIndex)
	{
		return default(InputHandle_t);
	}

	public static int GetGamepadIndexForController(InputHandle_t ulinputHandle)
	{
		return 0;
	}

	public static string GetStringForXboxOrigin(EXboxOrigin eOrigin)
	{
		return null;
	}

	public static string GetGlyphForXboxOrigin(EXboxOrigin eOrigin)
	{
		return null;
	}

	public static EInputActionOrigin GetActionOriginFromXboxOrigin(InputHandle_t inputHandle, EXboxOrigin eOrigin)
	{
		return default(EInputActionOrigin);
	}

	public static EInputActionOrigin TranslateActionOrigin(ESteamInputType eDestinationInputType, EInputActionOrigin eSourceOrigin)
	{
		return default(EInputActionOrigin);
	}

	public static bool GetDeviceBindingRevision(InputHandle_t inputHandle, out int pMajor, out int pMinor)
	{
		pMajor = default(int);
		pMinor = default(int);
		return false;
	}

	public static uint GetRemotePlaySessionID(InputHandle_t inputHandle)
	{
		return 0u;
	}

	public static ushort GetSessionInputConfigurationSettings()
	{
		return 0;
	}

	public static void SetDualSenseTriggerEffect(InputHandle_t inputHandle, IntPtr pParam)
	{
	}
}
