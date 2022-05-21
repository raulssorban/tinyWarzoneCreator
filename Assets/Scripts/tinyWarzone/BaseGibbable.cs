using Humanlights.Extensions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BaseGibbable : HumanlightsListableBehaviour<BaseGibbable>
{
    public bool TriggerDespawnOnStart = true;
    public int MinimumDespawnRate = 5;
    public int MaximumDespawnRate = 25;
    public List<Rigidbody> Gibs = new List<Rigidbody> ();

}