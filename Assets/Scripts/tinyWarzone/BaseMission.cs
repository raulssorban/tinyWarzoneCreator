using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
[CreateAssetMenu ( menuName = "tinyWarzone/Create Mission" ), JsonObject ( MemberSerialization.OptIn )]
public class BaseMission : HumanlightsScriptable
{
    [JsonProperty] public string Title;
    [JsonProperty] public string Description;
    public BaseMap Map;
    public int MinimumPlayers = 1;
    public int MaximumPlayers = 4;
    [JsonProperty] public List<BaseMissionObjective> Objectives = new List<BaseMissionObjective> ();
    public List<BaseMissionReward> Rewards = new List<BaseMissionReward> ();
    [JsonProperty, ReadOnly] public int CurrentObjectiveIndex;

}