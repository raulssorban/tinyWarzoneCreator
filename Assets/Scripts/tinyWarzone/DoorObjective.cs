using Humanlights.Extensions;
using Newtonsoft.Json;
using System.Linq;
using UnityEngine;
[CreateAssetMenu ( menuName = "tinyWarzone/Missions/Objectives/Door" ), JsonObject ( MemberSerialization.OptIn )]
public class DoorObjective : BaseMissionObjective
{
    public bool MustOpen;
    public BaseDoor [] DoorEntities;

}