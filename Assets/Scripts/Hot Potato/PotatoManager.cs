using System;
using System.Collections.Generic;
using UnityEngine;

namespace HotPotato
{
    public class PotatoManager : MonoBehaviour
    {
        #region -Variables-
        [Header("Settings")]
        [SerializeField]
        private float StartTime; //The Max Time a Player have to catch someone 

        [HideInInspector]
        public static float LeftTime; //Time left till the owner die

        private bool isRunning = true;
        private static Player owner;
        private static List<Player> allPlayer;
        private int PlayerCount;
        #endregion

        #region -Unity Functions-

        private void Awake()
        {
            LeftTime = StartTime;
            SpawnPlayer(); //TODO ------------!!
        }

        private void Start()
        {
            if (allPlayer == null || allPlayer.Count < 2)
            {
                Debug.LogError("Not enough Players found! You need to Add the Player in the Awake");
            }
            PlayerCount = allPlayer.Count;
            ChooseRandomPlayer().HavePotato = true;
        }

        private void Update()
        {
            if (isRunning)
            {
                if (LeftTime > StartTime)   // Can be over the StartTime when you change the owner
                    LeftTime = StartTime;   // Clamp the Time
                if (LeftTime <= 0)          // When the Time is over
                {
                    RemovePlayer(owner);
                    ChooseRandomPlayer().HavePotato = true;
                    LeftTime = StartTime;   // Reset the Time
                }
                else
                {
                    LeftTime -= Time.deltaTime;
                }
            }
        }
        #endregion

        #region -Custom Functions-

        #region -priviate-
        private void Win()
        {
            isRunning = false;
        }

        private void RemovePlayer(Player _player)
        {
            _player.Die();
            allPlayer.Remove(_player);
            if (allPlayer.Count == 1)
            {
                Win();
            }
        }
        public static void AddPlayer(Player _player)
        {
            allPlayer.Add(_player);
        }

        private Player ChooseRandomPlayer()
        {
            return allPlayer[UnityEngine.Random.Range(0, PlayerCount)];
        }

        private void SpawnPlayer() { } //TODO --------------------
        #endregion

        #region -public-
        /// <summary>
        /// Change the Owner of the hot Potato
        /// </summary>
        /// <param name="_owner">The currend Owner of the Potato</param>
        /// <param name="_receiver">The new Owner of the Potato</param>
        public static void GivePotato(Player _owner, Player _receiver)
        {
            if (owner == _owner && _owner.HavePotato && !_receiver.HavePotato && _receiver.CanBeOwner)
            {
                _owner.HavePotato = false;      // Owner lose Potato
                _receiver.HavePotato = true;    // Receiver get Potato
                _owner.SetOwnerTimeout();         // Old Owner start Timeout
                owner = _receiver;              // Set the new Owner
                LeftTime += 10f;                // Add Time till Explosion
            }
        }
        #endregion

        #endregion
    }
}
