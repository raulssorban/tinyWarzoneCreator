using System;
using System.Collections.Generic;
using UnityEngine;
public class Ragdoll : HumanlightsBehaviour
{
    public bool Enable = false;
    public Limb [] Limbs;
    public BaseCollision Collision;
    public bool EnableEffects = true;
    public Transform Root;
    [System.Serializable]
    public class Limb
    {
        public Transform Transform;
        public Collider Collider;
        public Rigidbody Rigidbody;
        public CharacterJoint Joint;
        public CollisionEffects Effects;
    }

}