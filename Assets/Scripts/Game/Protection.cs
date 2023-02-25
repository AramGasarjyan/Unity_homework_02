using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.Game
{ 
    public class Protection : AbstractItem
    {
        [SerializeField] private float protectionTime;
        private float timer;
        PlayerHealth _playerHealth;

        private void Update()
        {
            if (timer >= protectionTime)
            {
                _playerHealth.protectionActiveOnPLayer = false;
            }
            timer += Time.deltaTime;
        }

        public void ProtectionActiveOnPlayer(PlayerHealth playerHealth, bool value)
        {
            _playerHealth = playerHealth;
            playerHealth.protectionActiveOnPLayer = value;
        }
    }
}
