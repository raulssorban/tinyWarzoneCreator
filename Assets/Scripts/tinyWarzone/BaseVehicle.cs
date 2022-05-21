using Humanlights.Extensions;
using Humanlights.Unity.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using tinyWarzone.Entities;
using tinyWarzone.Traffic;
using UnityEngine;
public class BaseVehicle : BaseInteractible
{
    public bool IsDebugging = false;
    public float Fuel = 0f;
    public float MaximumFuel = 0f;
    public EntityRef [] FuelHandles;
    public float MotorForce = 3000;
    public float BrakeForce = 6000;
    public bool IsBraking;
    public float MaximumSteeringAngle = 35;
    public float SteerSmoothness = 4;
    [Help ( "Maximum speed per hour till acceleration is no longer allowed." )]
    public float MaxSpeed = 20f;
    [Help ( "The speed needed for the car to automatically brake." )]
    public float BrakeSpeed = 90f;
    public float CurrentPushForce;
    public float CurrentBrakingForce;
    public float CurrentSteeringAngle;
    public float CurrentSpeed;
    public bool CurrentIsStuck;
    public bool IsBootingUp;
    public bool IsBootingDown;
    public float Angle;
    public EntityRef [] SeatRefs;
    public float PushForce;
    public float HazardHealthTreshold;
    public GameObject Lights;
    public GameObject InsideLights;
    public float NoPushBrakeAmount = 50f;
    public float EngineBurnMinPitch = 0.75f;
    public float EngineBurnMaxPitch = 1.25f;
    public float EngineBootWaitTime = 2.5f;
    public float EngineTransitionTime = 10f;
    public float SkidSpeedTreshhold = 10f;
    [Help ( "For testing reasons, this can be toggleable in editor, although not recommended. Used for checking vehicle engine's if it's on or not." )]
    public bool AllowPush;
    public TrailRenderer [] SkidMarks;
    public ParticleSystem [] TireSmokes;
    public WheelCollider FrontLeftWC;
    public WheelCollider FrontRightWC;
    public WheelCollider BackLeftWC;
    public WheelCollider BackRightWC;
    public Transform FrontLeftWT;
    public Transform FrontRightWT;
    public Transform BackLeftWT;
    public Transform BackRightWT;
    public Transform SteeringWheel;

}