using Humanlights;
using Newtonsoft.Json;
using System;
using UnityEngine;
[CreateAssetMenu ( menuName = "tinyWarzone/Create Mission Objective" ), JsonObject ( MemberSerialization.OptIn )]
public class BaseMissionObjective : HumanlightsScriptable
{
    [Help ( "Time in seconds till the objective fails if not complete. Leave 0 if no timer." )]
    public float Countdown = 0f;
    [JsonProperty] public string Title;
    [JsonProperty, ReadOnly] public long StartupTick;

}