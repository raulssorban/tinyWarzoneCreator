using UnityEngine;
[CreateAssetMenu ( menuName = "tinyWarzone/Create Weapon" )]
public class BaseWeapon : ScriptableObject
{
    public string Id;
    public BaseProjectile ProjectileDefinition;
}
