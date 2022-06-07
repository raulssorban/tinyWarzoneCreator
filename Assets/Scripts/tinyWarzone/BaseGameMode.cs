using UnityEngine;
public class BaseGameMode : HumanlightsScriptable
{
    public string Id;
    [LargeHeader ( "General" )]
    public int MaxPlayerCount;
    public BaseMap [] Maps;
}
