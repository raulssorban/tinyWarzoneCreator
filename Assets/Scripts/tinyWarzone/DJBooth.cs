using Humanlights.Unity.Sound;
using tinyWarzone.UI;
using UnityEngine;

namespace tinyWarzone.Entities
{
    public class DJBooth : BaseInteractible
    {
        public SoundDefinition Music;
        public SoundPlayer SoundPlayer;
        public Light Light;
        [ReadOnly] public float MusicTime;
        public float Volume = 2f;
        [LargeHeader ( "Seats" )]
        public EntityRef SeatRef;
	}
}