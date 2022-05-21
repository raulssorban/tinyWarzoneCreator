using tinyWarzone.Objects;
using UnityEngine;

namespace tinyWarzone.Entities
{
    public class GasPump : BaseInteractible
    {
        public float FuelLeft = 100f;
        public float FuelPerPump = 2.3f;
        public float FuelPumpRate = 1f;
        public float MaximumDistance = 10f;
        public Cable Cable;
        public Transform Handle;
        public Transform Connector;
        public TMPro.TMP_Text Text;
	}
}