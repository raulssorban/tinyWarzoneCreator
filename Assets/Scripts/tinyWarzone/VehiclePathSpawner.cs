using Humanlights.Extensions;
using tinyWarzone.Entities;
using tinyWarzone.Traffic;
using UnityEngine;

namespace tinyWarzone.Spawner
{
    public class VehiclePathSpawner : EntitySpawner
    {
        public Path Path;
        public int WaypointSpawnIndex = 0;
	}
}