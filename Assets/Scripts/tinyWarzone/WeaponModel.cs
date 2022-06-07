using Humanlights.Extensions;
using System;
using System.Collections;
using System.Linq;
using UnityEngine;
public class WeaponModel : BaseModel
{
    public float TriggerPullAngle = -20f;
    [LargeHeader ( "References" )]
    public GameObject Muzzle;
    public Attachment [] Attachments;
    public Transform Trigger;
    public class Attachment
    {
        [Header ( "Required" )]
        public BaseModel Model;
        [Header ( "Overrides" )]
        public GameObject MuzzleOverride;
    }

}