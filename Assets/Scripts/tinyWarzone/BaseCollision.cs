using System.Linq;
using UnityEngine;
[CreateAssetMenu ( menuName = "tinyWarzone/Impact/Create Collision" )]
public class BaseCollision : HumanlightsScriptable
{
    public float Threshold;
    public float Cooldown = 0.5f;
    public bool CollideWithNonEntityObjects = true;
    public BaseEntity [] NonCollidableEntities;

}