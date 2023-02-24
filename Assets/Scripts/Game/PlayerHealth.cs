using UnityEngine;

namespace DefaultNamespace.Game
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField] private float defaultHealth;
        public bool protectionActiveOnPLayer;

        private float currentHealth;

        private void Start()
        {
            currentHealth = defaultHealth;
        }

        public float GetDefalutHealth() => defaultHealth;
        public float GetCurrentHealth() => currentHealth;

        public void SetDefaultHealth()
        {
            currentHealth = defaultHealth;
        }

        public void Change(float amount)
        {
            if (currentHealth + amount <= defaultHealth)
            {
                currentHealth += amount;
                Debug.Log("current health " + currentHealth);
            }

            if (currentHealth <= 0f)
            {
                Die();
            }
        }

        private void Die()
        {
            Debug.Log("DIE");
        }
    }
}