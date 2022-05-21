using Humanlights.Extensions;
using UnityEngine;
public class BaseUIPanel<T> : HumanlightsSingleton<T> where T : HumanlightsBehaviour
{
    [Help ( "Recommended for you not to touch this. It only allows you to enable it for debugging purposes." )] public bool IsShowing;
    public bool InterceptCursor = false;
    public CanvasGroup Group;
    public GameObject Object;

}