using Humanlights.Extensions;
using Humanlights.Tools;
using Humanlights.Unity.Network;
using Humanlights.Unity.Sound;
using System;
using System.Collections.Generic;
using System.Linq;
using tinyWarzone.Entities;
using tinyWarzone.Traffic;
using UnityEngine;
public class BaseVehicle : BaseInteractible
{
    public bool IsDebugging = false;
    [LargeHeader ( "Fuel" )]
    public float Fuel = 0f;
    public float MaximumFuel = 0f;
    public EntityRef [] FuelHandles;
    [LargeHeader ( "AI" )]
    [ReadOnly] public bool DisablePath = false;
    [LargeHeader ( "Settings" )]
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
    [LargeHeader ( "Seats" )]
    public EntityRef [] SeatRefs;
    [LargeHeader ( "Push" )]
    public float PushForce;
    [LargeHeader ( "Horn & Hazard" )]
    public float HazardHealthTreshold;
    public SoundPlayer Horn;
    public SoundPlayer Hazard;
    public SoundDefinition HornDefinition;
    public SoundDefinition HazardDefinition;
    [LargeHeader ( "Lights" )]
    public SoundPlayer LightsSound;
    public GameObject Lights;
    public GameObject InsideLights;
    public SoundDefinition LightsOnDefinition;
    public SoundDefinition LightsOffDefinition;
    [LargeHeader ( "Engine" )]
    public SoundPlayer EngineStatus;
    public SoundPlayer EngineIdle;
    public SoundPlayer EngineBurn;
    public SoundPlayer Skid;
    public float NoPushBrakeAmount = 50f;
    public float EngineBurnMinPitch = 0.75f;
    public float EngineBurnMaxPitch = 1.25f;
    public float EngineBootWaitTime = 2.5f;
    public float EngineTransitionTime = 10f;
    public SoundDefinition EngineBootDefinition;
    public SoundDefinition EngineShutdownDefinition;
    public SoundDefinition EngineBurnDefinition;
    public SoundDefinition EngineIdleDefinition;
    public SoundDefinition SkidDefinition;
    public float SkidSpeedTreshhold = 10f;
    [Help ( "For testing reasons, this can be toggleable in editor, although not recommended. Used for checking vehicle engine's if it's on or not." )]
    public bool AllowPush;
    [LargeHeader ( "Effects" )]
    public TrailRenderer [] SkidMarks;
    public ParticleSystem [] TireSmokes;
    [LargeHeader ( "Components" )]
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