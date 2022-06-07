using Humanlights.Tools;
using tinyWarzone.Entities;
using tinyWarzone.UI;
using UnityEngine;

namespace tinyWarzone.Player
{
    public class PlayerInput : PlayerComponent
    {
        [LargeHeader ( "Keys" )]
        public KeyCode UseKey = KeyCode.E;
        public KeyCode ModeToggleKey = KeyCode.V;
        public float NoclipSpeed = 0.5f;
        public float NoclipFastSpeed = 8.5f;
        public float LadderClimbSpeed = 1.5f;
	}
}