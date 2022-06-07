using System.Collections.Generic;
using UnityEngine;

namespace tinyWarzone.Trigger
{
    public class ParentOnTrigger : BaseTrigger
    {
        public Transform Parent;
        [ReadOnly] public List<BaseEntity> Children = new List<BaseEntity> ();
        public float Amplifier = 1f;
	}
}