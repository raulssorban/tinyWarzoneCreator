using tinyWarzone.Entities;

namespace tinyWarzone.Spawner
{
    public class ElevatorSpawner : EntitySpawner
    {
        public int StartAtFloor = 0;
        public bool [] Floors;
	}
}