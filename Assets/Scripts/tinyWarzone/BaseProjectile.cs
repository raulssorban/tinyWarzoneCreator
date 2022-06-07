using Humanlights.Extensions;
using System.Linq;
using UnityEngine;
public class BaseProjectile : BaseCombat
{
    [LargeHeader ( "Projectile" )]
    public BaseDecal Decal;
    public float FrameRate = 60f;
    public AnimationCurve DropCurve;
    public float DropSensitivity = 1f;
    public AnimationCurve SlowDownCurve;
    [Help ( "The distance in meters of how far the bullet can reach before it's being killed of not enough DPP occurred." )]
    public float Distance = 200;
    public float DamagePerPenetration;
    public LayerMask Mask;
    [LargeHeader ( "Trail" )]
    public TrailRenderer Trail;
    public float TrailDelay = 0.25f;
    [Header ( "Physics" )]
    public CollisionEffects Effects;
    [ReadOnly] public bool IsMoving;
    [ReadOnly] public new float Velocity;
    [ReadOnly] public Vector3 InitialPosition;
    [ReadOnly] public Vector3 InitialForward;
    [ReadOnly] public float DistanceTravelled;
    [ReadOnly] public Collider [] PenetratedColliders = new Collider [ 10 ];
    [ReadOnly] public Collider [] IgnoredColliders = new Collider [ 10 ];
    private RaycastHit [] PredictedHits = new RaycastHit [ 10 ];

}