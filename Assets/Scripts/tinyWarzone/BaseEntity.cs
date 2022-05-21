using Humanlights.Extensions;
using Humanlights.Managers;
using Humanlights.Unity.Network;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class BaseEntity : HumanlightsNetworkBehaviour, IEntity
{
    public static Vector3 ValidGameBounds = new Vector3 ( 1000, 1000, 1000 );
    public string FriendlyName;
    public bool CanSave;
    [Help ( "This collider's used to get the center of the whole entity, so it can be used accurately." )] public Collider Collider;
    public Rigidbody Rigidbody;
    public Bone [] Bones;
    public bool ResetLocalOnParented = true;
    public BaseGibbable Gibbable;
    public BaseEffect GibbableEffect;
    public Bone Parent;
    public class Bone
    {
        public Transform Reference;
        [JsonProperty, ReadOnly]
        public int Id;
        [JsonProperty, ReadOnly]
        public uint EntityId;
	}
}