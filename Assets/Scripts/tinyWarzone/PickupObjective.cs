using Humanlights.Extensions;
using Newtonsoft.Json;
using System.Linq;
using UnityEngine;
[CreateAssetMenu ( menuName = "tinyWarzone/Missions/Objectives/Pickup" ), JsonObject ( MemberSerialization.OptIn )]
public class PickupObjective : BaseMissionObjective
{
    public BaseEntity [] PickupEntities;
    [JsonProperty] public int Amount;

}