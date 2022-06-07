using System.Linq;
using tinyWarzone.UI;
using UnityEngine;
public class BaseInteractible : BaseCombat
{
    [LargeHeader ( "Interactible" )]
    public bool CanInteract = true;
    public float InteractionTimer = 1f;
    [Header ( "Client" )]
    public Renderer [] HighlightedRenderers;

}