using UnityEngine;

namespace tinyWarzone.Entities.Components
{
    public class ZiplinePoint : BaseEntityComponent<Zipline>
    {
        public Rigidbody Rigidbody;
        public PrefabRef CableRef;
	}
}