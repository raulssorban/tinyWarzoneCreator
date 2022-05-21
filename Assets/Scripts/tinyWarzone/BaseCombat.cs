using Humanlights.Extensions;
using Newtonsoft.Json;
using System;
using tinyWarzone.UI;
using UnityEngine;
public class BaseCombat : BaseEntity
{
    public float Health = 500;
    public float MaximumHealth = 500;
    public bool Invulnerable = false;
    public bool KillOnDeath = true;
    public BaseDamage Damage;
    public float DealtDamageThreshold = 0.1f;
    public CollisionEffects [] ConsideredCollisionEffects;

}