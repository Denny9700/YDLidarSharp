#ifndef YDLIDARSDK_H
#define YDLIDARSDK_H
#endif

#include <CYdLidar.h>

#ifdef __cplusplus
extern "C" {
#endif

#if defined(_MSC_VER)
#define EXPORT __declspec(dllexport)
#define IMPORT __declspec(dllimport)
#endif

	using namespace std;
	using namespace ydlidar;

#if defined(_MSC_VER)
#pragma comment(lib, "ydlidar_driver.lib")
#endif

	struct ExportData
	{
		uint32_t pointSize;

		uint64_t stamp;
		LaserConfig Config;
		LaserPoint* Points;
	};

	EXPORT char* GetLidarPortList();
	EXPORT void Free(void* pointer);

	//CYLidar
	EXPORT void* CreateInstance();
	EXPORT void DestroyInstance(void* instance);

	EXPORT float GetMaxRange(void* instance);
	EXPORT void SetMaxRange(void* instance, float value);

	EXPORT float GetMinRange(void* instance);
	EXPORT void SetMinRange(void* instance, float value);

	EXPORT float GetMaxAngle(void* instance);
	EXPORT void SetMaxAngle(void* instance, float value);

	EXPORT float GetMinAngle(void* instance);
	EXPORT void SetMinAngle(void* instance, float value);

	EXPORT int GetSampleRate(void* instance);
	EXPORT void SetSampleRate(void* instance, int value);

	EXPORT float GetScanFrequency(void* instance);
	EXPORT void SetScanFrequency(void* instance, float value);

	EXPORT bool GetFixedResolution(void* instance);
	EXPORT void SetFixedResolution(void* instance, bool value);

	EXPORT bool GetReversion(void* instance);
	EXPORT void SetReversion(void* instance, bool value);

	EXPORT bool GetInverted(void* instance);
	EXPORT void SetInverted(void* instance, bool value);

	EXPORT bool GetAutoReconnect(void* instance);
	EXPORT void SetAutoReconnect(void* instance, bool value);

	EXPORT int GetSerialBaudrate(void* instance);
	EXPORT void SetSerialBaudrate(void* instance, int value);

	EXPORT int GetAbnormalCheckCount(void* instance);
	EXPORT void SetAbnormalCheckCount(void* instance, int value);

	EXPORT char* GetSerialPort(void* instance);
	EXPORT void SetSerialPort(void* instance, char* value);

	EXPORT float GetOffsetTime(void* instance);
	EXPORT void SetOffsetTime(void* instance, float value);

	EXPORT bool GetSingleChannel(void* instance);
	EXPORT void SetSingleChannel(void* instance, bool value);

	EXPORT int GetLidarType(void* instance);
	EXPORT void SetLidarType(void* instance, int value);

	EXPORT bool Initialize(void* instance);

	EXPORT bool TurnOn(void* instance);
	EXPORT bool TurnOff(void* instance);

	EXPORT void Disconnecting(void* instance);

	//Const?
	EXPORT float GetAngleOffset(void* instance);
	EXPORT bool IsAngleOffsetCorrected(void* instance);
	EXPORT char* GetSoftVersion(void* instance);
	EXPORT char* GetHardwareVersion(void* instance);
	EXPORT char* GetSerialNumber(void* instance);

	EXPORT void* GetData(void* instance);

#ifdef __cplusplus
}
#endif