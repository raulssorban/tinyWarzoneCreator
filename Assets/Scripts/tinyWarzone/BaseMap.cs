using tinyWarzone.Player;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
[CreateAssetMenu ( menuName = "tinyWarzone/Create Map" )]
public class BaseMap : HumanlightsScriptable
{
    public string Id;
    public GameObject SceneObject;
    public PostProcessProfile PostProcessingProfile;
    public TextAsset TOD_Profile;
    public PlayerModes.ModeTypes PlayerMode = PlayerModes.ModeTypes.ThirdPerson;
    public float FogGlobalDensity = 0.005f;
    public float FogHeightFalloff = 0.01f;
    public float FogStartDistance = 0f;
}
