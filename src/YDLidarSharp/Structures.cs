namespace YDLidarSharp
{
  using System;
  using System.Collections.Generic;
  using System.Runtime.InteropServices;

  [StructLayout(LayoutKind.Sequential)]
  public struct ExportData
  {
    public UInt32 PointSize;
    public UInt64 Stamp;
    public LaserConfig LaserConfig;
    public IntPtr PointsPointer;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  public struct LaserConfig
  {
    public float MinAngle;
    public float MaxAngle;
    public float AngleIncrement;
    public float TimeIncrement;
    public float ScanTime;
    public float MinRange;
    public float MaxRange;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  public struct LaserPoint
  {
    public float Angle;
    public float Range;
    public float Intensity;
  }

  public struct LaserScan
  {
    public UInt64 Stamp;
    public LaserConfig LaserConfig;
    public List<LaserPoint> LaserPoints;
  }

  public enum LidarType : int
  {
    TOF = 0,
    TRIANGLE = 1,
    TAIL,
    NONE
  }
}
