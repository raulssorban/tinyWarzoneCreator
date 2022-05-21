using UnityEngine;
[CreateAssetMenu ( menuName = "tinyWarzone/Create Game-Mode" )]
public class BaseGameMode : HumanlightsScriptable
{
    public string Id;
    public int MaxPlayerCount;
    public BaseMap [] Maps;
}
