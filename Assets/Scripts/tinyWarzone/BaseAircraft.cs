using Humanlights.Extensions;
using Humanlights.Unity.Sound;
using System;
using tinyWarzone;
using tinyWarzone.Traffic;
using UnityEngine;
public class BaseAircraft : BaseInteractible
{
    public class AircraftRotor
    {
        public Rotor Rotor;
        [Range ( 0f, 50f )] public float Multiply = 1f;
    }
    public LayerMask Mask;
    public bool IsDebugging;
    [LargeHeader ( "AI" )]
    [ReadOnly] public bool DisablePath = false;
    [LargeHeader ( "Controller" )]
    [Range ( 0.0f, 500f )] public float Power = 20f;
    [Range ( -1f, 1f )] public new float Forward = 0f;
    [Range ( -1f, 1f )] public float Sideways = 0f;
    [Range ( -1f, 1f )] public float Roll = 0f;
    [Range ( -1f, 1f )] public float Pitch = 0f;
    [Range ( -1f, 1f )] public float Yaw = 0f;
    [Range ( 0.1f, 250f )] public float HeightLevel = 2.0f;
    public float PushMultiplier = 1f;
    public float RotationMultiplier = 1f;
    [LargeHeader ( "Stability" )]
    public Transform Support;
    public float SupportHeight = 2f;
    public bool Stability = true;
    [Header ( "Motor Properties" )]
    [Range ( 0f, 5f )] public float HeightStabilization = 0.3f;
    [Range ( 0f, 50f )] public float YawStabilization = 10f;
    public float DirectionalBoost = 20f;
    [Space]
    [ReadOnly] public float CurrentSpeed;
    [ReadOnly] public float CurrentProportionalHeight;
    [ReadOnly] public Vector3 CurrentVelocity;
    [Header ( "Rotor Properties" )]
    public AircraftRotor [] Rotors;
    public float RotorLerp = 0.25f;
    [LargeHeader ( "Effects" )]
    [Header ( "Dust" )]
    public ParticleSystem DustParticle;
    public float DustHeightLevel;
    public float DustPowerLevel;
    [Header ( "Sound" )]
    public SoundPlayer Sound;
    public SoundDefinition FlightDefinition;
    public float SoundLerp = 2.5f;
    public float SoundDelay = 0f;
    [LargeHeader ( "References" )]
    public new RaycastHit Hit;

}