using Humanlights.Extensions;
using tinyWarzone.Player;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
public class CameraAutoFocus : HumanlightsBehaviour
{
    public Camera Camera;
    public PostProcessProfile Profile;
    public float Lerp = 2f;
    public float Distance = 30f;
    public float Offset;
    public LayerMask Mask;

}