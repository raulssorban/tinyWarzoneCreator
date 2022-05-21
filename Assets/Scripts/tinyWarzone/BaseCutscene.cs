using Humanlights.Extensions;
using Humanlights.Unity.Components;
using System;
using System.Collections.Generic;
using System.Linq;
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
    public int Camera = 0;
    public float FieldOfView = 60f;
    public float Focus = 5f;
    public float Aperture = 24.0f;
    public bool OverrideTime = false;
    public float TimeOfDay = 12f;
    public PostProcessProfile Profile;
    public Animation Animation;
    public Transform CameraPivot;
    public CinematicCamera [] Cameras;
    public List<GameObject> CutsceneObjects = new List<GameObject> ();

}