using Humanlights.Extensions;
using Newtonsoft.Json;
using System.Linq;
using tinyWarzone.Entities;
using UnityEngine;
[CreateAssetMenu ( menuName = "tinyWarzone/Missions/Objectives/Switch" ), JsonObject ( MemberSerialization.OptIn )]
public class SwitchObjective : BaseMissionObjective
{
    public bool On;
    public Switch [] SwitchEntities;

}