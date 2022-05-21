using UnityEngine;
[CreateAssetMenu ( menuName = "tinyWarzone/Impact/Create Impact" )]
public class BaseImpact : HumanlightsScriptable
{
    public ImpactTypes Type = ImpactTypes.Low;
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
