using Humanlights.Extensions;
using System.Linq;
using UnityEngine;
public class BaseProjectile : BaseCombat
{
    public BaseDecal Decal;
    public float FrameRate = 60f;
    public AnimationCurve DropCurve;
    public float DropSensitivity = 1f;
    public AnimationCurve SlowDownCurve;
    [Help ( "The distance in meters of how far the bullet can reach before it's being killed of not enough DPP occurred." )]
    public float Distance = 200;
    public float DamagePerPenetration;
    public LayerMask Mask;
    public TrailRenderer Trail;
    public float TrailDelay = 0.25f;
    public CollisionEffects Effects;
    private RaycastHit [] PredictedHits = new RaycastHit [ 10 ];

}