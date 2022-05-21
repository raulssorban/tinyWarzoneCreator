using System;
using UnityEngine;
public class BaseMapSetup : BaseEntity
{
    public Spawnable [] Spawnables;
    public class Spawnable
    {
        public Transform Spawnpoint;
        public BaseEntity Entity;
    }

}