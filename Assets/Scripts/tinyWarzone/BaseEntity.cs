using Humanlights.Extensions;
using Humanlights.Managers;
using Humanlights.Tools;
using Humanlights.Unity.Network;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class BaseEntity : HumanlightsNetworkBehaviour, IEntity
{
    public static Vector3 ValidGameBounds = new Vector3 ( 1000, 1000, 1000 );
    [LargeHeader ( "Entity" )]
    [ReadOnly] public uint Id;
    [ReadOnly] public BasePlayer Owner;
    [ReadOnly] public BasePlayer AuthorizedPlayer;
    public string FriendlyName;
    public bool CanSave;
    [Help ( "This collider's used to get the center of the whole entity, so it can be used accurately." )] public Collider Collider;
    public Rigidbody Rigidbody;
    [ReadOnly] public PrefabManager.PrefabInformation PrefabInfo;
    [Header ( "Spawning" )]
    [ReadOnly] public bool IsSpawned = false;
    [ReadOnly] public bool HasClientInit;
    [ReadOnly] public bool HasInit;
    [Header ( "Parenting" )]
    public Bone [] Bones;
    public bool ResetLocalOnParented = true;
    [Header ( "Gibs" )]
    public BaseGibbable Gibbable;
    public BaseEffect GibbableEffect;
    [ReadOnly] public BaseEffect GibbableEffectInstance;
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