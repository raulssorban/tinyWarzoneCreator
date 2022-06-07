using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class EntityGroupRef
{
    public BaseEntity Reference;
    [ReadOnly] public List<BaseEntity> Instances = new List<BaseEntity> ();

}