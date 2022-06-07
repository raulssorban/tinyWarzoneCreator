using Humanlights.Extensions;
using Humanlights.Unity.Components;
using Humanlights.Unity.Sound;
using System;
using System.Collections.Generic;
using System.Linq;
using tinyWarzone.Spawner;
using tinyWarzone.UI;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
public class BaseCutscene : BaseEntity
{
    public enum CutsceneModes
    {
        Cinematic = 0,
        Narration = 1
    }
    public CutsceneModes Mode;
    public Transform PostCutsceneSpawnables;
    [LargeHeader ( "Camera Settings" )]
    public int Camera = 0;
    public float FieldOfView = 60f;
    public float Focus = 5f;
    public float Aperture = 24.0f;
    [LargeHeader ( "TOD" )]
    public bool OverrideTime = false;
    public float TimeOfDay = 12f;
    [LargeHeader ( "References" )]
    public PostProcessProfile Profile;
    public Animation Animation;
    public Transform CameraPivot;
    public CinematicCamera [] Cameras;
    [ReadOnly] public DepthOfField DOF;
    [LargeHeader ( "Timeline" )]
    [ReadOnly] public float Time;
    [ReadOnly] public string Name;
    [ReadOnly] public int CameraIndex;
    public List<GameObject> CutsceneObjects = new List<GameObject> ();

}