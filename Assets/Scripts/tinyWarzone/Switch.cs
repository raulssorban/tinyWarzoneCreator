using System;

namespace tinyWarzone.Entities
{
    public class Switch : BaseInteractible
    {
        public float Delay;
        public uint ObjectId;
        [ReadOnly] public BaseSwitchObject Object;
	}
}