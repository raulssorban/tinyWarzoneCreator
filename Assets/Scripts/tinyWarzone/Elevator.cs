using tinyWarzone.Entities.Components;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using tinyWarzone.UI;

namespace tinyWarzone.Entities
{
    public class Elevator : BaseInteractible
    {
        public int MaximumLevel;
        public EntityRef Door;
        public EntityRef CCTVCamera;
        public float SnappingDistance = 1f;
        public float Speed = 0.3f;
        public bool PlayElevatorMusic = true;
        public ElevatorArrow Arrow;
        public Transform Platform;
        public GameObject ElevatorLight;
        public TMPro.TMP_Text ValueText;
	}
}