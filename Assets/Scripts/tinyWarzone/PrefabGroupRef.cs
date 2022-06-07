using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PrefabGroupRef
{
    public HumanlightsBehaviour Reference;
    [ReadOnly] public List<HumanlightsBehaviour> Instances = new List<HumanlightsBehaviour> ();

}