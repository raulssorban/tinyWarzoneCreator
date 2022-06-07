using Humanlights.Tools;
using Humanlights.Unity.Sound;
using System;
using UnityEngine;
public class CollisionEffects : HumanlightsBehaviour
{
    public static bool Debug = true;
    public static void LogDebug ( object message = null ) { DebugEx.Log ( "CollisionEffects", $"{message}", Debug ); }
    public bool Enable = true;
    [LargeHeader ( "Trigger" )]
    public bool IsTrigger = false;
    [ReadOnly] public float InheritedVelocity;
    [LargeHeader ( "Presets" )]
    public BaseCollision Collision;
    [LargeHeader ( "Components" )]
    public SoundPlayer Player;

}