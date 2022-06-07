using System;
public class BasePickupObject : BaseInteractible
{
    [LargeHeader ( "Pickup" )]
    public int Amount = 1;
    public BaseEffect UseEffect;

}