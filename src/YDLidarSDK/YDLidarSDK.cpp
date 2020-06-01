#include "YDLidarSDK.h"

char* GetLidarPortList()
{
  std::map<std::string, std::string> ports = YDlidarDriver::lidarPortList();
  std::map<std::string, std::string>::iterator it;
  std::string return_str;

  if (ports.size() == 1)
    return_str.append(ports.begin()->first).append("-").append(ports.begin()->second);
  else
  {
    for (it = ports.begin(); it != ports.end(); it++)
      return_str.append(it->first).append("-").append(it->second).append(",");

    return_str = return_str.substr(0, return_str.size() - 1);
  }

  char* value = (char*)::CoTaskMemAlloc(return_str.size());
  strcpy(value, return_str.c_str());

  return value;
}

void Free(void* pointer)
{
  free(pointer);
}

#pragma region -> CYdLidar Wrapper

void* CreateInstance()
{
  CYdLidar* lidar_laser = new CYdLidar();
  return lidar_laser;
}

void DestroyInstance(void* instance)
{
  free(instance);
}

float GetMaxRange(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->getMaxRange();
}

void SetMaxRange(void* instance, float value)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  lidar_laser->setMaxRange(value);
}

float GetMinRange(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->getMinRange();
}

void SetMinRange(void* instance, float value)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  lidar_laser->setMinRange(value);
}

float GetMaxAngle(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->getMaxAngle();
}

void SetMaxAngle(void* instance, float value)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  lidar_laser->setMaxAngle(value);
}

float GetMinAngle(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->getMinAngle();
}

void SetMinAngle(void* instance, float value)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  lidar_laser->setMinAngle(value);
}

int GetSampleRate(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->getSampleRate();
}

void SetSampleRate(void* instance, int value)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  lidar_laser->setSampleRate(value);
}

float GetScanFrequency(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->getScanFrequency();
}

void SetScanFrequency(void* instance, float value)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  lidar_laser->setScanFrequency(value);
}

bool GetFixedResolution(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->getFixedResolution();
}

void SetFixedResolution(void* instance, bool value)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  lidar_laser->setFixedResolution(value);
}

bool GetReversion(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->getReversion();
}

void SetReversion(void* instance, bool value)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  lidar_laser->setReversion(value);
}

bool GetInverted(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->getInverted();
}

void SetInverted(void* instance, bool value)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  lidar_laser->setInverted(value);
}

bool GetAutoReconnect(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->getAutoReconnect();
}

void SetAutoReconnect(void* instance, bool value)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  lidar_laser->setAutoReconnect(value);
}

int GetSerialBaudrate(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->getSerialBaudrate();
}

void SetSerialBaudrate(void* instance, int value)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  lidar_laser->setSerialBaudrate(value);
}

int GetAbnormalCheckCount(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->getAbnormalCheckCount();
}

void SetAbnormalCheckCount(void* instance, int value)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  lidar_laser->setAbnormalCheckCount(value);
}

char* GetSerialPort(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  std::string port = lidar_laser->getSerialPort();

  char* value = (char*)::CoTaskMemAlloc(port.size());
  strcpy(value, port.c_str());

  return value;
}

void SetSerialPort(void* instance, char* value)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  std::string port = std::string(value);
  lidar_laser->setSerialPort(port);
}

float GetOffsetTime(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->getOffsetTime();
}

void SetOffsetTime(void* instance, float value)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  lidar_laser->setOffsetTime(value);
}

bool GetSingleChannel(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->getSingleChannel();
}

void SetSingleChannel(void* instance, bool value)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  lidar_laser->setSingleChannel(value);
}

int GetLidarType(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->getLidarType();
}

void SetLidarType(void* instance, int value)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  lidar_laser->setLidarType(value);
}

bool Initialize(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->initialize();
}

bool TurnOn(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->turnOn();
}

bool TurnOff(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->turnOff();
}

void Disconnecting(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  lidar_laser->disconnecting();
}

float GetAngleOffset(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->getAngleOffset();
}

bool IsAngleOffsetCorrected(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  return lidar_laser->isAngleOffetCorrected();
}

char* GetSoftVersion(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  std::string version = lidar_laser->getSoftVersion();

  char* value = (char*)::CoTaskMemAlloc(version.size());
  strcpy(value, version.c_str());

  return value;
}

char* GetHardwareVersion(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  std::string version = lidar_laser->getHardwareVersion();

  char* value = (char*)::CoTaskMemAlloc(version.size());
  strcpy(value, version.c_str());

  return value;
}

char* GetSerialNumber(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  std::string version = lidar_laser->getSerialNumber();

  char* value = (char*)::CoTaskMemAlloc(version.size());
  strcpy(value, version.c_str());

  return value;
}

void* GetData(void* instance)
{
  CYdLidar* lidar_laser = (CYdLidar*)instance;
  if (ydlidar::ok)
  {
    //Get data only if it's ok
    bool hardError;
    LaserScan laserScan;

    if (lidar_laser->doProcessSimple(laserScan, hardError))
    {
      ExportData* exportData = (ExportData*)malloc(sizeof(ExportData));
      size_t pointCount = laserScan.points.size();

      exportData->pointSize = pointCount;
      exportData->stamp = laserScan.stamp;
      exportData->Config = laserScan.config;
      exportData->Points = (LaserPoint*)malloc(pointCount * sizeof(LaserPoint));

      for (int index = 0; index < pointCount; index++)
        exportData->Points[index] = laserScan.points[index];

      return exportData;
    }
  }
}

#pragma endregion
