using System;
using System.Collections.Generic;
public static class TinyHooks
{
    public static Dictionary<string, Func<object [], object>> Hooks = new Dictionary<string, Func<object [], object>> ();
    public enum HooksDefinitions
    {
        INone,
        OnPluginAdded,
        OnEntityCreated,
        OnEntitySpawned,
        OnEntityDestroyed,
        OnPreEntityKilled,
        OnPostEntityKilled,
        OnEntityUpdated,
        OnEntityTick,
        OnPlayerJoined,
        OnPlayerLeft,
        OnPlayerDeath,
        OnPlayerKick,
        OnPlayerInput,
        OnPlayerCanUse,
        OnPlayerUse,
        OnPlayerMount,
        OnPlayerDismount,
        OnProjectileShot,
        OnProjectileHit,
        OnDroppedItem,
        OnItemPickup,
        OnElevatorSend,
        OnElevatorArrival,
    }

}