using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tinyWarzone.Entities
{
    public class FeedMonitor : BaseEntity
    {
        public Color LightColor;
        [LargeHeader ( "References" )]
        public MeshRenderer Screen;
        public Light Light;
	}
}