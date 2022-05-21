using System.Linq;
using tinyWarzone.UI;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace tinyWarzone.Entities
{
    public class RocketExplodyPod : BaseInteractible
    {
        public Camera ViewCamera;
        public Camera MapCamera;
        public float MapScrollLerp = 1f;
        public float MapScrollSpeed = 10f;
        public int Countdown = 5;
        public int TakeoffCooldown = 5;
        public TMPro.TMP_Text Text;
        public Rocket RocketRef;
        public EntityRef [] Pods;
        public MeshRenderer Screen;
	}
}