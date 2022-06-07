using Humanlights.Unity.Sound;
using UnityEngine;

namespace tinyWarzone.Entities
{
    public class Ball : BaseInteractible
    {
        public float ForwardForce = 400f;
        public float UpwardForce = 250f;
        public float BulletHitForce = 100f;
        [LargeHeader ( "Sound" )]
        public SoundPlayer SoundPlayer;
        public SoundDefinition KickDef;
	}
}