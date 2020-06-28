using UnityEngine;
using UnityEngine.InputSystem;

namespace HotPotato
{
    public class Player : MonoBehaviour
    {
        #region -Variables-

        [Header("Settings")]
        [SerializeField]
        private float MaxOwnerTimeout; //The Duration the Player cant be the new Owner

        [HideInInspector]
        public bool HavePotato = false;
        [HideInInspector]
        public bool CanBeOwner = true;
        [HideInInspector]
        public bool IsAlive = true;

        private float ownerTimeoutTimer;

        #endregion

        private void Awake()
        {
            PotatoManager.AddPlayer(this);
        }

        private void Update()
        {
            // Handle the Timeout Duration
            if (ownerTimeoutTimer > 0)
                ownerTimeoutTimer -= Time.deltaTime;
            else if (CanBeOwner == false)
            {
                ownerTimeoutTimer = 0;
                CanBeOwner = true;
            }
        }

        /// <summary>
        /// Start the Timeout to be Owner for the Player
        /// </summary>
        public void SetOwnerTimeout()
        {
            ownerTimeoutTimer = MaxOwnerTimeout;
            CanBeOwner = false;
        }

        /// <summary>
        /// Kill the Player
        /// </summary>
        public void Die()
        {
            IsAlive = false;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Player") // if the Player Collide with another Player
            {
                Player reciver;
                reciver = collision.gameObject.GetComponent<Player>(); // Get the Player from the gameObject

                if (reciver != null)
                    PotatoManager.GivePotato(this, reciver); //Change the Owner in the Manager
            }
        }
    }
}
