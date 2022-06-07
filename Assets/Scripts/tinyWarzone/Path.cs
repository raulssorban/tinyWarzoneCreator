using Humanlights.Extensions;
using Humanlights.Tools;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace tinyWarzone.Traffic
{
    public class Path : HumanlightsListableBehaviour<Path>
    {
        public bool Loop = false;
        public Waypoint [] Waypoints;
	}
}