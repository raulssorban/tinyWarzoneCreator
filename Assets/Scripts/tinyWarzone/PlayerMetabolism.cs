
namespace tinyWarzone.Player
{
    public class PlayerMetabolism : PlayerNetworkedComponent
    {
        [LargeHeader ( "Stamina" )]
        public float Stamina;
        public float MaximumStamina = 100f;
        public float SprintStaminaWaste = 0.2f;
        public float JumpStaminaWaste = 0.35f;
        public float StaminaRise = 0.1f;
	}
}