using Humanlights;
using Newtonsoft.Json;
using System;
using UnityEngine;
public class BaseMissionObjective : HumanlightsScriptable
{
    [ReadOnly] public BaseMissionObjective Definition;
    [ReadOnly] public BaseMission Mission;
    [Help ( "Time in seconds till the objective fails if not complete. Leave 0 if no timer." )]
    public float Countdown = 0f;
    [JsonProperty] public string Title;
    [JsonProperty, ReadOnly] public long StartupTick;

}