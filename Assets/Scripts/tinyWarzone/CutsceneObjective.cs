using Newtonsoft.Json;
using UnityEngine;
public class CutsceneObjective : BaseMissionObjective
{
    public string Subtitle;
    public bool CompleteAtStart = true;
    public BaseCutscene Cutscene;
}
