using Newtonsoft.Json;
using UnityEngine;
[CreateAssetMenu ( menuName = "tinyWarzone/Missions/Objectives/Cutscene" ), JsonObject ( MemberSerialization.OptIn )]
public class CutsceneObjective : BaseMissionObjective
{
    public string Subtitle;
    public bool CompleteAtStart = true;
    public BaseCutscene Cutscene;
}
