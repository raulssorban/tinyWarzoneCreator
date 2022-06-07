using Humanlights.Unity.Sound;
using UnityEngine;
public class BaseImpact : HumanlightsScriptable
{
    public ImpactTypes Type = ImpactTypes.Low;
    public SoundDefinition Definition;
    public BaseEntity Effect;
    public enum ImpactTypes
    {
        None,
        Low,
        Average,
        High,
        Fatal
    }
}
