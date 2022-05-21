using tinyWarzone.UI;
using UnityEngine;
public class BaseInteractible : BaseCombat
{
    public bool CanInteract = true;
    public float InteractionTimer = 1f;
    public Renderer [] HighlightedRenderers;

}