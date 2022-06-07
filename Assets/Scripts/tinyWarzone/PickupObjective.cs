using Humanlights.Extensions;
using Newtonsoft.Json;
using System.Linq;
using UnityEngine;
public class PickupObjective : BaseMissionObjective
{
    public BaseEntity [] PickupEntities;
    [JsonProperty] public int Amount;

}