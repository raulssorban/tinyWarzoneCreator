using Humanlights.Extensions;
using tinyWarzone.Traffic;
using UnityEngine;
public class BaseVehicleSensor : HumanlightsBehaviour
{
    public BaseVehicle Vehicle;
    public LayerMask Mask;
    [LargeHeader ( "Debug" )]
    public float CollisionAngle;

}