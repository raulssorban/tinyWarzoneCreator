public class BaseEntityComponent<T> : HumanlightsBehaviour where T : BaseEntity
{
    [LargeHeader ( "Entity Component" )]
    [Help ( "This usually gets assigned in the editor or automatically detects itself." )] public T Entity;
    [ReadOnly] public bool IsSetUp;

}