using Humanlights.Tools;
using System.Linq;

namespace tinyWarzone.Trigger
{
    public class CutsceneTrigger : BaseTrigger
    {
        [LargeHeader ( "Cutscene" )]
        public int Lobby = -1;
        public BaseCutscene Cutscene;
        public bool CanRetrigger = false;
        [ReadOnly] public bool HasBeenTriggered = false;
	}
}