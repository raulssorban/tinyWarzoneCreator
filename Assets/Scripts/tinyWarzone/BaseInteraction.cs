public class BaseInteraction : HumanlightsBehaviour
{
    public BaseInteractible Entity;
    public bool IgnoreLineOfSight = false;
    public virtual string GetUseTextOverride ( BasePlayer player ) { return null; }
    public virtual bool? CanUseOverride ( BasePlayer player ) { return null; }

}