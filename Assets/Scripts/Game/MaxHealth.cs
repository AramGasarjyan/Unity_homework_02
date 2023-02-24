using UnityEngine;

namespace DefaultNamespace.Game
{
    public class MaxHealth : AbstractItem
    {
        public float GetValue(PlayerHealth playerHealth)
        {
            return playerHealth.GetDefalutHealth() - playerHealth.GetCurrentHealth();
        }
    }
}
