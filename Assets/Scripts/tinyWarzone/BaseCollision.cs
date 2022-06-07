using System.Linq;
using UnityEngine;
public class BaseCollision : HumanlightsScriptable
{
    public float Threshold;
    public float Cooldown = 0.5f;
    [LargeHeader ( "Filters" )]
    public bool CollideWithNonEntityObjects = true;
    public BaseEntity [] NonCollidableEntities;

}