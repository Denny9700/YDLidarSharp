namespace YDLidarSharp
{
  using System;
  using System.Collections.Generic;
  using System.IO;
  using System.Runtime.InteropServices;

  public class YDLidarSDK
  {
    #region CYdLidar Functions

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.LPStr)]
    private static extern string GetLidarPortList();

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void Free(IntPtr pointer);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern IntPtr CreateInstance();

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void DestroyInstance(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern float GetMaxRange(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void SetMaxRange(IntPtr instance, float value);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern float GetMinRange(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void SetMinRange(IntPtr instance, float value);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern float GetMaxAngle(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void SetMaxAngle(IntPtr instance, float value);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern float GetMinAngle(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void SetMinAngle(IntPtr instance, float value);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern int GetSampleRate(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void SetSampleRate(IntPtr instance, int value);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern float GetScanFrequency(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void SetScanFrequency(IntPtr instance, float value);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern bool GetFixedResolution(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void SetFixedResolution(IntPtr instance, bool value);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern bool GetReversion(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void SetReversion(IntPtr instance, bool value);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern bool GetInverted(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void SetInverted(IntPtr instance, bool value);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern bool GetAutoReconnect(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void SetAutoReconnect(IntPtr instance, bool value);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern int GetSerialBaudrate(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void SetSerialBaudrate(IntPtr instance, int value);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern int GetAbnormalCheckCount(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void SetAbnormalCheckCount(IntPtr instance, int value);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.LPStr)]
    private static extern string GetSerialPort(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
    private static extern void SetSerialPort(IntPtr instance, [MarshalAs(UnmanagedType.LPStr)]string value);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern float GetOffsetTime(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void SetOffsetTime(IntPtr instance, float value);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern bool GetSingleChannel(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void SetSingleChannel(IntPtr instance, bool value);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern int GetLidarType(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void SetLidarType(IntPtr instance, int type);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern bool Initialize(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern bool TurnOn(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern bool TurnOff(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void Disconnecting(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern float GetAngleOffset(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern bool IsAngleOffsetCorrected(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.LPStr)]
    private static extern string GetSoftVersion(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.LPStr)]
    private static extern string GetHardwareVersion(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.LPStr)]
    private static extern string GetSerialNumber(IntPtr instance);

    [DllImport("YDLidarSDK.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern IntPtr GetData(IntPtr instance);

    #endregion

    private readonly object _lockMutex = new object();

    private readonly IntPtr _instance;
    private bool _isRunning;
    private bool _configured;

    public bool IsRunning
    {
      get { return _isRunning; }
      internal set { _isRunning = value; }
    }

    public bool IsConfigured
    {
      get { return _configured; }
      internal set { _configured = value; }
    }

    #region Properties

    public float MaxRange
    {
      get
      {
        if (_instance != IntPtr.Zero)
          return GetMaxRange(_instance);

        return 0.0f;
      }
      set
      {
        if (_instance != IntPtr.Zero)
          SetMaxRange(_instance, value);
      }
    }

    public float MinRange
    {
      get
      {
        if (_instance != IntPtr.Zero)
          return GetMinRange(_instance);

        return 0.0f;
      }
      set
      {
        if (_instance != IntPtr.Zero)
          SetMinRange(_instance, value);
      }
    }

    public float MaxAngle
    {
      get
      {
        if (_instance != IntPtr.Zero)
          return GetMaxAngle(_instance);

        return 0.0f;
      }
      set
      {
        if (_instance != IntPtr.Zero)
          SetMaxAngle(_instance, value);
      }
    }

    public float MinAngle
    {
      get
      {
        if (_instance != IntPtr.Zero)
          return GetMinAngle(_instance);

        return 0.0f;
      }
      set
      {
        if (_instance != IntPtr.Zero)
          SetMinAngle(_instance, value);
      }
    }

    public int SampleRate
    {
      get
      {
        if (_instance != IntPtr.Zero)
          return GetSampleRate(_instance);

        return 0;
      }
      set
      {
        if (_instance != IntPtr.Zero)
          SetSampleRate(_instance, value);
      }
    }

    public float ScanFrequency
    {
      get
      {
        if (_instance != IntPtr.Zero)
          return GetScanFrequency(_instance);

        return 0.0f;
      }
      set
      {
        if (_instance != IntPtr.Zero)
          SetScanFrequency(_instance, value);
      }
    }

    public bool FixedResolution
    {
      get
      {
        if (_instance != IntPtr.Zero)
          return GetFixedResolution(_instance);

        return false;
      }
      set
      {
        if (_instance != IntPtr.Zero)
          SetFixedResolution(_instance, value);
      }
    }

    public bool Reversion
    {
      get
      {
        if (_instance != IntPtr.Zero)
          return GetReversion(_instance);

        return false;
      }
      set
      {
        if (_instance != IntPtr.Zero)
          SetReversion(_instance, value);
      }
    }

    public bool Inverted
    {
      get
      {
        if (_instance != IntPtr.Zero)
          return GetInverted(_instance);

        return false;
      }
      set
      {
        if (_instance != IntPtr.Zero)
          SetInverted(_instance, value);
      }
    }

    public bool AutoReconnect
    {
      get
      {
        if (_instance != IntPtr.Zero)
          return GetAutoReconnect(_instance);

        return false;
      }
      set
      {
        if (_instance != IntPtr.Zero)
          SetAutoReconnect(_instance, value);
      }
    }

    public int SerialBaudrate
    {
      get
      {
        if (_instance != IntPtr.Zero)
          return GetSerialBaudrate(_instance);

        return 0;
      }
      set
      {
        if (_instance != IntPtr.Zero)
          SetSerialBaudrate(_instance, value);
      }
    }

    public int AbnormalCheckCount
    {
      get
      {
        if (_instance != IntPtr.Zero)
          return GetAbnormalCheckCount(_instance);

        return 0;
      }
      set
      {
        if (_instance != IntPtr.Zero)
          SetAbnormalCheckCount(_instance, value);
      }
    }

    public string SerialPort
    {
      get
      {
        if (_instance != IntPtr.Zero)
          return GetSerialPort(_instance);

        return string.Empty;
      }
      set
      {
        if (_instance != IntPtr.Zero)
          SetSerialPort(_instance, value);
      }
    }

    public float OffsetTime
    {
      get
      {
        if (_instance != IntPtr.Zero)
          return GetOffsetTime(_instance);

        return 0.0f;
      }
      set
      {
        if (_instance != IntPtr.Zero)
          SetOffsetTime(_instance, value);
      }
    }

    public bool SingleChannel
    {
      get
      {
        if (_instance != IntPtr.Zero)
          return GetSingleChannel(_instance);

        return false;
      }
      set
      {
        if (_instance != IntPtr.Zero)
          SetSingleChannel(_instance, value);
      }
    }

    public LidarType LidarType
    {
      get
      {
        if (_instance != IntPtr.Zero)
          return (LidarType)GetLidarType(_instance);

        return LidarType.NONE;
      }
      set
      {
        if (_instance != IntPtr.Zero)
          SetLidarType(_instance, (int)value);
      }
    }

    #endregion

    #region Methods

    public static string[] GetLidarPorts()
    { return GetLidarPortList().Split(','); }

    public YDLidarSDK()
    { _instance = CreateInstance(); }

    ~YDLidarSDK()
    { DestroyInstance(_instance); }

    public bool Initialize()
    {
      if (_instance == IntPtr.Zero)
        throw new Exception("Instance is null");

      IsConfigured = true;
      return Initialize(_instance);
    }

    public bool TurnOn()
    {
      if (_instance == IntPtr.Zero)
        throw new Exception("Instance is null");

      IsRunning = TurnOn(_instance);
      return _isRunning;
    }

    public bool TurnOff()
    {
      if (_instance == IntPtr.Zero)
        throw new Exception("Instance is null");

      IsRunning = false;
      return !TurnOff(_instance);
    }

    public void Disconnecting()
    {
      if (_instance == IntPtr.Zero)
        throw new Exception("Instance is null");

      TurnOff();
      Disconnecting(_instance);
    }

    public float GetAngleOffset()
    {
      if (_instance == IntPtr.Zero)
        throw new Exception("Instance is null");

      return GetAngleOffset(_instance);
    }

    public bool IsAngleOffsetCorrected()
    {
      if (_instance == IntPtr.Zero)
        throw new Exception("Instance is null");

      return IsAngleOffsetCorrected(_instance);
    }

    public string GetSoftVersion()
    {
      if (_instance == IntPtr.Zero)
        throw new Exception("Instance is null");

      return GetSoftVersion(_instance);
    }

    public string GetHardwareVersion()
    {
      if (_instance == IntPtr.Zero)
        throw new Exception("Instance is null");

      return GetHardwareVersion(_instance);
    }

    public string GetSerialNumber()
    {
      if (_instance == IntPtr.Zero)
        throw new Exception("Instance is null");

      return GetSerialNumber(_instance);
    }

    #endregion

    public LaserScan GetData()
    {
      if (_instance == IntPtr.Zero)
        throw new Exception("Instance is null");

      lock(_lockMutex)
      {
        if (IsRunning)
        {
          IntPtr pointer = GetData(_instance);
          ExportData data = Marshal.PtrToStructure<ExportData>(pointer);

          byte[] buffer = new byte[data.PointSize * Marshal.SizeOf(typeof(LaserPoint))];
          Marshal.Copy(data.PointsPointer, buffer, 0, buffer.Length);

          LaserScan laserScan = new LaserScan
          {
            Stamp = data.Stamp,
            LaserConfig = data.LaserConfig,
            LaserPoints = new List<LaserPoint>()
          };

          using (MemoryStream memStream = new MemoryStream(buffer))
          using (BinaryReader reader = new BinaryReader(memStream))
          {
            for (int i = 0; i < data.PointSize; i++)
            {
              laserScan.LaserPoints.Add(new LaserPoint
              {
                Angle = reader.ReadSingle(),
                Range = reader.ReadSingle(),
                Intensity = reader.ReadSingle()
              });
            }
          }

          Free(data.PointsPointer);
          Free(pointer);

          return laserScan;
        }
      }
      return new LaserScan();
    }
  }
}
