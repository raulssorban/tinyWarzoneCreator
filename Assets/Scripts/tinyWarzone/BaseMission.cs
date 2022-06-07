using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class BaseMission : HumanlightsScriptable
{
    [ReadOnly] public BaseMission Definition;
    [JsonProperty] public string Title;
    [JsonProperty] public string Description;
    public BaseMap Map;
    public int MinimumPlayers = 1;
    public int MaximumPlayers = 4;
    [JsonProperty] public List<BaseMissionObjective> Objectives = new List<BaseMissionObjective> ();
    public List<BaseMissionReward> Rewards = new List<BaseMissionReward> ();
    [JsonProperty, ReadOnly] public int CurrentObjectiveIndex;
    [ReadOnly] public bool IsInstanced = false;
    [ReadOnly] public BaseMissionObjective CurrentObjective;

}