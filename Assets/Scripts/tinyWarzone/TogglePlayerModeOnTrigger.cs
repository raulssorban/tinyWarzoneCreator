using tinyWarzone.Player;

namespace tinyWarzone.Trigger
{
    public class TogglePlayerModeOnTrigger : BaseTrigger
    {
        public PlayerModes.ModeTypes OnEnter;
        [ReadOnly] public PlayerModes.ModeTypes LatestPlayerMode;
        [ReadOnly] public BasePlayer LatestPlayer;
	}
}