using System;
using UnityEngine;
public class CollisionEffects : HumanlightsBehaviour
{
    public static bool Debug = true;
    public static void LogDebug ( object message = null ) { DebugEx.Log ( "CollisionEffects", $"{message}", Debug ); }
    public bool Enable = true;
    public bool IsTrigger = false;
    public BaseCollision Collision;

}