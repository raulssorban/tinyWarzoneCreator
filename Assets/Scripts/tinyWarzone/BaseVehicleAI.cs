using Humanlights.Extensions;
using Humanlights.Tools;
using UnityEngine;
public class BaseVehicleAI : HumanlightsBehaviour
{
    public BaseVehicle Vehicle;
    public Transform [] Waypoints;
    public bool Loop;
    public float NeededDistance;
    public float WaitFarSeconds;
    public float DistanceCompensation;
    public float ConsideredAngles = 130f;
    public float MaximumAcceleration = 1f;
    public float MinimumAcceleration = -0.25f;
    public float FrontAngle = 10f;
    [ReadOnly] public int CurrentWaypoint;
    [ReadOnly] public float SpeedApplied;
    [ReadOnly] public float Angle;
    [ReadOnly] public bool WaypointBehind;

}