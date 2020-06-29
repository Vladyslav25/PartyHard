using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MainMenu
{
    public class PlayerManager : MonoBehaviour
    {
        [SerializeField]
        private UIManager m_UIMangerRef;

        private int count = -1;
        public void OnPlayerJoined(PlayerInput _playerInput)
        {
            count++;
            if (count < 4)
            {
                BasePlayer tmpPlayer = new BasePlayer(_playerInput, count);

                DataManager.Instance.GetPlayerData().AddPlayer(tmpPlayer);
                m_UIMangerRef.AddPlayer(tmpPlayer);
                tmpPlayer.m_objRef.GetComponent<Player>().SetBasePlayer(tmpPlayer);
            }
        }
    }
}
