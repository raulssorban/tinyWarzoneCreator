using Humanlights.Extensions;

namespace tinyWarzone.Misc
{
    public class GameTips : HumanlightsSingleton<GameTips>
    {
        public string [] Tips;
        public float Rate = 20f;
        public float Duration = 5.5f;
	}
}