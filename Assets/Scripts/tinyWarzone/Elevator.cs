using Humanlights.Unity.Sound;
using tinyWarzone.Entities.Components;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using tinyWarzone.UI;

namespace tinyWarzone.Entities
{
    public class Elevator : BaseInteractible
    {
        [ReadOnly] public int CurrentLevel;
        [ReadOnly] public string ValueTextValue;
        [ReadOnly] public bool IsGoingUp;
        public int MaximumLevel;
        public EntityRef Door;
        [ReadOnly] public List<EntityRef> Doors = new List<EntityRef> ();
        [LargeHeader ( "CCTV" )]
        public EntityRef CCTVCamera;
        [LargeHeader ( "Settings" )]
        public float SnappingDistance = 1f;
        public float Speed = 0.3f;
        public bool PlayElevatorMusic = true;
        [LargeHeader ( "References" )]
        public ElevatorArrow Arrow;
        public SoundPlayer MusicPlayer;
        public SoundDefinition MusicDef;
        public Transform Platform;
        public GameObject ElevatorLight;
        public SoundPlayer SoundPlayer;
        public SoundDefinition StartDef, StopDef, LoopDef;
        public TMPro.TMP_Text ValueText;
	}
}