using Humanlights.Extensions;
using System.Linq;
using UnityEngine;
public class EntitySpawner : HumanlightsListableBehaviour<EntitySpawner>
{
    public bool SpawnOnStart = false;
    public int Lobby = -1;
    public BaseEntity Entity;
    public bool Invulnerable = false;
    public int FlagSettingDelay = 0;
    public SpawnTypes SpawnType = SpawnTypes.AtPosition;
    public enum SpawnTypes
    {
        None,
        AtPosition,
        AtMapOffset
    }
    public Color OutlineColor = Color.white;
    public Color FillingColor = Color.grey;
    public Collider Collider;

}