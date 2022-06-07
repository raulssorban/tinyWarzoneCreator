using UnityEngine;
public class CinematicCamera : HumanlightsSingleton<CinematicCamera>
{
    [LargeHeader ( "Settings" )]
    public float NormalSpeed;
    public float FastSpeed;
    public float MovementSmoothness;
    public float LookSmoothness;
    [ReadOnly] public bool IsFast;
    [LargeHeader ( "Keys" )]
    public KeyCode Forward;
    public KeyCode Backward;
    public KeyCode Left;
    public KeyCode Right;
    public KeyCode Fast;

}