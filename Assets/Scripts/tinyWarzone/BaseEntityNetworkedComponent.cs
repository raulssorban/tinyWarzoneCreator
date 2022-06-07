public class BaseEntityNetworkedComponent : BaseEntity
{
    [LargeHeader ( "Entity Component" )]
    public BaseEntity Entity;
    [ReadOnly] public bool IsSetUp;

}